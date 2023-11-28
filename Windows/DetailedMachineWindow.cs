using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MEMS.Windows
{
    public partial class DetailedMachineWindow : Form
    {
        private ListMachinesWindow list;
        private List<String> zoneList;
        public DetailedMachineWindow()
        {
            InitializeComponent();
        }
        
        public DetailedMachineWindow(ListMachinesWindow l, String[] d, List<String> z)
        {
            InitializeComponent();
            list = l;
            nameBox.Text = d[0];
            modelBox.Text = d[2];
            serialBox.Text = d[5];
            manuBox.Text = d[3];
            zoneBox.Text = d[4];
            nameBox.SelectionStart = 0;
            zoneList = z;
        }
        
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void moveButton_Click(object sender, EventArgs e)
        {
            Machine m = ServiceUtil.machineService.ReadByName(nameBox.Text);
            var moveMachineWindow = new MoveMachineWindow(m, m.zone, zoneList);
            moveMachineWindow.ShowDialog();
            this.Close();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            //this function should save the changes to the machine AND populate the change log
            //throw new System.NotImplementedException();
        }

        private void lblManu_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void DetailedMachineWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Parent = null;
            e.Cancel = true;
        }
    }
}