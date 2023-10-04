using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEMS.Model
{
    public partial class ChangeLogUI : Form
    {
        public ChangeLogUI()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            String machine = lstChangeEvents.SelectedValue.ToString();
            
        }

        private void rchtxtbxItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object machine = lstChangeEvents.SelectedValue;
            List<String> displayItems = new List<String>();
            int i = 0;
            while (i < database.get(machine).size())
            {
                displayItems.Add(database.get(machine).getIndex(i));
                i = i + 1;
            }
        }

        private void lblActiveMachines_Click(object sender, EventArgs e)
        {

        }

        private void ChangeLogUI_Load(object sender, EventArgs e)
        {

        }
    }
}
