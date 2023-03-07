namespace Restaurant.FormApp
{
    partial class RestaurantsForm
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
            this.groupBoxRestaurant = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddRestaurant = new System.Windows.Forms.Button();
            this.comboRating = new System.Windows.Forms.ComboBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Restaurants = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.comboItemsPerPage = new System.Windows.Forms.ComboBox();
            this.labelPages = new System.Windows.Forms.Label();
            this.groupBoxRestaurant.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRestaurant
            // 
            this.groupBoxRestaurant.Controls.Add(this.label5);
            this.groupBoxRestaurant.Controls.Add(this.txtDelete);
            this.groupBoxRestaurant.Controls.Add(this.btnDelete);
            this.groupBoxRestaurant.Controls.Add(this.btnClear);
            this.groupBoxRestaurant.Controls.Add(this.btnAddRestaurant);
            this.groupBoxRestaurant.Controls.Add(this.comboRating);
            this.groupBoxRestaurant.Controls.Add(this.comboType);
            this.groupBoxRestaurant.Controls.Add(this.comboBoxLocation);
            this.groupBoxRestaurant.Controls.Add(this.textBoxName);
            this.groupBoxRestaurant.Controls.Add(this.label4);
            this.groupBoxRestaurant.Controls.Add(this.label3);
            this.groupBoxRestaurant.Controls.Add(this.label2);
            this.groupBoxRestaurant.Controls.Add(this.label1);
            this.groupBoxRestaurant.Location = new System.Drawing.Point(72, 32);
            this.groupBoxRestaurant.Name = "groupBoxRestaurant";
            this.groupBoxRestaurant.Size = new System.Drawing.Size(345, 396);
            this.groupBoxRestaurant.TabIndex = 0;
            this.groupBoxRestaurant.TabStop = false;
            this.groupBoxRestaurant.Text = "Create";
            this.groupBoxRestaurant.Enter += new System.EventHandler(this.groupBoxRestaurant_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enter Id to delete restaurant:";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(208, 297);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(96, 27);
            this.txtDelete.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(208, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 54);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(190, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 48);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddRestaurant
            // 
            this.btnAddRestaurant.Location = new System.Drawing.Point(46, 225);
            this.btnAddRestaurant.Name = "btnAddRestaurant";
            this.btnAddRestaurant.Size = new System.Drawing.Size(107, 48);
            this.btnAddRestaurant.TabIndex = 8;
            this.btnAddRestaurant.Text = "Add";
            this.btnAddRestaurant.UseVisualStyleBackColor = true;
            this.btnAddRestaurant.Click += new System.EventHandler(this.btnAddRestaurant_Click);
            // 
            // comboRating
            // 
            this.comboRating.FormattingEnabled = true;
            this.comboRating.Location = new System.Drawing.Point(95, 170);
            this.comboRating.Name = "comboRating";
            this.comboRating.Size = new System.Drawing.Size(209, 28);
            this.comboRating.TabIndex = 7;
            this.comboRating.SelectedIndexChanged += new System.EventHandler(this.comboRating_SelectedIndexChanged);
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Italian",
            "Japanese",
            "Bulgarian",
            "Chinese",
            "Greek"});
            this.comboType.Location = new System.Drawing.Point(95, 123);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(209, 28);
            this.comboType.TabIndex = 6;
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Items.AddRange(new object[] {
            "Sofia",
            "Velingrad",
            "Plovdiv",
            "Blagoevgrad",
            "Varna",
            "Burgas"});
            this.comboBoxLocation.Location = new System.Drawing.Point(95, 77);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(209, 28);
            this.comboBoxLocation.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(95, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(209, 27);
            this.textBoxName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Restaurants
            // 
            this.Restaurants.FormattingEnabled = true;
            this.Restaurants.ItemHeight = 20;
            this.Restaurants.Location = new System.Drawing.Point(511, 32);
            this.Restaurants.Name = "Restaurants";
            this.Restaurants.Size = new System.Drawing.Size(388, 324);
            this.Restaurants.TabIndex = 1;
            this.Restaurants.SelectedIndexChanged += new System.EventHandler(this.listBoxRestaurants_SelectedIndexChanged);
            this.Restaurants.DoubleClick += new System.EventHandler(this.listBoxRestaurants_DoubleClick);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(543, 384);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(94, 44);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(667, 384);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 44);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // comboItemsPerPage
            // 
            this.comboItemsPerPage.FormattingEnabled = true;
            this.comboItemsPerPage.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.comboItemsPerPage.Location = new System.Drawing.Point(785, 393);
            this.comboItemsPerPage.Name = "comboItemsPerPage";
            this.comboItemsPerPage.Size = new System.Drawing.Size(114, 28);
            this.comboItemsPerPage.TabIndex = 4;
            this.comboItemsPerPage.SelectedIndexChanged += new System.EventHandler(this.comboItemsPerPage_SelectedIndexChanged);
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(630, 361);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(15, 20);
            this.labelPages.TabIndex = 5;
            this.labelPages.Text = "-";
            // 
            // RestaurantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(985, 479);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.comboItemsPerPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.Restaurants);
            this.Controls.Add(this.groupBoxRestaurant);
            this.Name = "RestaurantsForm";
            this.Text = "RestaurantsForm";
            this.Load += new System.EventHandler(this.RestaurantsForm_Load);
            this.groupBoxRestaurant.ResumeLayout(false);
            this.groupBoxRestaurant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRestaurant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboRating;
        private System.Windows.Forms.Button btnAddRestaurant;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox Restaurants;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox comboItemsPerPage;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDelete;
    }
}