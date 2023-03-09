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
            service=new ItemsService();
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            labelPages.Text = $"{currentPage} / {totalPages}";
        }
        private void ClearAddGroupBox()
        {
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage >= totalPages) { return; }
            Items.Items.Clear();
            List<string> list = service.GetItemsBasicInfo(++currentPage, itemsPerPage);
            list.ForEach(p => Items.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage <= 1) { return; }
            Items.Items.Clear();
            List<string> list = service.GetItemsBasicInfo(--currentPage, itemsPerPage);
            list.ForEach(p => Items.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void Items_DoubleClick(object sender, EventArgs e)
        {
            string itemsInfo = Items.Text;
            currentItemId = int.Parse(itemsInfo.Split(' ').First());
            Item item = service.GetItemById(currentItemId);
            if (item != null)
            {
                txtName.Text = item.Name;
                txtPrice.Text =item.Price.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAddGroupBox();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(btnDelete.Text);
            string result = service.RemoveItemById(id);
            MessageBox.Show(result);
            ClearAddGroupBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string name = txtName.Text;
            //decimal price = decimal.Parse(txtPrice.SelectedIndex.ToString());
            //var result = service.AddItem(name, price);
            //MessageBox.Show(result);
            ClearAddGroupBox();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
