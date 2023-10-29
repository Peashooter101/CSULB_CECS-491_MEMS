using System;
using System.Windows.Forms;

namespace MEMS.Windows
{
    public partial class MoveMachineWindow : Form
    {
        public MoveMachineWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void relocateButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}