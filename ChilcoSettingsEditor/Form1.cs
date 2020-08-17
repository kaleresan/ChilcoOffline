using Chilco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChilcoSettingsEditor
{
    public partial class Form1 : Form
    {
        private List<Group> Groups;
        private Group CurrentGroup;
        public Form1()
        {
            InitializeComponent();
            Groups = FileIO.LoadGroups().ToList();
            foreach (Group group in Groups)
            {
                listBoxRules.Items.Add(group.ruleset.Key + " " + group.ruleset.Title);
            }
            listBoxRules.SelectedIndex = 0;
        }

        public void UpdateGroupInformation()
        {
            Console.WriteLine("Updating Group Information");
            textBoxTitle.Text = CurrentGroup.ruleset.Title;
            textBoxDailyPlaytime.Text = CurrentGroup.ruleset.DailyPlaytime.ToString();
            textBoxLeftoverTime.Text = CurrentGroup.LeftoverTime.ToString();
            textBoxMaxPlaytime.Text = CurrentGroup.ruleset.MaxPlaytime.ToString();
            checkBoxTimeRollover.Checked = CurrentGroup.ruleset.DoTimeRollover;

            listBoxProcesses.Items.Clear();
            foreach (string process in CurrentGroup.ruleset.Processes)
            {
                listBoxProcesses.Items.Add(process);
            }
        }

        private void listBoxRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = listBoxRules.SelectedItem.ToString().Split(' ')[0];
            CurrentGroup = Groups.First(g => g.ruleset.Key.Equals(key));
            UpdateGroupInformation();
        }

        private void checkBoxTimeRollover_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTimeRollover.Checked)
                checkBoxTimeRollover.Text = "Ja";
            else
                checkBoxTimeRollover.Text = "Nein";

            CurrentGroup.ruleset.DoTimeRollover = checkBoxTimeRollover.Checked;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

    }
}
