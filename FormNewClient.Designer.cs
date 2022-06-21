namespace LanguageVS
{
    partial class FormNewClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.dtpRegistation = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.SystemColors.Window;
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLastName.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLastName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbLastName.Location = new System.Drawing.Point(44, 60);
            this.tbLastName.MaxLength = 120;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(296, 27);
            this.tbLastName.TabIndex = 4;
            this.tbLastName.TabStop = false;
            this.tbLastName.Text = "Фамилия*";
            this.tbLastName.Enter += new System.EventHandler(this.TbLastName_Enter);
            this.tbLastName.Leave += new System.EventHandler(this.TbLastName_Leave);
            // 
            // lblAdd
            // 
            this.lblAdd.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblAdd.Location = new System.Drawing.Point(40, 20);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(300, 22);
            this.lblAdd.TabIndex = 21;
            this.lblAdd.Text = "ДОБАВЛЕНИЕ НОВОГО КЛИЕНТА";
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(240, 344);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinimized.ForeColor = System.Drawing.Color.Silver;
            this.btnMinimized.Location = new System.Drawing.Point(339, 1);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(20, 20);
            this.btnMinimized.TabIndex = 24;
            this.btnMinimized.Text = "—";
            this.btnMinimized.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimized.UseVisualStyleBackColor = false;
            this.btnMinimized.Click += new System.EventHandler(this.BtnMinimized_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.Silver;
            this.btnClose.Location = new System.Drawing.Point(359, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFirstName.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFirstName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbFirstName.Location = new System.Drawing.Point(44, 90);
            this.tbFirstName.MaxLength = 120;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(296, 27);
            this.tbFirstName.TabIndex = 25;
            this.tbFirstName.TabStop = false;
            this.tbFirstName.Text = "Имя*";
            this.tbFirstName.Enter += new System.EventHandler(this.TbFirstName_Enter);
            this.tbFirstName.Leave += new System.EventHandler(this.TbFirstName_Leave);
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.BackColor = System.Drawing.SystemColors.Window;
            this.tbMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMiddleName.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMiddleName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbMiddleName.Location = new System.Drawing.Point(44, 120);
            this.tbMiddleName.MaxLength = 120;
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(296, 27);
            this.tbMiddleName.TabIndex = 26;
            this.tbMiddleName.TabStop = false;
            this.tbMiddleName.Text = "Отчество";
            this.tbMiddleName.Enter += new System.EventHandler(this.TbMiddleName_Enter);
            this.tbMiddleName.Leave += new System.EventHandler(this.TbMiddleName_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbEmail.Location = new System.Drawing.Point(44, 150);
            this.tbEmail.MaxLength = 120;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(296, 27);
            this.tbEmail.TabIndex = 27;
            this.tbEmail.TabStop = false;
            this.tbEmail.Text = "Email";
            this.tbEmail.Enter += new System.EventHandler(this.TbEmail_Enter);
            this.tbEmail.Leave += new System.EventHandler(this.TbEmail_Leave);
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.SystemColors.Window;
            this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPhone.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPhone.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPhone.Location = new System.Drawing.Point(44, 180);
            this.tbPhone.MaxLength = 120;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(296, 27);
            this.tbPhone.TabIndex = 28;
            this.tbPhone.TabStop = false;
            this.tbPhone.Text = "Телефон*";
            this.tbPhone.Enter += new System.EventHandler(this.TbPhone_Enter);
            this.tbPhone.Leave += new System.EventHandler(this.TbPhone_Leave);
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.SystemColors.Window;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbGender.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Мужчина",
            "Женщина"});
            this.cbGender.Location = new System.Drawing.Point(44, 210);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(296, 30);
            this.cbGender.TabIndex = 29;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CalendarFont = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirthday.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(44, 243);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(296, 27);
            this.dtpBirthday.TabIndex = 30;
            // 
            // dtpRegistation
            // 
            this.dtpRegistation.CalendarFont = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpRegistation.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpRegistation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegistation.Location = new System.Drawing.Point(44, 276);
            this.dtpRegistation.Name = "dtpRegistation";
            this.dtpRegistation.Size = new System.Drawing.Size(296, 27);
            this.dtpRegistation.TabIndex = 31;
            // 
            // FormNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(380, 421);
            this.Controls.Add(this.dtpRegistation);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.tbLastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNewClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormNewClient_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormNewClient_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.DateTimePicker dtpRegistation;
    }
}