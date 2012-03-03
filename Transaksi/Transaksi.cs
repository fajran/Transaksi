using System;
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
    }
}
