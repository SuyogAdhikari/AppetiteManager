namespace Appitite_Manager_9
{
    partial class NewPassword
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
            this.SignIn = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UpdateInfo = new System.Windows.Forms.Label();
            this.GotoHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(482, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add New Password";
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.Transparent;
            this.SignIn.FlatAppearance.BorderSize = 0;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Image = global::Appitite_Manager_9.Properties.Resources._lock;
            this.SignIn.Location = new System.Drawing.Point(733, 165);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(46, 51);
            this.SignIn.TabIndex = 14;
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordBox.Location = new System.Drawing.Point(477, 176);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(250, 27);
            this.PasswordBox.TabIndex = 13;
            this.PasswordBox.Text = "New Password";
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBox_Enter);
            this.PasswordBox.Leave += new System.EventHandler(this.PasswordBox_Leave);
            // 
            // UpdateInfo
            // 
            this.UpdateInfo.AutoSize = true;
            this.UpdateInfo.BackColor = System.Drawing.Color.Transparent;
            this.UpdateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateInfo.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateInfo.ForeColor = System.Drawing.Color.Yellow;
            this.UpdateInfo.Location = new System.Drawing.Point(442, 238);
            this.UpdateInfo.Name = "UpdateInfo";
            this.UpdateInfo.Size = new System.Drawing.Size(0, 51);
            this.UpdateInfo.TabIndex = 15;
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
            this.GotoHome.Location = new System.Drawing.Point(342, 100);
            this.GotoHome.Name = "GotoHome";
            this.GotoHome.Size = new System.Drawing.Size(129, 135);
            this.GotoHome.TabIndex = 16;
            this.GotoHome.UseVisualStyleBackColor = false;
            this.GotoHome.Click += new System.EventHandler(this.GotoHome_Click);
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Appitite_Manager_9.Properties.Resources.fries_1557592818692_7113;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 424);
            this.Controls.Add(this.GotoHome);
            this.Controls.Add(this.UpdateInfo);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label UpdateInfo;
        private System.Windows.Forms.Button GotoHome;
    }
}