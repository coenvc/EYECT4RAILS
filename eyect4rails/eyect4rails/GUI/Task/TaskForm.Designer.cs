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
            this.lbTaskList = new System.Windows.Forms.ListBox();
            this.btnGetHistoryTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnFinishTask = new System.Windows.Forms.Button();
            this.lblNameTask = new System.Windows.Forms.Label();
            this.lblDateTask = new System.Windows.Forms.Label();
            this.lblTramnrTask = new System.Windows.Forms.Label();
            this.tbNameTask = new System.Windows.Forms.TextBox();
            this.tbTramnrTask = new System.Windows.Forms.TextBox();
            this.tbDateTask = new System.Windows.Forms.TextBox();
            this.cbRepairTask = new System.Windows.Forms.CheckBox();
            this.cbMaintenanceTask = new System.Windows.Forms.CheckBox();
            this.lblTypeTask = new System.Windows.Forms.Label();
            this.lbTaskHistory = new System.Windows.Forms.ListBox();
            this.pbLogoTask = new System.Windows.Forms.PictureBox();
            this.lblErrorTask = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTask)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTaskList
            // 
            this.lbTaskList.FormattingEnabled = true;
            this.lbTaskList.Location = new System.Drawing.Point(12, 191);
            this.lbTaskList.Name = "lbTaskList";
            this.lbTaskList.Size = new System.Drawing.Size(218, 277);
            this.lbTaskList.TabIndex = 0;
            // 
            // btnGetHistoryTask
            // 
            this.btnGetHistoryTask.Location = new System.Drawing.Point(236, 162);
            this.btnGetHistoryTask.Name = "btnGetHistoryTask";
            this.btnGetHistoryTask.Size = new System.Drawing.Size(218, 23);
            this.btnGetHistoryTask.TabIndex = 1;
            this.btnGetHistoryTask.Text = "Geschiedenis Ophalen";
            this.btnGetHistoryTask.UseVisualStyleBackColor = true;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(12, 162);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(113, 23);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "Toevoegen";
            this.btnAddTask.UseVisualStyleBackColor = true;
            // 
            // btnFinishTask
            // 
            this.btnFinishTask.Location = new System.Drawing.Point(131, 162);
            this.btnFinishTask.Name = "btnFinishTask";
            this.btnFinishTask.Size = new System.Drawing.Size(99, 23);
            this.btnFinishTask.TabIndex = 2;
            this.btnFinishTask.Text = "Afronden";
            this.btnFinishTask.UseVisualStyleBackColor = true;
            // 
            // lblNameTask
            // 
            this.lblNameTask.AutoSize = true;
            this.lblNameTask.Location = new System.Drawing.Point(12, 31);
            this.lblNameTask.Name = "lblNameTask";
            this.lblNameTask.Size = new System.Drawing.Size(35, 13);
            this.lblNameTask.TabIndex = 3;
            this.lblNameTask.Text = "Naam";
            // 
            // lblDateTask
            // 
            this.lblDateTask.AutoSize = true;
            this.lblDateTask.Location = new System.Drawing.Point(12, 101);
            this.lblDateTask.Name = "lblDateTask";
            this.lblDateTask.Size = new System.Drawing.Size(38, 13);
            this.lblDateTask.TabIndex = 3;
            this.lblDateTask.Text = "Datum";
            // 
            // lblTramnrTask
            // 
            this.lblTramnrTask.AutoSize = true;
            this.lblTramnrTask.Location = new System.Drawing.Point(12, 66);
            this.lblTramnrTask.Name = "lblTramnrTask";
            this.lblTramnrTask.Size = new System.Drawing.Size(40, 13);
            this.lblTramnrTask.TabIndex = 3;
            this.lblTramnrTask.Text = "Tramnr";
            // 
            // tbNameTask
            // 
            this.tbNameTask.Location = new System.Drawing.Point(73, 28);
            this.tbNameTask.Name = "tbNameTask";
            this.tbNameTask.Size = new System.Drawing.Size(157, 20);
            this.tbNameTask.TabIndex = 4;
            // 
            // tbTramnrTask
            // 
            this.tbTramnrTask.Location = new System.Drawing.Point(73, 63);
            this.tbTramnrTask.Name = "tbTramnrTask";
            this.tbTramnrTask.Size = new System.Drawing.Size(157, 20);
            this.tbTramnrTask.TabIndex = 4;
            // 
            // tbDateTask
            // 
            this.tbDateTask.Location = new System.Drawing.Point(73, 98);
            this.tbDateTask.Name = "tbDateTask";
            this.tbDateTask.Size = new System.Drawing.Size(157, 20);
            this.tbDateTask.TabIndex = 4;
            // 
            // cbRepairTask
            // 
            this.cbRepairTask.AutoSize = true;
            this.cbRepairTask.Location = new System.Drawing.Point(73, 135);
            this.cbRepairTask.Name = "cbRepairTask";
            this.cbRepairTask.Size = new System.Drawing.Size(72, 17);
            this.cbRepairTask.TabIndex = 6;
            this.cbRepairTask.Text = "Reparatie";
            this.cbRepairTask.UseVisualStyleBackColor = true;
            // 
            // cbMaintenanceTask
            // 
            this.cbMaintenanceTask.AutoSize = true;
            this.cbMaintenanceTask.Location = new System.Drawing.Point(151, 136);
            this.cbMaintenanceTask.Name = "cbMaintenanceTask";
            this.cbMaintenanceTask.Size = new System.Drawing.Size(79, 17);
            this.cbMaintenanceTask.TabIndex = 6;
            this.cbMaintenanceTask.Text = "Onderhoud";
            this.cbMaintenanceTask.UseVisualStyleBackColor = true;
            // 
            // lblTypeTask
            // 
            this.lblTypeTask.AutoSize = true;
            this.lblTypeTask.Location = new System.Drawing.Point(12, 136);
            this.lblTypeTask.Name = "lblTypeTask";
            this.lblTypeTask.Size = new System.Drawing.Size(31, 13);
            this.lblTypeTask.TabIndex = 3;
            this.lblTypeTask.Text = "Type";
            // 
            // lbTaskHistory
            // 
            this.lbTaskHistory.FormattingEnabled = true;
            this.lbTaskHistory.Location = new System.Drawing.Point(236, 191);
            this.lbTaskHistory.Name = "lbTaskHistory";
            this.lbTaskHistory.Size = new System.Drawing.Size(218, 277);
            this.lbTaskHistory.TabIndex = 0;
            // 
            // pbLogoTask
            // 
            this.pbLogoTask.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoTask.Image")));
            this.pbLogoTask.Location = new System.Drawing.Point(236, 12);
            this.pbLogoTask.Name = "pbLogoTask";
            this.pbLogoTask.Size = new System.Drawing.Size(218, 137);
            this.pbLogoTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoTask.TabIndex = 7;
            this.pbLogoTask.TabStop = false;
            // 
            // lblErrorTask
            // 
            this.lblErrorTask.AutoSize = true;
            this.lblErrorTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTask.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTask.Location = new System.Drawing.Point(12, 482);
            this.lblErrorTask.Name = "lblErrorTask";
            this.lblErrorTask.Size = new System.Drawing.Size(105, 16);
            this.lblErrorTask.TabIndex = 8;
            this.lblErrorTask.Text = "FOUTMELDING";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 505);
            this.Controls.Add(this.lblErrorTask);
            this.Controls.Add(this.pbLogoTask);
            this.Controls.Add(this.cbMaintenanceTask);
            this.Controls.Add(this.cbRepairTask);
            this.Controls.Add(this.tbDateTask);
            this.Controls.Add(this.tbTramnrTask);
            this.Controls.Add(this.tbNameTask);
            this.Controls.Add(this.lblTypeTask);
            this.Controls.Add(this.lblDateTask);
            this.Controls.Add(this.lblTramnrTask);
            this.Controls.Add(this.lblNameTask);
            this.Controls.Add(this.btnFinishTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnGetHistoryTask);
            this.Controls.Add(this.lbTaskHistory);
            this.Controls.Add(this.lbTaskList);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTaskList;
        private System.Windows.Forms.Button btnGetHistoryTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnFinishTask;
        private System.Windows.Forms.Label lblNameTask;
        private System.Windows.Forms.Label lblDateTask;
        private System.Windows.Forms.Label lblTramnrTask;
        private System.Windows.Forms.TextBox tbNameTask;
        private System.Windows.Forms.TextBox tbTramnrTask;
        private System.Windows.Forms.TextBox tbDateTask;
        private System.Windows.Forms.CheckBox cbRepairTask;
        private System.Windows.Forms.CheckBox cbMaintenanceTask;
        private System.Windows.Forms.Label lblTypeTask;
        private System.Windows.Forms.ListBox lbTaskHistory;
        private System.Windows.Forms.PictureBox pbLogoTask;
        private System.Windows.Forms.Label lblErrorTask;
    }
}