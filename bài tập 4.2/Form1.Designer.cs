using static System.Net.Mime.MediaTypeNames;

namespace Form_đăng_ký
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCourse;

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cboCourse;

        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;

        private System.Windows.Forms.CheckBox chkAgree;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblFullName = new Label();
            lblPhone = new Label();
            lblBirthDate = new Label();
            lblGender = new Label();
            lblCourse = new Label();
            txtFullName = new TextBox();
            mtxtPhone = new MaskedTextBox();
            dtpBirthDate = new DateTimePicker();
            cboCourse = new ComboBox();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            chkAgree = new CheckBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(30, 30);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(92, 32);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Họ tên:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(30, 70);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(161, 32);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Số điện thoại:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(30, 110);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(126, 32);
            lblBirthDate.TabIndex = 4;
            lblBirthDate.Text = "Ngày sinh:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(30, 150);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(110, 32);
            lblGender.TabIndex = 6;
            lblGender.Text = "Giới tính:";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(30, 190);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(119, 32);
            lblCourse.TabIndex = 9;
            lblCourse.Text = "Khóa học:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(150, 27);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(220, 39);
            txtFullName.TabIndex = 1;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(197, 70);
            mtxtPhone.Mask = "(000) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(170, 39);
            mtxtPhone.TabIndex = 3;
            mtxtPhone.MaskInputRejected += mtxtPhone_MaskInputRejected;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(150, 107);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(220, 39);
            dtpBirthDate.TabIndex = 5;
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.Location = new Point(150, 187);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(220, 40);
            cboCourse.TabIndex = 10;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Checked = true;
            rdoMale.Location = new Point(150, 148);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(96, 36);
            rdoMale.TabIndex = 7;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(220, 148);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(77, 36);
            rdoFemale.TabIndex = 8;
            rdoFemale.Text = "Nữ";
            // 
            // chkAgree
            // 
            chkAgree.AutoSize = true;
            chkAgree.Location = new Point(150, 230);
            chkAgree.Name = "chkAgree";
            chkAgree.Size = new Size(251, 36);
            chkAgree.TabIndex = 11;
            chkAgree.Text = "Đồng ý điều khoản";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(150, 270);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 47);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Đăng ký";
            btnRegister.Click += btnRegister_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(551, 370);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblPhone);
            Controls.Add(mtxtPhone);
            Controls.Add(lblBirthDate);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblGender);
            Controls.Add(rdoMale);
            Controls.Add(rdoFemale);
            Controls.Add(lblCourse);
            Controls.Add(cboCourse);
            Controls.Add(chkAgree);
            Controls.Add(btnRegister);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form đăng ký";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}