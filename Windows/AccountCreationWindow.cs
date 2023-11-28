using System;
using System.Windows.Forms;

namespace MEMS.Windows
{
    public partial class AccountCreationWindow : Form
    {
        public AccountCreationWindow()
        {
            InitializeComponent();
            username.Text = Program.currentUser.username;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AccountCreationWindow_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void username_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void AccountCreationWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Parent = null;
            e.Cancel = true;
        }
    }
}