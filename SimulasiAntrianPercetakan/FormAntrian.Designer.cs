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
            this.akanDicetakGroupBox = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.baruSajaDicetakLabel = new System.Windows.Forms.Label();
            this.cetakButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.akanDicetakLabel = new System.Windows.Forms.Label();
            this.antrianEkspresGroupBox = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.antrianEkspresLabel = new System.Windows.Forms.Label();
            this.antrianBiasaGroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.antrianBiasaLabel = new System.Windows.Forms.Label();
            this.mulaiMencetakButton = new System.Windows.Forms.Button();
            this.berhentiMencetakButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.akanDicetakGroupBox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.antrianEkspresGroupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.antrianBiasaGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.akanDicetakGroupBox);
            this.panel1.Controls.Add(this.antrianEkspresGroupBox);
            this.panel1.Controls.Add(this.antrianBiasaGroupBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 385);
            this.panel1.TabIndex = 0;
            // 
            // akanDicetakGroupBox
            // 
            this.akanDicetakGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.akanDicetakGroupBox.Controls.Add(this.panel4);
            this.akanDicetakGroupBox.Controls.Add(this.cetakButton);
            this.akanDicetakGroupBox.Controls.Add(this.label1);
            this.akanDicetakGroupBox.Controls.Add(this.akanDicetakLabel);
            this.akanDicetakGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Underline);
            this.akanDicetakGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.akanDicetakGroupBox.Location = new System.Drawing.Point(652, 14);
            this.akanDicetakGroupBox.Name = "akanDicetakGroupBox";
            this.akanDicetakGroupBox.Size = new System.Drawing.Size(307, 354);
            this.akanDicetakGroupBox.TabIndex = 14;
            this.akanDicetakGroupBox.TabStop = false;
            this.akanDicetakGroupBox.Text = "Akan Dicetak";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.baruSajaDicetakLabel);
            this.panel4.Location = new System.Drawing.Point(0, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 194);
            this.panel4.TabIndex = 13;
            // 
            // baruSajaDicetakLabel
            // 
            this.baruSajaDicetakLabel.AutoSize = true;
            this.baruSajaDicetakLabel.Font = new System.Drawing.Font("Calibri", 11F);
            this.baruSajaDicetakLabel.Location = new System.Drawing.Point(6, 4);
            this.baruSajaDicetakLabel.Name = "baruSajaDicetakLabel";
            this.baruSajaDicetakLabel.Size = new System.Drawing.Size(199, 27);
            this.baruSajaDicetakLabel.TabIndex = 12;
            this.baruSajaDicetakLabel.Text = "Klik mulai mencetak.";
            // 
            // cetakButton
            // 
            this.cetakButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.cetakButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cetakButton.Enabled = false;
            this.cetakButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.cetakButton.FlatAppearance.BorderSize = 0;
            this.cetakButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cetakButton.Font = new System.Drawing.Font("Calibri", 11F);
            this.cetakButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.cetakButton.Location = new System.Drawing.Point(11, 85);
            this.cetakButton.Name = "cetakButton";
            this.cetakButton.Size = new System.Drawing.Size(194, 30);
            this.cetakButton.TabIndex = 8;
            this.cetakButton.Text = "Cetak";
            this.cetakButton.UseVisualStyleBackColor = false;
            this.cetakButton.Click += new System.EventHandler(this.cetakButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(6, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Baru Saja Dicetak";
            // 
            // akanDicetakLabel
            // 
            this.akanDicetakLabel.AutoSize = true;
            this.akanDicetakLabel.Font = new System.Drawing.Font("Calibri", 11F);
            this.akanDicetakLabel.Location = new System.Drawing.Point(6, 47);
            this.akanDicetakLabel.Name = "akanDicetakLabel";
            this.akanDicetakLabel.Size = new System.Drawing.Size(199, 27);
            this.akanDicetakLabel.TabIndex = 2;
            this.akanDicetakLabel.Text = "Klik mulai mencetak.";
            // 
            // antrianEkspresGroupBox
            // 
            this.antrianEkspresGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.antrianEkspresGroupBox.Controls.Add(this.panel3);
            this.antrianEkspresGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Underline);
            this.antrianEkspresGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.antrianEkspresGroupBox.Location = new System.Drawing.Point(332, 14);
            this.antrianEkspresGroupBox.Name = "antrianEkspresGroupBox";
            this.antrianEkspresGroupBox.Size = new System.Drawing.Size(307, 354);
            this.antrianEkspresGroupBox.TabIndex = 13;
            this.antrianEkspresGroupBox.TabStop = false;
            this.antrianEkspresGroupBox.Text = "Antrian Ekspres";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.antrianEkspresLabel);
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 313);
            this.panel3.TabIndex = 2;
            // 
            // antrianEkspresLabel
            // 
            this.antrianEkspresLabel.AutoSize = true;
            this.antrianEkspresLabel.Font = new System.Drawing.Font("Calibri", 11F);
            this.antrianEkspresLabel.Location = new System.Drawing.Point(1, 1);
            this.antrianEkspresLabel.Name = "antrianEkspresLabel";
            this.antrianEkspresLabel.Size = new System.Drawing.Size(196, 27);
            this.antrianEkspresLabel.TabIndex = 1;
            this.antrianEkspresLabel.Text = "antrianEkspresLabel";
            // 
            // antrianBiasaGroupBox
            // 
            this.antrianBiasaGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.antrianBiasaGroupBox.Controls.Add(this.panel2);
            this.antrianBiasaGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Underline);
            this.antrianBiasaGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.antrianBiasaGroupBox.Location = new System.Drawing.Point(12, 14);
            this.antrianBiasaGroupBox.Name = "antrianBiasaGroupBox";
            this.antrianBiasaGroupBox.Size = new System.Drawing.Size(307, 354);
            this.antrianBiasaGroupBox.TabIndex = 12;
            this.antrianBiasaGroupBox.TabStop = false;
            this.antrianBiasaGroupBox.Text = "Antrian Biasa";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.antrianBiasaLabel);
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 313);
            this.panel2.TabIndex = 1;
            // 
            // antrianBiasaLabel
            // 
            this.antrianBiasaLabel.AutoSize = true;
            this.antrianBiasaLabel.Font = new System.Drawing.Font("Calibri", 11F);
            this.antrianBiasaLabel.Location = new System.Drawing.Point(1, 1);
            this.antrianBiasaLabel.Name = "antrianBiasaLabel";
            this.antrianBiasaLabel.Size = new System.Drawing.Size(174, 27);
            this.antrianBiasaLabel.TabIndex = 0;
            this.antrianBiasaLabel.Text = "antrianBiasaLabel";
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
            this.mulaiMencetakButton.Location = new System.Drawing.Point(267, 403);
            this.mulaiMencetakButton.Name = "mulaiMencetakButton";
            this.mulaiMencetakButton.Size = new System.Drawing.Size(238, 45);
            this.mulaiMencetakButton.TabIndex = 6;
            this.mulaiMencetakButton.Text = "Mulai Mencetak";
            this.mulaiMencetakButton.UseVisualStyleBackColor = false;
            this.mulaiMencetakButton.Click += new System.EventHandler(this.mulaiMencetakButton_Click);
            // 
            // berhentiMencetakButton
            // 
            this.berhentiMencetakButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.berhentiMencetakButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.berhentiMencetakButton.Enabled = false;
            this.berhentiMencetakButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.berhentiMencetakButton.FlatAppearance.BorderSize = 0;
            this.berhentiMencetakButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.berhentiMencetakButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.berhentiMencetakButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.berhentiMencetakButton.Location = new System.Drawing.Point(511, 403);
            this.berhentiMencetakButton.Name = "berhentiMencetakButton";
            this.berhentiMencetakButton.Size = new System.Drawing.Size(238, 45);
            this.berhentiMencetakButton.TabIndex = 7;
            this.berhentiMencetakButton.Text = "Berhenti Mencetak";
            this.berhentiMencetakButton.UseVisualStyleBackColor = false;
            this.berhentiMencetakButton.Click += new System.EventHandler(this.berhentiMencetakButton_Click);
            // 
            // FormAntrian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(993, 455);
            this.Controls.Add(this.berhentiMencetakButton);
            this.Controls.Add(this.mulaiMencetakButton);
            this.Controls.Add(this.panel1);
            this.Name = "FormAntrian";
            this.Text = "Form Antrian";
            this.panel1.ResumeLayout(false);
            this.akanDicetakGroupBox.ResumeLayout(false);
            this.akanDicetakGroupBox.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.antrianEkspresGroupBox.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.antrianBiasaGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mulaiMencetakButton;
        private System.Windows.Forms.Button berhentiMencetakButton;
        private System.Windows.Forms.GroupBox akanDicetakGroupBox;
        private System.Windows.Forms.GroupBox antrianEkspresGroupBox;
        private System.Windows.Forms.GroupBox antrianBiasaGroupBox;
        private System.Windows.Forms.Label akanDicetakLabel;
        private System.Windows.Forms.Label antrianEkspresLabel;
        private System.Windows.Forms.Label antrianBiasaLabel;
        private System.Windows.Forms.Label baruSajaDicetakLabel;
        private System.Windows.Forms.Button cetakButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}