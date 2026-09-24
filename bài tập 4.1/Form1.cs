using System;
using System.Windows.Forms;

namespace Loginform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Nhập tên đăng nhập");
            }

            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Nhập mật khẩu");
            }

            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}