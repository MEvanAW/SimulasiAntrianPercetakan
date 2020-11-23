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
        public int prioritas; // 0 = biasa, 1 = ekspres
        public int timeStamp = (int)DateTime.UtcNow.Subtract(new DateTime(2020, 11, 22)).TotalSeconds;
    }
}
