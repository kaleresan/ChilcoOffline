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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDeleteGroup = new System.Windows.Forms.Button();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.labelGroup = new System.Windows.Forms.Label();
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
            this.textBoxTitle.Size = new System.Drawing.Size(111, 22);
            this.textBoxTitle.TabIndex = 4;
            // 
            // textBoxLeftoverTime
            // 
            this.textBoxLeftoverTime.Location = new System.Drawing.Point(367, 79);
            this.textBoxLeftoverTime.Name = "textBoxLeftoverTime";
            this.textBoxLeftoverTime.Size = new System.Drawing.Size(111, 22);
            this.textBoxLeftoverTime.TabIndex = 5;
            // 
            // textBoxDailyPlaytime
            // 
            this.textBoxDailyPlaytime.Location = new System.Drawing.Point(367, 107);
            this.textBoxDailyPlaytime.Name = "textBoxDailyPlaytime";
            this.textBoxDailyPlaytime.Size = new System.Drawing.Size(111, 22);
            this.textBoxDailyPlaytime.TabIndex = 7;
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
            this.checkBoxTimeRollover.Size = new System.Drawing.Size(111, 22);
            this.checkBoxTimeRollover.TabIndex = 10;
            this.checkBoxTimeRollover.Text = "Nein";
            this.checkBoxTimeRollover.UseVisualStyleBackColor = true;
            this.checkBoxTimeRollover.CheckedChanged += new System.EventHandler(this.checkBoxTimeRollover_CheckedChanged);
            // 
            // textBoxMaxPlaytime
            // 
            this.textBoxMaxPlaytime.Location = new System.Drawing.Point(367, 166);
            this.textBoxMaxPlaytime.Name = "textBoxMaxPlaytime";
            this.textBoxMaxPlaytime.Size = new System.Drawing.Size(111, 22);
            this.textBoxMaxPlaytime.TabIndex = 12;
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
            this.listBoxProcesses.Location = new System.Drawing.Point(240, 226);
            this.listBoxProcesses.Name = "listBoxProcesses";
            this.listBoxProcesses.Size = new System.Drawing.Size(238, 164);
            this.listBoxProcesses.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "laufende Prozesse";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 206);
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
            this.listBoxRunningProcesses.Location = new System.Drawing.Point(510, 50);
            this.listBoxRunningProcesses.Name = "listBoxRunningProcesses";
            this.listBoxRunningProcesses.Size = new System.Drawing.Size(236, 308);
            this.listBoxRunningProcesses.TabIndex = 16;
            // 
            // buttonRemoveProcess
            // 
            this.buttonRemoveProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveProcess.Location = new System.Drawing.Point(240, 396);
            this.buttonRemoveProcess.Name = "buttonRemoveProcess";
            this.buttonRemoveProcess.Size = new System.Drawing.Size(238, 26);
            this.buttonRemoveProcess.TabIndex = 17;
            this.buttonRemoveProcess.Text = "Prozess entfernen";
            this.buttonRemoveProcess.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(510, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 26);
            this.button2.TabIndex = 18;
            this.button2.Text = "Prozess hinzufügen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Location = new System.Drawing.Point(510, 364);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(236, 26);
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
            // 
            // labelGroup
            // 
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(258, 15);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(200, 30);
            this.labelGroup.TabIndex = 23;
            this.labelGroup.Text = "Regel";
            this.labelGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 461);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.buttonAddGroup);
            this.Controls.Add(this.buttonDeleteGroup);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.button2);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDeleteGroup;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Label labelGroup;
    }
}

