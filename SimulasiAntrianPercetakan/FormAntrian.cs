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
    public partial class FormAntrian : Form
    {
        // Atribut FormAntrian
        private bool sedangMencetak;
        private List<Pesanan> antrianBiasa = Percetakan.AntrianBiasa;
        private List<Pesanan> antrianEkspres = Percetakan.AntrianEkspres;

        // Constructor FormAntrian
        public FormAntrian()
        {
            InitializeComponent();
            PerbaruiAntrianBiasaLabel();
            PerbaruiAntrianEkspresLabel();
            sedangDicetakLabel.Text = "";
            cetakProgressBar.Minimum = 0;
            cetakProgressBar.Maximum = 500000;
            cetakProgressBar.Value = 0;
            cetakProgressBar.Step = 1;
        }

        // Behaviour FormAntrian
        private void mulaiMencetakButton_Click(object sender, EventArgs e)
        {
            Pesanan pesanan;
            sedangMencetak = true;
            int count = antrianBiasa.Count + antrianEkspres.Count;
            for (int i = 0; i < count && sedangMencetak; i++)
            {
                if (antrianEkspresLabel.Text != "")
                {
                    MessageBox.Show("mulai if");
                    pesanan = antrianEkspres[0];
                    antrianEkspres.RemoveAt(0);
                    PerbaruiAntrianEkspresLabel();
                    sedangDicetakLabel.Text = "Pelanggan" + pesanan.idPelanggan.ToString() + ": " +
                        pesanan.namaBerkas;
                    for (int x = 0; x < 500000; x++)
                        cetakProgressBar.PerformStep();
                    Percetakan.Cetak();
                    cetakProgressBar.Value = 0;
                }
                else if (antrianBiasaLabel.Text != "")
                {
                    MessageBox.Show("mulai else if");
                    pesanan = antrianBiasa[0];
                    antrianBiasa.RemoveAt(0);
                    PerbaruiAntrianBiasaLabel();
                    sedangDicetakLabel.Text = "Pelanggan" + pesanan.idPelanggan.ToString() + ": " +
                        pesanan.namaBerkas;
                    for (int x = 0; x < 500000; x++)
                        cetakProgressBar.PerformStep();
                    Percetakan.Cetak();
                    cetakProgressBar.Value = 0;
                }
            }
            sedangDicetakLabel.Text = "";
        }
        private void berhentiMencetakButton_Click(object sender, EventArgs e)
        {
            sedangMencetak = false;
        }
        private void PerbaruiAntrianBiasaLabel()
        {
            antrianBiasaLabel.Text = "";
            for (int index = 0; index < antrianBiasa.Count; index++)
            {
                antrianBiasaLabel.Text += (index + 1).ToString() + ". " +
                    "Pelanggan" + antrianBiasa[index].idPelanggan.ToString() + ": " +
                    antrianBiasa[index].namaBerkas + "\n";
            }
        }
        private void PerbaruiAntrianEkspresLabel()
        {
            antrianEkspresLabel.Text = "";
            for (int index = 0; index < antrianEkspres.Count; index++)
            {
                antrianEkspresLabel.Text += (index + 1).ToString() + ". " +
                    "Pelanggan" + antrianEkspres[index].idPelanggan.ToString() + ": " +
                    antrianEkspres[index].namaBerkas + "\n";
            }
        }
    }
}
