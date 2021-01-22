namespace Appitite_Manager_9
{
    partial class Add
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.FoodName = new System.Windows.Forms.TextBox();
            this.FoodPrice = new System.Windows.Forms.TextBox();
            this.FoodDescription = new System.Windows.Forms.TextBox();
            this.BrowseImage = new System.Windows.Forms.Button();
            this.FoodImage = new System.Windows.Forms.PictureBox();
            this.AddItem = new System.Windows.Forms.Button();
            this.Confirmed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FoodImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.Color.Transparent;
            this.Name.Font = new System.Drawing.Font("Snap ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.Color.Yellow;
            this.Name.Location = new System.Drawing.Point(822, 322);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(154, 55);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.Font = new System.Drawing.Font("Snap ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.Yellow;
            this.Price.Location = new System.Drawing.Point(821, 404);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(155, 55);
            this.Price.TabIndex = 1;
            this.Price.Text = "Price";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.BackColor = System.Drawing.Color.Transparent;
            this.Description.Font = new System.Drawing.Font("Snap ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.Color.Yellow;
            this.Description.Location = new System.Drawing.Point(672, 479);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(304, 55);
            this.Description.TabIndex = 1;
            this.Description.Text = "Description";
            // 
            // FoodName
            // 
            this.FoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodName.Location = new System.Drawing.Point(1033, 337);
            this.FoodName.Name = "FoodName";
            this.FoodName.Size = new System.Drawing.Size(296, 38);
            this.FoodName.TabIndex = 2;
            // 
            // FoodPrice
            // 
            this.FoodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodPrice.Location = new System.Drawing.Point(1033, 421);
            this.FoodPrice.Name = "FoodPrice";
            this.FoodPrice.Size = new System.Drawing.Size(296, 38);
            this.FoodPrice.TabIndex = 2;
            // 
            // FoodDescription
            // 
            this.FoodDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodDescription.Location = new System.Drawing.Point(1033, 496);
            this.FoodDescription.Name = "FoodDescription";
            this.FoodDescription.Size = new System.Drawing.Size(296, 38);
            this.FoodDescription.TabIndex = 2;
            // 
            // BrowseImage
            // 
            this.BrowseImage.BackColor = System.Drawing.Color.Transparent;
            this.BrowseImage.FlatAppearance.BorderSize = 0;
            this.BrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseImage.Image = global::Appitite_Manager_9.Properties.Resources.yello2;
            this.BrowseImage.Location = new System.Drawing.Point(831, 124);
            this.BrowseImage.Name = "BrowseImage";
            this.BrowseImage.Size = new System.Drawing.Size(112, 113);
            this.BrowseImage.TabIndex = 3;
            this.BrowseImage.UseVisualStyleBackColor = false;
            this.BrowseImage.Click += new System.EventHandler(this.BrowseImage_Click);
            // 
            // FoodImage
            // 
            this.FoodImage.BackColor = System.Drawing.Color.Yellow;
            this.FoodImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FoodImage.Location = new System.Drawing.Point(979, 78);
            this.FoodImage.Name = "FoodImage";
            this.FoodImage.Size = new System.Drawing.Size(400, 211);
            this.FoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodImage.TabIndex = 4;
            this.FoodImage.TabStop = false;
            // 
            // AddItem
            // 
            this.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItem.Font = new System.Drawing.Font("Snap ITC", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem.ForeColor = System.Drawing.Color.Yellow;
            this.AddItem.Location = new System.Drawing.Point(1033, 643);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(296, 53);
            this.AddItem.TabIndex = 5;
            this.AddItem.Text = "Add";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // Confirmed
            // 
            this.Confirmed.AutoSize = true;
            this.Confirmed.BackColor = System.Drawing.Color.Transparent;
            this.Confirmed.Font = new System.Drawing.Font("Script MT Bold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmed.ForeColor = System.Drawing.Color.Yellow;
            this.Confirmed.Location = new System.Drawing.Point(852, 719);
            this.Confirmed.Name = "Confirmed";
            this.Confirmed.Size = new System.Drawing.Size(0, 58);
            this.Confirmed.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(837, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Appetizer",
            "Soup",
            "Salad",
            "Desert"});
            this.comboBox1.Location = new System.Drawing.Point(1033, 603);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 24);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Text = "Select Item";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Confirmed);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.FoodImage);
            this.Controls.Add(this.BrowseImage);
            this.Controls.Add(this.FoodDescription);
            this.Controls.Add(this.FoodPrice);
            this.Controls.Add(this.FoodName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Name);
            this.Size = new System.Drawing.Size(1640, 1080);
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FoodImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox FoodName;
        private System.Windows.Forms.TextBox FoodPrice;
        private System.Windows.Forms.TextBox FoodDescription;
        private System.Windows.Forms.Button BrowseImage;
        private System.Windows.Forms.PictureBox FoodImage;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Label Confirmed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
