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
        private string _loginName;
        private string _password;
        private int _securityLevel = 1;

        // Constructor pelanggan
        public Pelanggan(int idPelanggan)
        {
            _idPelanggan = idPelanggan;
        }
        public Pelanggan(int idPelanggan, int securityLevel)
        {
            _idPelanggan = idPelanggan;
            _securityLevel = securityLevel;
        }

        // Properties pelanggan
        public int IdPelanggan
        {
            get { return IdPelanggan; }
        }
        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public int SecurityLevel
        {
            get { return _securityLevel; }
        }

        // Behaviour pelanggan
        public void mulaiMemesan() { }
        public void ambilPesanan() { }
        public void memberiTanggapan() { }
    }
}
