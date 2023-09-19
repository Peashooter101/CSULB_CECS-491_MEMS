using System;
using System.Windows.Forms;

namespace MEMS
{
    public partial class NewMaintenanceWindow : Form
    {
        public NewMaintenanceWindow()
        {
            InitializeComponent();
        }

        private void NewMaintenanceWindow_Load(object sender, EventArgs e)
        {
            Load_ListView();
            //throw new System.NotImplementedException();
        }

        private void Load_ListView()
        {
            //test objects to display in window 
            //note: MaintenanceRequests will need a Machine reference
            Machine machine1 = new Machine()
            {
                Name = "Kintera Two-Section Reach-In Freezer 54\"",
                Manufacturer = "Kintera",
                Model = "KBM2F",
                UniqueId = "1",
                Zone = 3
            };
            Machine machine2 = new Machine()
            {
                Name = "Traulsen Dealer's Choice Glass Door Reach-In Refrigerator",
                Manufacturer = "Traulsen",
                Model = "G11011",
                UniqueId = "2",
                Zone = 2
            };
            Machine machine3 = new Machine()
            {
                Name = "Arctic Air Reach-In Refrigerator, Solid Door, 1 Section",
                Manufacturer = "Arctic",
                Model = "AR23",
                UniqueId = "3",
                Zone = 1
            };
            
            //add the machines to the list view
            string[] machine1Arr =
                {   machine1.Name, 
                    machine1.UniqueId,
                };
            var listMachine1 = new ListViewItem(machine1Arr);
            //listview is named in in designer and we use it here. . . 
            listview.Items.Add(listMachine1);
            
            string[] machine2Arr =
            {   machine2.Name, 
                machine2.UniqueId, 
            };
            var listMachine2 = new ListViewItem(machine2Arr);
            listview.Items.Add(listMachine2);
            string[] machine3Arr =
            {   machine3.Name, 
                machine3.UniqueId, 
            };
            var listMachine3 = new ListViewItem(machine3Arr);
            listview.Items.Add(listMachine3);

        }
    }
}