using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using MongoDB.Driver.Linq;

namespace MEMS
{
    public partial class ChangeLogWindow : Form
    {
        public ChangeLogWindow()
        {
            InitializeComponent();
        }

        private void ChangelogWindow_Load(object sender, EventArgs e)
        {
            ChangelogList();
        }

        private void ChangelogList()
        {
            List<ChangelogEntry> changelogList = ServiceUtil.changeLogService.GetChangeLogEntries();
            foreach (var change in changelogList)
            {
                string[] changeArray =
                {
                    change.Id.ToString().Substring(19),
                    change.machineId.ToString().Substring(19),
                    change.userId.ToString().Substring(19),
                    change.authorId.ToString().Substring(19),
                    change.timestamp.ToString(CultureInfo.CurrentCulture),
                    change.type,
                    change.description
                };
                var changelogMachine = new ListViewItem(changeArray);
                listView1.Items.Add(changelogMachine);
                
            }
        }
        
        private void ChangeLogWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Parent = null;
            e.Cancel = true;
        }
    }
}