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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBoxCreateItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCreateItem
            // 
            this.groupBoxCreateItem.Controls.Add(this.btnAdd);
            this.groupBoxCreateItem.Controls.Add(this.textBox2);
            this.groupBoxCreateItem.Controls.Add(this.textBox1);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 30);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 30);
            this.textBox2.TabIndex = 3;
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
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 491);
            this.Controls.Add(this.groupBoxCreateItem);
            this.Name = "ItemsForm";
            this.Text = "ItemsForm";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            this.groupBoxCreateItem.ResumeLayout(false);
            this.groupBoxCreateItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCreateItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnAdd;
    }
}