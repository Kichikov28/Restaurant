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

        private void btnItemForm_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRestaurantForm_Click_1(object sender, EventArgs e)
        {
            RestaurantsForm restaurantsForm = new RestaurantsForm();
            restaurantsForm.ShowDialog();

        }
    }
}
