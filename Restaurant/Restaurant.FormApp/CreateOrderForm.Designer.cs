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
            this.Create = new System.Windows.Forms.GroupBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.itemTxt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.ListBox();
            this.labelPages = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.Create.SuspendLayout();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Controls.Add(this.ClearBtn);
            this.Create.Controls.Add(this.AddBtn);
            this.Create.Controls.Add(this.itemTxt);
            this.Create.Controls.Add(this.label3);
            this.Create.Location = new System.Drawing.Point(31, 23);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(360, 344);
            this.Create.TabIndex = 0;
            this.Create.TabStop = false;
            this.Create.Text = "Create order";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.ClearBtn.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearBtn.Location = new System.Drawing.Point(207, 227);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(105, 67);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.AddBtn.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(26, 227);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(118, 67);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add to the order";
            this.AddBtn.UseVisualStyleBackColor = false;
            // 
            // itemTxt
            // 
            this.itemTxt.FormattingEnabled = true;
            this.itemTxt.Location = new System.Drawing.Point(161, 34);
            this.itemTxt.Name = "itemTxt";
            this.itemTxt.Size = new System.Drawing.Size(151, 28);
            this.itemTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose item";
            // 
            // Order
            // 
            this.Order.FormattingEnabled = true;
            this.Order.ItemHeight = 20;
            this.Order.Location = new System.Drawing.Point(475, 43);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(385, 324);
            this.Order.TabIndex = 2;
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(629, 403);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(15, 20);
            this.labelPages.TabIndex = 6;
            this.labelPages.Text = "-";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FloralWhite;
            this.button4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(669, 387);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 55);
            this.button4.TabIndex = 7;
            this.button4.Text = "Next";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.PreviousBtn.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreviousBtn.Location = new System.Drawing.Point(475, 387);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(120, 55);
            this.PreviousBtn.TabIndex = 8;
            this.PreviousBtn.Text = "Previous";
            this.PreviousBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.PreviousBtn.UseVisualStyleBackColor = false;
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(909, 465);
            this.Controls.Add(this.PreviousBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.Create);
            this.Name = "CreateOrderForm";
            this.Text = "CreateOrderForm";
            this.Create.ResumeLayout(false);
            this.Create.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Create;
        private System.Windows.Forms.ComboBox itemTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ListBox Order;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button PreviousBtn;
    }
}