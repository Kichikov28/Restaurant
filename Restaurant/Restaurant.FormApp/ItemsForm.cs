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
    }
}
