namespace Restaurant.FormApp
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
    public partial class RestaurantsForm : Form
    {
        private RestaurantsService service;
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private int totalPages = 0;
        private int currentRestaurantId = 0;
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
            for (double i = 2.0; i < 10.0; i += 0.1)
            {
                comboRating.Items.Add($"{i:f1}");
            }
            comboRating.SelectedIndex = 0;
            comboItemsPerPage.SelectedIndex = 0;
            labelPages.Text = $"{currentPage} / {totalPages}";
            radioBtnAdd.Checked = true;
            checkBoxDeleteRestaurant.Visible = false;

        }
        private void ClearAddGroupBox()
        {
            textBoxName.Text = string.Empty;
            comboRating.SelectedIndex = 0;
            comboBoxLocation.SelectedIndex = 0;
            comboType.SelectedIndex = 0;
        }

        private void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            if (btnAddRestaurant.Text == "Add")
            {
                string name = textBoxName.Text;
                string location = comboBoxLocation.Text;
                double rating = double.Parse(comboRating.SelectedItem.ToString());
                string type = comboType.Text;

                string result = service.AddRestaurant(name, rating, location, type);
                MessageBox.Show(result);
                ClearAddGroupBox();
            }
            else if (btnAddRestaurant.Text == "Update")
            {
                if (checkBoxDeleteRestaurant.Checked)
                {
                    MessageBox.Show(service.DeleteRestaurantById(currentRestaurantId));
                }
                else
                {
                    double rating = double.Parse(comboRating.Text);
                    MessageBox.Show(service.UpdateRestaurantRating(currentRestaurantId,rating));
                }
                ClearAddGroupBox();
            }
            

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
        private void listBoxRestaurants_DoubleClick(object sender, EventArgs e)
        {
            string restaurantInfo = listBoxRestaurants.Text;
            currentRestaurantId = int.Parse(restaurantInfo.Split(' ').First());
            Restaurant restaurant = service.GetRestaurantById(currentRestaurantId);
            if (restaurant != null)
            {
                textBoxName.Text = restaurant.Name;
                comboBoxLocation.Text = restaurant.Location.ToString();
                comboRating.Text = restaurant.Rating.ToString();
                comboType.Text = restaurant.Type.ToString();
            }

        }

        private void comboRating_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnAdd.Checked)
            {
                btnAddRestaurant.Text = "Add";
                listBoxRestaurants.Enabled = false;
                textBoxName.Enabled = !false;
                comboBoxLocation.Enabled = !false;
                comboRating.Enabled = !false;
                checkBoxDeleteRestaurant.Visible = false;
                ClearAddGroupBox();
                AddInputOnOff(true);
            }
            else
            {
                btnAddRestaurant.Text = "Update";
                checkBoxDeleteRestaurant.Visible = true;
                listBoxRestaurants.Enabled = true;
                AddInputOnOff(false);
            }

        }
        private void AddInputOnOff(bool isActive)
        {
            textBoxName.Enabled = isActive;
            comboBoxLocation.Enabled = isActive;
            comboType.Enabled = isActive;
        }
    }
}
