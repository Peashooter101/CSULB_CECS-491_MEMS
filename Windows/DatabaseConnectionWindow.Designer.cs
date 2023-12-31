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
            this.submitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please provide the following MongoDB Database Information";
            // 
            // connectStringLabel
            // 
            this.connectStringLabel.Location = new System.Drawing.Point(12, 61);
            this.connectStringLabel.Name = "connectStringLabel";
            this.connectStringLabel.Size = new System.Drawing.Size(182, 23);
            this.connectStringLabel.TabIndex = 2;
            this.connectStringLabel.Text = "Database Connection String";
            this.connectStringLabel.Click += new System.EventHandler(this.connectStringLabel_Click);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(227, 264);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(84, 27);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(201, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Location = new System.Drawing.Point(201, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox2.Location = new System.Drawing.Point(201, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(349, 23);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox3.Location = new System.Drawing.Point(199, 189);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(349, 23);
            this.textBox3.TabIndex = 11;
            // 
            // DatabaseConnectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 318);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.connectStringLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbConnectString);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DatabaseConnectionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[MEMS] Database Conection";
            this.Load += new System.EventHandler(this.DatabaseConnectionWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label connectStringLabel;
        private System.Windows.Forms.Button submitButton;

        private System.Windows.Forms.TextBox dbConnectString;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}