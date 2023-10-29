using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MEMS.Windows
{
    public partial class AddMachineWindow : Form
    {
        public delegate void MachineAddedHandler();
        public event MachineAddedHandler MachineAdded;
        public AddMachineWindow()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            modelBox.Clear();
            serialNumBox.Clear();
            manuBox.Clear();
            zoneBox.Clear();
            buildingBox.Clear();
        }

        private void saveDetailBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text)
                || string.IsNullOrWhiteSpace(modelBox.Text)
                || string.IsNullOrWhiteSpace(manuBox.Text)
                || string.IsNullOrWhiteSpace(buildingBox.Text)
                || string.IsNullOrWhiteSpace(serialNumBox.Text)
                )
            {
                lblConfirm.Text = @"Please fill in required machine information.";
            }
            else
            {
                List<Machine> addedMachines = ServiceUtil.machineService.ReadAllByName(nameBox.Text);
                bool duplicate = false;
                foreach (Machine m in addedMachines)
                {
                    if (m.serial == serialNumBox.Text)
                    {
                        duplicate = true;
                    }
                }

                if (!duplicate)
                {
                    detailBox.Items.Add("Machine Name: " + nameBox.Text);
                    detailBox.Items.Add("Model: " + modelBox.Text);
                    detailBox.Items.Add("Serial Number: " + serialNumBox.Text);
                    detailBox.Items.Add("Manufacturer: " + manuBox.Text);
                    detailBox.Items.Add("Zone: " + zoneBox.Text);
                    detailBox.Items.Add("Building: " + buildingBox.Text);


                    lblConfirm.Text = @"Adding this machine. Click ""Save Details"" to confirm.";
                    //need to add business logic to check if machine has been added or not yet.
                    //Query the DB if no entry -> add else -> create popup that machine already exists. 
                    ServiceUtil.machineService.CreateMachine(nameBox.Text, modelBox.Text, serialNumBox.Text,
                        manuBox.Text, zoneBox.Text);
                    MachineAdded?.Invoke();
                }
                else
                {
                    lblConfirm.Text = @"Machine already exists in database";
                }
            }
        }
    }
}