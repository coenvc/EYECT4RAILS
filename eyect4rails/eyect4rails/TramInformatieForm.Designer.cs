namespace eyect4rails
{
    partial class TramInformatieForm
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
            this.tbTramnumber = new System.Windows.Forms.TextBox();
            this.tbLine = new System.Windows.Forms.TextBox();
            this.tbTramtype = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbTrack = new System.Windows.Forms.TextBox();
            this.lbInformation = new System.Windows.Forms.ListBox();
            this.btnInformation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTramnumber
            // 
            this.tbTramnumber.BackColor = System.Drawing.SystemColors.Control;
            this.tbTramnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTramnumber.Location = new System.Drawing.Point(15, 25);
            this.tbTramnumber.Name = "tbTramnumber";
            this.tbTramnumber.Size = new System.Drawing.Size(54, 20);
            this.tbTramnumber.TabIndex = 0;
            // 
            // tbLine
            // 
            this.tbLine.BackColor = System.Drawing.SystemColors.Control;
            this.tbLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLine.Location = new System.Drawing.Point(110, 25);
            this.tbLine.Name = "tbLine";
            this.tbLine.Size = new System.Drawing.Size(46, 20);
            this.tbLine.TabIndex = 1;
            // 
            // tbTramtype
            // 
            this.tbTramtype.BackColor = System.Drawing.SystemColors.Control;
            this.tbTramtype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTramtype.Location = new System.Drawing.Point(197, 25);
            this.tbTramtype.Name = "tbTramtype";
            this.tbTramtype.Size = new System.Drawing.Size(92, 20);
            this.tbTramtype.TabIndex = 2;
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.SystemColors.Control;
            this.tbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStatus.Location = new System.Drawing.Point(330, 25);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(71, 20);
            this.tbStatus.TabIndex = 3;
            // 
            // tbTrack
            // 
            this.tbTrack.BackColor = System.Drawing.SystemColors.Control;
            this.tbTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTrack.Location = new System.Drawing.Point(441, 25);
            this.tbTrack.Name = "tbTrack";
            this.tbTrack.Size = new System.Drawing.Size(46, 20);
            this.tbTrack.TabIndex = 4;
            // 
            // lbInformation
            // 
            this.lbInformation.FormattingEnabled = true;
            this.lbInformation.Location = new System.Drawing.Point(12, 51);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(642, 303);
            this.lbInformation.TabIndex = 5;
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(543, 12);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(111, 33);
            this.btnInformation.TabIndex = 6;
            this.btnInformation.Text = "Weergeef info";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnWeergeefInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tramnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lijn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tramtype";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Spoor";
            // 
            // TramInformatieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.tbTrack);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbTramtype);
            this.Controls.Add(this.tbLine);
            this.Controls.Add(this.tbTramnumber);
            this.Name = "TramInformatieForm";
            this.Text = "Tram Informatie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTramnumber;
        private System.Windows.Forms.TextBox tbLine;
        private System.Windows.Forms.TextBox tbTramtype;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbTrack;
        private System.Windows.Forms.ListBox lbInformation;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}