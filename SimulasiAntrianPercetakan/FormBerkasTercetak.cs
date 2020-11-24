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
    public partial class FormBerkasTercetak : Form
    {
        public FormBerkasTercetak()
        {
            InitializeComponent();
            berkasTercetakLabel.Text = "";
            for (int index = 0; index < Percetakan.BerkasTercetak.Count; index++)
            {
                berkasTercetakLabel.Text += (index + 1).ToString() + ". " +
                    "Pelanggan" + Percetakan.BerkasTercetak[index].idPelanggan.ToString() + ": " +
                    Percetakan.BerkasTercetak[index].namaBerkas + "\n";
            }
        }
    }
}
