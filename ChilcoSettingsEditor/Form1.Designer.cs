namespace ChilcoSettingsEditor
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxRules = new System.Windows.Forms.ListBox();
            this.labelRules = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLeftoverTime = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxLeftoverTime = new System.Windows.Forms.TextBox();
            this.textBoxDailyPlaytime = new System.Windows.Forms.TextBox();
            this.labelDailyPlaytime = new System.Windows.Forms.Label();
            this.labelTimeRollover = new System.Windows.Forms.Label();
            this.checkBoxTimeRollover = new System.Windows.Forms.CheckBox();
            this.textBoxMaxPlaytime = new System.Windows.Forms.TextBox();
            this.labelMaxPlaytime = new System.Windows.Forms.Label();
            this.listBoxProcesses = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxRunningProcesses = new System.Windows.Forms.ListBox();
            this.buttonRemoveProcess = new System.Windows.Forms.Button();
            this.buttonAddProcess = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDeleteGroup = new System.Windows.Forms.Button();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.labelGroup = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxModay = new System.Windows.Forms.CheckBox();
            this.checkBoxTuesday = new System.Windows.Forms.CheckBox();
            this.checkBoxWednesday = new System.Windows.Forms.CheckBox();
            this.checkBoxThursday = new System.Windows.Forms.CheckBox();
            this.checkBoxFriday = new System.Windows.Forms.CheckBox();
            this.checkBoxSaturday = new System.Windows.Forms.CheckBox();
            this.checkBoxSunday = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxRules
            // 
            this.listBoxRules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxRules.FormattingEnabled = true;
            this.listBoxRules.ItemHeight = 16;
            this.listBoxRules.Location = new System.Drawing.Point(10, 50);
            this.listBoxRules.Name = "listBoxRules";
            this.listBoxRules.Size = new System.Drawing.Size(200, 308);
            this.listBoxRules.TabIndex = 0;
            this.listBoxRules.SelectedIndexChanged += new System.EventHandler(this.listBoxRules_SelectedIndexChanged);
            // 
            // labelRules
            // 
            this.labelRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRules.Location = new System.Drawing.Point(10, 15);
            this.labelRules.Name = "labelRules";
            this.labelRules.Size = new System.Drawing.Size(200, 30);
            this.labelRules.TabIndex = 1;
            this.labelRules.Text = "Regeln";
            this.labelRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(237, 53);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(53, 17);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Name: ";
            // 
            // labelLeftoverTime
            // 
            this.labelLeftoverTime.AutoSize = true;
            this.labelLeftoverTime.Location = new System.Drawing.Point(237, 82);
            this.labelLeftoverTime.Name = "labelLeftoverTime";
            this.labelLeftoverTime.Size = new System.Drawing.Size(82, 17);
            this.labelLeftoverTime.TabIndex = 3;
            this.labelLeftoverTime.Text = "Übrige Zeit:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(367, 50);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(226, 22);
            this.textBoxTitle.TabIndex = 4;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // textBoxLeftoverTime
            // 
            this.textBoxLeftoverTime.Location = new System.Drawing.Point(367, 79);
            this.textBoxLeftoverTime.Name = "textBoxLeftoverTime";
            this.textBoxLeftoverTime.Size = new System.Drawing.Size(226, 22);
            this.textBoxLeftoverTime.TabIndex = 5;
            this.textBoxLeftoverTime.TextChanged += new System.EventHandler(this.textBoxLeftoverTime_TextChanged);
            // 
            // textBoxDailyPlaytime
            // 
            this.textBoxDailyPlaytime.Location = new System.Drawing.Point(367, 107);
            this.textBoxDailyPlaytime.Name = "textBoxDailyPlaytime";
            this.textBoxDailyPlaytime.Size = new System.Drawing.Size(226, 22);
            this.textBoxDailyPlaytime.TabIndex = 7;
            this.textBoxDailyPlaytime.TextChanged += new System.EventHandler(this.textBoxDailyPlaytime_TextChanged);
            // 
            // labelDailyPlaytime
            // 
            this.labelDailyPlaytime.AutoSize = true;
            this.labelDailyPlaytime.Location = new System.Drawing.Point(237, 110);
            this.labelDailyPlaytime.Name = "labelDailyPlaytime";
            this.labelDailyPlaytime.Size = new System.Drawing.Size(94, 17);
            this.labelDailyPlaytime.TabIndex = 6;
            this.labelDailyPlaytime.Text = "Tägliche Zeit:";
            // 
            // labelTimeRollover
            // 
            this.labelTimeRollover.AutoSize = true;
            this.labelTimeRollover.Location = new System.Drawing.Point(237, 138);
            this.labelTimeRollover.Name = "labelTimeRollover";
            this.labelTimeRollover.Size = new System.Drawing.Size(104, 17);
            this.labelTimeRollover.TabIndex = 8;
            this.labelTimeRollover.Text = "Zeit aufsparen:";
            // 
            // checkBoxTimeRollover
            // 
            this.checkBoxTimeRollover.Location = new System.Drawing.Point(367, 138);
            this.checkBoxTimeRollover.Name = "checkBoxTimeRollover";
            this.checkBoxTimeRollover.Size = new System.Drawing.Size(226, 22);
            this.checkBoxTimeRollover.TabIndex = 10;
            this.checkBoxTimeRollover.Text = "Nein";
            this.checkBoxTimeRollover.UseVisualStyleBackColor = true;
            this.checkBoxTimeRollover.CheckedChanged += new System.EventHandler(this.checkBoxTimeRollover_CheckedChanged);
            // 
            // textBoxMaxPlaytime
            // 
            this.textBoxMaxPlaytime.Location = new System.Drawing.Point(367, 166);
            this.textBoxMaxPlaytime.Name = "textBoxMaxPlaytime";
            this.textBoxMaxPlaytime.Size = new System.Drawing.Size(226, 22);
            this.textBoxMaxPlaytime.TabIndex = 12;
            this.textBoxMaxPlaytime.TextChanged += new System.EventHandler(this.textBoxMaxPlaytime_TextChanged);
            // 
            // labelMaxPlaytime
            // 
            this.labelMaxPlaytime.AutoSize = true;
            this.labelMaxPlaytime.Location = new System.Drawing.Point(237, 169);
            this.labelMaxPlaytime.Name = "labelMaxPlaytime";
            this.labelMaxPlaytime.Size = new System.Drawing.Size(126, 17);
            this.labelMaxPlaytime.TabIndex = 11;
            this.labelMaxPlaytime.Text = "Max sparbare Zeit:";
            // 
            // listBoxProcesses
            // 
            this.listBoxProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxProcesses.FormattingEnabled = true;
            this.listBoxProcesses.ItemHeight = 16;
            this.listBoxProcesses.Location = new System.Drawing.Point(240, 242);
            this.listBoxProcesses.Name = "listBoxProcesses";
            this.listBoxProcesses.Size = new System.Drawing.Size(353, 148);
            this.listBoxProcesses.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(592, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "laufende Prozesse";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prozesse:";
            // 
            // listBoxRunningProcesses
            // 
            this.listBoxRunningProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRunningProcesses.FormattingEnabled = true;
            this.listBoxRunningProcesses.ItemHeight = 16;
            this.listBoxRunningProcesses.Location = new System.Drawing.Point(617, 50);
            this.listBoxRunningProcesses.Name = "listBoxRunningProcesses";
            this.listBoxRunningProcesses.Size = new System.Drawing.Size(241, 308);
            this.listBoxRunningProcesses.TabIndex = 16;
            // 
            // buttonRemoveProcess
            // 
            this.buttonRemoveProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveProcess.Location = new System.Drawing.Point(240, 396);
            this.buttonRemoveProcess.Name = "buttonRemoveProcess";
            this.buttonRemoveProcess.Size = new System.Drawing.Size(353, 26);
            this.buttonRemoveProcess.TabIndex = 17;
            this.buttonRemoveProcess.Text = "Prozess entfernen";
            this.buttonRemoveProcess.UseVisualStyleBackColor = true;
            this.buttonRemoveProcess.Click += new System.EventHandler(this.buttonRemoveProcess_Click);
            // 
            // buttonAddProcess
            // 
            this.buttonAddProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddProcess.Location = new System.Drawing.Point(617, 396);
            this.buttonAddProcess.Name = "buttonAddProcess";
            this.buttonAddProcess.Size = new System.Drawing.Size(241, 26);
            this.buttonAddProcess.TabIndex = 18;
            this.buttonAddProcess.Text = "Prozess hinzufügen";
            this.buttonAddProcess.UseVisualStyleBackColor = true;
            this.buttonAddProcess.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Location = new System.Drawing.Point(617, 364);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(241, 26);
            this.buttonUpdate.TabIndex = 19;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(10, 428);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(736, 26);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDeleteGroup
            // 
            this.buttonDeleteGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteGroup.Location = new System.Drawing.Point(10, 396);
            this.buttonDeleteGroup.Name = "buttonDeleteGroup";
            this.buttonDeleteGroup.Size = new System.Drawing.Size(200, 26);
            this.buttonDeleteGroup.TabIndex = 21;
            this.buttonDeleteGroup.Text = "Regel entfernen";
            this.buttonDeleteGroup.UseVisualStyleBackColor = true;
            this.buttonDeleteGroup.Click += new System.EventHandler(this.buttonDeleteGroup_Click);
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddGroup.Location = new System.Drawing.Point(10, 364);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(200, 26);
            this.buttonAddGroup.TabIndex = 22;
            this.buttonAddGroup.Text = "Regel hinzufügen";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // labelGroup
            // 
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(258, 15);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(315, 30);
            this.labelGroup.TabIndex = 23;
            this.labelGroup.Text = "Regel";
            this.labelGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.checkBoxSunday, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxSaturday, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxFriday, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxThursday, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxWednesday, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxTuesday, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxModay, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(240, 194);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 25);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // checkBoxModay
            // 
            this.checkBoxModay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxModay.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxModay.AutoSize = true;
            this.checkBoxModay.Location = new System.Drawing.Point(0, 0);
            this.checkBoxModay.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxModay.Name = "checkBoxModay";
            this.checkBoxModay.Size = new System.Drawing.Size(50, 25);
            this.checkBoxModay.TabIndex = 0;
            this.checkBoxModay.Text = "Mo";
            this.checkBoxModay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxModay.UseVisualStyleBackColor = true;
            this.checkBoxModay.CheckedChanged += new System.EventHandler(this.checkBoxModay_CheckedChanged);
            // 
            // checkBoxTuesday
            // 
            this.checkBoxTuesday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTuesday.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxTuesday.AutoSize = true;
            this.checkBoxTuesday.Location = new System.Drawing.Point(50, 0);
            this.checkBoxTuesday.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxTuesday.Name = "checkBoxTuesday";
            this.checkBoxTuesday.Size = new System.Drawing.Size(50, 25);
            this.checkBoxTuesday.TabIndex = 1;
            this.checkBoxTuesday.Text = "Di";
            this.checkBoxTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxTuesday.UseVisualStyleBackColor = true;
            this.checkBoxTuesday.CheckedChanged += new System.EventHandler(this.checkBoxTuesday_CheckedChanged);
            // 
            // checkBoxWednesday
            // 
            this.checkBoxWednesday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxWednesday.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxWednesday.AutoSize = true;
            this.checkBoxWednesday.Location = new System.Drawing.Point(100, 0);
            this.checkBoxWednesday.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxWednesday.Name = "checkBoxWednesday";
            this.checkBoxWednesday.Size = new System.Drawing.Size(50, 25);
            this.checkBoxWednesday.TabIndex = 2;
            this.checkBoxWednesday.Text = "Mi";
            this.checkBoxWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxWednesday.UseVisualStyleBackColor = true;
            this.checkBoxWednesday.CheckedChanged += new System.EventHandler(this.checkBoxWednesday_CheckedChanged);
            // 
            // checkBoxThursday
            // 
            this.checkBoxThursday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxThursday.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxThursday.AutoSize = true;
            this.checkBoxThursday.Location = new System.Drawing.Point(150, 0);
            this.checkBoxThursday.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxThursday.Name = "checkBoxThursday";
            this.checkBoxThursday.Size = new System.Drawing.Size(50, 25);
            this.checkBoxThursday.TabIndex = 3;
            this.checkBoxThursday.Text = "Do";
            this.checkBoxThursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxThursday.UseVisualStyleBackColor = true;
            this.checkBoxThursday.CheckedChanged += new System.EventHandler(this.checkBoxThursday_CheckedChanged);
            // 
            // checkBoxFriday
            // 
            this.checkBoxFriday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFriday.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxFriday.AutoSize = true;
            this.checkBoxFriday.Location = new System.Drawing.Point(200, 0);
            this.checkBoxFriday.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxFriday.Name = "checkBoxFriday";
            this.checkBoxFriday.Size = new System.Drawing.Size(50, 25);
            this.checkBoxFriday.TabIndex = 4;
            this.checkBoxFriday.Text = "Fr";
            this.checkBoxFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxFriday.UseVisualStyleBackColor = true;
            this.checkBoxFriday.CheckedChanged += new System.EventHandler(this.checkBoxFriday_CheckedChanged);
            // 
            // checkBoxSaturday
            // 
            this.checkBoxSaturday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSaturday.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxSaturday.AutoSize = true;
            this.checkBoxSaturday.Location = new System.Drawing.Point(250, 0);
            this.checkBoxSaturday.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSaturday.Name = "checkBoxSaturday";
            this.checkBoxSaturday.Size = new System.Drawing.Size(50, 25);
            this.checkBoxSaturday.TabIndex = 5;
            this.checkBoxSaturday.Text = "Sa";
            this.checkBoxSaturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSaturday.UseVisualStyleBackColor = true;
            this.checkBoxSaturday.CheckedChanged += new System.EventHandler(this.checkBoxSaturday_CheckedChanged);
            // 
            // checkBoxSunday
            // 
            this.checkBoxSunday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSunday.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxSunday.AutoSize = true;
            this.checkBoxSunday.Location = new System.Drawing.Point(300, 0);
            this.checkBoxSunday.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSunday.Name = "checkBoxSunday";
            this.checkBoxSunday.Size = new System.Drawing.Size(53, 25);
            this.checkBoxSunday.TabIndex = 6;
            this.checkBoxSunday.Text = "So";
            this.checkBoxSunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSunday.UseVisualStyleBackColor = true;
            this.checkBoxSunday.CheckedChanged += new System.EventHandler(this.checkBoxSunday_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.buttonAddGroup);
            this.Controls.Add(this.buttonDeleteGroup);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAddProcess);
            this.Controls.Add(this.buttonRemoveProcess);
            this.Controls.Add(this.listBoxRunningProcesses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxProcesses);
            this.Controls.Add(this.textBoxMaxPlaytime);
            this.Controls.Add(this.labelMaxPlaytime);
            this.Controls.Add(this.checkBoxTimeRollover);
            this.Controls.Add(this.labelTimeRollover);
            this.Controls.Add(this.textBoxDailyPlaytime);
            this.Controls.Add(this.labelDailyPlaytime);
            this.Controls.Add(this.textBoxLeftoverTime);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelLeftoverTime);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelRules);
            this.Controls.Add(this.listBoxRules);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Chilco";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRules;
        private System.Windows.Forms.Label labelRules;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLeftoverTime;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxLeftoverTime;
        private System.Windows.Forms.TextBox textBoxDailyPlaytime;
        private System.Windows.Forms.Label labelDailyPlaytime;
        private System.Windows.Forms.Label labelTimeRollover;
        private System.Windows.Forms.CheckBox checkBoxTimeRollover;
        private System.Windows.Forms.TextBox textBoxMaxPlaytime;
        private System.Windows.Forms.Label labelMaxPlaytime;
        private System.Windows.Forms.ListBox listBoxProcesses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxRunningProcesses;
        private System.Windows.Forms.Button buttonRemoveProcess;
        private System.Windows.Forms.Button buttonAddProcess;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDeleteGroup;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxModay;
        private System.Windows.Forms.CheckBox checkBoxSunday;
        private System.Windows.Forms.CheckBox checkBoxSaturday;
        private System.Windows.Forms.CheckBox checkBoxFriday;
        private System.Windows.Forms.CheckBox checkBoxThursday;
        private System.Windows.Forms.CheckBox checkBoxWednesday;
        private System.Windows.Forms.CheckBox checkBoxTuesday;
    }
}

