namespace FastFoodApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.ListBox lstSelected;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblMenu = new System.Windows.Forms.Label();
            lblSelected = new System.Windows.Forms.Label();
            lstMenu = new System.Windows.Forms.ListBox();
            lstSelected = new System.Windows.Forms.ListBox();
            btnAdd = new System.Windows.Forms.Button();
            btnRemove = new System.Windows.Forms.Button();
            lblTotal = new System.Windows.Forms.Label();

            SuspendLayout();

            lblMenu.AutoSize = true;
            lblMenu.Location = new System.Drawing.Point(30, 25);
            lblMenu.Text = "Menu";

            lstMenu.Location = new System.Drawing.Point(30, 55);
            lstMenu.Size = new System.Drawing.Size(180, 140);
            lstMenu.Name = "lstMenu";

            btnAdd.Location = new System.Drawing.Point(230, 75);
            btnAdd.Size = new System.Drawing.Size(50, 35);
            btnAdd.Text = ">";
            btnAdd.Click += btnAdd_Click;

            btnRemove.Location = new System.Drawing.Point(230, 125);
            btnRemove.Size = new System.Drawing.Size(50, 35);
            btnRemove.Text = "<";
            btnRemove.Click += btnRemove_Click;

            lblSelected.AutoSize = true;
            lblSelected.Location = new System.Drawing.Point(310, 25);
            lblSelected.Text = "Món đã chọn";

            lstSelected.Location = new System.Drawing.Point(310, 55);
            lstSelected.Size = new System.Drawing.Size(180, 140);
            lstSelected.Name = "lstSelected";

            lblTotal.AutoSize = true;
            lblTotal.Location = new System.Drawing.Point(30, 225);
            lblTotal.Text = "Tổng tiền: 0 VNĐ";

            ClientSize = new System.Drawing.Size(530, 280);
            Controls.Add(lblMenu);
            Controls.Add(lstMenu);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(lblSelected);
            Controls.Add(lstSelected);
            Controls.Add(lblTotal);

            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Đặt món Fast Food";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}