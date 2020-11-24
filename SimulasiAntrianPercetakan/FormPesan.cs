using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulasiAntrianPercetakan
{
    public partial class FormPesan : Form
    {
        // Atribut FormPesan
        private int idPelanggan;

        // Constructor FormPesan
        public FormPesan(int idPelanggan)
        {
            InitializeComponent();
            biasaRadioButton.Select();
            this.idPelanggan = idPelanggan;
            Text += idPelanggan.ToString() + ")";
        }

        // Behaviour FormPesan
        private void pesanButton_Click(object sender, EventArgs e)
        {
            if (namaBerkasTextBox.Text == "")
            {
                MessageBox.Show("Mohon isi nama berkas.", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // START DEBUGGING
            /* MessageBox.Show("idPelanggan: " + idPelanggan.ToString() + "\n" +
                "namaBerkas: " + namaBerkasTextBox.Text + "\n" +
                "isEkspres: " + (ekspresRadioButton.Checked).ToString(),
                "DEBUGGING", MessageBoxButtons.OK, MessageBoxIcon.Information); */
            // END DEBUGGING
            FormUtama.pelanggan[idPelanggan].Pesan(namaBerkasTextBox.Text, ekspresRadioButton.Checked);
            Close();
        }
        private void namaBerkasTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                pesanButton.PerformClick();
            }
        }
    }
}
