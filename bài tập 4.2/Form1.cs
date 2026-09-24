using System;
using System.Data;
using System.Windows.Forms;

namespace Form_đăng_ký
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable dt = new DataTable();

            dt.Columns.Add("CourseCode");
            dt.Columns.Add("CourseName");

            dt.Rows.Add("C01", "Lập trình C#");
            dt.Rows.Add("C02", "Java cơ bản");
            dt.Rows.Add("C03", "SQL Server");
            dt.Rows.Add("C04", "Oracle Database");

            cboCourse.DataSource = dt;
            cboCourse.DisplayMember = "CourseName";
            cboCourse.ValueMember = "CourseCode";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (rdoMale.Checked)
                gender = "Nam";
            else if (rdoFemale.Checked)
                gender = "Nữ";

            string result =
                "THÔNG TIN ĐĂNG KÝ\n" +
                "Họ tên: " + txtFullName.Text + "\n" +
                "Số điện thoại: " + mtxtPhone.Text + "\n" +
                "Ngày sinh: " + dtpBirthDate.Text + "\n" +
                "Giới tính: " + gender + "\n" +
                "Khóa học: " + cboCourse.Text + "\n" +
                "Mã khóa học: " + cboCourse.SelectedValue + "\n" +
                "Đồng ý điều khoản: " +
                (chkAgree.Checked ? "Có" : "Không");

            MessageBox.Show(result, "Form đăng ký");
        }

        private void mtxtPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
