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

        private void moveButton_Click(object sender, EventArgs e)
        {
            var moveMachineWindow = new MoveMachineWindow();
            moveMachineWindow.ShowDialog();
            this.Close();
        }
    }
}