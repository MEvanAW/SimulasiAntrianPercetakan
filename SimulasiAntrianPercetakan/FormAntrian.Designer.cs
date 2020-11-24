namespace SimulasiAntrianPercetakan
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
            this.sedangDicetakGroupBox = new System.Windows.Forms.GroupBox();
            this.sudahDicetakLabel = new System.Windows.Forms.Label();
            this.cetakButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sedangDicetakLabel = new System.Windows.Forms.Label();
            this.antrianEkspresGroupBox = new System.Windows.Forms.GroupBox();
            this.antrianEkspresLabel = new System.Windows.Forms.Label();
            this.antrianBiasaGroupBox = new System.Windows.Forms.GroupBox();
            this.antrianBiasaLabel = new System.Windows.Forms.Label();
            this.mulaiMencetakButton = new System.Windows.Forms.Button();
            this.berhentiMencetakButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.sedangDicetakGroupBox.SuspendLayout();
            this.antrianEkspresGroupBox.SuspendLayout();
            this.antrianBiasaGroupBox.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(972, 385);
            this.panel1.TabIndex = 0;
            // 
            // sedangDicetakGroupBox
            // 
            this.sedangDicetakGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.sedangDicetakGroupBox.Controls.Add(this.sudahDicetakLabel);
            this.sedangDicetakGroupBox.Controls.Add(this.cetakButton);
            this.sedangDicetakGroupBox.Controls.Add(this.label1);
            this.sedangDicetakGroupBox.Controls.Add(this.sedangDicetakLabel);
            this.sedangDicetakGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Underline);
            this.sedangDicetakGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.sedangDicetakGroupBox.Location = new System.Drawing.Point(652, 14);
            this.sedangDicetakGroupBox.Name = "sedangDicetakGroupBox";
            this.sedangDicetakGroupBox.Size = new System.Drawing.Size(307, 354);
            this.sedangDicetakGroupBox.TabIndex = 14;
            this.sedangDicetakGroupBox.TabStop = false;
            this.sedangDicetakGroupBox.Text = "Sedang Dicetak";
            // 
            // sudahDicetakLabel
            // 
            this.sudahDicetakLabel.AutoSize = true;
            this.sudahDicetakLabel.Font = new System.Drawing.Font("Calibri", 11F);
            this.sudahDicetakLabel.Location = new System.Drawing.Point(10, 168);
            this.sudahDicetakLabel.Name = "sudahDicetakLabel";
            this.sudahDicetakLabel.Size = new System.Drawing.Size(199, 27);
            this.sudahDicetakLabel.TabIndex = 12;
            this.sudahDicetakLabel.Text = "Klik mulai mencetak.";
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
            this.label1.Size = new System.Drawing.Size(203, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sudah Dicetak";
            // 
            // sedangDicetakLabel
            // 
            this.sedangDicetakLabel.AutoSize = true;
            this.sedangDicetakLabel.Font = new System.Drawing.Font("Calibri", 11F);
            this.sedangDicetakLabel.Location = new System.Drawing.Point(6, 47);
            this.sedangDicetakLabel.Name = "sedangDicetakLabel";
            this.sedangDicetakLabel.Size = new System.Drawing.Size(199, 27);
            this.sedangDicetakLabel.TabIndex = 2;
            this.sedangDicetakLabel.Text = "Klik mulai mencetak.";
            // 
            // antrianEkspresGroupBox
            // 
            this.antrianEkspresGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.antrianEkspresGroupBox.Controls.Add(this.antrianEkspresLabel);
            this.antrianEkspresGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Underline);
            this.antrianEkspresGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.antrianEkspresGroupBox.Location = new System.Drawing.Point(332, 14);
            this.antrianEkspresGroupBox.Name = "antrianEkspresGroupBox";
            this.antrianEkspresGroupBox.Size = new System.Drawing.Size(307, 354);
            this.antrianEkspresGroupBox.TabIndex = 13;
            this.antrianEkspresGroupBox.TabStop = false;
            this.antrianEkspresGroupBox.Text = "Antrian Ekspres";
            // 
            // antrianEkspresLabel
            // 
            this.antrianEkspresLabel.AutoSize = true;
            this.antrianEkspresLabel.Font = new System.Drawing.Font("Calibri", 11F);
            this.antrianEkspresLabel.Location = new System.Drawing.Point(6, 47);
            this.antrianEkspresLabel.Name = "antrianEkspresLabel";
            this.antrianEkspresLabel.Size = new System.Drawing.Size(196, 27);
            this.antrianEkspresLabel.TabIndex = 1;
            this.antrianEkspresLabel.Text = "antrianEkspresLabel";
            // 
            // antrianBiasaGroupBox
            // 
            this.antrianBiasaGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.antrianBiasaGroupBox.Controls.Add(this.antrianBiasaLabel);
            this.antrianBiasaGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Underline);
            this.antrianBiasaGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.antrianBiasaGroupBox.Location = new System.Drawing.Point(12, 14);
            this.antrianBiasaGroupBox.Name = "antrianBiasaGroupBox";
            this.antrianBiasaGroupBox.Size = new System.Drawing.Size(307, 354);
            this.antrianBiasaGroupBox.TabIndex = 12;
            this.antrianBiasaGroupBox.TabStop = false;
            this.antrianBiasaGroupBox.Text = "Antrian Biasa";
            // 
            // antrianBiasaLabel
            // 
            this.antrianBiasaLabel.AutoSize = true;
            this.antrianBiasaLabel.Font = new System.Drawing.Font("Calibri", 11F);
            this.antrianBiasaLabel.Location = new System.Drawing.Point(6, 47);
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
            this.sedangDicetakGroupBox.ResumeLayout(false);
            this.sedangDicetakGroupBox.PerformLayout();
            this.antrianEkspresGroupBox.ResumeLayout(false);
            this.antrianEkspresGroupBox.PerformLayout();
            this.antrianBiasaGroupBox.ResumeLayout(false);
            this.antrianBiasaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mulaiMencetakButton;
        private System.Windows.Forms.Button berhentiMencetakButton;
        private System.Windows.Forms.GroupBox sedangDicetakGroupBox;
        private System.Windows.Forms.GroupBox antrianEkspresGroupBox;
        private System.Windows.Forms.GroupBox antrianBiasaGroupBox;
        private System.Windows.Forms.Label sedangDicetakLabel;
        private System.Windows.Forms.Label antrianEkspresLabel;
        private System.Windows.Forms.Label antrianBiasaLabel;
        private System.Windows.Forms.Label sudahDicetakLabel;
        private System.Windows.Forms.Button cetakButton;
        private System.Windows.Forms.Label label1;
    }
}