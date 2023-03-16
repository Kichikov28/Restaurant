namespace Restaurant.FormApp
{
    partial class ItemsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxCreateItem = new System.Windows.Forms.GroupBox();
            btnDelete = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtPrice = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            labelPrice = new System.Windows.Forms.Label();
            labelName = new System.Windows.Forms.Label();
            Items = new System.Windows.Forms.ListBox();
            btnNext = new System.Windows.Forms.Button();
            btnPrevious = new System.Windows.Forms.Button();
            labelPages = new System.Windows.Forms.Label();
            comboBoxItems = new System.Windows.Forms.ComboBox();
            groupBoxCreateItem.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCreateItem
            // 
            groupBoxCreateItem.Controls.Add(btnDelete);
            groupBoxCreateItem.Controls.Add(textBox1);
            groupBoxCreateItem.Controls.Add(label5);
            groupBoxCreateItem.Controls.Add(label3);
            groupBoxCreateItem.Controls.Add(btnClear);
            groupBoxCreateItem.Controls.Add(btnAdd);
            groupBoxCreateItem.Controls.Add(txtPrice);
            groupBoxCreateItem.Controls.Add(txtName);
            groupBoxCreateItem.Controls.Add(labelPrice);
            groupBoxCreateItem.Controls.Add(labelName);
            groupBoxCreateItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBoxCreateItem.Location = new System.Drawing.Point(38, 34);
            groupBoxCreateItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxCreateItem.Name = "groupBoxCreateItem";
            groupBoxCreateItem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxCreateItem.Size = new System.Drawing.Size(301, 228);
            groupBoxCreateItem.TabIndex = 0;
            groupBoxCreateItem.TabStop = false;
            groupBoxCreateItem.Text = "Create Item";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.FloralWhite;
            btnDelete.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(174, 187);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(109, 37);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(174, 160);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(110, 26);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(5, 162);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(170, 20);
            label5.TabIndex = 7;
            label5.Text = "Enter Id to delete item:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(22, 162);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 19);
            label3.TabIndex = 6;
            label3.Click += label3_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.FloralWhite;
            btnClear.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClear.Location = new System.Drawing.Point(153, 117);
            btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(94, 32);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.FloralWhite;
            btnAdd.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdd.Location = new System.Drawing.Point(41, 117);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(86, 32);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(94, 72);
            txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(110, 26);
            txtPrice.TabIndex = 3;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(94, 40);
            txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(110, 26);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPrice.Location = new System.Drawing.Point(22, 72);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new System.Drawing.Size(43, 20);
            labelPrice.TabIndex = 1;
            labelPrice.Text = "Price";
            labelPrice.Click += label2_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelName.Location = new System.Drawing.Point(22, 40);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(51, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // Items
            // 
            Items.FormattingEnabled = true;
            Items.ItemHeight = 15;
            Items.Location = new System.Drawing.Point(411, 34);
            Items.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Items.Name = "Items";
            Items.Size = new System.Drawing.Size(283, 229);
            Items.TabIndex = 1;
            Items.SelectedIndexChanged += Items_SelectedIndexChanged;
            Items.DoubleClick += Items_DoubleClick;
            // 
            // btnNext
            // 
            btnNext.BackColor = System.Drawing.Color.FloralWhite;
            btnNext.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnNext.Location = new System.Drawing.Point(526, 283);
            btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(84, 33);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = System.Drawing.Color.FloralWhite;
            btnPrevious.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPrevious.Location = new System.Drawing.Point(411, 283);
            btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new System.Drawing.Size(82, 33);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // labelPages
            // 
            labelPages.AutoSize = true;
            labelPages.Location = new System.Drawing.Point(508, 265);
            labelPages.Name = "labelPages";
            labelPages.Size = new System.Drawing.Size(12, 15);
            labelPages.TabIndex = 4;
            labelPages.Text = "-";
            // 
            // comboBoxItems
            // 
            comboBoxItems.FormattingEnabled = true;
            comboBoxItems.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30" });
            comboBoxItems.Location = new System.Drawing.Point(630, 293);
            comboBoxItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            comboBoxItems.Name = "comboBoxItems";
            comboBoxItems.Size = new System.Drawing.Size(81, 23);
            comboBoxItems.TabIndex = 8;
            comboBoxItems.SelectedIndexChanged += comboBoxItems_SelectedIndexChanged;
            // 
            // ItemsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightSteelBlue;
            ClientSize = new System.Drawing.Size(765, 349);
            Controls.Add(comboBoxItems);
            Controls.Add(labelPages);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(Items);
            Controls.Add(groupBoxCreateItem);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "ItemsForm";
            Text = "ItemsForm";
            Load += ItemsForm_Load;
            groupBoxCreateItem.ResumeLayout(false);
            groupBoxCreateItem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCreateItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox Items;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboBoxItems;
    }
}