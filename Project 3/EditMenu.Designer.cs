namespace Appitite_Manager_9
{
    partial class EditMenu
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
            this.Failed = new System.Windows.Forms.Label();
            this.AddItem = new System.Windows.Forms.Button();
            this.EditMenus = new System.Windows.Forms.Button();
            this.EditSpecial = new System.Windows.Forms.Button();
            this.ItemDefPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.GotoHome = new System.Windows.Forms.Button();
            this.ItemDefPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Failed
            // 
            this.Failed.AutoSize = true;
            this.Failed.BackColor = System.Drawing.Color.Transparent;
            this.Failed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Failed.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Failed.ForeColor = System.Drawing.Color.Yellow;
            this.Failed.Location = new System.Drawing.Point(88, 359);
            this.Failed.Name = "Failed";
            this.Failed.Size = new System.Drawing.Size(0, 51);
            this.Failed.TabIndex = 19;
            // 
            // AddItem
            // 
            this.AddItem.BackColor = System.Drawing.Color.Transparent;
            this.AddItem.FlatAppearance.BorderSize = 4;
            this.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItem.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem.ForeColor = System.Drawing.Color.Yellow;
            this.AddItem.Location = new System.Drawing.Point(3, 239);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(211, 112);
            this.AddItem.TabIndex = 23;
            this.AddItem.Text = "Add/\r\nRemove Item";
            this.AddItem.UseVisualStyleBackColor = false;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // EditMenus
            // 
            this.EditMenus.FlatAppearance.BorderSize = 4;
            this.EditMenus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditMenus.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMenus.ForeColor = System.Drawing.Color.Yellow;
            this.EditMenus.Location = new System.Drawing.Point(3, 121);
            this.EditMenus.Name = "EditMenus";
            this.EditMenus.Size = new System.Drawing.Size(211, 112);
            this.EditMenus.TabIndex = 22;
            this.EditMenus.Text = "Edit Menus";
            this.EditMenus.UseVisualStyleBackColor = true;
            this.EditMenus.Click += new System.EventHandler(this.EditMenus_Click);
            // 
            // EditSpecial
            // 
            this.EditSpecial.FlatAppearance.BorderSize = 4;
            this.EditSpecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSpecial.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSpecial.ForeColor = System.Drawing.Color.Yellow;
            this.EditSpecial.Location = new System.Drawing.Point(3, 3);
            this.EditSpecial.Name = "EditSpecial";
            this.EditSpecial.Size = new System.Drawing.Size(211, 112);
            this.EditSpecial.TabIndex = 21;
            this.EditSpecial.Text = "Edit Special Item";
            this.EditSpecial.UseVisualStyleBackColor = true;
            this.EditSpecial.Click += new System.EventHandler(this.EditSpecial_Click);
            // 
            // ItemDefPanel
            // 
            this.ItemDefPanel.BackColor = System.Drawing.Color.Transparent;
            this.ItemDefPanel.Controls.Add(this.EditSpecial);
            this.ItemDefPanel.Controls.Add(this.EditMenus);
            this.ItemDefPanel.Controls.Add(this.AddItem);
            this.ItemDefPanel.Location = new System.Drawing.Point(722, 46);
            this.ItemDefPanel.Name = "ItemDefPanel";
            this.ItemDefPanel.Size = new System.Drawing.Size(219, 357);
            this.ItemDefPanel.TabIndex = 24;
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
            this.GotoHome.Location = new System.Drawing.Point(519, 158);
            this.GotoHome.Name = "GotoHome";
            this.GotoHome.Size = new System.Drawing.Size(129, 135);
            this.GotoHome.TabIndex = 20;
            this.GotoHome.UseVisualStyleBackColor = false;
            this.GotoHome.Click += new System.EventHandler(this.GotoHome_Click);
            // 
            // EditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BackgroundImage = global::Appitite_Manager_9.Properties.Resources.fries_1557592818692_7117;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 445);
            this.Controls.Add(this.ItemDefPanel);
            this.Controls.Add(this.GotoHome);
            this.Controls.Add(this.Failed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMenu";
            this.ItemDefPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GotoHome;
        private System.Windows.Forms.Label Failed;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button EditMenus;
        private System.Windows.Forms.Button EditSpecial;
        private System.Windows.Forms.FlowLayoutPanel ItemDefPanel;
    }
}