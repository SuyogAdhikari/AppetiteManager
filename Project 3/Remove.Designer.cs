namespace Appitite_Manager_9
{
    partial class FoodName
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
            this.Confirmed = new System.Windows.Forms.Label();
            this.AddItem = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Confirmed
            // 
            this.Confirmed.AutoSize = true;
            this.Confirmed.BackColor = System.Drawing.Color.Transparent;
            this.Confirmed.Font = new System.Drawing.Font("Script MT Bold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmed.ForeColor = System.Drawing.Color.Yellow;
            this.Confirmed.Location = new System.Drawing.Point(977, 689);
            this.Confirmed.Name = "Confirmed";
            this.Confirmed.Size = new System.Drawing.Size(0, 58);
            this.Confirmed.TabIndex = 16;
            // 
            // AddItem
            // 
            this.AddItem.BackColor = System.Drawing.Color.Transparent;
            this.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItem.Font = new System.Drawing.Font("Snap ITC", 19.8F);
            this.AddItem.ForeColor = System.Drawing.Color.Yellow;
            this.AddItem.Location = new System.Drawing.Point(1044, 421);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(186, 55);
            this.AddItem.TabIndex = 15;
            this.AddItem.Text = "Remove";
            this.AddItem.UseVisualStyleBackColor = false;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.Color.Transparent;
            this.Name.Font = new System.Drawing.Font("Snap ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.Color.Yellow;
            this.Name.Location = new System.Drawing.Point(465, 417);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(154, 55);
            this.Name.TabIndex = 7;
            this.Name.Text = "Name";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(637, 435);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(391, 37);
            this.comboBox1.TabIndex = 23;
            // 
            // FoodName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Confirmed);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.Name);
            this.Size = new System.Drawing.Size(1920, 930);
            this.Load += new System.EventHandler(this.Remove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Confirmed;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
