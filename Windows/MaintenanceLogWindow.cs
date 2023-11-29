using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MEMS.Model;

namespace MEMS.Windows
{

    
    public partial class MaintenanceLogWindow : Form
    {
        public MaintenanceLogWindow()
        {
            InitializeComponent();
            MachineList.SelectionMode = SelectionMode.None;

            List<Machine> machineList = ServiceUtil.machineService.GetAllMachines();
            
            MachineList.DataSource = machineList;
            MachineList.DisplayMember = "name";
            MachineList.SelectionMode = SelectionMode.One;

        }
        
        private void MachineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var m = (Machine)MachineList.SelectedItem;
            var c = (Contact)ServiceUtil.ContactService.GetContactByMachine(m.Id);
            var r = (MaintenanceEntry)ServiceUtil.MaintenanceReminderService.ReadByMachineID(m.Id);
            
            if (MachineList.SelectedItem == null) 
            { 
                return; 
            }

            lblInfo.Text = m.name + " Maintenance Log";
            MachineDetails.Items.Clear();

            MachineDetails.Items.Add("Machine Name: " + m.name);
            MachineDetails.Items.Add("Model: " + m.model);
            MachineDetails.Items.Add("Manufacturer: " + m.manufacturer);
            MachineDetails.Items.Add("Zone: " + m.zone);
            MachineDetails.Items.Add("\nProblem: " + r.description);
            MachineDetails.Items.Add("\nTechnician: " + c.name);
            MachineDetails.Items.Add("Phone Number: " + c.phoneNumber);
            
        }
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var m = (Machine)MachineList.SelectedItem;
            
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Maintenance Logs";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string time = System.DateTime.Now.ToString("yy-MMM-dd ddd");
            TextWriter txt = new StreamWriter(dir + "\\Log " + time + " for " + m.serial + ".txt");
            foreach (var item in MachineDetails.Items) 
            {
                txt.WriteLine(item.ToString());
            }
            txt.Close();
            string loc = "Log saved to ";
            MessageBox.Show(loc + dir);

        }
        // private void UpdateBtn_Click(object sender, EventArgs e)
        // {
        //     throw new System.NotImplementedException();
        // }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMaintenanceBtn_Click(object sender, EventArgs e)
        {
            NewMaintenanceWindow request = new NewMaintenanceWindow();
            request.ShowDialog();
            request = null;
            this.Show();
        }
        
        private void MaintenanceLogWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Parent = null;
            e.Cancel = true;
        }
    }
}