using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MEMS.Windows
{
    public partial class MoveMachineWindow : Form
    {
        public MoveMachineWindow()
        {
            InitializeComponent();
        }

        public MoveMachineWindow(string z, List<String> zs)
        {
            InitializeComponent();
            zoneChoice.Text = z;
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
            throw new NotImplementedException();
        }
    }
}