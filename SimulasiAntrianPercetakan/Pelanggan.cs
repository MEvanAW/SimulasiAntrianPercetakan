using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulasiAntrianPercetakan
{
    class Pelanggan
    {
        // ATRIBUT PELANGGAN
        private int _idPelanggan;
        private List<string> _berkasDimiliki = new List<string>();

        // KONSTRUKTOR PELANGGAN
        public Pelanggan(int idPelanggan)
        {
            _idPelanggan = idPelanggan;
        }

        // PROPERTIES PELANGGAN
        public int IdPelanggan
        {
            get { return IdPelanggan; }
        }
        /// <summary>
        /// List string berisi nama berkas-berkas yang sudah pernah dipesan lalu diambil oleh pelanggan.
        /// </summary>
        public List<string> BerkasDimiliki
        {
            get { return _berkasDimiliki; }
        }

        // BEHAVIOUR PELANGGAN
        /// <summary>
        /// Pelanggan memesan berkas kepada percetakan untuk dicetak.
        /// </summary>
        /// <param name="namaBerkas">Nama berkas yang dipesan.</param>
        /// <param name="isEkspres">Bernilai true jika pesanan ekspres, bernilai false jika pesanan biasa.</param>
        public void Pesan(string namaBerkas, bool isEkspres) {
            Percetakan.TerimaPesanan(new Pesanan(_idPelanggan, namaBerkas, isEkspres));
        }
        /// <summary>
        /// Pelanggan mengambil berkas yang sudah dicetak oleh percetakan.
        /// </summary>
        public void AmbilPesanan() {
            foreach (Pesanan pesanan in Percetakan.BerkasTercetak)
                if (pesanan.idPelanggan == _idPelanggan)
                    BerkasDimiliki.Add(pesanan.namaBerkas);
            foreach (string namaBerkas in _berkasDimiliki)
                Percetakan.BerkasTercetak.RemoveAll(pesanan => pesanan.namaBerkas == namaBerkas && pesanan.idPelanggan == _idPelanggan);
        }
    }
}
