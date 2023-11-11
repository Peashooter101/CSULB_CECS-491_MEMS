using System;
using System.Collections.Generic;
using System.Globalization;
using System.Media;
using System.Timers;
using System.Windows.Forms;
using MEMS.Model;

namespace MEMS.Windows
{
    public partial class MainMenuMaintenanceReminderWindow : Form
    {
        public MainMenuMaintenanceReminderWindow()
        {
            InitializeComponent();
        }

        private void MainMenuMaintenanceReminder_Load(object sender, EventArgs e)
        {
            MaintenanceAlert();
        }
        private void MaintenanceAlert()
        {
            
            //read from the data base any active machine requests 
            List<MaintenanceEntry> maintenanceEntries =
                ServiceUtil.MaintenanceReminderService.ReadAllBySeverity(Severity.Urgent);
            foreach (var mEntry in maintenanceEntries)
            {
                string[] maintenanceEntriesArr =
                {
                    mEntry.Id.ToString().Substring(19),
                    mEntry.severity.ToString(),
                    mEntry.maintenanceTime.ToString(CultureInfo.CurrentCulture),
                    mEntry.userId.ToString().Substring(19),
                    mEntry.machineId.ToString().Substring(19),
                    mEntry.type.ToString(),
                    mEntry.description
                };
                var maintenanceEntry = new ListViewItem(maintenanceEntriesArr);
                maintenanceEntriesList.Items.Add(maintenanceEntry);
            }
            DisplayMessageBox();
        }

        private void DisplayMessageBox()
        {
            MessageBox.Show(@"Attention: Outstanding Urgent Maintenance Requests.", @"Maintenance Needed",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
    }
}