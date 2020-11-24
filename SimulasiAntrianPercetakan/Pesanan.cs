using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulasiAntrianPercetakan
{
    class Pesanan
    {
        // ATRIBUT PESANAN
        public int idPelanggan;
        public string namaBerkas;
        public bool isEkspres;
        public int timeStamp;

        /// <summary>
        /// Konstruktor kelas Pesanan.
        /// </summary>
        /// <param name="idPelanggan">Nomor pelanggan yang memesan.</param>
        /// <param name="namaBerkas">Nama berkas yang dipesan.</param>
        /// <param name="isEkspres">Bernilai true jika pesanan ekspres, bernilai false jika pesanan biasa.</param>
        public Pesanan(int idPelanggan, string namaBerkas, bool isEkspres)
        {
            this.idPelanggan = idPelanggan;
            this.namaBerkas = namaBerkas;
            this.isEkspres = isEkspres;
            timeStamp = (int)DateTime.UtcNow.Subtract(new DateTime(2020, 11, 22)).TotalSeconds;
        }
    }
}
