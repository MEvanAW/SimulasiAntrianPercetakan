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
        public static LinkedList<Pesanan> Antrian = new LinkedList<Pesanan>();
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
        public static int JumlahPrinterOn{
            get { return _jumlahPrinterOn; }
            set {
                if (value <= _jumlahPrinter)
                    _jumlahPrinterOn = value;
                else // Jika printer hidup lebih banyak dari printer yang ada, tidak logis
                     // Maka dilakukan penyesuaian:
                    _jumlahPrinterOn = _jumlahPrinter; }
        }
        public static List<Pesanan> AntrianBiasa{
            get {
                List<Pesanan> returnList = new List<Pesanan>();
                foreach (Pesanan pesanan in Antrian)
                    if(!pesanan.isEkspres)
                        returnList.Add(pesanan);
                return returnList;
            }
        }
        public static List<Pesanan> AntrianEkspres{
            get {
                List<Pesanan> returnList = new List<Pesanan>();
                foreach (Pesanan pesanan in Antrian)
                    if (pesanan.isEkspres)
                        returnList.Add(pesanan);
                return returnList;
            }
        }

        // Behaviour percetakan
        public static void TerimaPesanan(Pesanan pesanan)
        {
            var nodePesanan = new LinkedListNode<Pesanan>(pesanan);
            if (Antrian.First == null)
                Antrian.AddFirst(nodePesanan);
            else
            {
                var pointer = Antrian.First;
                while (pointer.Next != null && pointer.Value.isEkspres && !pesanan.isEkspres)
                    pointer = pointer.Next;
                while (pointer.Next != null && pointer.Value.timeStamp < pesanan.timeStamp && pointer.Value.isEkspres == pesanan.isEkspres)
                    pointer = pointer.Next;
                if (pointer.Value.timeStamp <= pesanan.timeStamp)
                    Antrian.AddAfter(pointer, pesanan);
                else
                    Antrian.AddBefore(pointer, pesanan);
            }
        }
        public static bool Cetak()
        {
            if (Antrian.Any())
            {
                BerkasTercetak.Add(Antrian.First.Value);
                Antrian.RemoveFirst();
                return true;
            }
            else
                return false;
        }
    }
}
