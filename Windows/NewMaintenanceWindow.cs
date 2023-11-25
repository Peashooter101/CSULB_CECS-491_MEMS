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
            dataGridView1.Rows.Add(companyTextBox.Text,
                phoneBoxText.Text,
                contactTextBox.Text,
                emailTextBox.Text,
                issueDescriptionTextBox.Text);
        }

        /*TEST CODE*/
        private void LoadListView()
        {
            //test objects to display in window 
            //note: MaintenanceRequests will need a Machine reference

            List<Machine> machineList = ServiceUtil.machineService.GetMachinesByPage(1);
            foreach (var machine in machineList)
            {
                string[] machineArr = { machine.name, machine.Id.ToString().Substring(19)};
                if (!machine.isActive) continue;
                var listMachine = new ListViewItem(machineArr);
                activeMachines.Items.Add(listMachine);
            }
        }

        private void addRequestButton_Click(object sender, EventArgs e)
        {
            
        }

        private void companyTextBox_TextChanged(string companyText)
        {
            
        }
    }
}