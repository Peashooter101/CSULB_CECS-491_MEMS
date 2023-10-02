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
        private bool IsSessionEnding = true;

        private void NewMaintenanceWindow_Load(object sender, EventArgs e)
        {
            LoadListView();
            //throw new System.NotImplementedException();
            
        }
        private void NewMaintenanceWindow_FormClosing(Object sender, FormClosingEventArgs e) {
            if (IsSessionEnding)
            {
                switch (MessageBox.Show(
                            "Save any changes?", 
                            Text,
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        //
                        MessageBox.Show("Saved");
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        IsSessionEnding = false;
                        e.Cancel = true;
                        break;
                }
            }
            IsSessionEnding = true;
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
            Machine[] Machines = new[] { machine1, machine2, machine3 };
            foreach (var machine in Machines)
            {
                var name = machine.Name;
                var uid = machine.UniqueId;
                var active = machine.IsActive;
                string[] machineArr = { name, uid};
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