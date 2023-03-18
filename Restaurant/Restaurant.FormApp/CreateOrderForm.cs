using Restaurant.Models;
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
        private List<OrderItem> orderItems;
        private decimal total;
        public CreateOrderForm()
        {
            InitializeComponent();
            orderItems = new List<OrderItem>();
            total = 0;
        }
        private void CreateOrderForm_Load_1(object sender, EventArgs e)
        {

        }
        private void AddItemToOrder(Item item)
        {
            bool itemFound = false;
            foreach (OrderItem orderItem in orderItems)
            {
                if (orderItem.ItemId == item.Id)
                {
                    orderItem.Quantity++;
                    itemFound = true;
                    break;
                }
            }
            if (!itemFound)
            {
                OrderItem orderItem = new OrderItem
                {
                    Id = 1,
                    ItemId = item.Id,
                    OrderId = 1,
                    Quantity = 1
                };
                orderItems.Add(orderItem);
            }
            total += item.Price;
            labelTotalSum.Text = $"Total Price: {total} leva";
            foreach (OrderItem orderItem in orderItems)
            {
                Item orderItemName = new Item { Id = orderItem.Id, Name = item.Name, Price = item.Price };
                orderItemListBox.Items.Add($"{orderItemName.Name} x {orderItem.Quantity} = {(double)orderItemName.Price * orderItem.Quantity} leva");
            }
           
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string itemName = itemNameTextBox.Text;
            decimal itemPrice;
            if (!decimal.TryParse(itemPriceTextBox.Text, out itemPrice))
            {
                MessageBox.Show("Please enter a valid item price.");
                return;
            }
            Item item = new Item { Id = 1, Name = itemName, Price = itemPrice };
            AddItemToOrder(item);
            itemNameTextBox.Text = "";
            itemPriceTextBox.Text = "";
        }
    }
}
