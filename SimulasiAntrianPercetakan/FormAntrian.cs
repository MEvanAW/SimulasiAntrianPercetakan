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
        private List<Pesanan> antrianBiasa = Percetakan.AntrianBiasa;
        private List<Pesanan> antrianEkspres = Percetakan.AntrianEkspres;
        private List<Pesanan> sudahDicetak = new List<Pesanan>();
        Pesanan sedangDicetak;

        // Constructor FormAntrian
        public FormAntrian()
        {
            InitializeComponent();
            PerbaruiAntrianBiasaLabel();
            PerbaruiAntrianEkspresLabel();
            baruSajaDicetakLabel.Text = "";
            if (antrianBiasa.Count == 0 && antrianEkspres.Count == 0)
            {
                mulaiMencetakButton.Enabled = false;
                akanDicetakLabel.Text = "Antrian print sedang kosong.";
            }
        }

        // Behaviour FormAntrian
        private void mulaiMencetakButton_Click(object sender, EventArgs e)
        {
            mulaiMencetakButton.Enabled = false;
            cetakButton.Enabled = true;
            berhentiMencetakButton.Enabled = true;
            BersiapMencetak();
        }
        private void cetakButton_Click(object sender, EventArgs e)
        {
            sudahDicetak.Add(Percetakan.Cetak());
            BersiapMencetak();
            if (Percetakan.AntrianBiasa.Count == 0 && Percetakan.AntrianEkspres.Count == 0)
            {
                cetakButton.Enabled = false;
                berhentiMencetakButton.Enabled = false;
                akanDicetakLabel.Text = "Semua berkas sudah dicetak.";
            }
            // Memperbarui sudahDicetakLabel.Text
            baruSajaDicetakLabel.Text = "";
            for (int index = 0; index < sudahDicetak.Count; index++)
            {
                baruSajaDicetakLabel.Text += (index + 1).ToString() + ". " +
                    "Pelanggan" + sudahDicetak[index].idPelanggan.ToString() + ": " +
                    sudahDicetak[index].namaBerkas + "\n";
            }
        }
        private void BersiapMencetak()
        {
            if (antrianEkspresLabel.Text != "")
            {
                sedangDicetak = antrianEkspres[0];
                antrianEkspres.RemoveAt(0);
                PerbaruiAntrianEkspresLabel();
                akanDicetakLabel.Text = "Pelanggan" + sedangDicetak.idPelanggan.ToString() + ": " +
                    sedangDicetak.namaBerkas;
            }
            else if (antrianBiasaLabel.Text != "")
            {
                sedangDicetak = antrianBiasa[0];
                antrianBiasa.RemoveAt(0);
                PerbaruiAntrianBiasaLabel();
                akanDicetakLabel.Text = "Pelanggan" + sedangDicetak.idPelanggan.ToString() + ": " +
                    sedangDicetak.namaBerkas;
            }
        }
        private void berhentiMencetakButton_Click(object sender, EventArgs e)
        {
            berhentiMencetakButton.Enabled = false;
            cetakButton.Enabled = false;
            mulaiMencetakButton.Enabled = true;
            akanDicetakLabel.Text = "Klik mulai mencetak.";
            if (sedangDicetak.isEkspres)
            {
                antrianEkspres.Insert(0, sedangDicetak);
                PerbaruiAntrianEkspresLabel();
            }
            else
            {
                antrianBiasa.Insert(0, sedangDicetak);
                PerbaruiAntrianBiasaLabel();
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
    }
}
