﻿namespace SimulasiAntrianPercetakan
{
    partial class FormAntrian
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
            this.mulaiMencetakButton = new System.Windows.Forms.Button();
            this.berhentiMencetakButton = new System.Windows.Forms.Button();
            this.antrianBiasaGroupBox = new System.Windows.Forms.GroupBox();
            this.antrianEkspresGroupBox = new System.Windows.Forms.GroupBox();
            this.sedangDicetakGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.sedangDicetakGroupBox);
            this.panel1.Controls.Add(this.antrianEkspresGroupBox);
            this.panel1.Controls.Add(this.antrianBiasaGroupBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 385);
            this.panel1.TabIndex = 0;
            // 
            // mulaiMencetakButton
            // 
            this.mulaiMencetakButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.mulaiMencetakButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mulaiMencetakButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.mulaiMencetakButton.FlatAppearance.BorderSize = 0;
            this.mulaiMencetakButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mulaiMencetakButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulaiMencetakButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.mulaiMencetakButton.Location = new System.Drawing.Point(157, 403);
            this.mulaiMencetakButton.Name = "mulaiMencetakButton";
            this.mulaiMencetakButton.Size = new System.Drawing.Size(238, 45);
            this.mulaiMencetakButton.TabIndex = 6;
            this.mulaiMencetakButton.Text = "Mulai Mencetak";
            this.mulaiMencetakButton.UseVisualStyleBackColor = false;
            // 
            // berhentiMencetakButton
            // 
            this.berhentiMencetakButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.berhentiMencetakButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.berhentiMencetakButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.berhentiMencetakButton.FlatAppearance.BorderSize = 0;
            this.berhentiMencetakButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.berhentiMencetakButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.berhentiMencetakButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.berhentiMencetakButton.Location = new System.Drawing.Point(401, 403);
            this.berhentiMencetakButton.Name = "berhentiMencetakButton";
            this.berhentiMencetakButton.Size = new System.Drawing.Size(238, 45);
            this.berhentiMencetakButton.TabIndex = 7;
            this.berhentiMencetakButton.Text = "Berhenti Mencetak";
            this.berhentiMencetakButton.UseVisualStyleBackColor = false;
            // 
            // antrianBiasaGroupBox
            // 
            this.antrianBiasaGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.antrianBiasaGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Underline);
            this.antrianBiasaGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.antrianBiasaGroupBox.Location = new System.Drawing.Point(12, 14);
            this.antrianBiasaGroupBox.Name = "antrianBiasaGroupBox";
            this.antrianBiasaGroupBox.Size = new System.Drawing.Size(245, 354);
            this.antrianBiasaGroupBox.TabIndex = 12;
            this.antrianBiasaGroupBox.TabStop = false;
            this.antrianBiasaGroupBox.Text = "Antrian Biasa";
            // 
            // antrianEkspresGroupBox
            // 
            this.antrianEkspresGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.antrianEkspresGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Underline);
            this.antrianEkspresGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.antrianEkspresGroupBox.Location = new System.Drawing.Point(266, 15);
            this.antrianEkspresGroupBox.Name = "antrianEkspresGroupBox";
            this.antrianEkspresGroupBox.Size = new System.Drawing.Size(245, 354);
            this.antrianEkspresGroupBox.TabIndex = 13;
            this.antrianEkspresGroupBox.TabStop = false;
            this.antrianEkspresGroupBox.Text = "Antrian Ekspres";
            // 
            // sedangDicetakGroupBox
            // 
            this.sedangDicetakGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.sedangDicetakGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Underline);
            this.sedangDicetakGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.sedangDicetakGroupBox.Location = new System.Drawing.Point(520, 14);
            this.sedangDicetakGroupBox.Name = "sedangDicetakGroupBox";
            this.sedangDicetakGroupBox.Size = new System.Drawing.Size(245, 354);
            this.sedangDicetakGroupBox.TabIndex = 14;
            this.sedangDicetakGroupBox.TabStop = false;
            this.sedangDicetakGroupBox.Text = "Sedang Dicetak";
            // 
            // FormAntrian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.berhentiMencetakButton);
            this.Controls.Add(this.mulaiMencetakButton);
            this.Controls.Add(this.panel1);
            this.Name = "FormAntrian";
            this.Text = "Form Antrian";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mulaiMencetakButton;
        private System.Windows.Forms.Button berhentiMencetakButton;
        private System.Windows.Forms.GroupBox sedangDicetakGroupBox;
        private System.Windows.Forms.GroupBox antrianEkspresGroupBox;
        private System.Windows.Forms.GroupBox antrianBiasaGroupBox;
    }
}