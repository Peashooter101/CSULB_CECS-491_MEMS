using System;
using System.Collections.Generic;
using System.Globalization;
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
        private void MainMenu_Load(object sender, EventArgs e)
        {
            MainMenuMaintenanceReminderPopUp();
        }

        private void MainMenuMaintenanceReminderPopUp()
        {
            MainMenuMaintenanceReminderWindow loadMaintenanceList = new MainMenuMaintenanceReminderWindow();
            loadMaintenanceList.TopLevel = false;
            containerControl1.Controls.Add(loadMaintenanceList);
            loadMaintenanceList.Show();
        }
        
        private void MDIAccountInformation_Click(object sender, EventArgs e)
        {
            AccountCreationWindow accountInfo = new AccountCreationWindow();
            accountInfo.TopLevel = false;
            containerControl1.Controls.Add(accountInfo);
            accountInfo.FormBorderStyle = FormBorderStyle.Sizable;
            accountInfo.Dock = DockStyle.Fill;
            accountInfo.Show();
        }

        
        private void MDIAddMachineButton_Click(object sender, EventArgs e)
        {
            AddMachineWindow addMachine = new AddMachineWindow();
            addMachine.TopLevel = false;
            containerControl1.Controls.Add(addMachine);
            addMachine.FormBorderStyle = FormBorderStyle.Sizable;
            addMachine.Dock = DockStyle.Fill; 
            addMachine.Show(); 
        }
        
        private void MDIChangeLogButton_Click(object sender, EventArgs e)
        {
            var changeLog = new ChangeLogWindow();
            changeLog.TopLevel = false;
            containerControl1.Controls.Add(changeLog);
            changeLog.FormBorderStyle = FormBorderStyle.Sizable;
            changeLog.Dock = DockStyle.Fill;
            changeLog.Show();
        }
        private void MDIDbConnectInfoButton_Click(object sender, EventArgs e)
        {
            TextPopUpWindow dbPopUp = new TextPopUpWindow();
            var dbConnection = ServiceUtil.dbContext.database.DatabaseNamespace;
            dbPopUp.TextDisplay(@"Database Connection: " + dbConnection);
            dbPopUp.TopLevel = false;
            containerControl1.Controls.Add(dbPopUp);
            dbPopUp.Show();
        }


        private void MDIActiveMachineButtons_Click(object sender, EventArgs e)
        {
            var listMachines = new ListMachinesWindow();
            listMachines.TopLevel = false;
            containerControl1.Controls.Add(listMachines);
            listMachines.FormBorderStyle = FormBorderStyle.Sizable;
            listMachines.Dock = DockStyle.Fill;
            listMachines.Show();
        }

        private void MDIMaintenanceLogButton_Click(object sender, EventArgs e)
        {
            var maintenanceLog = new MaintenanceLogWindow();
            maintenanceLog.TopLevel = false;
            containerControl1.Controls.Add(maintenanceLog);
            maintenanceLog.FormBorderStyle = FormBorderStyle.Sizable;
            maintenanceLog.Dock = DockStyle.Fill;
            maintenanceLog.Show();
        }

        private void MDIMaintenanceReminderButton_Click(object sender, EventArgs e)
        {
            var maintenanceReminder = new MaintenanceReminderWindow();
            maintenanceReminder.TopLevel = false;
            containerControl1.Controls.Add(maintenanceReminder);
            maintenanceReminder.FormBorderStyle = FormBorderStyle.Sizable;
            maintenanceReminder.Dock = DockStyle.Fill;
            maintenanceReminder.Show();
        }

        private void MDINewMaintenanceRequestButton_Click(object sender, EventArgs e)
        {
            var newMaintenance = new NewMaintenanceWindow();
            newMaintenance.TopLevel = false;
            containerControl1.Controls.Add(newMaintenance);
            newMaintenance.FormBorderStyle = FormBorderStyle.Sizable;
            newMaintenance.Dock = DockStyle.Fill;
            newMaintenance.Show();
        }
    }
}