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
        public CreateOrderForm()
        {
            InitializeComponent();
        }
        private void CreateOrderForm_Load_1(object sender, EventArgs e)
        {
            labelInfo.Text = "Step 1 - Choose Restaurant";
            List<string> restaurants= orderService.GetFromRestaurant();
            restaurants.ForEach(x=>listBoxRestaurant.Items.Add(x));

        }

        private void listBoxRestaurant_DoubleClick(object sender, EventArgs e)
        {
            labelInfo.Text = "Step 2 - Select destination end point";
            restaurantid = int.Parse(listBoxRestaurant.Text.Split(" - ").FirstOrDefault());
            List<string> toItems = orderService.GetToRestaurants(restaurantid);
            toItems.ForEach(x => listBoxItems.Items.Add(x));
            listBoxRestaurant.Enabled = false;
        }

        private void listBoxRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
