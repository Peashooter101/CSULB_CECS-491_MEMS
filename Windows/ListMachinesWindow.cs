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
        //test objects to display in window 
        //note: MaintenanceRequests will need a Machine reference
        /*Machine machine1 = new Machine()
        {
            name = "Kintera Two-Section Reach-In Freezer 54\"",
            manufacturer = "Kintera",
            model = "KBM2F",
            zone = "3",
            isActive = true
        };
        Machine machine2 = new Machine()
        {
            name = "Traulsen Dealer's Choice Glass Door Reach-In Refrigerator",
            manufacturer = "Traulsen",
            model = "G11011",
            zone = "2",
            isActive = true
        };
        Machine machine3 = new Machine()
        {
            name = "Arctic Air Reach-In Refrigerator, Solid Door, 1 Section",
            manufacturer = "Arctic",
            model = "AR23",
            zone = "1",
            isActive= false
        };*/
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

            //we will have to take this data from the db, returning a list of machines to the program 
            //from there we can use this functionality to list the machines 
            //var dbInstance = DatabaseContext.GetInstance();
            //var databaseMachines = dbInstance.Machines;
            //var filter = Builders<Machine>.Filter.Eq("isActive", "true");
            //var dbMachines = databaseMachines.Find(filter).ToList();
            List<Machine> MachineList = ServiceUtil.machineService.GetMachineByPage(1);
            
            //Machine[] machines = { machine1, machine2, machine3 };
            foreach (var machine in MachineList)
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
            this.Hide();
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