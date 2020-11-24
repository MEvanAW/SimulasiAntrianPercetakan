namespace SimulasiAntrianPercetakan
{
    partial class FormBerkasTercetak
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.berkasTercetakGroupBox = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            this.berkasTercetakLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.berkasTercetakGroupBox.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.berkasTercetakGroupBox);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 431);
            this.panel1.TabIndex = 1;
            // 
            // berkasTercetakGroupBox
            // 
            this.berkasTercetakGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.berkasTercetakGroupBox.Controls.Add(this.panel);
            this.berkasTercetakGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Underline);
            this.berkasTercetakGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.berkasTercetakGroupBox.Location = new System.Drawing.Point(13, 15);
            this.berkasTercetakGroupBox.Name = "berkasTercetakGroupBox";
            this.berkasTercetakGroupBox.Size = new System.Drawing.Size(319, 399);
            this.berkasTercetakGroupBox.TabIndex = 13;
            this.berkasTercetakGroupBox.TabStop = false;
            this.berkasTercetakGroupBox.Text = "Berkas Tercetak";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.berkasTercetakLabel);
            this.panel.Location = new System.Drawing.Point(0, 41);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(319, 358);
            this.panel.TabIndex = 1;
            // 
            // berkasTercetakLabel
            // 
            this.berkasTercetakLabel.AutoSize = true;
            this.berkasTercetakLabel.Font = new System.Drawing.Font("Calibri", 11F);
            this.berkasTercetakLabel.Location = new System.Drawing.Point(1, 1);
            this.berkasTercetakLabel.Name = "berkasTercetakLabel";
            this.berkasTercetakLabel.Size = new System.Drawing.Size(197, 27);
            this.berkasTercetakLabel.TabIndex = 0;
            this.berkasTercetakLabel.Text = "berkasTercetakLabel";
            // 
            // FormBerkasTercetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormBerkasTercetak";
            this.Text = "Form Berkas Tercetak";
            this.panel1.ResumeLayout(false);
            this.berkasTercetakGroupBox.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox berkasTercetakGroupBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label berkasTercetakLabel;
    }
}