namespace Appitite_Manager_9
{
    partial class AuthenticateCollection
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
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.GotoHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Failed
            // 
            this.Failed.AutoSize = true;
            this.Failed.BackColor = System.Drawing.Color.Transparent;
            this.Failed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Failed.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Failed.ForeColor = System.Drawing.Color.Yellow;
            this.Failed.Location = new System.Drawing.Point(159, 330);
            this.Failed.Name = "Failed";
            this.Failed.Size = new System.Drawing.Size(0, 51);
            this.Failed.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(380, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Access Verification";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordBox.Location = new System.Drawing.Point(416, 198);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(250, 27);
            this.PasswordBox.TabIndex = 6;
            this.PasswordBox.Text = "Authentication Code";
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBox_Enter);
            this.PasswordBox.Leave += new System.EventHandler(this.PasswordBox_Leave);
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.Transparent;
            this.SignIn.FlatAppearance.BorderSize = 0;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Image = global::Appitite_Manager_9.Properties.Resources._lock;
            this.SignIn.Location = new System.Drawing.Point(681, 187);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(46, 51);
            this.SignIn.TabIndex = 8;
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // ChangePassword
            // 
            this.ChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.ChangePassword.FlatAppearance.BorderSize = 0;
            this.ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePassword.Image = global::Appitite_Manager_9.Properties.Resources.icons8_gears_24;
            this.ChangePassword.Location = new System.Drawing.Point(727, 12);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(57, 36);
            this.ChangePassword.TabIndex = 7;
            this.ChangePassword.UseVisualStyleBackColor = false;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
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
            this.GotoHome.Location = new System.Drawing.Point(262, 123);
            this.GotoHome.Name = "GotoHome";
            this.GotoHome.Size = new System.Drawing.Size(129, 135);
            this.GotoHome.TabIndex = 14;
            this.GotoHome.UseVisualStyleBackColor = false;
            this.GotoHome.Click += new System.EventHandler(this.GotoHome_Click);
            // 
            // Authenticate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Appitite_Manager_9.Properties.Resources.fries_1557592818692_7111;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 424);
            this.Controls.Add(this.GotoHome);
            this.Controls.Add(this.Failed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.ChangePassword);
            this.Controls.Add(this.PasswordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authenticate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authenticate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Failed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button GotoHome;
    }
}