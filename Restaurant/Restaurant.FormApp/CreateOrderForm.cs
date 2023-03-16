using Restaurant.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Restaurant.FormApp
{
    public partial class CreateOrderForm : Form
    {
        private ItemsService itemService;
        private RestaurantsService restaurantService;
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private int totalPages = 0;
        public CreateOrderForm()
        {
            InitializeComponent();
        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Order_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearAddGroupBox()
        {
            cuisineTxt.Text = string.Empty;
            townTxt.Text = string.Empty;
            restaurantTxt.Text = string.Empty;
            itemTxt.Text = string.Empty;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearAddGroupBox();
        }

        private void PreviousBtn_Click_1(object sender, EventArgs e)
        {
            if (currentPage >= totalPages) { return; }
            Order.Items.Clear();
            List<string> list = itemService.GetItemsBasicInfo(++currentPage, itemsPerPage);
            list.ForEach(p => Order.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentPage >= totalPages) { return; }
            Order.Items.Clear();
            List<string> list = itemService.GetItemsBasicInfo(++currentPage, itemsPerPage);
            list.ForEach(p => Order.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }
    }
}
