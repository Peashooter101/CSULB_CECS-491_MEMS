using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MEMS.Windows
{
    public partial class DatabaseConnectionWindow : Form
    {
        public DatabaseConnectionWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (LoginService.TestMongoDBConnection(dbConnectString.Text))
            {
                label2.Text = "Connection successfull";
                LoginService.SetConnectionString(dbConnectString.Text);
                var MainMenuWindow = new MainMenuWindow();
                MainMenuWindow.Show();

            }
            else
            {
                label2.Text = "Failed to connect using connection string";
            }
        }

        private void dbConnectString_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void dbName_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        
    }
}