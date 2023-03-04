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
            this.btnRestaurantForm = new System.Windows.Forms.Button();
            this.btnItemForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestaurantForm
            // 
            this.btnRestaurantForm.Location = new System.Drawing.Point(104, 67);
            this.btnRestaurantForm.Name = "btnRestaurantForm";
            this.btnRestaurantForm.Size = new System.Drawing.Size(94, 65);
            this.btnRestaurantForm.TabIndex = 0;
            this.btnRestaurantForm.Text = "Restaurants";
            this.btnRestaurantForm.UseVisualStyleBackColor = true;
            this.btnRestaurantForm.Click += new System.EventHandler(this.btnRestaurantForm_Click_1);
            // 
            // btnItemForm
            // 
            this.btnItemForm.Location = new System.Drawing.Point(240, 86);
            this.btnItemForm.Name = "btnItemForm";
            this.btnItemForm.Size = new System.Drawing.Size(94, 29);
            this.btnItemForm.TabIndex = 1;
            this.btnItemForm.Text = "Items";
            this.btnItemForm.UseVisualStyleBackColor = true;
            this.btnItemForm.Click += new System.EventHandler(this.btnItemForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnItemForm);
            this.Controls.Add(this.btnRestaurantForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestaurantForm;
        private System.Windows.Forms.Button btnItemForm;
    }
}