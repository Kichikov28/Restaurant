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
            this.groupBoxCreateItem = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.Items = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.labelPages = new System.Windows.Forms.Label();
            this.groupBoxCreateItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCreateItem
            // 
            this.groupBoxCreateItem.Controls.Add(this.btnAdd);
            this.groupBoxCreateItem.Controls.Add(this.txtPrice);
            this.groupBoxCreateItem.Controls.Add(this.txtName);
            this.groupBoxCreateItem.Controls.Add(this.labelPrice);
            this.groupBoxCreateItem.Controls.Add(this.labelName);
            this.groupBoxCreateItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCreateItem.Location = new System.Drawing.Point(43, 46);
            this.groupBoxCreateItem.Name = "groupBoxCreateItem";
            this.groupBoxCreateItem.Size = new System.Drawing.Size(344, 294);
            this.groupBoxCreateItem.TabIndex = 0;
            this.groupBoxCreateItem.TabStop = false;
            this.groupBoxCreateItem.Text = "Create Item";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(47, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(108, 96);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 30);
            this.txtPrice.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 30);
            this.txtName.TabIndex = 2;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(24, 96);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(47, 23);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price";
            this.labelPrice.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(24, 57);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // Items
            // 
            this.Items.FormattingEnabled = true;
            this.Items.ItemHeight = 20;
            this.Items.Location = new System.Drawing.Point(470, 46);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(323, 304);
            this.Items.TabIndex = 1;
            this.Items.DoubleClick += new System.EventHandler(this.Items_DoubleClick);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(632, 377);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 44);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(500, 377);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(94, 44);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(611, 356);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(15, 20);
            this.labelPages.TabIndex = 4;
            this.labelPages.Text = "-";
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 465);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.groupBoxCreateItem);
            this.Name = "ItemsForm";
            this.Text = "ItemsForm";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            this.groupBoxCreateItem.ResumeLayout(false);
            this.groupBoxCreateItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}