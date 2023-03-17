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
            Create = new System.Windows.Forms.GroupBox();
            ClearBtn = new System.Windows.Forms.Button();
            AddBtn = new System.Windows.Forms.Button();
            cuisineTxt = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            itemTxt = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            restaurantTxt = new System.Windows.Forms.ComboBox();
            townTxt = new System.Windows.Forms.ComboBox();
            Order = new System.Windows.Forms.ListBox();
            labelPages = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            PreviousBtn = new System.Windows.Forms.Button();
            Create.SuspendLayout();
            SuspendLayout();
            // 
            // Create
            // 
            Create.Controls.Add(ClearBtn);
            Create.Controls.Add(AddBtn);
            Create.Controls.Add(cuisineTxt);
            Create.Controls.Add(label4);
            Create.Controls.Add(itemTxt);
            Create.Controls.Add(label3);
            Create.Controls.Add(label2);
            Create.Controls.Add(label1);
            Create.Controls.Add(restaurantTxt);
            Create.Controls.Add(townTxt);
            Create.Location = new System.Drawing.Point(27, 17);
            Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Create.Name = "Create";
            Create.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Create.Size = new System.Drawing.Size(315, 258);
            Create.TabIndex = 0;
            Create.TabStop = false;
            Create.Text = "Create order";
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ClearBtn.Location = new System.Drawing.Point(181, 170);
            ClearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new System.Drawing.Size(92, 50);
            ClearBtn.TabIndex = 9;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AddBtn.Location = new System.Drawing.Point(23, 170);
            AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new System.Drawing.Size(103, 50);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Add to the order";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // cuisineTxt
            // 
            cuisineTxt.FormattingEnabled = true;
            cuisineTxt.Location = new System.Drawing.Point(140, 26);
            cuisineTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cuisineTxt.Name = "cuisineTxt";
            cuisineTxt.Size = new System.Drawing.Size(133, 23);
            cuisineTxt.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(23, 28);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(88, 15);
            label4.TabIndex = 7;
            label4.Text = "Choose cuisine";
            // 
            // itemTxt
            // 
            itemTxt.FormattingEnabled = true;
            itemTxt.Location = new System.Drawing.Point(142, 131);
            itemTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            itemTxt.Name = "itemTxt";
            itemTxt.Size = new System.Drawing.Size(133, 23);
            itemTxt.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(23, 134);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 15);
            label3.TabIndex = 5;
            label3.Text = "Choose item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(23, 98);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(108, 15);
            label2.TabIndex = 4;
            label2.Text = "Choose restaurant";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(23, 61);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 15);
            label1.TabIndex = 3;
            label1.Text = "Choose town";
            // 
            // restaurantTxt
            // 
            restaurantTxt.FormattingEnabled = true;
            restaurantTxt.Location = new System.Drawing.Point(140, 95);
            restaurantTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            restaurantTxt.Name = "restaurantTxt";
            restaurantTxt.Size = new System.Drawing.Size(133, 23);
            restaurantTxt.TabIndex = 2;
            // 
            // townTxt
            // 
            townTxt.FormattingEnabled = true;
            townTxt.Location = new System.Drawing.Point(140, 58);
            townTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            townTxt.Name = "townTxt";
            townTxt.Size = new System.Drawing.Size(133, 23);
            townTxt.TabIndex = 1;
            // 
            // Order
            // 
            Order.FormattingEnabled = true;
            Order.ItemHeight = 15;
            Order.Location = new System.Drawing.Point(416, 32);
            Order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Order.Name = "Order";
            Order.Size = new System.Drawing.Size(337, 244);
            Order.TabIndex = 2;
            // 
            // labelPages
            // 
            labelPages.AutoSize = true;
            labelPages.Location = new System.Drawing.Point(550, 302);
            labelPages.Name = "labelPages";
            labelPages.Size = new System.Drawing.Size(12, 15);
            labelPages.TabIndex = 6;
            labelPages.Text = "-";
            // 
            // button4
            // 
            button4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button4.Location = new System.Drawing.Point(585, 290);
            button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(105, 41);
            button4.TabIndex = 7;
            button4.Text = "Next";
            button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // PreviousBtn
            // 
            PreviousBtn.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PreviousBtn.Location = new System.Drawing.Point(416, 290);
            PreviousBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            PreviousBtn.Name = "PreviousBtn";
            PreviousBtn.Size = new System.Drawing.Size(105, 41);
            PreviousBtn.TabIndex = 8;
            PreviousBtn.Text = "Previous";
            PreviousBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            PreviousBtn.UseVisualStyleBackColor = true;
            PreviousBtn.Click += PreviousBtn_Click_1;
            // 
            // CreateOrderForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightSteelBlue;
            ClientSize = new System.Drawing.Size(795, 349);
            Controls.Add(PreviousBtn);
            Controls.Add(button4);
            Controls.Add(labelPages);
            Controls.Add(Order);
            Controls.Add(Create);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "CreateOrderForm";
            Text = "CreateOrderForm";
            Create.ResumeLayout(false);
            Create.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox Create;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox itemTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox restaurantTxt;
        private System.Windows.Forms.ComboBox townTxt;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox cuisineTxt;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ListBox Order;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button PreviousBtn;
    }
}