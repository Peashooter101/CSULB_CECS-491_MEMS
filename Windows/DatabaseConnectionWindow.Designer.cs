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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dbConnectString
            // 
            this.dbConnectString.Location = new System.Drawing.Point(258, 78);
            this.dbConnectString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbConnectString.Name = "dbConnectString";
            this.dbConnectString.Size = new System.Drawing.Size(448, 26);
            this.dbConnectString.TabIndex = 0;
            this.dbConnectString.TextChanged += new System.EventHandler(this.dbConnectString_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please provide the following MongoDB Database Information";
            // 
            // connectStringLabel
            // 
            this.connectStringLabel.Location = new System.Drawing.Point(15, 78);
            this.connectStringLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectStringLabel.Name = "connectStringLabel";
            this.connectStringLabel.Size = new System.Drawing.Size(234, 31);
            this.connectStringLabel.TabIndex = 2;
            this.connectStringLabel.Text = "Database Connection String";
            // 
            // dbNameLabel
            // 
            this.dbNameLabel.Location = new System.Drawing.Point(15, 138);
            this.dbNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dbNameLabel.Name = "dbNameLabel";
            this.dbNameLabel.Size = new System.Drawing.Size(234, 31);
            this.dbNameLabel.TabIndex = 4;
            this.dbNameLabel.Text = "Database Name";
            // 
            // dbName
            // 
            this.dbName.Location = new System.Drawing.Point(258, 138);
            this.dbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbName.Name = "dbName";
            this.dbName.Size = new System.Drawing.Size(448, 26);
            this.dbName.TabIndex = 3;
            this.dbName.TextChanged += new System.EventHandler(this.dbName_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(308, 214);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(112, 35);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(273, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 23);
            this.label2.TabIndex = 6;
            // 
            // DatabaseConnectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dbNameLabel);
            this.Controls.Add(this.dbName);
            this.Controls.Add(this.connectStringLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbConnectString);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DatabaseConnectionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[MEMS] Database Conection";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label connectStringLabel;
        private System.Windows.Forms.TextBox dbName;
        private System.Windows.Forms.Button submitButton;

        private System.Windows.Forms.Label dbNameLabel;

        private System.Windows.Forms.TextBox dbConnectString;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}