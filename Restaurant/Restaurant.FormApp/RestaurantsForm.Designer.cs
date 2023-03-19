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
            this.checkBoxDeleteRestaurant = new System.Windows.Forms.CheckBox();
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
            this.listBoxRestaurants = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.comboItemsPerPage = new System.Windows.Forms.ComboBox();
            this.labelPages = new System.Windows.Forms.Label();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.radioBtnEdit = new System.Windows.Forms.RadioButton();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.groupBoxRestaurant.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRestaurant
            // 
            this.groupBoxRestaurant.Controls.Add(this.checkBoxDeleteRestaurant);
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
            this.groupBoxRestaurant.Size = new System.Drawing.Size(345, 324);
            this.groupBoxRestaurant.TabIndex = 0;
            this.groupBoxRestaurant.TabStop = false;
            this.groupBoxRestaurant.Text = "Create";
            // 
            // checkBoxDeleteRestaurant
            // 
            this.checkBoxDeleteRestaurant.AutoSize = true;
            this.checkBoxDeleteRestaurant.Location = new System.Drawing.Point(16, 213);
            this.checkBoxDeleteRestaurant.Name = "checkBoxDeleteRestaurant";
            this.checkBoxDeleteRestaurant.Size = new System.Drawing.Size(145, 24);
            this.checkBoxDeleteRestaurant.TabIndex = 10;
            this.checkBoxDeleteRestaurant.Text = "DeleteRestaurant";
            this.checkBoxDeleteRestaurant.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FloralWhite;
            this.btnClear.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(189, 253);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 48);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnAddRestaurant
            // 
            this.btnAddRestaurant.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAddRestaurant.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddRestaurant.Location = new System.Drawing.Point(40, 253);
            this.btnAddRestaurant.Name = "btnAddRestaurant";
            this.btnAddRestaurant.Size = new System.Drawing.Size(107, 48);
            this.btnAddRestaurant.TabIndex = 8;
            this.btnAddRestaurant.Text = "Add";
            this.btnAddRestaurant.UseVisualStyleBackColor = false;
            this.btnAddRestaurant.Click += new System.EventHandler(this.btnAddRestaurant_Click_1);
            // 
            // comboRating
            // 
            this.comboRating.FormattingEnabled = true;
            this.comboRating.Location = new System.Drawing.Point(95, 171);
            this.comboRating.Name = "comboRating";
            this.comboRating.Size = new System.Drawing.Size(209, 28);
            this.comboRating.TabIndex = 7;
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
            this.comboType.Location = new System.Drawing.Point(95, 127);
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
            this.comboBoxLocation.Location = new System.Drawing.Point(95, 85);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(209, 28);
            this.comboBoxLocation.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(95, 43);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(209, 27);
            this.textBoxName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // listBoxRestaurants
            // 
            this.listBoxRestaurants.FormattingEnabled = true;
            this.listBoxRestaurants.ItemHeight = 20;
            this.listBoxRestaurants.Location = new System.Drawing.Point(511, 32);
            this.listBoxRestaurants.Name = "listBoxRestaurants";
            this.listBoxRestaurants.Size = new System.Drawing.Size(442, 324);
            this.listBoxRestaurants.TabIndex = 1;
            this.listBoxRestaurants.DoubleClick += new System.EventHandler(this.listBoxRestaurants_DoubleClick_1);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FloralWhite;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.Location = new System.Drawing.Point(546, 384);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(106, 53);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FloralWhite;
            this.btnNext.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(685, 384);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 53);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // comboItemsPerPage
            // 
            this.comboItemsPerPage.FormattingEnabled = true;
            this.comboItemsPerPage.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.comboItemsPerPage.Location = new System.Drawing.Point(817, 393);
            this.comboItemsPerPage.Name = "comboItemsPerPage";
            this.comboItemsPerPage.Size = new System.Drawing.Size(114, 28);
            this.comboItemsPerPage.TabIndex = 4;
            this.comboItemsPerPage.SelectedIndexChanged += new System.EventHandler(this.comboItemsPerPage_SelectedIndexChanged_1);
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(653, 359);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(15, 20);
            this.labelPages.TabIndex = 5;
            this.labelPages.Text = "-";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.radioBtnEdit);
            this.groupBoxOptions.Controls.Add(this.radioBtnAdd);
            this.groupBoxOptions.Location = new System.Drawing.Point(88, 373);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(253, 64);
            this.groupBoxOptions.TabIndex = 6;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // radioBtnEdit
            // 
            this.radioBtnEdit.AutoSize = true;
            this.radioBtnEdit.Location = new System.Drawing.Point(155, 27);
            this.radioBtnEdit.Name = "radioBtnEdit";
            this.radioBtnEdit.Size = new System.Drawing.Size(56, 24);
            this.radioBtnEdit.TabIndex = 1;
            this.radioBtnEdit.TabStop = true;
            this.radioBtnEdit.Text = "Edit";
            this.radioBtnEdit.UseVisualStyleBackColor = true;
            // 
            // radioBtnAdd
            // 
            this.radioBtnAdd.AutoSize = true;
            this.radioBtnAdd.Location = new System.Drawing.Point(35, 27);
            this.radioBtnAdd.Name = "radioBtnAdd";
            this.radioBtnAdd.Size = new System.Drawing.Size(58, 24);
            this.radioBtnAdd.TabIndex = 0;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "Add";
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            this.radioBtnAdd.CheckedChanged += new System.EventHandler(this.radioBtnAdd_CheckedChanged_1);
            // 
            // RestaurantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(985, 479);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.comboItemsPerPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.listBoxRestaurants);
            this.Controls.Add(this.groupBoxRestaurant);
            this.Name = "RestaurantsForm";
            this.Text = "RestaurantsForm";
            this.Load += new System.EventHandler(this.RestaurantsForm_Load_1);
            this.groupBoxRestaurant.ResumeLayout(false);
            this.groupBoxRestaurant.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
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
        private System.Windows.Forms.ListBox listBoxRestaurants;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox comboItemsPerPage;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.CheckBox checkBoxDeleteRestaurant;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.RadioButton radioBtnEdit;
        private System.Windows.Forms.RadioButton radioBtnAdd;
    }
}