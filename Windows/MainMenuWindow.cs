using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MEMS.Model;

namespace MEMS.Windows
{
    public partial class MainMenuWindow : Form
    {
        
        public MainMenuWindow()
        {
            InitializeComponent();
            IsMdiContainer = true;
            
            
        }
        
        private void accountInformationButton_Click(object sender, EventArgs e)
        {
            var accountInfo = new AccountCreationWindow();
            accountInfo.Show();
            
        }

        private void MaintenanceAlert_Load(object sender, EventArgs e)
        {
            MaintenanceAlert();
        }

        private void MaintenanceAlert()
        {
            //read from the data base any active machine requests 
            //List<MaintenanceEntry> maintenanceEntries = ServiceUtil.maintenanceService.
        }
        private void addMachineButton_Click(object sender, EventArgs e)
        {
            var addMachine = new AddMachineWindow();
            addMachine.Show();
        }
        
        private void changeLogButton_Click(object sender, EventArgs e)
        {
            var changeLog = new ChangeLogWindow();
            changeLog.Show();
        }
        private void dbConnectInfoButton_Click(object sender, EventArgs e)
        {
            var dbConnection = ServiceUtil.dbContext.database.DatabaseNamespace;
            //need to create a popup window that will display text
            //var displayDb = new TextPopUpWindow();
            MessageBox.Show(dbConnection.ToString());
            //displayDb.TextDisplay(dbConnection.ToString());
            //displayDb.Show();
        }


        private void activeMachineButtons_Click(object sender, EventArgs e)
        {
            var listMachines = new ListMachinesWindow();
            listMachines.Show();
        }

        private void maintenanceLogButton_Click(object sender, EventArgs e)
        {
            var maintenanceLog = new MaintenanceLogWindow();
            maintenanceLog.Show();
        }

        private void maintenanceReminderButton_Click(object sender, EventArgs e)
        {
            var maintenanceReminder = new MaintenanceReminderWindow();
            maintenanceReminder.Show();
        }

        private void newMaintenanceRequestButton_Click(object sender, EventArgs e)
        {
            var newMaintenance = new NewMaintenanceWindow();
            newMaintenance.Show();
        }

        
    }
}