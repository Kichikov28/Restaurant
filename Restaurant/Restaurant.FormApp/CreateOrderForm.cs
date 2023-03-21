namespace Restaurant.FormApp
{
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
        public CreateOrderForm()
        {
            InitializeComponent();
            orderService = new OrderService();
        }
        private void CreateOrderForm_Load_1(object sender, EventArgs e)
        {
            labelInfo.Text = "Step 1 - Choose Restaurant";
            List<string> restaurants = orderService.GetFromRestaurant();
            restaurants.ForEach(x => listBoxRestaurant.Items.Add(x));
        }

        private void listBoxRestaurant_DoubleClick(object sender, EventArgs e)
        {
            labelInfo.Text = "Step 2 - Select items";
            List<string> items = orderService.GetItems();
            items.ForEach(x => listBoxItems.Items.Add(x));
            listBoxRestaurant.Enabled = false;
        }

        private void listBoxItems_DoubleClick(object sender, EventArgs e)
        {
            labelInfo.Text = "Step 3 - Create order";
            listBoxOrder.Items.Add(listBoxItems.SelectedItem);
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            //int order = int.Parse(labelOrders.Text.Split(" - ").FirstOrDefault());
            //List<int> items = new List<int>();
            //foreach (var item in listBoxOrder.Items)
            //{
            //    int itemId = int.Parse(item.ToString().Split(" - ").FirstOrDefault());
            //    items.Add(itemId);

            //}
            //string result = orderService.AddOrderItems(order, items);
            //MessageBox.Show(result);
            //this.CreateOrderForm_Load_1(sender, e);



            MessageBox.Show("Order was successfully added and is coming to your address! Thanks for choosing KiDy's Delicious Food!");
            CreateOrderForm createOrderForm = new CreateOrderForm();
            MainForm mainForm = new MainForm();
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
                MessageBox.Show("Select an item in the listbox.");
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
            MessageBox.Show(string.Join(", ",items));
        }
    }
}
