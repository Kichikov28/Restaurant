﻿namespace Restaurant.FormApp
{
    using Models;
    using Restaurant.Services;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    public partial class ItemsForm : Form
    {
        private ItemsService service;
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private int totalPages = 0;
        private int currentItemId = 0;
        public ItemsForm()
        {
            InitializeComponent();
            service = new ItemsService();
        }
        private void ClearAddGroupBox()
        {
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            textBoxDelete.Text = string.Empty;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxDelete.Text);
            string result = service.RemoveItemById(id);
            MessageBox.Show(result);
            ClearAddGroupBox();
        }

        private void ItemsForm_Load_2(object sender, EventArgs e)
        {
            comboBoxItems.SelectedIndex = 0;
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (currentPage >= totalPages) { return; }
            Items.Items.Clear();
            List<string> list = service.GetItemsBasicInfo(++currentPage, itemsPerPage);
            list.ForEach(p => Items.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            var result = service.AddItem(name, price);
            MessageBox.Show(result);
            ClearAddGroupBox();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearAddGroupBox();
        }

        private void comboBoxItems_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            itemsPerPage = int.Parse(comboBoxItems.Text);
            totalPages = service.GetItemsPagesCount(itemsPerPage);

            Items.Items.Clear();
            List<string> list = service.GetItemsBasicInfo(1, itemsPerPage);
            list.ForEach(i => Items.Items.Add(i));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void Items_DoubleClick_1(object sender, EventArgs e)
        {
            string itemsInfo = Items.Text;
            currentItemId = int.Parse(itemsInfo.Split(' ').First());
            Item item = service.GetItemById(currentItemId);
            if (item != null)
            {
                txtName.Text = item.Name;
                txtPrice.Text = item.Price.ToString();
            }
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {

            if (currentPage <= 1) { return; }
            Items.Items.Clear();
            List<string> list = service.GetItemsBasicInfo(--currentPage, itemsPerPage);
            list.ForEach(p => Items.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }
    }
}
