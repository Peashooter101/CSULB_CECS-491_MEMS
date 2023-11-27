using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
using MEMS.Model;

namespace MEMS.Windows
{
    public partial class NewMaintenanceWindow : Form
    {
        public NewMaintenanceWindow()
        {
            InitializeComponent();
        }
        
        private bool _isSessionEnding = true;

        private void NewMaintenanceWindow_Load(object sender, EventArgs e)
        {
            LoadListView();
            DataInputFields();
        }

        private static void PlayPopUpSound()
        {
            SoundPlayer popUpSound = new SoundPlayer("C:\\Windows\\Media\\Windows Notify System Generic.wav");
            popUpSound.Play();
        }
        private void NewMaintenanceWindow_FormClosing(Object sender, FormClosingEventArgs e) {
            if (_isSessionEnding)
            {
                PlayPopUpSound();
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
        private void DataInputFields()
        {
            dataGridView1.Rows.Add("Edit Company",
                "Edit Phone",
                "Edit Contact",
                "Edit Email",
                "Edit Issue",
                "Edit Severity");
        }

        private void MachineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var machine = (Machine)activeMachines.SelectedItem;
            if (activeMachines.SelectedItem == null)
            {
                return;
            }

            machineDisplay.Items.Clear();
            machineDisplay.Items.Add("Name: " + machine.name);
            machineDisplay.Items.Add("Model: " + machine.model);
            machineDisplay.Items.Add("Manufacturer: " + machine.manufacturer);
            machineDisplay.Items.Add("Zone: " + machine.zone);
        }
        

        private void LoadListView()
        {
            List<Machine> machineList = ServiceUtil.machineService.GetMachinesByPage(1);
            var machines = new List<Machine>();
            foreach (var machine in machineList)
            {
                machines.Add(machine);
                if (!machine.isActive) continue;
                activeMachines.Items.Add("ID: " + machine.Id.ToString().Substring(19) + " Name: " + machine.name );
            }

            activeMachines.DataSource = machines;
            activeMachines.DisplayMember = "name";
            activeMachines.SelectionMode = SelectionMode.One;

        }

        private void UpdateCompany(List<string> vendorCompany)
        {
            if (dataGridView1.CurrentCell.Value.Equals("Edit Company"))
            {
                MessageBox.Show(@"Valid input required.");
            }
            else
            {
                vendorCompany.Add(dataGridView1.CurrentCell.Value.ToString());
            }

            foreach (var vendor in vendorCompany)
            {
                Console.WriteLine(vendor);
            }
        }
        
        //this function went up by one for each error that occured. 
        //the user is prompted to enter correct values, but it is adding regardless. 
        private void UpdatePhone(List<string> vendorPhone)
        {
            if (dataGridView1.CurrentCell.Value.Equals("Edit Phone") || dataGridView1.CurrentCell.Value.ToString().Length < 10 || dataGridView1.CurrentCell.Value.ToString().Length > 13)
            {
                MessageBox.Show(@"Valid input required.");
            }
            else
            {
                vendorPhone.Add(dataGridView1.CurrentCell.Value.ToString());
            }

            
            foreach (var vendor in vendorPhone)
            {
                Console.WriteLine(vendor);
            }
        }
        
        //should create a separate method call for each column edit... 


        private void addRequestButton_Click(object sender, EventArgs e)
        {
            //need to save the request 
            //initialize a maintenanceRequest service util 
            
            //will need the machine information and use some of that information (UID) to reference request
            //NOTE// maintenance requests should probably have a reference number... //NOTE//
            List<string> vendorInformation = new List<string>();
            //save users input data
            //these functions should take an existing object and return an object with the augmented data 
            //example: vendorInfo -> edit company -> return object with company and all others needing to be completed
            UpdateCompany(vendorInformation);
            UpdatePhone(vendorInformation);

            foreach (var info in vendorInformation)
            {
                Console.WriteLine(info);
            }

        }
    }
}