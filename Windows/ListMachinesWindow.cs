using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;

using System.Windows.Forms;
using MongoDB.Driver;

namespace MEMS
{
    public partial class ListMachinesWindow : Form
    { 
        private AddMachineWindow addMachineWindow;
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
            List<Machine> machineList = ServiceUtil.machineService.GetMachinesByPage(1);
            activeMachines.Items.Clear();
            foreach (var machine in machineList)
            {
                string[] machineArr =
                    { machine.name, machine.Id.ToString(), machine.model, machine.manufacturer, machine.zone };
                if (!machine.isActive) continue;
                var listMachine = new ListViewItem(machineArr);
                activeMachines.Items.Add(listMachine);
            }
        }

        private void NewMachineButton_Click(object sender, EventArgs e)
        {
            //Hide();
            var addMachineWindow = new AddMachineWindow();
            addMachineWindow.MachineAdded += LoadListView;
            addMachineWindow.Show();
        }
        private void PrintButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void activeMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        //FormClosing event unsubscribes from the MachineAdded event to prevent memory leak
        private void ListMachinesWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (addMachineWindow != null)
            {
                addMachineWindow.MachineAdded -= LoadListView;
                addMachineWindow.Close();
            }
        }
    }
}