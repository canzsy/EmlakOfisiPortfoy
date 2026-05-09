using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace EmlakOfisiPortfoy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Veri.DosyadanOku();
            ListeyiYenile();

            if (Veri.Ilanlar.Count == 0)
            {
                MessageBox.Show(
                    "Henüz ilan eklenmemiş.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(this);
            frm.Show();
            this.Hide();
        }

        public void ListeyiYenile()
        {
            lstIlanlar.DataSource = null;
            lstIlanlar.DataSource = Veri.Ilanlar;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstIlanlar.SelectedItem == null)
            {
                MessageBox.Show(
                    "Lütfen silmek için bir ilan seçin.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Ilan secilenIlan = (Ilan)lstIlanlar.SelectedItem;

            DialogResult sonuc = MessageBox.Show(
                "Seçili ilanı silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (sonuc == DialogResult.Yes)
            {
                Veri.Ilanlar.Remove(secilenIlan);

                Veri.DosyayaKaydet();

                ListeyiYenile();

                rtbDetay.Clear();

                MessageBox.Show(
                    "İlan silindi.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtArama.Text.ToLower();

            lstIlanlar.DataSource = null;

            lstIlanlar.DataSource = Veri.Ilanlar
                .Where(x => x.Baslik.ToLower().Contains(aranan))
                .ToList();
        }

        private void lstIlanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIlanlar.SelectedItem == null)
                return;

            Ilan secilen = (Ilan)lstIlanlar.SelectedItem;

            rtbDetay.Clear();

            rtbDetay.AppendText(
                "BAŞLIK: " +
                secilen.Baslik.ToUpper() +
                "\n"
            );

            rtbDetay.AppendText("----------------------------------\n");

            rtbDetay.AppendText(
                "KONUM: " +
                secilen.Sehir +
                " / " +
                secilen.Ilce +
                "\n"
            );

            rtbDetay.AppendText(
                "DURUM: " +
                secilen.Durum +
                " " +
                secilen.Tur +
                "\n"
            );

            rtbDetay.AppendText(
                "ALAN: " +
                secilen.Metrekare +
                " m²\n"
            );

            if (secilen.Tur != "Arsa")
            {
                rtbDetay.AppendText(
                    "ODA SAYISI: " +
                    secilen.OdaSayisi +
                    "\n"
                );

                rtbDetay.AppendText(
                    "BULUNDUĞU KAT: " +
                    secilen.BulunduguKat +
                    "\n"
                );

                rtbDetay.AppendText(
                    "BİNA YAŞI: " +
                    secilen.BinaYasi +
                    "\n"
                );
            }

            rtbDetay.AppendText(
                "AÇIK ADRES: " +
                secilen.Adres +
                "\n"
            );

            rtbDetay.AppendText("----------------------------------\n");

            rtbDetay.AppendText(
                "İLETİŞİM KİŞİSİ: " +
                secilen.AdSoyad +
                "\n"
            );

            rtbDetay.AppendText(
                "TELEFON: " +
                secilen.Telefon +
                "\n"
            );

            rtbDetay.AppendText(
                "İLETİŞİM ADRESİ: " +
                secilen.IletisimAdres +
                "\n"
            );

            rtbDetay.AppendText("----------------------------------\n");

            rtbDetay.AppendText(
                "FİYAT: " +
                secilen.Fiyat.ToString("N2") +
                " TL"
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(
                "Sistemden çıkış yapmak istediğinize emin misiniz?",
                "Çıkış Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}