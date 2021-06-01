using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotDefteriUygulamasi
{
    public partial class AnaForm : Form
    {
        private List<Not> notlar;
        public AnaForm()
        {
            VeriOku();
            InitializeComponent();
            Listele();
        }

        private void VeriOku()
        {

            try
            {
                string json = File.ReadAllText("veri.json");
                notlar = JsonSerializer.Deserialize<List<Not>>(json);
            }
            catch (Exception)
            {
                notlar = new List<Not>();
                OrnekNotlarEkle();
            }
        }

        private void OrnekNotlarEkle()
        {

            notlar.Add(new Not() { AktiviteMetin = "Arkadaşımla buluştum.", Zaman = new DateTime(2021, 05, 26, 18, 48, 43), Isaret = "" });
            notlar.Add(new Not() { AktiviteMetin = "Köpeğimi gezdirdim.", Zaman = new DateTime(2021, 05, 27, 22, 06, 13), Isaret = "★" });
            notlar.Sort();

        }

        private void Listele()
        {
            string arama = txtMetin.Text.Trim().ToLower();
            bool fav = cbYildiz.Checked;
            List<Not> sonuc = notlar.Where(x => (!fav || x.Isaret != "") && (arama == "" || x.AktiviteMetin.ToLower().Contains(arama))).ToList();
            sonuc.Sort();
            lstNotlar.DataSource = sonuc;
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VeriKaydet();
        }

        private void VeriKaydet()
        {
            string json = JsonSerializer.Serialize(notlar, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText("veri.json", json);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string metin = txtMetin.Text.Trim();
            if (metin == "")
            {
                MessageBox.Show("Lütfen not giriniz!");
                return;
            }
            else
            {
                notlar.Add(new Not()
                {
                    Zaman = DateTime.Now,
                    AktiviteMetin = txtMetin.Text,
                    // Isaret = cbYildiz.Checked ? "★" : ""

                });
                txtMetin.Clear();
                notlar.Sort();
                Listele();
            }
        }

        private void txtMetin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // tuşa basılmamış gibi davran (windows ding sesini de önlüyor)
                btnEkle.PerformClick(); // btnEkle butonuna tıkla
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Not secilen;
            if (lstNotlar.SelectedItem == null)
                MessageBox.Show("Lütfen bir not seçiniz!");
            else
            {
                secilen = (Not)lstNotlar.SelectedItem;
                notlar.Remove(secilen);
                Listele();
            }
        }

        private void lstNotlar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
            {
                e.SuppressKeyPress = true;
                btnSil.PerformClick();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            new DuzenleForm((Not)lstNotlar.SelectedItem).ShowDialog();
            Listele();
        }

        private void cbYildiz_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtMetin_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
