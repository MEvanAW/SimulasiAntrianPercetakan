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
        public FormAntrian()
        {
            InitializeComponent();
            antrianBiasaLabel.Text = "";
            antrianEkspresLabel.Text = "";
            for (int index = 0; index < Percetakan.AntrianBiasa.Count; index++)
            {
                antrianBiasaLabel.Text += (index + 1).ToString() + ". " +
                    "Pelanggan" + Percetakan.AntrianBiasa[index].idPelanggan.ToString() + ": " +
                    Percetakan.AntrianBiasa[index].namaBerkas + "\n";
            }
            for (int index = 0; index < Percetakan.AntrianEkspres.Count; index++)
            {
                antrianEkspresLabel.Text += (index + 1).ToString() + ". " +
                    "Pelanggan" + Percetakan.AntrianEkspres[index].idPelanggan.ToString() + ": " +
                    Percetakan.AntrianEkspres[index].namaBerkas + "\n";
            }
        }
    }
}
