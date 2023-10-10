using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MEMS
{
    public partial class NewMaintenanceWindow : Form
    {
        public NewMaintenanceWindow()
        {
            InitializeComponent();
            //NewMaintenanceWindow_FormClosing();
        }
        //this should be in its own class... with NewMaintenanceWindow_FormClosing
        private bool _isSessionEnding = true;

        private void NewMaintenanceWindow_Load(object sender, EventArgs e)
        {
            LoadListView();
            //throw new System.NotImplementedException();
            
        }
        private void NewMaintenanceWindow_FormClosing(Object sender, FormClosingEventArgs e) {
            if (_isSessionEnding)
            {
                switch (MessageBox.Show(
                            @"Save any changes?", 
                            Text,
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        //
                        MessageBox.Show(@"Saved");
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        _isSessionEnding = false;
                        e.Cancel = true;
                        break;
                }
            }
            _isSessionEnding = true;
        }
        private void DataInputFields(object sender, EventArgs eventArgs)
        {
            dataGridView1.Rows.Add(companyLabel.Text,
                phoneLabel.Text,
                contactLabel.Text,
                emailLabel.Text,
                issueDescriptionLabel.Text);
        }

        /*TEST CODE*/
        private void LoadListView()
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
            //we will have to take this data from the db, returning a list of machines to the program 
            //from there we can use this functionality to list the machines 
            Machine[] Machines = new[] { machine1, machine2, machine3 };
            foreach (var machine in Machines)
            {
                var name = machine.name;
                var uid = machine.Id;
                var active = machine.isActive;
                string[] machineArr = { name, uid.ToString()};
                if (active)
                {
                    var listMachine = new ListViewItem(machineArr);
                    listview.Items.Add(listMachine);
                }
            }
            //add the machines to the list view
            //string[] machine1Arr =
            //    {   machine1.Name, 
            //        machine1.UniqueId
            //    };
            //var listMachine1 = new ListViewItem(machine1Arr);
            ////listview is named in in designer and we use it here. . . 
            //listview.Items.Add(listMachine1);
            //
            //string[] machine2Arr =
            //{   machine2.Name, 
            //    machine2.UniqueId, 
            //};
            //var listMachine2 = new ListViewItem(machine2Arr);
            //
            //listview.Items.Add(listMachine2);
            //string[] machine3Arr =
            //{   machine3.Name, 
            //    machine3.UniqueId, 
            //};
            //
            //var listMachine3 = new ListViewItem(machine3Arr);
            //listview.Items.Add(listMachine3);
        /*END TEST CODE*/
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void companyTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}