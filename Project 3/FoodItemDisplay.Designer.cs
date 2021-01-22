namespace Appitite_Manager_9
{
    partial class FoodItemDisplay
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
            this.Display = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.FoodImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Display.Controls.Add(this.label1);
            this.Display.Controls.Add(this.button1);
            this.Display.Controls.Add(this.label6);
            this.Display.Controls.Add(this.name1);
            this.Display.Controls.Add(this.FoodImage);
            this.Display.Location = new System.Drawing.Point(0, 2);
            this.Display.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(356, 521);
            this.Display.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(80, 386);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Price";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(12, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Your Text Here";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.ForeColor = System.Drawing.Color.Yellow;
            this.name1.Location = new System.Drawing.Point(4, 34);
            this.name1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(249, 35);
            this.name1.TabIndex = 5;
            this.name1.Text = "Your Text Here";
            // 
            // FoodImage
            // 
            this.FoodImage.Location = new System.Drawing.Point(12, 86);
            this.FoodImage.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.FoodImage.Name = "FoodImage";
            this.FoodImage.Size = new System.Drawing.Size(316, 199);
            this.FoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodImage.TabIndex = 0;
            this.FoodImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(31, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "RS.";
            // 
            // FoodItemDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.Display);
            this.Name = "FoodItemDisplay";
            this.Size = new System.Drawing.Size(356, 521);
            this.Display.ResumeLayout(false);
            this.Display.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Display;
        public System.Windows.Forms.PictureBox FoodImage;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label label1;
    }
}
