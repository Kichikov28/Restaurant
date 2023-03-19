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

namespace Restaurant.FormApp
{
    public partial class CreateOrderForm : Form
    {
        private OrderService orderService;
        private int restaurantid = 0;
        private int itemId = 0;
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
            List<string> menus = orderService.GetItems();
            menus.ForEach(x => listBoxMenus.Items.Add(x));
            listBoxRestaurant.Enabled = false;
        }

        private void listBoxItems_DoubleClick(object sender, EventArgs e)
        {
            labelInfo.Text = "Step 3 - Create order";
           
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
