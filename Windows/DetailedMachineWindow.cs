using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MEMS.Windows
{
    public partial class DetailedMachineWindow : Form
    {
        private List<String> zoneList;
        public DetailedMachineWindow()
        {
            InitializeComponent();
        }
        
        public DetailedMachineWindow(String[] d, List<String> z)
        {
            InitializeComponent();
            
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
            string zone = zoneBox.Text;
            var moveMachineWindow = new MoveMachineWindow(zone, zoneList);
            moveMachineWindow.ShowDialog();
            this.Close();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            //this function should save the changes to the machine AND populate the change log
            //throw new System.NotImplementedException();
        }
        
    }
}