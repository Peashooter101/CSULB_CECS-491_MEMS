using System;
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
            Console.Out.WriteLine(this.dbConnectString.Text);
            Console.Out.WriteLine(this.dbName.Text);
            throw new System.NotImplementedException();
        }
        
    }
}