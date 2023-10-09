using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace MEMS
{
    public partial class MaintenanceReminderWindow : Form
    {        
        private Machine machine1 = new Machine()
        {
            name = "Machine Test",
            isActive = true,
            manufacturer = "Machinery",
            model = "123A",
            zone = "2"
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
            //throw new System.NotImplementedException();
        }

        private void LoadListView()
        {
            string[] machine =
                { machine1.name, machine1.Id.ToString(), machine1.model, machine1.manufacturer, machine1.zone };
            var listMachine = new ListViewItem(machine);
            machineListView.Items.Add(listMachine);

        }


        private void label2_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
    }
}