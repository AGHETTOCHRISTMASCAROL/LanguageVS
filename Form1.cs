using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LanguageVS
{
    public partial class Form1 : Form
    {
        #region toolBAR

        private void BtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) // перетаскивание формы 
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        #endregion

        #region Объявление переменных
        //static String connectionString = @"data source=10.111.105.2,1433\SQLEXPRESS;initial catalog=Language20101;user id=20.101-17;password=Siv3836;MultipleActiveResultSets=True;App=EntityFramework";
        static String connectionString = "data source = CAROLMACHINE; initial catalog = LanguageLanguage; integrated security = True; MultipleActiveResultSets = True; App = EntityFramework";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        String quary = "";

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Clear();
            connection.Open();
            quary = "SELECT C.ID, C.LastName AS 'Фамилия', C.FirstName AS 'Имя', C.Patronymic AS 'Отчество', G.Name AS 'Пол', C.Phone AS 'Телефон', C.Email, C.Birthday AS 'Birthday', C.RegistrationDate AS 'Registered' " +
                    "FROM Client AS C JOIN Gender AS G ON C.GenderCode = G.Code";

            adapter = new SqlDataAdapter(quary, connection);

            adapter.Fill(table);

            dataGridView1.DataSource = table;

            dataGridView1.ClearSelection();
            dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkGray;
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 140;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 130;
            dataGridView1.Columns[6].Width = 190;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].Width = 100;

            connection.Close();
        } //Вывод при запуске

        private void TbFIO_TextChanged(object sender, EventArgs e)
        {
            table.Clear();
            ArrayList arrayList = new ArrayList();
            connection.Open();
            arrayList.AddRange(tbFIO.Text.Split(' '));

            for (int i = arrayList.Count; i < 3; i++)
                arrayList.Add("%");

            quary = $"SELECT C.ID, C.LastName AS 'Фамилия', C.FirstName AS 'Имя', C.Patronymic AS 'Отчество', G.Name AS 'Пол', C.Phone AS 'Телефон', C.Email, C.Birthday AS 'Birthday', C.RegistrationDate AS 'Registered' " +
                    $"FROM Client AS C JOIN Gender AS G ON C.GenderCode = G.Code " +
                    $"WHERE C.LastName like '{arrayList[0]}%' AND c.FirstName like '{arrayList[1]}%' AND C.Patronymic like '{arrayList[2]}%'";

            adapter = new SqlDataAdapter(quary, connection);

            adapter.Fill(table);

            dataGridView1.DataSource = table;
            connection.Close();
        } //Поиск по ФИО в реальном времени

        private void TbPhone_TextChanged(object sender, EventArgs e)
        {
            table.Clear();
            connection.Open();

            quary = "SELECT C.ID, C.LastName AS 'Фамилия', C.FirstName AS 'Имя', C.Patronymic AS 'Отчество', G.Name AS 'Пол', C.Phone AS 'Телефон', C.Email, C.Birthday AS 'Birthday', C.RegistrationDate AS 'Registered' " +
                    "FROM Client AS C JOIN Gender AS G ON C.GenderCode = G.Code " +
                    $"WHERE C.Phone like ' {tbPhone.Text}%'"; // пробел не забыть убрать

            adapter = new SqlDataAdapter(quary, connection);

            adapter.Fill(table);

            dataGridView1.DataSource = table;
            connection.Close();
        } //Поиск по телефону

        private void TbEmail_TextChanged(object sender, EventArgs e)
        {
            table.Clear();
            connection.Open();

            quary = $"SELECT C.ID, C.LastName AS 'Фамилия', C.FirstName AS 'Имя', C.Patronymic AS 'Отчество', G.Name AS 'Пол', C.Phone AS 'Телефон', C.Email, C.Birthday AS 'Birthday', C.RegistrationDate AS 'Registered' " +
                    $"FROM Client AS C JOIN Gender AS G ON C.GenderCode = G.Code " +
                    $"WHERE C.Email like ' {tbEmail.Text}%'"; // пробел не забыть убрать

            adapter = new SqlDataAdapter(quary, connection);

            adapter.Fill(table);

            dataGridView1.DataSource = table;
            connection.Close();
        } //Поиск по email

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int row = int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            table.Clear();
            connection.Open();

            quary = $"DELETE FROM Client WHERE ID = '{row}' " +
                    $"SELECT C.ID, C.LastName AS 'Фамилия', C.FirstName AS 'Имя', C.Patronymic AS 'Отчество', G.Name AS 'Пол', C.Phone AS 'Телефон', C.Email, C.Birthday AS 'Birthday', C.RegistrationDate AS 'Registered' " +
                    $"FROM Client AS C JOIN Gender AS G ON C.GenderCode = G.Code";

            adapter = new SqlDataAdapter(quary, connection);

            adapter.Fill(table);

            dataGridView1.DataSource = table;
            connection.Close();

            MessageBox.Show("Клиент удален");
        } //удаление по выделению строки

        #region Подсказки
        private void tbFIO_Leave(object sender, EventArgs e)
        {
            tbFIO.Text = "ПОИСК ПО ФИО";
        }

        private void tbPhone_Leave(object sender, EventArgs e)
        {
            tbPhone.Text = "ПОИСК ПО НОМЕРУ";
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            tbEmail.Text = "ПОИСК ПО EMAIL";
        }

        private void tbFIO_Enter(object sender, EventArgs e)
        {
            if (tbFIO.Text == "ПОИСК ПО ФИО")
                tbFIO.Clear();
        }

        private void tbPhone_Enter(object sender, EventArgs e)
        {
            if (tbPhone.Text == "ПОИСК ПО НОМЕРУ")
                tbPhone.Clear();
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "ПОИСК ПО EMAIL")
                tbEmail.Clear();
        }
        #endregion

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}