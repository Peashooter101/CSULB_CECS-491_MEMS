using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnsClient.Protocol;
using MEMS.Model;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;

namespace MEMS
{

    
    public partial class MaintenanceLogWindow : Form
    {
        public MaintenanceLogWindow()
        {
            InitializeComponent();
            MachineList.SelectionMode = SelectionMode.None;
            Random rnd = new Random();

            Machine machine1 = new Machine()
            {
                name = "Machine 1",
                model = Convert.ToString(rnd.Next()),
                manufacturer = "Vollrath",
                zone = "5"
            };
            Machine machine2 = new Machine()
            {
                name = "Machine 2",
                model = Convert.ToString(rnd.Next()),
                manufacturer = "Vulcan",
                zone = "1"
            };
            Machine machine3 = new Machine()
            {
                name = "Machine 3",
                model = Convert.ToString(rnd.Next()),
                manufacturer = "Regency",
                zone = "3"
            };

            var machines = new List<Machine>();
            machines.Add(machine1);
            machines.Add(machine2);
            machines.Add(machine3);
            
            MachineList.DataSource = machines;
            MachineList.DisplayMember = "name";
            MachineList.SelectionMode = SelectionMode.One;

        }
        
        private void MachineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var m = (Machine)MachineList.SelectedItem;
            //  
            if (MachineList.SelectedItem == null) 
            { 
                return; 
            }

            lblInfo.Text = m.name + " Maintenance Log";
            MachineDetails.Items.Clear();

            MachineDetails.Items.Add("Machine Name: " + m.name);
            MachineDetails.Items.Add("Model: " + m.model);
            MachineDetails.Items.Add("Manufacturer: " + m.manufacturer);
            MachineDetails.Items.Add("Zone: " + m.zone);
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Maintenance Logs";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string time = System.DateTime.Now.ToString("yy-MMM-dd ddd") + ".txt";
            TextWriter txt = new StreamWriter(dir + "\\Log " + time + ".txt");
            foreach (var item in MachineDetails.Items) 
            {
                txt.WriteLine(item.ToString());
            }
            txt.Close();
            string loc = "Log saved to ";
            MessageBox.Show(loc + dir);

        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMaintenanceBtn_Click(object sender, EventArgs e)
        {
            NewMaintenanceWindow request = new NewMaintenanceWindow();
            request.ShowDialog();
            request = null;
            this.Show();
        }
    }
}