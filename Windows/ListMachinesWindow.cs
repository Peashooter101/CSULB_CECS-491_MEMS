using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MEMS.Windows
{
    public partial class ListMachinesWindow : Form
    { 
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
            Hide();
            var addMachine = new AddMachineWindow();
            addMachine.Show();
        }
        private void PrintButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void activeMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}