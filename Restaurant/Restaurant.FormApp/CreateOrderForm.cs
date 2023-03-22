namespace Restaurant.FormApp
{
    using Castle.Core.Resource;
    using Restaurant.Models;
    using Restaurant.Services;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml.Linq;
    public partial class CreateOrderForm : Form
    {
        private OrderService orderService;
        private CustomerService customerService;
        private int total = 0;
        public CreateOrderForm()
        {
            InitializeComponent();
            orderService = new OrderService();
            customerService = new CustomerService();
        }
        private void CreateOrderForm_Load_1(object sender, EventArgs e)
        {
            labelInfo.Text = "Step 1 - Choose Restaurant";
            List<string> restaurants = orderService.GetFromRestaurant();
            restaurants.ForEach(x => listBoxRestaurant.Items.Add(x));

            List<string> customers = customerService.GetCustomers();
            customers.ForEach(x => comboBox1.Items.Add(x));
            comboBox1.SelectedIndex = 0;
            listBoxItems.Enabled = false;
        }

        private void listBoxRestaurant_DoubleClick(object sender, EventArgs e)
        {

            labelInfo.Text = "Step 2 - Choose customer ->";
            List<string> items = orderService.GetItems();
            items.ForEach(x => listBoxItems.Items.Add(x));
            listBoxRestaurant.Enabled = false;

        }

        private void listBoxItems_DoubleClick(object sender, EventArgs e)
        {
            labelInfo.Text = "Step 4 - Create order";
            listBoxOrder.Items.Add(listBoxItems.SelectedItem);
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            int restaurantId = int.Parse(listBoxRestaurant.Text.Split(" - ").FirstOrDefault());
            int customerId = int.Parse(comboBox1.Text.Split(" - ").FirstOrDefault());
            decimal totalItemsPrice = 0;
            List<int> items = new List<int>();
            foreach (var item in listBoxOrder.Items)
            {
                int itemId = int.Parse(item.ToString().Split(" - ").FirstOrDefault());
                decimal itemPrice = decimal.Parse(item.ToString().Split(" - ").LastOrDefault().Replace("Leva", ""));
                items.Add(itemId);
                totalItemsPrice += itemPrice;
            }

            string result = orderService.CreateOrder(restaurantId, customerId, items);
            MessageBox.Show(result + $"\nTotal items price: {totalItemsPrice:f2}");

            this.CreateOrderForm_Load_1(sender, e);

            //CreateOrderForm createOrderForm = new CreateOrderForm();
            //MainForm mainForm = new MainForm();
            listBoxOrder.Items.Clear();
            listBoxItems.Items.Clear();
            listBoxRestaurant.Enabled = true;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (listBoxOrder.SelectedIndex > -1)
            {
                listBoxOrder.Items.RemoveAt(listBoxOrder.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Select an item in the listbox!");
            }
        }

        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            List<string> selectedItems = new List<string>();
            foreach (var item in listBoxOrder.Items)
            {
                selectedItems.Add(item.ToString());
            }
            List<string> items = new List<string>(selectedItems);
            MessageBox.Show(string.Join(", ", items));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelInfo.Text = "Step 3 - Select items";
            listBoxItems.Enabled = true;
        }
    }
}
