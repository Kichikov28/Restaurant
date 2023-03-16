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
            groupBoxRestaurant = new System.Windows.Forms.GroupBox();
            checkBoxDeleteRestaurant = new System.Windows.Forms.CheckBox();
            btnClear = new System.Windows.Forms.Button();
            btnAddRestaurant = new System.Windows.Forms.Button();
            comboRating = new System.Windows.Forms.ComboBox();
            comboType = new System.Windows.Forms.ComboBox();
            comboBoxLocation = new System.Windows.Forms.ComboBox();
            textBoxName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            listBoxRestaurants = new System.Windows.Forms.ListBox();
            btnPrevious = new System.Windows.Forms.Button();
            btnNext = new System.Windows.Forms.Button();
            comboItemsPerPage = new System.Windows.Forms.ComboBox();
            labelPages = new System.Windows.Forms.Label();
            groupBoxOptions = new System.Windows.Forms.GroupBox();
            radioBtnEdit = new System.Windows.Forms.RadioButton();
            radioBtnAdd = new System.Windows.Forms.RadioButton();
            groupBoxRestaurant.SuspendLayout();
            groupBoxOptions.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRestaurant
            // 
            groupBoxRestaurant.Controls.Add(checkBoxDeleteRestaurant);
            groupBoxRestaurant.Controls.Add(btnClear);
            groupBoxRestaurant.Controls.Add(btnAddRestaurant);
            groupBoxRestaurant.Controls.Add(comboRating);
            groupBoxRestaurant.Controls.Add(comboType);
            groupBoxRestaurant.Controls.Add(comboBoxLocation);
            groupBoxRestaurant.Controls.Add(textBoxName);
            groupBoxRestaurant.Controls.Add(label4);
            groupBoxRestaurant.Controls.Add(label3);
            groupBoxRestaurant.Controls.Add(label2);
            groupBoxRestaurant.Controls.Add(label1);
            groupBoxRestaurant.Location = new System.Drawing.Point(63, 24);
            groupBoxRestaurant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxRestaurant.Name = "groupBoxRestaurant";
            groupBoxRestaurant.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxRestaurant.Size = new System.Drawing.Size(302, 243);
            groupBoxRestaurant.TabIndex = 0;
            groupBoxRestaurant.TabStop = false;
            groupBoxRestaurant.Text = "Create";
            groupBoxRestaurant.Enter += groupBoxRestaurant_Enter;
            // 
            // checkBoxDeleteRestaurant
            // 
            checkBoxDeleteRestaurant.AutoSize = true;
            checkBoxDeleteRestaurant.Location = new System.Drawing.Point(14, 160);
            checkBoxDeleteRestaurant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            checkBoxDeleteRestaurant.Name = "checkBoxDeleteRestaurant";
            checkBoxDeleteRestaurant.Size = new System.Drawing.Size(115, 19);
            checkBoxDeleteRestaurant.TabIndex = 10;
            checkBoxDeleteRestaurant.Text = "DeleteRestaurant";
            checkBoxDeleteRestaurant.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.FloralWhite;
            btnClear.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClear.Location = new System.Drawing.Point(165, 190);
            btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(101, 36);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddRestaurant
            // 
            btnAddRestaurant.BackColor = System.Drawing.Color.FloralWhite;
            btnAddRestaurant.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAddRestaurant.Location = new System.Drawing.Point(35, 190);
            btnAddRestaurant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAddRestaurant.Name = "btnAddRestaurant";
            btnAddRestaurant.Size = new System.Drawing.Size(94, 36);
            btnAddRestaurant.TabIndex = 8;
            btnAddRestaurant.Text = "Add";
            btnAddRestaurant.UseVisualStyleBackColor = false;
            btnAddRestaurant.Click += btnAddRestaurant_Click;
            // 
            // comboRating
            // 
            comboRating.FormattingEnabled = true;
            comboRating.Location = new System.Drawing.Point(83, 128);
            comboRating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            comboRating.Name = "comboRating";
            comboRating.Size = new System.Drawing.Size(183, 23);
            comboRating.TabIndex = 7;
            comboRating.SelectedIndexChanged += comboRating_SelectedIndexChanged;
            // 
            // comboType
            // 
            comboType.FormattingEnabled = true;
            comboType.Items.AddRange(new object[] { "Italian", "Japanese", "Bulgarian", "Chinese", "Greek" });
            comboType.Location = new System.Drawing.Point(83, 95);
            comboType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            comboType.Name = "comboType";
            comboType.Size = new System.Drawing.Size(183, 23);
            comboType.TabIndex = 6;
            // 
            // comboBoxLocation
            // 
            comboBoxLocation.FormattingEnabled = true;
            comboBoxLocation.Items.AddRange(new object[] { "Sofia", "Velingrad", "Plovdiv", "Blagoevgrad", "Varna", "Burgas" });
            comboBoxLocation.Location = new System.Drawing.Point(83, 64);
            comboBoxLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            comboBoxLocation.Name = "comboBoxLocation";
            comboBoxLocation.Size = new System.Drawing.Size(183, 23);
            comboBoxLocation.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(83, 32);
            textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(183, 23);
            textBoxName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(13, 134);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Rating";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(13, 95);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Location";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(13, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // listBoxRestaurants
            // 
            listBoxRestaurants.FormattingEnabled = true;
            listBoxRestaurants.ItemHeight = 15;
            listBoxRestaurants.Location = new System.Drawing.Point(447, 24);
            listBoxRestaurants.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            listBoxRestaurants.Name = "listBoxRestaurants";
            listBoxRestaurants.Size = new System.Drawing.Size(387, 244);
            listBoxRestaurants.TabIndex = 1;
            listBoxRestaurants.SelectedIndexChanged += listBoxRestaurants_SelectedIndexChanged;
            listBoxRestaurants.DoubleClick += listBoxRestaurants_DoubleClick;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = System.Drawing.Color.FloralWhite;
            btnPrevious.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPrevious.Location = new System.Drawing.Point(478, 288);
            btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new System.Drawing.Size(93, 40);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = System.Drawing.Color.FloralWhite;
            btnNext.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnNext.Location = new System.Drawing.Point(599, 288);
            btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(94, 40);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // comboItemsPerPage
            // 
            comboItemsPerPage.FormattingEnabled = true;
            comboItemsPerPage.Items.AddRange(new object[] { "5", "10", "15", "20" });
            comboItemsPerPage.Location = new System.Drawing.Point(715, 295);
            comboItemsPerPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            comboItemsPerPage.Name = "comboItemsPerPage";
            comboItemsPerPage.Size = new System.Drawing.Size(100, 23);
            comboItemsPerPage.TabIndex = 4;
            comboItemsPerPage.SelectedIndexChanged += comboItemsPerPage_SelectedIndexChanged;
            // 
            // labelPages
            // 
            labelPages.AutoSize = true;
            labelPages.Location = new System.Drawing.Point(571, 269);
            labelPages.Name = "labelPages";
            labelPages.Size = new System.Drawing.Size(12, 15);
            labelPages.TabIndex = 5;
            labelPages.Text = "-";
            // 
            // groupBoxOptions
            // 
            groupBoxOptions.Controls.Add(radioBtnEdit);
            groupBoxOptions.Controls.Add(radioBtnAdd);
            groupBoxOptions.Location = new System.Drawing.Point(77, 280);
            groupBoxOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxOptions.Name = "groupBoxOptions";
            groupBoxOptions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBoxOptions.Size = new System.Drawing.Size(221, 48);
            groupBoxOptions.TabIndex = 6;
            groupBoxOptions.TabStop = false;
            groupBoxOptions.Text = "Options";
            // 
            // radioBtnEdit
            // 
            radioBtnEdit.AutoSize = true;
            radioBtnEdit.Location = new System.Drawing.Point(136, 20);
            radioBtnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            radioBtnEdit.Name = "radioBtnEdit";
            radioBtnEdit.Size = new System.Drawing.Size(45, 19);
            radioBtnEdit.TabIndex = 1;
            radioBtnEdit.TabStop = true;
            radioBtnEdit.Text = "Edit";
            radioBtnEdit.UseVisualStyleBackColor = true;
            // 
            // radioBtnAdd
            // 
            radioBtnAdd.AutoSize = true;
            radioBtnAdd.Location = new System.Drawing.Point(31, 20);
            radioBtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            radioBtnAdd.Name = "radioBtnAdd";
            radioBtnAdd.Size = new System.Drawing.Size(47, 19);
            radioBtnAdd.TabIndex = 0;
            radioBtnAdd.TabStop = true;
            radioBtnAdd.Text = "Add";
            radioBtnAdd.UseVisualStyleBackColor = true;
            radioBtnAdd.CheckedChanged += radioBtnAdd_CheckedChanged;
            // 
            // RestaurantsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightSteelBlue;
            ClientSize = new System.Drawing.Size(862, 359);
            Controls.Add(groupBoxOptions);
            Controls.Add(labelPages);
            Controls.Add(comboItemsPerPage);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(listBoxRestaurants);
            Controls.Add(groupBoxRestaurant);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "RestaurantsForm";
            Text = "RestaurantsForm";
            Load += RestaurantsForm_Load;
            groupBoxRestaurant.ResumeLayout(false);
            groupBoxRestaurant.PerformLayout();
            groupBoxOptions.ResumeLayout(false);
            groupBoxOptions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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