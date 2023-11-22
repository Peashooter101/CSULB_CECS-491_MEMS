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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseConnectionWindow));
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
            this.dbConnectString.BackColor = System.Drawing.Color.GhostWhite;
            this.dbConnectString.Location = new System.Drawing.Point(201, 59);
            this.dbConnectString.Name = "dbConnectString";
            this.dbConnectString.Size = new System.Drawing.Size(349, 23);
            this.dbConnectString.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please provide the following MongoDB Database Information";
            // 
            // connectStringLabel
            // 
            this.connectStringLabel.Location = new System.Drawing.Point(12, 59);
            this.connectStringLabel.Name = "connectStringLabel";
            this.connectStringLabel.Size = new System.Drawing.Size(182, 23);
            this.connectStringLabel.TabIndex = 2;
            this.connectStringLabel.Text = "Database Connection String";
            // 
            // dbNameLabel
            // 
            this.dbNameLabel.Location = new System.Drawing.Point(12, 104);
            this.dbNameLabel.Name = "dbNameLabel";
            this.dbNameLabel.Size = new System.Drawing.Size(182, 23);
            this.dbNameLabel.TabIndex = 4;
            this.dbNameLabel.Text = "Database Name";
            // 
            // dbName
            // 
            this.dbName.BackColor = System.Drawing.Color.GhostWhite;
            this.dbName.Location = new System.Drawing.Point(201, 104);
            this.dbName.Name = "dbName";
            this.dbName.Size = new System.Drawing.Size(349, 23);
            this.dbName.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(239, 160);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(87, 27);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // DatabaseConnectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(565, 215);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dbNameLabel);
            this.Controls.Add(this.dbName);
            this.Controls.Add(this.connectStringLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbConnectString);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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