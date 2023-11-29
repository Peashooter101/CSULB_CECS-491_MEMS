using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace MEMS.Windows
{
    
    public partial class ListMachinesWindow : Form
    { 
        private AddMachineWindow addMachineWindow = new AddMachineWindow();
        private ListMachinesWindow listMachinesWindow;
        private Bitmap memoryImage; 
        private List<Machine> machineList = ServiceUtil.machineService.GetMachinesByPage(1);
        public ListMachinesWindow()
        {
            InitializeComponent();
            
        }

        private void ListMachinesWindow_Load(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void LoadListView()
        { 
            machineList = ServiceUtil.machineService.GetMachinesByPage(1);
            activeMachines.Items.Clear();
            foreach (var machine in machineList)
            {
                string[] machineArr =
                    { machine.name, machine.Id.ToString(), machine.model, machine.manufacturer, machine.zone, machine.serial };
                if (!machine.isActive) continue;
                var listMachine = new ListViewItem(machineArr);
                activeMachines.Items.Add(listMachine);
            }
        }

        private void NewMachineButton_Click(object sender, EventArgs e)
        {
            //Hide();
            //var addMachineWindow = new AddMachineWindow();
            addMachineWindow.MachineAdded += LoadListView;
            addMachineWindow.Show();
        }
        
        private void activeMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }
        //FormClosing event unsubscribes from the MachineAdded event to prevent memory leak
        private void ListMachinesWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (addMachineWindow != null)
            {
                addMachineWindow.MachineAdded -= LoadListView;
                addMachineWindow.Close();
            }
            Hide();
            Parent = null;
            e.Cancel = true;
        }

        private void activeMachines_DoubleClick(object sender, EventArgs e)
        {
            string[] details =
            {
                activeMachines.FocusedItem.SubItems[0].Text,
                activeMachines.FocusedItem.SubItems[1].Text,
                activeMachines.FocusedItem.SubItems[2].Text,
                activeMachines.FocusedItem.SubItems[3].Text,
                activeMachines.FocusedItem.SubItems[4].Text,
                activeMachines.FocusedItem.SubItems[5].Text
            };
            
            List<string> zones = new List<string>();
            
            for (int i = 0; i < activeMachines.Items.Count; i++)
            {
                zones.Add(activeMachines.Items[i].SubItems[4].Text);
            }
            
            var detail = new DetailedMachineWindow(listMachinesWindow, details, zones);
            detail.ShowDialog();
            LoadListView();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}