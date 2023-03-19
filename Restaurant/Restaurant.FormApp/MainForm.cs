using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant.FormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateOrder_Click_1(object sender, EventArgs e)
        {
            CreateOrderForm createOrder = new CreateOrderForm();
            createOrder.ShowDialog();
        }

        private void RestaurantForm_Click_1(object sender, EventArgs e)
        {

            RestaurantsForm restaurantsForm = new RestaurantsForm();
            restaurantsForm.ShowDialog();
        }

        private void ItemsForm_Click_1(object sender, EventArgs e)
        {
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.ShowDialog();
        }

        private void MainForm_Load_3(object sender, EventArgs e)
        {

        }
    }
}
