namespace eyect4rails
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.rbRepairGroot = new System.Windows.Forms.RadioButton();
            this.rbRepairKlein = new System.Windows.Forms.RadioButton();
            this.rbRepair = new System.Windows.Forms.RadioButton();
            this.rbService = new System.Windows.Forms.RadioButton();
            this.pbTaskLogo = new System.Windows.Forms.PictureBox();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.lblSizeTypeTask = new System.Windows.Forms.Label();
            this.tbTaskDate = new System.Windows.Forms.TextBox();
            this.lblTaskDate = new System.Windows.Forms.Label();
            this.lblTaskTram = new System.Windows.Forms.Label();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnHistoryTask = new System.Windows.Forms.Button();
            this.lbTaskHistory = new System.Windows.Forms.ListBox();
            this.lbTasklist = new System.Windows.Forms.ListBox();
            this.cbTramTask = new System.Windows.Forms.ComboBox();
            this.btnFinishTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.lblErrorTask = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaskLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // rbRepairGroot
            // 
            this.rbRepairGroot.AutoSize = true;
            this.rbRepairGroot.Location = new System.Drawing.Point(175, 128);
            this.rbRepairGroot.Name = "rbRepairGroot";
            this.rbRepairGroot.Size = new System.Drawing.Size(51, 17);
            this.rbRepairGroot.TabIndex = 22;
            this.rbRepairGroot.TabStop = true;
            this.rbRepairGroot.Text = "Groot";
            this.rbRepairGroot.UseVisualStyleBackColor = true;
            // 
            // rbRepairKlein
            // 
            this.rbRepairKlein.AutoSize = true;
            this.rbRepairKlein.Location = new System.Drawing.Point(90, 128);
            this.rbRepairKlein.Name = "rbRepairKlein";
            this.rbRepairKlein.Size = new System.Drawing.Size(48, 17);
            this.rbRepairKlein.TabIndex = 21;
            this.rbRepairKlein.TabStop = true;
            this.rbRepairKlein.Text = "Klein";
            this.rbRepairKlein.UseVisualStyleBackColor = true;
            // 
            // rbRepair
            // 
            this.rbRepair.AutoSize = true;
            this.rbRepair.Location = new System.Drawing.Point(175, 157);
            this.rbRepair.Name = "rbRepair";
            this.rbRepair.Size = new System.Drawing.Size(71, 17);
            this.rbRepair.TabIndex = 20;
            this.rbRepair.TabStop = true;
            this.rbRepair.Text = "Reparatie";
            this.rbRepair.UseVisualStyleBackColor = true;
            // 
            // rbService
            // 
            this.rbService.AutoSize = true;
            this.rbService.Location = new System.Drawing.Point(90, 157);
            this.rbService.Name = "rbService";
            this.rbService.Size = new System.Drawing.Size(61, 17);
            this.rbService.TabIndex = 19;
            this.rbService.TabStop = true;
            this.rbService.Text = "Service";
            this.rbService.UseVisualStyleBackColor = true;
            // 
            // pbTaskLogo
            // 
            this.pbTaskLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbTaskLogo.Image")));
            this.pbTaskLogo.Location = new System.Drawing.Point(245, 12);
            this.pbTaskLogo.Name = "pbTaskLogo";
            this.pbTaskLogo.Size = new System.Drawing.Size(259, 131);
            this.pbTaskLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTaskLogo.TabIndex = 18;
            this.pbTaskLogo.TabStop = false;
            // 
            // lblTaskType
            // 
            this.lblTaskType.AutoSize = true;
            this.lblTaskType.Location = new System.Drawing.Point(8, 157);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(80, 13);
            this.lblTaskType.TabIndex = 13;
            this.lblTaskType.Text = "Onderhoudtype";
            // 
            // lblSizeTypeTask
            // 
            this.lblSizeTypeTask.AutoSize = true;
            this.lblSizeTypeTask.Location = new System.Drawing.Point(8, 130);
            this.lblSizeTypeTask.Name = "lblSizeTypeTask";
            this.lblSizeTypeTask.Size = new System.Drawing.Size(59, 13);
            this.lblSizeTypeTask.TabIndex = 14;
            this.lblSizeTypeTask.Text = "Type Beurt";
            // 
            // tbTaskDate
            // 
            this.tbTaskDate.Location = new System.Drawing.Point(87, 95);
            this.tbTaskDate.Name = "tbTaskDate";
            this.tbTaskDate.Size = new System.Drawing.Size(159, 20);
            this.tbTaskDate.TabIndex = 15;
            // 
            // lblTaskDate
            // 
            this.lblTaskDate.AutoSize = true;
            this.lblTaskDate.Location = new System.Drawing.Point(8, 98);
            this.lblTaskDate.Name = "lblTaskDate";
            this.lblTaskDate.Size = new System.Drawing.Size(38, 13);
            this.lblTaskDate.TabIndex = 12;
            this.lblTaskDate.Text = "Datum";
            // 
            // lblTaskTram
            // 
            this.lblTaskTram.AutoSize = true;
            this.lblTaskTram.Location = new System.Drawing.Point(8, 62);
            this.lblTaskTram.Name = "lblTaskTram";
            this.lblTaskTram.Size = new System.Drawing.Size(31, 13);
            this.lblTaskTram.TabIndex = 11;
            this.lblTaskTram.Text = "Tram";
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Location = new System.Drawing.Point(87, 25);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(159, 20);
            this.tbEmployeeName.TabIndex = 17;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(8, 28);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(66, 13);
            this.lblEmployee.TabIndex = 10;
            this.lblEmployee.Text = "Medewerker";
            // 
            // btnHistoryTask
            // 
            this.btnHistoryTask.Location = new System.Drawing.Point(251, 195);
            this.btnHistoryTask.Name = "btnHistoryTask";
            this.btnHistoryTask.Size = new System.Drawing.Size(235, 23);
            this.btnHistoryTask.TabIndex = 9;
            this.btnHistoryTask.Text = "Toon Geschiedenis";
            this.btnHistoryTask.UseVisualStyleBackColor = true;
            // 
            // lbTaskHistory
            // 
            this.lbTaskHistory.FormattingEnabled = true;
            this.lbTaskHistory.Location = new System.Drawing.Point(252, 224);
            this.lbTaskHistory.Name = "lbTaskHistory";
            this.lbTaskHistory.Size = new System.Drawing.Size(234, 225);
            this.lbTaskHistory.TabIndex = 7;
            // 
            // lbTasklist
            // 
            this.lbTasklist.FormattingEnabled = true;
            this.lbTasklist.Location = new System.Drawing.Point(12, 224);
            this.lbTasklist.Name = "lbTasklist";
            this.lbTasklist.Size = new System.Drawing.Size(234, 225);
            this.lbTasklist.TabIndex = 6;
            // 
            // cbTramTask
            // 
            this.cbTramTask.FormattingEnabled = true;
            this.cbTramTask.Location = new System.Drawing.Point(87, 59);
            this.cbTramTask.Name = "cbTramTask";
            this.cbTramTask.Size = new System.Drawing.Size(159, 21);
            this.cbTramTask.TabIndex = 23;
            // 
            // btnFinishTask
            // 
            this.btnFinishTask.Location = new System.Drawing.Point(133, 195);
            this.btnFinishTask.Name = "btnFinishTask";
            this.btnFinishTask.Size = new System.Drawing.Size(113, 23);
            this.btnFinishTask.TabIndex = 24;
            this.btnFinishTask.Text = "Afronden";
            this.btnFinishTask.UseVisualStyleBackColor = true;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(11, 195);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(113, 23);
            this.btnAddTask.TabIndex = 25;
            this.btnAddTask.Text = "Toevoegen";
            this.btnAddTask.UseVisualStyleBackColor = true;
            // 
            // lblErrorTask
            // 
            this.lblErrorTask.AutoSize = true;
            this.lblErrorTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTask.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTask.Location = new System.Drawing.Point(252, 158);
            this.lblErrorTask.Name = "lblErrorTask";
            this.lblErrorTask.Size = new System.Drawing.Size(104, 16);
            this.lblErrorTask.TabIndex = 26;
            this.lblErrorTask.Text = "FOUTBERICHT";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 461);
            this.Controls.Add(this.lblErrorTask);
            this.Controls.Add(this.btnFinishTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.cbTramTask);
            this.Controls.Add(this.rbRepairGroot);
            this.Controls.Add(this.rbRepairKlein);
            this.Controls.Add(this.rbRepair);
            this.Controls.Add(this.rbService);
            this.Controls.Add(this.pbTaskLogo);
            this.Controls.Add(this.lblTaskType);
            this.Controls.Add(this.lblSizeTypeTask);
            this.Controls.Add(this.tbTaskDate);
            this.Controls.Add(this.lblTaskDate);
            this.Controls.Add(this.lblTaskTram);
            this.Controls.Add(this.tbEmployeeName);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.btnHistoryTask);
            this.Controls.Add(this.lbTaskHistory);
            this.Controls.Add(this.lbTasklist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskForm";
            this.Text = "TaskSysteem";
            ((System.ComponentModel.ISupportInitialize)(this.pbTaskLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbRepairGroot;
        private System.Windows.Forms.RadioButton rbRepairKlein;
        private System.Windows.Forms.RadioButton rbRepair;
        private System.Windows.Forms.RadioButton rbService;
        private System.Windows.Forms.PictureBox pbTaskLogo;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.Label lblSizeTypeTask;
        private System.Windows.Forms.TextBox tbTaskDate;
        private System.Windows.Forms.Label lblTaskDate;
        private System.Windows.Forms.Label lblTaskTram;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnHistoryTask;
        private System.Windows.Forms.ListBox lbTaskHistory;
        private System.Windows.Forms.ListBox lbTasklist;
        private System.Windows.Forms.ComboBox cbTramTask;
        private System.Windows.Forms.Button btnFinishTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label lblErrorTask;
    }
}