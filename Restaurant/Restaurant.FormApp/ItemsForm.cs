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
    public partial class ItemsForm : Form
    {
        private ItemsService service;
        public ItemsForm()
        {
            InitializeComponent();
            service=new ItemsService();
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
