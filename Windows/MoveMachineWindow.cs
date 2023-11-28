using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MEMS.Windows
{
    public partial class MoveMachineWindow : Form
    {
        private Machine m;
        public MoveMachineWindow()
        {
            InitializeComponent();
        }

        public MoveMachineWindow(Machine m, string z, List<String> zs)
        {
            InitializeComponent();
            zoneChoice.Text = z;
            this.m = m;
            foreach (var x in zs)
            {
                zoneChoice.Items.Add(x);
            }
        }
        
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void relocateButton_Click(object sender, EventArgs e)
        {
            m.zone = zoneChoice.Text;
            ServiceUtil.machineService.UpdateMachine(m);
            this.Close();
        }
    }
}