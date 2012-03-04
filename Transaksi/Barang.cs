using System;
using System.Collections.Generic;
using System.Text;

namespace Transaksi
{
    public class Barang
    {
        private string _nama;
        private int _harga;
        private int _stok;

        public Barang(string nama) : this(nama, 0, 0)
        {
        }

        public Barang(string nama, int harga) : this(nama, harga, 0)
        {
        }

        public Barang(string nama, int harga, int stok)
        {
            _nama = nama;
            _harga = harga;
            _stok = stok;
        }

        public string Nama
        {
            set { _nama = value; }
            get { return _nama; }
        }

        public int Harga
        {
            set { _harga = value; }
            get { return _harga; }
        }

        public int Stok
        {
            set { _stok = value; }
            get { return _stok; }
        }
    }
}
