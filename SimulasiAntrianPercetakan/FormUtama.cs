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
    public partial class FormUtama : Form
    {
        // Atribut FormUtama
        internal static Pelanggan[] pelanggan = {
            new Pelanggan(0),
            new Pelanggan(1),
            new Pelanggan(2),
            new Pelanggan(3),
            new Pelanggan(4),
            new Pelanggan(5)
        };

        // Konstruktor FormUtama
        public FormUtama()
        {
            InitializeComponent();
        }

        // Behaviour FormUtama
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bukaAntrianButton_Click(object sender, EventArgs e)
        {
            new FormAntrian().Show();
        }
        private void berkasTercetakButton_Click(object sender, EventArgs e)
        {
            new FormBerkasTercetak().Show();
        }
        private void pelanggan1PesanButton_Click(object sender, EventArgs e)
        {
            new FormPesan(1).Show();
        }
        private void pelanggan2PesanButton_Click(object sender, EventArgs e)
        {
            new FormPesan(2).Show();
        }
        private void pelanggan3PesanButton_Click(object sender, EventArgs e)
        {
            new FormPesan(3).Show();
        }
        private void pelanggan4PesanButton_Click(object sender, EventArgs e)
        {
            new FormPesan(4).Show();
        }
        private void pelanggan5PesanButton_Click(object sender, EventArgs e)
        {
            new FormPesan(5).Show();
        }
        private void pelanggan1AmbilPesananButton_Click(object sender, EventArgs e)
        {
            new FormAmbilPesanan(1).Show();
        }
        private void pelanggan2AmbilPesananButton_Click(object sender, EventArgs e)
        {
            new FormAmbilPesanan(2).Show();
        }
        private void pelanggan3AmbilPesananButton_Click(object sender, EventArgs e)
        {
            new FormAmbilPesanan(3).Show();
        }
        private void pelanggan4AmbilPesananButton_Click(object sender, EventArgs e)
        {
            new FormAmbilPesanan(4).Show();
        }
        private void pelanggan5AmbilPesananButton_Click(object sender, EventArgs e)
        {
            new FormAmbilPesanan(5).Show();
        }
    }
}
