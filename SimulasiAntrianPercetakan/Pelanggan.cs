using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulasiAntrianPercetakan
{
    class Pelanggan
    {
        // Atribut pelanggan
        private int _idPelanggan;
        private List<string> _berkasDimiliki = new List<string>();

        // Constructor pelanggan
        public Pelanggan(int idPelanggan)
        {
            _idPelanggan = idPelanggan;
        }

        // Properties pelanggan
        public int IdPelanggan
        {
            get { return IdPelanggan; }
        }
        public List<string> BerkasDimiliki
        {
            get { return _berkasDimiliki; }
        }

        // Behaviour pelanggan
        public void Pesan(string namaBerkas, bool isEkspres) {
            Percetakan.TerimaPesanan(new Pesanan(_idPelanggan, namaBerkas, isEkspres));
        }
        public void AmbilPesanan() {
            foreach (Pesanan pesanan in Percetakan.BerkasTercetak)
                if (pesanan.idPelanggan == _idPelanggan)
                    BerkasDimiliki.Add(pesanan.namaBerkas);
            foreach (string namaBerkas in _berkasDimiliki)
                Percetakan.BerkasTercetak.RemoveAll(pesanan => pesanan.namaBerkas == namaBerkas && pesanan.idPelanggan == _idPelanggan);
        }
    }
}
