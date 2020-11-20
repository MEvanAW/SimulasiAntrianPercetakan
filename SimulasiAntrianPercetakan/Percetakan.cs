using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulasiAntrianPercetakan
{
    class Percetakan
    {
        // Atribut percetakan
        public int antrian = 0;
        private int jumlahPrinter = 0;
        private int jumlahPrinterOn = 0;
        public int jumlahPesananEkspress = 0;
        public int jumlahPesananBiasa = 0;

        // Behaviour percetakan
        public void terimaPesanan() { }
        public void mulaiMencetak() { }
        public void berhentiMencetak() { }
        public void ubahJumlahPrinter(int jumlahPrinter) {
            this.jumlahPrinter = jumlahPrinter;
            // Jika printer hidup lebih banyak dari printer yang ada, tidak logis
            if (jumlahPrinterOn > jumlahPrinter)
                // Maka dilakukan penyesuaian:
                jumlahPrinterOn = jumlahPrinter;
        }
        public void ubahJumlahPrinterOn(int jumlahPrinterOn) {
            if (jumlahPrinterOn <= jumlahPrinter)
                this.jumlahPrinterOn = jumlahPrinterOn;
            else // Jika printer hidup lebih banyak dari printer yang ada, tidak logis
                // Maka dilakukan penyesuaian:
                this.jumlahPrinterOn = jumlahPrinter;
        }
        public void lihatPesananEkspress() { }
        public void lihatPesananBiasa() { }
    }
}
