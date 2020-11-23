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
        public LinkedList<NotaPesanan> antrian { get; } = new LinkedList<NotaPesanan>();
        private int jumlahPrinter = 1;
        private int jumlahPrinterOn = 1;

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
        public void enqueue(NotaPesanan pesanan)
        {
            var nodePesanan = new LinkedListNode<NotaPesanan>(pesanan);
            if (antrian.First == null)
                antrian.AddFirst(nodePesanan);
            else
            {
                var pointer = antrian.First;
                while (pointer.Next != null & pointer.Value.prioritas < pesanan.prioritas)
                    pointer = pointer.Next;
                if (pointer.Value.prioritas <= pesanan.prioritas)
                    antrian.AddAfter(pointer, pesanan);
                else
                    antrian.AddBefore(pointer, pesanan);
            }

        }
        public NotaPesanan dequeue()
        {
            if (antrian.Any())
            {
                var pesananUntukDihapus = antrian.First.Value;
                antrian.RemoveFirst();
                return pesananUntukDihapus;
            }
            return default;
        }
    }
}
