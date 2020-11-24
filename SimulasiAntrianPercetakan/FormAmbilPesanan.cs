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
    public partial class FormAmbilPesanan : Form
    {
        // Atribut FormAmbilPesanan
        int idPelanggan;

        // Kontruktor FormAmbilPesanan
        public FormAmbilPesanan(int idPelanggan)
        {
            InitializeComponent();
            // Untuk mengenali pelanggan mana yang memesan
            this.idPelanggan = idPelanggan;
            // Menampilkan nomor pelanggan pada judul form
            Text += idPelanggan.ToString() + ")";
            // Menampilkan berkas siap ambil
            berkasSiapAmbilLabel.Text = "";
            int noBerkas = 1;
            foreach (Pesanan berkasTercetak in Percetakan.BerkasTercetak)
            {
                if (berkasTercetak.idPelanggan == idPelanggan)
                {
                    berkasSiapAmbilLabel.Text += noBerkas.ToString() + ". " +
                        berkasTercetak.namaBerkas + "\n";
                    noBerkas++;
                }
            }
            // Menampilkan berkas yang sudah dimiliki
            UpdateBerkasDimilikiLabel();
            // Disable button Ambil Pesanan bila tidak ada berkas siap ambil
            if (berkasSiapAmbilLabel.Text == "")
                ambilPesananButton.Enabled = false;
        }

        // Behaviour FormAmbilPesanan
        private void ambilPesananButton_Click(object sender, EventArgs e)
        {
            berkasSiapAmbilLabel.Text = "";
            FormUtama.pelanggan[idPelanggan].AmbilPesanan();
            UpdateBerkasDimilikiLabel();
        }
        private void UpdateBerkasDimilikiLabel()
        {
            berkasDimilikiLabel.Text = "";
            for (int index = 0; index < FormUtama.pelanggan[idPelanggan].BerkasDimiliki.Count; index++)
            {
                berkasDimilikiLabel.Text += (index + 1).ToString() + ". " +
                    FormUtama.pelanggan[idPelanggan].BerkasDimiliki[index] + "\n";
            }
        }
        
    }
}
