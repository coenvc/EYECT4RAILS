namespace eyect4rails
{
    partial class SpoorInformatieForm
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
            this.tbTrack = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInformation = new System.Windows.Forms.Button();
            this.lbInformation = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbTrack
            // 
            this.tbTrack.BackColor = System.Drawing.SystemColors.Control;
            this.tbTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTrack.Location = new System.Drawing.Point(15, 25);
            this.tbTrack.Name = "tbTrack";
            this.tbTrack.Size = new System.Drawing.Size(46, 20);
            this.tbTrack.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Spoor";
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(224, 12);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(111, 33);
            this.btnInformation.TabIndex = 13;
            this.btnInformation.Text = "Weergeef info";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnWeergeefInfo_Click);
            // 
            // lbInformation
            // 
            this.lbInformation.FormattingEnabled = true;
            this.lbInformation.Location = new System.Drawing.Point(15, 51);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(320, 264);
            this.lbInformation.TabIndex = 14;
            // 
            // SpoorInformatieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 324);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTrack);
            this.Name = "SpoorInformatieForm";
            this.Text = "Spoor Informatie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTrack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.ListBox lbInformation;
    }
}