using System;
using System.Windows.Forms;

namespace MEMS
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
            //test objects to display in window 
            //note: MaintenanceRequests will need a Machine reference
            Machine machine1 = new Machine()
            {
                Name = "Kintera Two-Section Reach-In Freezer 54\"",
                Manufacturer = "Kintera",
                Model = "KBM2F",
                UniqueId = "1",
                Zone = 3,
                IsActive = true
            };
            Machine machine2 = new Machine()
            {
                Name = "Traulsen Dealer's Choice Glass Door Reach-In Refrigerator",
                Manufacturer = "Traulsen",
                Model = "G11011",
                UniqueId = "2",
                Zone = 2,
                IsActive = true
            };
            Machine machine3 = new Machine()
            {
                Name = "Arctic Air Reach-In Refrigerator, Solid Door, 1 Section",
                Manufacturer = "Arctic",
                Model = "AR23",
                UniqueId = "3",
                Zone = 1,
                IsActive = false
            };
            //we will have to take this data from the db, returning a list of machines to the program 
            //from there we can use this functionality to list the machines 
            Machine[] Machines = { machine1, machine2, machine3 };
            foreach (var machine in Machines)
            {
                var name = machine.Name;
                var uid = machine.UniqueId;
                var model = machine.Model;
                var manufacturer = machine.Manufacturer;
                var zone = machine.Zone;
                var active = machine.IsActive;
                string[] machineArr = { name, uid, model, manufacturer, zone.ToString()};
                if (active)
                {
                    var listMachine = new ListViewItem(machineArr);
                    activeMachines.Items.Add(listMachine);
                }
            }
            /*END TEST CODE*/
        }

    }
}