using System;
using System.Windows.Forms;

namespace MEMS.Windows
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ServiceUtil.UserRoleService.matchUser(userNameBox.Text, passwordBox.Text) == null || userNameBox.Text =="" || passwordBox.Text == "")
            {
                createAccountLabel.Text = "no user with that username and password";
            }
            else
            {
                Program.currentUser = ServiceUtil.UserRoleService.matchUser(userNameBox.Text, passwordBox.Text);
                Hide();
                MainMenuWindow mainMenuWindow = new MainMenuWindow();
                mainMenuWindow.Show();
            }
            
        }

        private void createAccountLabel_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
    }
}