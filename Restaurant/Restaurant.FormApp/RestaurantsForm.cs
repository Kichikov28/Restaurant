
using Restaurant.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant.FormApp
{
    public partial class RestaurantsForm : Form
    {
        private RestaurantsService service;
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private int totalPages = 0;
        public RestaurantsForm()
        {
            InitializeComponent();
            service = new RestaurantsService();
        }

        private void groupBoxRestaurant_Enter(object sender, EventArgs e)
        {

        }

        private void RestaurantsForm_Load(object sender, EventArgs e)
        {
            for (double i = 2.0; i <= 10.0; i += 0.2)
            {
                comboRating.Items.Add($"{i:f1}");
            }
            comboRating.SelectedIndex = 0;
            //comboItemsPerPage.SelectedIndex = 0;
            labelPages.Text = $"{currentPage} / {totalPages}";

         
        }
        private void ClearAddGroupBox()
        {
            textBoxName.Text = string.Empty;
            comboRating.SelectedIndex = 0;
            comboBoxLocation.SelectedIndex = 0;
            comboType.SelectedIndex = 0;
            txtDelete.Text = string.Empty;
        }

        private void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string location = comboBoxLocation.Text;
            double rating = double.Parse(comboRating.SelectedItem.ToString());
            string type = comboType.Text;

            string result = service.AddRestaurant(name, rating, location, type);
            MessageBox.Show(result);
            ClearAddGroupBox();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            ClearAddGroupBox();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage >= totalPages) { return; }
            listBoxRestaurants.Items.Clear();
            List<string> list = service.GetRestaurantsBasicInfo(++currentPage, itemsPerPage);
            list.ForEach(p => listBoxRestaurants.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage <= 1) { return; }
            listBoxRestaurants.Items.Clear();
            List<string> list = service.GetRestaurantsBasicInfo(--currentPage, itemsPerPage);
            list.ForEach(p => listBoxRestaurants.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void comboItemsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemsPerPage = int.Parse(comboItemsPerPage.Text);
            totalPages = service.GetRestaurantPagesCount(itemsPerPage);

            listBoxRestaurants.Items.Clear();
            List<string> list = service.GetRestaurantsBasicInfo(1, itemsPerPage);
            list.ForEach(p => listBoxRestaurants.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void listBoxRestaurants_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDelete.Text);
            string result = service.DeleteRestaurantById(id);
            MessageBox.Show(result);
            ClearAddGroupBox();
        }
    }
}
