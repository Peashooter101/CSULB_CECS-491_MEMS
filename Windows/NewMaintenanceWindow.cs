using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace MEMS.Windows
{
    public partial class NewMaintenanceWindow : Form
    {
        public NewMaintenanceWindow()
        {
            InitializeComponent();
            
            activeMachines.SelectionMode = SelectionMode.None;
            //activeMachines.DataSource = "name";
            activeMachines.SelectionMode = SelectionMode.One;
            //NewMaintenanceWindow_FormClosing();
        }
        //this should be in its own class... with NewMaintenanceWindow_FormClosing
        private bool _isSessionEnding = true;

        private void NewMaintenanceWindow_Load(object sender, EventArgs e)
        {
            LoadListView();
            DataInputFields();
            //throw new System.NotImplementedException();
            
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
                "Edit Issue");
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
            
            
        }
    }
}