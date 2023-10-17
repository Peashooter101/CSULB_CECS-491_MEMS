using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MEMS
{
    public partial class ChangeLogWindow : Form
    {
        public ChangeLogWindow()
        {
            InitializeComponent();
        }

        private void listBoxChangeEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ChangeLogWindow_Load(object sender, EventArgs e)
        {
            List<ChangelogEntry> changelogList = ServiceUtil.changeLogService.GetChangeLogEntries();
            lstbxChangeEvents.Items.AddRange(changelogList.ToArray());
            //lstbxChangeEvents.DataSource = changelogList;
        }
    }
}