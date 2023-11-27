using System.ComponentModel;

namespace MEMS.Windows
{
    partial class CreateAccount
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
            this.backToLogin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backToLogin
            // 
            this.backToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.backToLogin.Location = new System.Drawing.Point(114, 153);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(173, 23);
            this.backToLogin.TabIndex = 0;
            this.backToLogin.Text = "Already have an account? Login.";
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Location = new System.Drawing.Point(42, 40);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(56, 23);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(42, 80);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 23);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "password:";
            // 
            // confirmLabel
            // 
            this.confirmLabel.Location = new System.Drawing.Point(3, 116);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(95, 23);
            this.confirmLabel.TabIndex = 7;
            this.confirmLabel.Text = "confirm password:";
            this.confirmLabel.Click += new System.EventHandler(this.confirmLabel_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // errorMessage
            // 
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(104, 11);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(56, 23);
            this.errorMessage.TabIndex = 8;
            this.errorMessage.Text = ":";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 227);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backToLogin);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label errorMessage;

        private System.Windows.Forms.Label backToLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.TextBox textBox3;

        #endregion
    }
}