namespace eyect4rails
{
    partial class VeranderStatusSpoorForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.tbSectornumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSpoornumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(204, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 47);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.Location = new System.Drawing.Point(12, 125);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(92, 47);
            this.btnToggle.TabIndex = 20;
            this.btnToggle.Text = "Toggle";
            this.btnToggle.UseVisualStyleBackColor = true;
            // 
            // tbSectornumber
            // 
            this.tbSectornumber.BackColor = System.Drawing.SystemColors.Control;
            this.tbSectornumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSectornumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSectornumber.Location = new System.Drawing.Point(196, 72);
            this.tbSectornumber.Name = "tbSectornumber";
            this.tbSectornumber.Size = new System.Drawing.Size(100, 26);
            this.tbSectornumber.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sectornummer:";
            // 
            // tbSpoornumber
            // 
            this.tbSpoornumber.BackColor = System.Drawing.SystemColors.Control;
            this.tbSpoornumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSpoornumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpoornumber.Location = new System.Drawing.Point(196, 7);
            this.tbSpoornumber.Name = "tbSpoornumber";
            this.tbSpoornumber.Size = new System.Drawing.Size(100, 26);
            this.tbSpoornumber.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Spoornummer:";
            // 
            // VeranderStatusSpoorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 184);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.tbSectornumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSpoornumber);
            this.Controls.Add(this.label2);
            this.Name = "VeranderStatusSpoorForm";
            this.Text = "Verander de status van een spoor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.TextBox tbSectornumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSpoornumber;
        private System.Windows.Forms.Label label2;
    }
}