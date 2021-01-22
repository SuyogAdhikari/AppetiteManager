namespace Appitite_Manager_9
{
    partial class BillingSystem1
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
            this.label1 = new System.Windows.Forms.Label();
            this.updatedata = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.GotoHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updatedata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(235, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appitite Manager";
            // 
            // updatedata
            // 
            this.updatedata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.updatedata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updatedata.Location = new System.Drawing.Point(158, 112);
            this.updatedata.Name = "updatedata";
            this.updatedata.RowTemplate.Height = 24;
            this.updatedata.Size = new System.Drawing.Size(796, 310);
            this.updatedata.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(693, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GotoHome
            // 
            this.GotoHome.BackColor = System.Drawing.Color.Transparent;
            this.GotoHome.BackgroundImage = global::Appitite_Manager_9.Properties.Resources._2d096faf383b2bc554dc6ec2c292a6a91;
            this.GotoHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GotoHome.FlatAppearance.BorderSize = 0;
            this.GotoHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GotoHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GotoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GotoHome.Location = new System.Drawing.Point(12, 57);
            this.GotoHome.Name = "GotoHome";
            this.GotoHome.Size = new System.Drawing.Size(129, 135);
            this.GotoHome.TabIndex = 21;
            this.GotoHome.UseVisualStyleBackColor = false;
            // 
            // BillingSystem1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 588);
            this.Controls.Add(this.GotoHome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updatedata);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillingSystem1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillingSystem";
            ((System.ComponentModel.ISupportInitialize)(this.updatedata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView updatedata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GotoHome;
    }
}