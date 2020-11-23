namespace SimulasiAntrianPercetakan
{
    partial class FormPesan
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
            this.pesanButton = new System.Windows.Forms.Button();
            this.ekspresRadioButton = new System.Windows.Forms.RadioButton();
            this.biasaRadioButton = new System.Windows.Forms.RadioButton();
            this.namaBerkasTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.pesanButton);
            this.panel1.Controls.Add(this.ekspresRadioButton);
            this.panel1.Controls.Add(this.biasaRadioButton);
            this.panel1.Controls.Add(this.namaBerkasTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 170);
            this.panel1.TabIndex = 0;
            // 
            // pesanButton
            // 
            this.pesanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.pesanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pesanButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.pesanButton.FlatAppearance.BorderSize = 0;
            this.pesanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesanButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesanButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.pesanButton.Location = new System.Drawing.Point(144, 105);
            this.pesanButton.Name = "pesanButton";
            this.pesanButton.Size = new System.Drawing.Size(238, 45);
            this.pesanButton.TabIndex = 7;
            this.pesanButton.Text = "Pesan";
            this.pesanButton.UseVisualStyleBackColor = false;
            this.pesanButton.Click += new System.EventHandler(this.pesanButton_Click);
            // 
            // ekspresRadioButton
            // 
            this.ekspresRadioButton.AutoSize = true;
            this.ekspresRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ekspresRadioButton.Location = new System.Drawing.Point(302, 59);
            this.ekspresRadioButton.Name = "ekspresRadioButton";
            this.ekspresRadioButton.Size = new System.Drawing.Size(126, 33);
            this.ekspresRadioButton.TabIndex = 5;
            this.ekspresRadioButton.TabStop = true;
            this.ekspresRadioButton.Text = "Ekspres";
            this.ekspresRadioButton.UseVisualStyleBackColor = true;
            // 
            // biasaRadioButton
            // 
            this.biasaRadioButton.AutoSize = true;
            this.biasaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.biasaRadioButton.Location = new System.Drawing.Point(198, 59);
            this.biasaRadioButton.Name = "biasaRadioButton";
            this.biasaRadioButton.Size = new System.Drawing.Size(98, 33);
            this.biasaRadioButton.TabIndex = 4;
            this.biasaRadioButton.TabStop = true;
            this.biasaRadioButton.Text = "Biasa";
            this.biasaRadioButton.UseVisualStyleBackColor = true;
            // 
            // namaBerkasTextBox
            // 
            this.namaBerkasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.namaBerkasTextBox.Location = new System.Drawing.Point(198, 9);
            this.namaBerkasTextBox.Name = "namaBerkasTextBox";
            this.namaBerkasTextBox.Size = new System.Drawing.Size(303, 35);
            this.namaBerkasTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Pesanan:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Berkas:";
            // 
            // FormPesan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(536, 193);
            this.Controls.Add(this.panel1);
            this.Name = "FormPesan";
            this.Text = "Form Pesan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ekspresRadioButton;
        private System.Windows.Forms.RadioButton biasaRadioButton;
        private System.Windows.Forms.TextBox namaBerkasTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pesanButton;
    }
}