﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Transaksi
{
    public partial class Transaksi : Form
    {
        private int _total;
        private Stok stok;

        public Transaksi()
        {
            InitializeComponent();
            total = 0;
            stok = new Stok();
            UpdateStok();
        }

        private void Reset()
        {
            dtTanggal.Value = DateTime.Now;
            txtNama.Text = "";
            cbBarang.SelectedItem = null;
            txtHarga.Text = "";
            txtKuantitas.Text = "";
            listBarang.Items.Clear();
            total = 0;
        }

        private void AddBarang(Barang barang, int harga, int kuantitas)
        {
            int total = harga + kuantitas;

            ListViewItem item = new ListViewItem();
            item.Tag = barang;
            item.Text = barang.Nama;
            item.SubItems.Add("" + kuantitas);
            item.SubItems.Add("" + harga);
            item.SubItems.Add("" + total);
            listBarang.Items.Add(item);

            this.total += total;
        }

        private void UpdateStok()
        {
            cbBarang.Items.Clear();
            foreach (Barang barang in stok)
            {
                cbBarang.Items.Add(barang);
            }
        }

        private int total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
                lblTotal.Text = "Rp. " + _total;
            }
        }

        private void Transaksi_Shown(object sender, EventArgs e)
        {
            Reset();
            txtNama.Focus();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Reset();
            txtNama.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Reset();
            txtNama.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (cbBarang.SelectedItem == null)
            {
                cbBarang.Focus();
                return;
            }

            Barang barang = (Barang)cbBarang.SelectedItem;
            string harga = txtHarga.Text;
            string kuantitas = txtKuantitas.Text;

            if (harga.Equals("") || Int32.Parse(harga) <= 0)
            {
                txtHarga.Focus();
                return;
            }
            if (kuantitas.Equals("") || Int32.Parse(kuantitas) <= 0)
            {
                txtKuantitas.Focus();
                return;
            }

            AddBarang(barang, Int32.Parse(harga), Int32.Parse(kuantitas));

            cbBarang.SelectedItem = null;
            txtHarga.Text = "";
            txtKuantitas.Text = "";
            cbBarang.Focus();
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.IsNumeric(e.KeyChar);
        }

        private void txtKuantitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.IsNumeric(e.KeyChar);
        }

        private void stokBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokBarang form = new StokBarang(stok);
            form.ShowDialog();
            UpdateStok();
        }

        private void listBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int total = 0;
                foreach (ListViewItem item in listBarang.Items)
                {
                    if (item.Selected)
                    {
                        total += Int32.Parse(item.SubItems[3].Text);
                        item.Remove();
                    }
                }
                this.total -= total;
            }
        }
    }
}
