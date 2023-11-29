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
        Contact contact = new Contact();
        MaintenanceEntry entry = new MaintenanceEntry();

        private void CreateNewMaintenanceRequest()
        {
            var companyValid = false;
            var phoneValid = false;
            var emailValid = false;
            var nameValid = false;
            var descriptionValid = false;
            var severityValid = false;
            var typeValid = false;
            //search for the bsonID of the machine by name 
            Machine machineObject = (Machine)activeMachines.SelectedItem;
            BsonObjectId referenceMachine = machineObject.Id;

            Console.WriteLine(referenceMachine);
            //store information from the user ... we need a contact and a maintenance entry


            //check data grid for valid input:

            //verify company input: 
            if (dataGridView1.Rows[0].Cells[0].Value.Equals("Edit Company") ||
                dataGridView1.Rows[0].Cells[0].Value.Equals(""))
            {
                MessageBox.Show(@"Please enter a company name.");
            }
            else
            {
                contact.employer = dataGridView1.Rows[0].Cells[0].Value.ToString();
                companyValid = true;
            }

            //verify phone input: 
            if (dataGridView1.Rows[0].Cells[1].Value.Equals("Edit Phone") ||
                dataGridView1.Rows[0].Cells[1].Value.ToString().Length > 14 ||
                dataGridView1.Rows[0].Cells[1].Value.ToString().Length < 10)
            {
                MessageBox.Show(@"Please enter a phone number.");
            }
            else
            {
                contact.phoneNumber = dataGridView1.Rows[0].Cells[1].Value.ToString();
                phoneValid = true;
            }

            //verify contact:
            if (dataGridView1.Rows[0].Cells[2].Value.Equals("Edit Contact") ||
                dataGridView1.Rows[0].Cells[2].Value.Equals(""))
            {
                MessageBox.Show(@"Please enter a valid contact.");
            }
            else
            {
                contact.name = dataGridView1.Rows[0].Cells[2].Value.ToString();
                nameValid = true;
            }

            //verify email: 
            if (dataGridView1.Rows[0].Cells[3].Value.Equals("Edit Email") ||
                dataGridView1.Rows[0].Cells[3].Value.Equals(""))
            {
                MessageBox.Show(@"Please enter an email.");
            }
            else
            {
                contact.email = dataGridView1.Rows[0].Cells[3].Value.ToString();
                emailValid = true;
            }

            //verify issue: 
            if (dataGridView1.Rows[0].Cells[4].Value.Equals("Edit Issue") ||
                dataGridView1.Rows[0].Cells[4].Value.Equals(""))
            {
                MessageBox.Show(@"Please enter an issue.");
            }
            else
            {
                entry.description = dataGridView1.Rows[0].Cells[4].Value.ToString();
                descriptionValid = true;
            }

            //verify severity:
            if (dataGridView1.Rows[0].Cells[5].Value.Equals("Edit Severity") ||
                dataGridView1.Rows[0].Cells[5].Value.Equals("") ||
                !dataGridView1.Rows[0].Cells[5].Value.Equals("Urgent") &&
                !dataGridView1.Rows[0].Cells[5].Value.Equals("Moderate") &&
                !dataGridView1.Rows[0].Cells[5].Value.Equals("Minor"))
            {
                MessageBox.Show(@"Please classify severity: Urgent, Moderate, Minor");
            }
            else
            {
                Enum.TryParse(dataGridView1.Rows[0].Cells[5].Value.ToString(), out Severity severity);
                entry.severity = severity;
                severityValid = true;
            }

            //verify request type: 
            if (dataGridView1.Rows[0].Cells[6].Value.Equals("Edit Severity") ||
                dataGridView1.Rows[0].Cells[6].Value.Equals("") ||
                !dataGridView1.Rows[0].Cells[6].Value.Equals("Repair") &&
                !dataGridView1.Rows[0].Cells[6].Value.Equals("Replace") &&
                !dataGridView1.Rows[0].Cells[6].Value.Equals("RoutineService") &&
                !dataGridView1.Rows[0].Cells[6].Value.Equals("Lockout") &&
                !dataGridView1.Rows[0].Cells[6].Value.Equals("Discontinue"))
            {
                MessageBox.Show(@"Please classify severity: Repair, Replace, RoutineService, Lockout, Discontinue");
            }
            else
            {
                Enum.TryParse(dataGridView1.Rows[0].Cells[6].Value.ToString(), out MaintenanceType maintenanceType);
                entry.type = maintenanceType;
                typeValid = true;
            }

            if (companyValid && phoneValid && emailValid && nameValid && descriptionValid && severityValid && typeValid)
            {
                ServiceUtil.ContactService.CreateContact(
                    contact.name, contact.email, contact.phoneNumber, contact.employer, contact.businessLocation,
                    referenceMachine);
                ServiceUtil.MaintenanceReminderService.CreateMaintenanceReminder(entry.type, entry.severity,
                    entry.description);
                ServiceUtil.changeLogService.CreateChange(DateTime.Now, entry.type.ToString(), entry.description);
                MessageBox.Show(@"Request Added");
            }



            Console.WriteLine(contact.employer + " " + contact.phoneNumber + " " + contact.name + " " + contact.email);
            Console.WriteLine(entry.severity + " " + entry.type + " " + entry.description);
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