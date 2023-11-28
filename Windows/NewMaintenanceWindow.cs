using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
using MEMS.Model;
using MongoDB.Bson;

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

        private void CreateNewMaintenanceRequest()
        {
            
            //search for the bsonID of the machine by name 
            Machine machineObject = (Machine)activeMachines.SelectedItem;
            BsonObjectId referenceMachine = machineObject.Id;
            
            Console.WriteLine(referenceMachine);
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
            Hide();
            Parent = null;
            e.Cancel = true;
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

        private void addRequestButton_Click(object sender, EventArgs e)
        {
            //button click should save request by having a contact reference a bsonId from a machine
            
            CreateNewMaintenanceRequest();

        }
    }
}