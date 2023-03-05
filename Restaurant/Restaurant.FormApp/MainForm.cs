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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateOrder_Click_RestaurantForm(object sender, EventArgs e)
        {
            RestaurantsForm restaurantsForm = new RestaurantsForm();
            restaurantsForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
