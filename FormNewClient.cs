using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageVS
{

    public partial class FormNewClient : Form
    {
        #region toolBar
        private void BtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormNewClient_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        #endregion
        private void FormNewClient_Paint(object sender, PaintEventArgs e)
        {
            BorderForm border = new BorderForm();
            border.FormPaint(this);
        }

        MyDelegate d;
        public FormNewClient(MyDelegate sender)
        {
            InitializeComponent();
            d = sender;
        }

        #region Подсказки
        private void TbLastName_Enter(object sender, EventArgs e)
        {
            if (tbLastName.Text == "Фамилия*")
            {
                tbLastName.ForeColor = Color.Black;
                tbLastName.Clear();
            }
        }

        private void TbLastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                tbLastName.ForeColor = Color.DimGray;
                tbLastName.Text = "Фамилия*";
            }
        }

        private void TbFirstName_Enter(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "Имя*")
            {
                tbFirstName.ForeColor = Color.Black;
                tbFirstName.Clear();
            }

        }

        private void TbFirstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                tbFirstName.ForeColor = Color.DimGray;
                tbFirstName.Text = "Имя*";
            }

        }

        private void TbMiddleName_Enter(object sender, EventArgs e)
        {
            if (tbMiddleName.Text == "Отчество")
            {
                tbMiddleName.ForeColor = Color.Black;
                tbMiddleName.Clear();
            }

        }

        private void TbMiddleName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMiddleName.Text))
            {
                tbMiddleName.ForeColor = Color.DimGray;
                tbMiddleName.Text = "Отчество";
            }

        }

        private void TbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Email")
            {
                tbEmail.ForeColor = Color.Black;
                tbEmail.Clear();
            }

        }

        private void TbEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                tbEmail.ForeColor = Color.DimGray;
                tbEmail.Text = "Email";
            }

        }

        private void TbPhone_Enter(object sender, EventArgs e)
        {
            if (tbPhone.Text == "Телефон*")
            {
                tbPhone.ForeColor = Color.Black;
                tbPhone.Clear();
            }

        }

        private void TbPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                tbPhone.ForeColor = Color.DimGray;
                tbPhone.Text = "Телефон*";
            }

        }
        #endregion

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            String middleName = "NULL";
            String email = "NULL";

            if (tbMiddleName.Text != "Отчество")
                middleName = tbMiddleName.Text.Trim(' ');

            if (tbEmail.Text != "Email")
                email = tbEmail.Text.Trim(' ');

            if (tbLastName.Text != "Фамилия*" && tbFirstName.Text != "Имя*" && tbPhone.Text != "Телефон*" && cbGender.SelectedIndex != -1)
            {
                string quary = $"INSERT INTO Client(LastName, FirstName, Patronymic, GenderCode, Birthday, Phone, Email, RegistrationDate)" +
                               $"VALUES('{tbLastName.Text.Trim(' ')}','{tbFirstName.Text.Trim(' ')}','{middleName}','{cbGender.SelectedIndex + 1}','{dtpBirthday.Value.ToString("yyyy-MM-dd")}','{tbPhone.Text.Trim(' ')}','{email}','{dtpRegistation.Value.ToString("yyyy-MM-dd")}')";
                d(quary);
                this.Close();
            }
            else
                MessageBox.Show("Заполните все обязательные поля*");
        } //формирование запроса добавления
    }
}