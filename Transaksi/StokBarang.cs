using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Transaksi
{
    public partial class StokBarang : Form
    {
        private Stok stok;

        public StokBarang(Stok stok)
        {
            InitializeComponent();
            this.stok = stok;
            UpdateStok();
        }

        private void UpdateStok()
        {
            UpdateListStok();
            UpdateListHarga();
            UpdateListBarang();
        }

        private void UpdateListStok()
        {
            listStok.Items.Clear();
            cbStok.Items.Clear();
            foreach (Barang barang in stok)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = barang;
                item.Text = barang.Nama;
                item.SubItems.Add("" + barang.Stok);
                listStok.Items.Add(item);

                cbStok.Items.Add(barang);
            }
        }

        private void UpdateListHarga()
        {
            listHarga.Items.Clear();
            cbHarga.Items.Clear();
            foreach (Barang barang in stok)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = barang;
                item.Text = barang.Nama;
                item.SubItems.Add("" + barang.Harga);
                listHarga.Items.Add(item);

                cbHarga.Items.Add(barang);
            }
        }

        private void UpdateListBarang()
        {
            listBarang.Items.Clear();
            foreach (Barang barang in stok)
            {
                listBarang.Items.Add(barang);
            }
        }
    }
}
