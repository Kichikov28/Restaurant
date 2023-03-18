namespace Restaurant.FormApp
{
    partial class CreateOrderForm
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
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.labelTotalSum = new System.Windows.Forms.Label();
            this.orderItemListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(60, 83);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(125, 27);
            this.itemNameTextBox.TabIndex = 0;
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(60, 135);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(125, 27);
            this.itemPriceTextBox.TabIndex = 1;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(67, 204);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(94, 29);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // labelTotalSum
            // 
            this.labelTotalSum.AutoSize = true;
            this.labelTotalSum.Location = new System.Drawing.Point(538, 292);
            this.labelTotalSum.Name = "labelTotalSum";
            this.labelTotalSum.Size = new System.Drawing.Size(15, 20);
            this.labelTotalSum.TabIndex = 4;
            this.labelTotalSum.Text = "-";
            // 
            // orderItemListBox
            // 
            this.orderItemListBox.FormattingEnabled = true;
            this.orderItemListBox.ItemHeight = 20;
            this.orderItemListBox.Location = new System.Drawing.Point(392, 35);
            this.orderItemListBox.Name = "orderItemListBox";
            this.orderItemListBox.Size = new System.Drawing.Size(336, 224);
            this.orderItemListBox.TabIndex = 3;
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(909, 465);
            this.Controls.Add(this.labelTotalSum);
            this.Controls.Add(this.orderItemListBox);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Name = "CreateOrderForm";
            this.Text = "CreateOrderForm";
            this.Load += new System.EventHandler(this.CreateOrderForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListBox orderItemListBox;
        private System.Windows.Forms.Label labelTotalSum;
    }
}