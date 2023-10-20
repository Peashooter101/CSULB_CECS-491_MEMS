using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MongoDB.Bson;

namespace MEMS.Windows
{
    public partial class MainMenuWindow : Form
    {
        public MainMenuWindow()
        {
            InitializeComponent();
        }

        private void accountInformationButton_Click(object sender, EventArgs e)
        {
            var accountInfo = new AccountCreationWindow();
            accountInfo.Show();
        }
        
        private void addMachineButton_Click(object sender, EventArgs e)
        {
            var addMachine = new AddMachineWindow();
            addMachine.Show();
        }
        
        private void changeLogButton_Click(object sender, EventArgs e)
        {
            //var changeLog = new ChangelogWindow();
            //changeLog.Show();
        }
        private void dbConnectInfoButton_Click(object sender, EventArgs e)
        {
            var dbConnection = ServiceUtil.dbContext.database.DatabaseNamespace;
            //need to create a popup window that will display text
            var displayDb = new TextPopUpWindow();
            displayDb.TextDisplay(dbConnection.ToString());
            displayDb.Show();
        }


        private void activeMachineButtons_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void maintenanceLogButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void maintenanceReminderButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void newMaintenanceRequestButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}