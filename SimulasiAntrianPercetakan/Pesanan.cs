using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulasiAntrianPercetakan
{
    class Pesanan
    {
        // Atribut nota pesanan
        public int idPelanggan;
        public string namaBerkas;
        public bool isEkspres;
        public int timeStamp;

        // Constructor Pesanan
        public Pesanan(int idPelanggan, string namaBerkas, bool isEkspres)
        {
            this.idPelanggan = idPelanggan;
            this.namaBerkas = namaBerkas;
            this.isEkspres = isEkspres;
            timeStamp = (int)DateTime.UtcNow.Subtract(new DateTime(2020, 11, 22)).TotalSeconds;
        }
    }
}
