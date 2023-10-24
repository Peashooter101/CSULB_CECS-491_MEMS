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
                    change.Id.ToString(),
                    change.machineId.ToString(),
                    change.userId.ToString(),
                    change.authorId.ToString(),
                    change.timestamp.ToString(CultureInfo.CurrentCulture),
                    change.type,
                    change.description
                };
                var changelogMachine = new ListViewItem(changeArray);
                listView1.Items.Add(changelogMachine);
                
            }
        }
    }
}