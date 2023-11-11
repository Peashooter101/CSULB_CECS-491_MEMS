using System;
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
            Machine[] machines = new[] { machine1, machine2, machine3 };
            foreach (var machine in machines)
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
        
    }
}