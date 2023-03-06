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
        
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void RestaurantForm_Click(object sender, EventArgs e)
        {
            RestaurantsForm restaurantsForm = new RestaurantsForm();
            restaurantsForm.ShowDialog();
        }

        private void MainForm_Load_2(object sender, EventArgs e)
        {

        }

        private void ItemsForm_Click(object sender, EventArgs e)
        {
            ItemsForm itemsForm=new ItemsForm();
            itemsForm.ShowDialog();
        }
    }
}
