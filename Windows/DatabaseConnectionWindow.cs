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
        
        private void dbConnectString_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void dbName_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox1.Text != "")
            {
                if (LoginService.TestMongoDBConnection(dbConnectString.Text))
                {
                    label2.Text = "Connection successful";
                    Environment.SetEnvironmentVariable("MONGO_DB_URI", dbConnectString.Text,
                        EnvironmentVariableTarget.User);
                    ServiceUtil.dbContext = DatabaseContext.GetInstance();
                    ServiceUtil.init();
                    ServiceUtil.LoginService.CreateUser(textBox2.Text, textBox3.Text, textBox1.Text);
                    //var loginWindow = new LoginWindow();
                    //loginWindow.Show();
                    Hide();

                    var MainMenuWindow = new MainMenuWindow();
                    MainMenuWindow.Show();

                }
                else
                {
                    label2.Text = "Failed to connect using connection string";
                }
            }
            else
            {
                label2.Text = "Please fill in all fields";
            }


        }

        private void DatabaseConnectionWindow_Load(object sender, EventArgs e)
        {
            
            //throw new System.NotImplementedException();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void connectStringLabel_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
    }
}