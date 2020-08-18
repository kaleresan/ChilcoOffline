using Chilco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            UpdateGrouplist(0);
        }

        public void UpdateGrouplist(int selectedIndex)
        {
            listBoxRules.Items.Clear();
            foreach (Group group in Groups)
            {
                listBoxRules.Items.Add(group.ruleset.Key + " " + group.ruleset.Title);
            }
            listBoxRules.SelectedIndex = selectedIndex;
        }

        public void UpdateGroupInformation()
        {
            bool isSelected = CurrentGroup.ruleset.Key != "";
            textBoxTitle.Enabled = isSelected;
            textBoxDailyPlaytime.Enabled = isSelected;
            textBoxLeftoverTime.Enabled = isSelected;
            textBoxMaxPlaytime.Enabled = isSelected;
            checkBoxTimeRollover.Enabled = isSelected;
            buttonRemoveProcess.Enabled = isSelected;
            buttonAddProcess.Enabled = isSelected;
            if (!isSelected)
            {
                textBoxTitle.Text = "";
                textBoxDailyPlaytime.Text = "";
                textBoxLeftoverTime.Text = "";
                textBoxMaxPlaytime.Text = "";
                checkBoxTimeRollover.Checked = true;
                listBoxProcesses.Items.Clear();
            }
            else
            {
                Console.WriteLine("Updating Group Information");
                textBoxTitle.Text = CurrentGroup.ruleset.Title;
                textBoxDailyPlaytime.Text = CurrentGroup.ruleset.DailyPlaytime.ToString(@"%d\dhh\hmm\mss\s");
                textBoxLeftoverTime.Text = CurrentGroup.LeftoverTime.ToString(@"%d\dhh\hmm\mss\s");
                textBoxMaxPlaytime.Text = CurrentGroup.ruleset.MaxPlaytime.ToString(@"%d\dhh\hmm\mss\s");
                checkBoxTimeRollover.Checked = CurrentGroup.ruleset.DoTimeRollover;

                listBoxProcesses.Items.Clear();
                foreach (string process in CurrentGroup.ruleset.Processes)
                {
                    listBoxProcesses.Items.Add(process);
                }
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

            textBoxMaxPlaytime.Enabled = checkBoxTimeRollover.Checked;
            CurrentGroup.ruleset.DoTimeRollover = checkBoxTimeRollover.Checked;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            listBoxRunningProcesses.Items.Clear();
            foreach (Process process in processes)
            {
                if (listBoxRunningProcesses.Items.Contains(process.ProcessName)) continue;
                listBoxRunningProcesses.Items.Add(process.ProcessName);
            }
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            CurrentGroup.ruleset.Title = textBoxTitle.Text;
            UpdateGrouplist(listBoxRules.SelectedIndex);
        }

        private void textBoxLeftoverTime_TextChanged(object sender, EventArgs e)
        {

            if (TimeSpan.TryParseExact(textBoxLeftoverTime.Text, @"%d\dhh\hmm\mss\s", null, out CurrentGroup.LeftoverTime))
                textBoxLeftoverTime.ForeColor = Color.Green;
            else
                textBoxLeftoverTime.ForeColor = Color.Red;
        }

        private void textBoxDailyPlaytime_TextChanged(object sender, EventArgs e)
        {
            if (TimeSpan.TryParseExact(textBoxDailyPlaytime.Text, @"%d\dhh\hmm\mss\s", null, out CurrentGroup.ruleset.DailyPlaytime))
                textBoxDailyPlaytime.ForeColor = Color.Green;
            else
                textBoxDailyPlaytime.ForeColor = Color.Red;
        }

        private void textBoxMaxPlaytime_TextChanged(object sender, EventArgs e)
        {
            if (TimeSpan.TryParseExact(textBoxMaxPlaytime.Text, @"%d\dhh\hmm\mss\s", null, out CurrentGroup.ruleset.MaxPlaytime))
            {
                textBoxMaxPlaytime.ForeColor = Color.Green;
                if (CurrentGroup.ruleset.MaxPlaytime.Ticks == 0) textBoxMaxPlaytime.ForeColor = Color.Gray;
            }
            else
                textBoxMaxPlaytime.ForeColor = Color.Red;
        }

        private void buttonRemoveProcess_Click(object sender, EventArgs e)
        {
            if (listBoxProcesses.SelectedIndex == -1) return;
            listBoxProcesses.Items.RemoveAt(listBoxProcesses.SelectedIndex);
            CurrentGroup.ruleset.Processes.Clear();
            for (int i = 0; i < listBoxProcesses.Items.Count; i++)
            {
                CurrentGroup.ruleset.Processes.Add(listBoxProcesses.Items[i].ToString());
            }
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            Group g = new Group(
                GenerateKey(), 
                "Neue Regel", 
                new List<string>(), 
                new TimeSpan(0), 
                true, DateTime.Now, 
                new TimeSpan(0), 
                new TimeSpan(0));
            Groups.Add(g);
            UpdateGrouplist(Groups.Count - 1);
        }

        private string GenerateKey()
        {
            Random rnd = new Random();
            string key;
            do
            {
                key = "";
                for (int i = 0; i < 6; i++)
                {
                    key += rnd.Next(0, 10);
                }
            } while (Groups.Count(g => g.ruleset.Key == key) > 0);
            return key;
        }

        private void buttonDeleteGroup_Click(object sender, EventArgs e)
        {
            if (listBoxRules.SelectedIndex == -1) return;
            Groups.Remove(CurrentGroup);
            CurrentGroup = new Group(
                "",
                "",
                new List<string>(),
                new TimeSpan(0),
                true, DateTime.Now,
                new TimeSpan(0),
                new TimeSpan(0));
            UpdateGrouplist(-1);
            UpdateGroupInformation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxProcesses.Items.Add(listBoxRunningProcesses.SelectedItem);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool chilco_was_running = Butcher.KillProcess("chilco");
            FileIO.SaveGroups(Groups.ToArray());
            if (chilco_was_running)
            {
                Process.Start(Directory.GetCurrentDirectory() + "\\chilco.exe");
            }
        }

        private void checkBoxModay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxTuesday_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxWednesday_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxThursday_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFriday_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSaturday_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSunday_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
