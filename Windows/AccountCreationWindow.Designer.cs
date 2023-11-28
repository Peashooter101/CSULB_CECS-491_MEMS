using System.ComponentModel;

namespace MEMS.Windows
{
    partial class AccountCreationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountCreationWindow));
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.GhostWhite;
            this.email.Location = new System.Drawing.Point(201, 59);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(349, 23);
            this.email.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please provide the User\'s Login Information";
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(12, 59);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(182, 23);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(12, 104);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(182, 23);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.GhostWhite;
            this.password.Location = new System.Drawing.Point(201, 104);
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(349, 23);
            this.password.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(238, 226);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(87, 27);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Location = new System.Drawing.Point(12, 149);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(182, 23);
            this.confirmPasswordLabel.TabIndex = 7;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // confirmPassword
            // 
            this.confirmPassword.BackColor = System.Drawing.Color.GhostWhite;
            this.confirmPassword.Location = new System.Drawing.Point(201, 149);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '•';
            this.confirmPassword.Size = new System.Drawing.Size(349, 23);
            this.confirmPassword.TabIndex = 6;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 186);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(539, 27);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountCreationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(565, 267);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AccountCreationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[MEMS] Account Creation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label errorLabel;

        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox confirmPassword;

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button submitButton;

        private System.Windows.Forms.Label passwordLabel;

        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}