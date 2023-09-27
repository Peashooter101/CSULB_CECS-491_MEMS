using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace MEMS
{
    public partial class MaintenanceReminderWindow : Form
    {        
        private Machine machine1 = new Machine()
        {
            Name = "Machine Test",
            IsActive = true,
            Manufacturer = "Machinery",
            Model = "123A",
            UniqueId = "19022AFF0",
            Zone = 2
        };
        public MaintenanceReminderWindow()
        {
            InitializeComponent();
        }

        private void MachineReminder_Load(object sender, EventArgs e)
        {
            LoadListView();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void LoadListView()
        {
            string[] machine =
                { machine1.Name, machine1.UniqueId, machine1.Model, machine1.Manufacturer, machine1.Zone.ToString() };
            var listMachine = new ListViewItem(machine);
            machineListView.Items.Add(listMachine);

        }


        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}