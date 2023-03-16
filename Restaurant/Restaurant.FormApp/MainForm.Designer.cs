namespace Restaurant.FormApp
{
    partial class MainForm
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
            ItemsForm = new System.Windows.Forms.Button();
            RestaurantForm = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnCreateOrder = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // ItemsForm
            // 
            ItemsForm.BackColor = System.Drawing.Color.FloralWhite;
            ItemsForm.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ItemsForm.Location = new System.Drawing.Point(12, 346);
            ItemsForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ItemsForm.Name = "ItemsForm";
            ItemsForm.Size = new System.Drawing.Size(169, 41);
            ItemsForm.TabIndex = 1;
            ItemsForm.Text = "Items";
            ItemsForm.UseVisualStyleBackColor = false;
            ItemsForm.Click += ItemsForm_Click;
            // 
            // RestaurantForm
            // 
            RestaurantForm.BackColor = System.Drawing.Color.FloralWhite;
            RestaurantForm.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RestaurantForm.Location = new System.Drawing.Point(12, 301);
            RestaurantForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            RestaurantForm.Name = "RestaurantForm";
            RestaurantForm.Size = new System.Drawing.Size(169, 41);
            RestaurantForm.TabIndex = 2;
            RestaurantForm.Text = "Restaurants";
            RestaurantForm.UseVisualStyleBackColor = false;
            RestaurantForm.Click += RestaurantForm_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Brown;
            label1.Location = new System.Drawing.Point(116, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(615, 62);
            label1.TabIndex = 3;
            label1.Text = "Welcome to DiKy's Delicious Food";
            label1.Click += label1_Click;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.BackColor = System.Drawing.Color.FloralWhite;
            btnCreateOrder.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCreateOrder.Location = new System.Drawing.Point(682, 322);
            btnCreateOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new System.Drawing.Size(135, 65);
            btnCreateOrder.TabIndex = 4;
            btnCreateOrder.Text = "Order";
            btnCreateOrder.UseVisualStyleBackColor = false;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(10, 112);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(109, 46);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(242, 199);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(109, 46);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new System.Drawing.Point(495, 119);
            pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(109, 46);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new System.Drawing.Point(682, 178);
            pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(109, 46);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            ClientSize = new System.Drawing.Size(827, 396);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnCreateOrder);
            Controls.Add(label1);
            Controls.Add(RestaurantForm);
            Controls.Add(ItemsForm);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button ItemsForm;
        private System.Windows.Forms.Button RestaurantForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}