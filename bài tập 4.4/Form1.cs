using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FastFoodApp
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> prices = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();

            prices.Add("Hamburger", 50000);
            prices.Add("Pizza", 120000);
            prices.Add("Gà Rán", 35000);
            prices.Add("Pepsi", 15000);

            lstMenu.Items.Add("Hamburger");
            lstMenu.Items.Add("Pizza");
            lstMenu.Items.Add("Gà Rán");
            lstMenu.Items.Add("Pepsi");

            UpdateTotal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem != null)
            {
                lstSelected.Items.Add(lstMenu.SelectedItem);
                UpdateTotal();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItem != null)
            {
                lstSelected.Items.Remove(lstSelected.SelectedItem);
                UpdateTotal();
            }
        }

        private void UpdateTotal()
        {
            int total = 0;

            foreach (string item in lstSelected.Items)
            {
                total += prices[item];
            }

            lblTotal.Text = "Tổng tiền: " + total.ToString("N0") + " VNĐ";
        }
    }
}