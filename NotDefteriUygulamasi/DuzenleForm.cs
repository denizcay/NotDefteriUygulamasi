using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotDefteriUygulamasi
{
    public partial class DuzenleForm : Form
    {

        private readonly Not _secili;

        public DuzenleForm(Not secili)
        {
            InitializeComponent();
            _secili = secili;
            txtNot.Text = secili.AktiviteMetin;
            dtpZaman.Format = DateTimePickerFormat.Custom;
            dtpZaman.CustomFormat = "dd '/' MM '/' yyyy - dddd HH ':' mm";
            dtpZaman.Value = secili.Zaman;
            if (secili.Isaret == "★")
                cbYildizEkle.Checked = true;
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            _secili.AktiviteMetin = txtNot.Text;
            if (txtNot.Text == "")
                MessageBox.Show("Lütfen bir not giriniz!");
            _secili.Zaman = dtpZaman.Value;
            if (cbYildizEkle.Checked)
                _secili.Isaret = "★";
            else if (cbYildizEkle.Checked == false)
                _secili.Isaret = "";
            Close();
        }

        private void btnIptal_Click_1(object sender, EventArgs e)
        {
                Close();
        }
    }
}