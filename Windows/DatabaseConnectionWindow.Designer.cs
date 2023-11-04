using System.ComponentModel;

namespace MEMS.Windows
{
    partial class DatabaseConnectionWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.dbConnectString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectStringLabel = new System.Windows.Forms.Label();
            this.dbNameLabel = new System.Windows.Forms.Label();
            this.dbName = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbConnectString
            // 
            this.dbConnectString.Location = new System.Drawing.Point(172, 51);
            this.dbConnectString.Name = "dbConnectString";
            this.dbConnectString.Size = new System.Drawing.Size(300, 20);
            this.dbConnectString.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please provide the following MongoDB Database Information";
            // 
            // connectStringLabel
            // 
            this.connectStringLabel.Location = new System.Drawing.Point(10, 51);
            this.connectStringLabel.Name = "connectStringLabel";
            this.connectStringLabel.Size = new System.Drawing.Size(156, 20);
            this.connectStringLabel.TabIndex = 2;
            this.connectStringLabel.Text = "Database Connection String";
            // 
            // dbNameLabel
            // 
            this.dbNameLabel.Location = new System.Drawing.Point(10, 90);
            this.dbNameLabel.Name = "dbNameLabel";
            this.dbNameLabel.Size = new System.Drawing.Size(156, 20);
            this.dbNameLabel.TabIndex = 4;
            this.dbNameLabel.Text = "Database Name";
            // 
            // dbName
            // 
            this.dbName.Location = new System.Drawing.Point(172, 90);
            this.dbName.Name = "dbName";
            this.dbName.Size = new System.Drawing.Size(300, 20);
            this.dbName.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(205, 139);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // DatabaseConnectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 186);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dbNameLabel);
            this.Controls.Add(this.dbName);
            this.Controls.Add(this.connectStringLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbConnectString);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DatabaseConnectionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[MEMS] Database Conection";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label connectStringLabel;
        private System.Windows.Forms.TextBox dbName;
        private System.Windows.Forms.Button submitButton;

        private System.Windows.Forms.Label dbNameLabel;

        private System.Windows.Forms.TextBox dbConnectString;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}