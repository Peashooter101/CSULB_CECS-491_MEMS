using System;
using System.Windows.Forms;

namespace MEMS.Windows
{
    public partial class AccountCreationWindow : Form
    {
        public AccountCreationWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(password.Text.Trim()) || string.IsNullOrWhiteSpace(email.Text))
            {
                errorLabel.Text = @"Your email and password cannot be empty.";
                return;
            }
            // TODO: Regex Check for Email
            if (!password.Text.Equals(confirmPassword.Text))
            {
                errorLabel.Text = @"Those passwords do not match!";
                return;
            }
            // TODO: Send information to Control which determines if account is administrator and updates database.
            throw new System.NotImplementedException();
        }
    }
}