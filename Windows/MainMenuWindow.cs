using System;
using System.Windows.Forms;

namespace MEMS.Windows
{
    public partial class MainMenuWindow : Form
    {
        private bool _activeWin;
        
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