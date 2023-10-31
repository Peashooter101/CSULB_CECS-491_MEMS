using System;
using System.Windows.Forms;

namespace MEMS.Windows
{
    public partial class DetailedMachineWindow : Form
    {
        public DetailedMachineWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DetailedMachineWindow(string[] d)
        {
            InitializeComponent();
            nameBox.Text = d[0];
            modelBox.Text = d[2];
            serialBox.Text = d[5];
            manuBox.Text = d[3];
            zoneBox.Text = d[4];
            nameBox.SelectionStart = 0;
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            var moveMachineWindow = new MoveMachineWindow();
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