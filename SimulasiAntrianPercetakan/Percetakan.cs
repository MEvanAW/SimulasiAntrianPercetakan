using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulasiAntrianPercetakan
{
    static class Percetakan
    {
        // Atribut percetakan
        private static Queue<Pesanan> _antrianBiasa = new Queue<Pesanan>();
        private static Queue<Pesanan> _antrianEkspres = new Queue<Pesanan>();
        public static List<Pesanan> BerkasTercetak = new List<Pesanan>();
        private static int _jumlahPrinter = 1;
        private static int _jumlahPrinterOn = 1;

        // Property percetakan
        public static int JumlahPrinter{
            get {return _jumlahPrinter; }
            set {
                _jumlahPrinter = value;
                // Jika printer hidup lebih banyak dari printer yang ada, tidak logis
                if (_jumlahPrinterOn > _jumlahPrinter)
                    // Maka dilakukan penyesuaian:
                    _jumlahPrinterOn = _jumlahPrinter; }
        }
        public static List<Pesanan> AntrianBiasa {
            get { return _antrianBiasa.ToList(); }
        }
        public static List<Pesanan> AntrianEkspres
        {
            get { return _antrianEkspres.ToList(); }
        }
        public static int JumlahPrinterOn{
            get { return _jumlahPrinterOn; }
            set {
                if (value <= _jumlahPrinter)
                    _jumlahPrinterOn = value;
                else // Jika printer hidup lebih banyak dari printer yang ada, tidak logis
                     // Maka dilakukan penyesuaian:
                    _jumlahPrinterOn = _jumlahPrinter; }
        }

        // Behaviour percetakan
        public static void TerimaPesanan(Pesanan pesanan)
        {
            if (!pesanan.isEkspres)
                _antrianBiasa.Enqueue(pesanan);
            else
                _antrianEkspres.Enqueue(pesanan);
        }
        public static Pesanan Cetak()
        {
            if (_antrianEkspres.Any())
            {
                Pesanan pesanan = _antrianEkspres.Peek();
                BerkasTercetak.Add(pesanan);
                _antrianEkspres.Dequeue();
                return pesanan;
            }
            else if (_antrianBiasa.Any())
            {
                Pesanan pesanan = _antrianBiasa.Peek();
                BerkasTercetak.Add(pesanan);
                _antrianBiasa.Dequeue();
                return pesanan;
            }
            else
                return new Pesanan(0, "", false);
        }
    }
}
