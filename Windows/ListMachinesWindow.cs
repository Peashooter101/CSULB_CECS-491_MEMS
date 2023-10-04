using System;
using System.Windows.Forms;

namespace MEMS
{
    public partial class ListMachinesWindow : Form
    {
        //test objects to display in window 
        //note: MaintenanceRequests will need a Machine reference
        Machine machine1 = new Machine()
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
        };
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
            Machine[] Machines = { machine1, machine2, machine3 };
            foreach (var machine in Machines)
            {
                string[] machineArr = { machine.name, machine.Id.ToString(), machine.model, machine.manufacturer, machine.zone};
                if (machine.isActive)
                {
                    var listMachine = new ListViewItem(machineArr);
                    activeMachines.Items.Add(listMachine);
                }
            }
            /*END TEST CODE*/
        }

        private void activeMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}