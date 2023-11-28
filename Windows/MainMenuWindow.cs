using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;
using MEMS.Model;

namespace MEMS.Windows
{
    public partial class MainMenuWindow : Form
    {
        MainMenuMaintenanceReminderWindow _loadMaintenanceList = new MainMenuMaintenanceReminderWindow();
        AccountCreationWindow _accountInfo = new AccountCreationWindow();
        AddMachineWindow _addMachine = new AddMachineWindow();
        ChangeLogWindow _changeLog = new ChangeLogWindow();
        TextPopUpWindow _dbPopUp = new TextPopUpWindow();
        ListMachinesWindow _listMachines = new ListMachinesWindow();
        MaintenanceLogWindow _maintenanceLog = new MaintenanceLogWindow();
        MaintenanceReminderWindow _maintenanceReminder = new MaintenanceReminderWindow();
        NewMaintenanceWindow _newMaintenance = new NewMaintenanceWindow();
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
            if (containerControl1.Controls.Contains(_loadMaintenanceList))
            {
                MessageBox.Show(@"Maintenance List Already Open.");
            }
            else
            {
                _loadMaintenanceList.TopLevel = false;
                containerControl1.Controls.Add(_loadMaintenanceList);
                _loadMaintenanceList.Dock = DockStyle.Fill;
                _loadMaintenanceList.Show();
            }
        }
        
        private void MDIAccountInformation_Click(object sender, EventArgs e)
        {
            
            if (containerControl1.Controls.Contains(_accountInfo))
            {
                MessageBox.Show(@"Account Information Window Already Open");
            }
            else
            {
                _accountInfo.MdiParent = this;
                containerControl1.Controls.Add(_accountInfo);
                _accountInfo.TopLevel = false;
                _accountInfo.FormBorderStyle = FormBorderStyle.Sizable;
                _accountInfo.Dock = DockStyle.Fill;
                _accountInfo.BringToFront();
                _accountInfo.Show();
            }
            
        }

        
        private void MDIAddMachineButton_Click(object sender, EventArgs e)
        {
            if (containerControl1.Controls.Contains(_addMachine))
            {
                MessageBox.Show(@"Add Machine Window Already Open");
            }
            else
            {
                _addMachine.MdiParent = this;
                _addMachine.TopLevel = false;
                containerControl1.Controls.Add(_addMachine);
                _addMachine.FormBorderStyle = FormBorderStyle.Sizable;
                _addMachine.Dock = DockStyle.Fill; 
                _addMachine.BringToFront();
                _addMachine.Show(); 
            }
        }
        
        private void MDIChangeLogButton_Click(object sender, EventArgs e)
        {
            if (containerControl1.Controls.Contains(_changeLog))
            {
                MessageBox.Show(@"Change Log Window Already Open");
            }
            else
            {
                _changeLog.MdiParent = this;
                _changeLog.TopLevel = false;
                containerControl1.Controls.Add(_changeLog);
                _changeLog.FormBorderStyle = FormBorderStyle.Sizable;
                _changeLog.Dock = DockStyle.Fill;
                _changeLog.BringToFront();
                _changeLog.Show();
            }
            
        }
        
        private void MDIDbConnectInfoButton_Click(object sender, EventArgs e)
        {
            if (containerControl1.Controls.Contains(_dbPopUp))
            {
                MessageBox.Show(@"Database Connection Window Already Open");
            }
            else
            {
                _dbPopUp.MdiParent = this;
                var dbConnection = ServiceUtil.dbContext.database.DatabaseNamespace;
                _dbPopUp.TextDisplay(@"Database Connection: " + dbConnection);
                _dbPopUp.TopLevel = false;
                containerControl1.Controls.Add(_dbPopUp);
                _dbPopUp.BringToFront();
                _dbPopUp.Show();
            }
        }


        private void MDIActiveMachineButtons_Click(object sender, EventArgs e)
        {
            if (containerControl1.Controls.Contains(_listMachines))
            {
                MessageBox.Show(@"Active Machines Window Already Open");
            }
            else
            {
                _listMachines.MdiParent = this;
                _listMachines.TopLevel = false;
                containerControl1.Controls.Add(_listMachines);
                _listMachines.FormBorderStyle = FormBorderStyle.Sizable;
                _listMachines.Dock = DockStyle.Fill;
                _listMachines.BringToFront();
                _listMachines.Show();
            }
            
        }

        private void MDIMaintenanceLogButton_Click(object sender, EventArgs e)
        {
            if (containerControl1.Controls.Contains(_maintenanceLog))
            {
                MessageBox.Show(@"Maintenance Log Window Already Open");
            }
            else
            {
                _maintenanceLog.MdiParent = this;
                _maintenanceLog.TopLevel = false;
                containerControl1.Controls.Add(_maintenanceLog);
                _maintenanceLog.FormBorderStyle = FormBorderStyle.Sizable;
                _maintenanceLog.Dock = DockStyle.Fill;
                _maintenanceLog.BringToFront();
                _maintenanceLog.Show();
            }
            
        }

        private void MDIMaintenanceReminderButton_Click(object sender, EventArgs e)
        {
            if (containerControl1.Controls.Contains(_maintenanceReminder))
            {
                MessageBox.Show(@"Maintenance Reminder Window Already Open");
            }
            else
            {
                _maintenanceReminder.MdiParent = this;
                _maintenanceReminder.TopLevel = false;
                containerControl1.Controls.Add(_maintenanceReminder);
                _maintenanceReminder.FormBorderStyle = FormBorderStyle.Sizable;
                _maintenanceReminder.Dock = DockStyle.Fill;
                _maintenanceReminder.BringToFront();
                _maintenanceReminder.Show();
            }
        }

        private void MDINewMaintenanceRequestButton_Click(object sender, EventArgs e)
        {
            if (containerControl1.Controls.Contains(_newMaintenance))
            {
                MessageBox.Show(@"New Maintenance Window Window Already Open");
            }
            else
            {
                _newMaintenance.MdiParent = this;
                _newMaintenance.TopLevel = false;
                containerControl1.Controls.Add(_newMaintenance);
                _newMaintenance.FormBorderStyle = FormBorderStyle.Sizable;
                _newMaintenance.Dock = DockStyle.Fill;
                _newMaintenance.BringToFront();
                _newMaintenance.Show();
            }
        }
        private Bitmap memoryImage;
        private void printContainer_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = containerControl1.CreateGraphics();
            Size size = containerControl1.Size;
            
            memoryImage = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(memoryImage);
            Point point = PointToScreen(containerControl1.Location);
            //Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            //memoryGraphics.CopyFromScreen(containerControl1.Location.X, containerControl1.Location.Y,0, 0, containerControl1.Size );
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, Size);
            printContainer.Print();
        }
    }
}