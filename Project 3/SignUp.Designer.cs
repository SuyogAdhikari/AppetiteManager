namespace Appitite_Manager_9
{
    partial class SignUp
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
            this.Address = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.RenewalDate = new System.Windows.Forms.Label();
            this.GenerateID = new System.Windows.Forms.Button();
            this.AutoGenCode = new System.Windows.Forms.Label();
            this.MemberName = new System.Windows.Forms.TextBox();
            this.MemberAddress = new System.Windows.Forms.TextBox();
            this.MemberPhone = new System.Windows.Forms.TextBox();
            this.SubsDate = new System.Windows.Forms.DateTimePicker();
            this.AddToDB = new System.Windows.Forms.Button();
            this.Confirmed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.Color.Yellow;
            this.Name.Location = new System.Drawing.Point(494, 197);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(206, 43);
            this.Name.TabIndex = 0;
            this.Name.Text = "Full Name";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.Yellow;
            this.Address.Location = new System.Drawing.Point(531, 278);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(169, 43);
            this.Address.TabIndex = 0;
            this.Address.Text = "Address";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.Color.Yellow;
            this.Phone.Location = new System.Drawing.Point(493, 359);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(207, 43);
            this.Phone.TabIndex = 0;
            this.Phone.Text = "Phone No.";
            // 
            // RenewalDate
            // 
            this.RenewalDate.AutoSize = true;
            this.RenewalDate.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenewalDate.ForeColor = System.Drawing.Color.Yellow;
            this.RenewalDate.Location = new System.Drawing.Point(415, 440);
            this.RenewalDate.Name = "RenewalDate";
            this.RenewalDate.Size = new System.Drawing.Size(285, 43);
            this.RenewalDate.TabIndex = 0;
            this.RenewalDate.Text = "Renewed Date";
            // 
            // GenerateID
            // 
            this.GenerateID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateID.Font = new System.Drawing.Font("Snap ITC", 19.8F);
            this.GenerateID.ForeColor = System.Drawing.Color.Yellow;
            this.GenerateID.Location = new System.Drawing.Point(393, 498);
            this.GenerateID.Name = "GenerateID";
            this.GenerateID.Size = new System.Drawing.Size(306, 61);
            this.GenerateID.TabIndex = 2;
            this.GenerateID.Text = "Generate";
            this.GenerateID.UseVisualStyleBackColor = true;
            this.GenerateID.Click += new System.EventHandler(this.button1_Click);
            // 
            // AutoGenCode
            // 
            this.AutoGenCode.AutoSize = true;
            this.AutoGenCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoGenCode.ForeColor = System.Drawing.Color.Yellow;
            this.AutoGenCode.Location = new System.Drawing.Point(742, 512);
            this.AutoGenCode.Name = "AutoGenCode";
            this.AutoGenCode.Size = new System.Drawing.Size(0, 32);
            this.AutoGenCode.TabIndex = 3;
            // 
            // MemberName
            // 
            this.MemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberName.Location = new System.Drawing.Point(734, 203);
            this.MemberName.Name = "MemberName";
            this.MemberName.Size = new System.Drawing.Size(343, 30);
            this.MemberName.TabIndex = 4;
            // 
            // MemberAddress
            // 
            this.MemberAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberAddress.Location = new System.Drawing.Point(734, 284);
            this.MemberAddress.Name = "MemberAddress";
            this.MemberAddress.Size = new System.Drawing.Size(343, 30);
            this.MemberAddress.TabIndex = 4;
            // 
            // MemberPhone
            // 
            this.MemberPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberPhone.Location = new System.Drawing.Point(734, 365);
            this.MemberPhone.Name = "MemberPhone";
            this.MemberPhone.Size = new System.Drawing.Size(343, 30);
            this.MemberPhone.TabIndex = 4;
            this.MemberPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // SubsDate
            // 
            this.SubsDate.CalendarForeColor = System.Drawing.Color.Transparent;
            this.SubsDate.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.SubsDate.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.SubsDate.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.SubsDate.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.SubsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SubsDate.Location = new System.Drawing.Point(734, 446);
            this.SubsDate.Name = "SubsDate";
            this.SubsDate.Size = new System.Drawing.Size(343, 30);
            this.SubsDate.TabIndex = 5;
            // 
            // AddToDB
            // 
            this.AddToDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToDB.Font = new System.Drawing.Font("Snap ITC", 19.8F);
            this.AddToDB.ForeColor = System.Drawing.Color.Yellow;
            this.AddToDB.Location = new System.Drawing.Point(559, 641);
            this.AddToDB.Name = "AddToDB";
            this.AddToDB.Size = new System.Drawing.Size(669, 61);
            this.AddToDB.TabIndex = 2;
            this.AddToDB.Text = "Confirm Membership";
            this.AddToDB.UseVisualStyleBackColor = true;
            this.AddToDB.Click += new System.EventHandler(this.AddToDB_Click);
            // 
            // Confirmed
            // 
            this.Confirmed.AutoSize = true;
            this.Confirmed.Font = new System.Drawing.Font("Snap ITC", 19.8F);
            this.Confirmed.ForeColor = System.Drawing.Color.Yellow;
            this.Confirmed.Location = new System.Drawing.Point(1201, 324);
            this.Confirmed.Name = "Confirmed";
            this.Confirmed.Size = new System.Drawing.Size(0, 43);
            this.Confirmed.TabIndex = 6;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.Confirmed);
            this.Controls.Add(this.SubsDate);
            this.Controls.Add(this.MemberPhone);
            this.Controls.Add(this.MemberAddress);
            this.Controls.Add(this.MemberName);
            this.Controls.Add(this.AutoGenCode);
            this.Controls.Add(this.AddToDB);
            this.Controls.Add(this.GenerateID);
            this.Controls.Add(this.RenewalDate);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Name);
            
            this.Size = new System.Drawing.Size(1643, 1080);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label RenewalDate;
        private System.Windows.Forms.Button GenerateID;
        private System.Windows.Forms.Label AutoGenCode;
        private System.Windows.Forms.TextBox MemberName;
        private System.Windows.Forms.TextBox MemberAddress;
        private System.Windows.Forms.TextBox MemberPhone;
        private System.Windows.Forms.DateTimePicker SubsDate;
        private System.Windows.Forms.Button AddToDB;
        private System.Windows.Forms.Label Confirmed;
    }
}
