﻿namespace Appitite_Manager_9
{
    partial class AppitizerEdit
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
            this.AppitizerDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AppitizerDisplay
            // 
            this.AppitizerDisplay.AutoScroll = true;
            this.AppitizerDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AppitizerDisplay.Location = new System.Drawing.Point(0, 179);
            this.AppitizerDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.AppitizerDisplay.Name = "AppitizerDisplay";
            this.AppitizerDisplay.Padding = new System.Windows.Forms.Padding(25);
            this.AppitizerDisplay.Size = new System.Drawing.Size(1770, 901);
            this.AppitizerDisplay.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(13, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(573, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(5, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 62);
            this.label3.TabIndex = 63;
            this.label3.Text = "Appitizer";
            // 
            // Search
            // 
            this.Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.DimGray;
            this.Search.Location = new System.Drawing.Point(621, 119);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(526, 31);
            this.Search.TabIndex = 68;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Image = global::Appitite_Manager_9.Properties.Resources.icons8_search_24;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(1153, 105);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(52, 49);
            this.SearchButton.TabIndex = 69;
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // AppitizerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.AppitizerDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "AppitizerEdit";
            this.Size = new System.Drawing.Size(1770, 1080);
            this.Load += new System.EventHandler(this.AppitizerEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox Search;
        public System.Windows.Forms.FlowLayoutPanel AppitizerDisplay;
    }
}
