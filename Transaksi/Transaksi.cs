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
        public Transaksi()
        {
            InitializeComponent();
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            dtTanggal.Value = DateTime.Now;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            dtTanggal.Value = DateTime.Now;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            dtTanggal.Value = DateTime.Now;
        }

        private bool IsNumeric(char ch)
        {
            return !char.IsControl(ch) && !char.IsDigit(ch);
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumeric(e.KeyChar);
        }

        private void txtKuantitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumeric(e.KeyChar);
        }
    }
}
