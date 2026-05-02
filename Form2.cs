using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            lstIlanlar.DataSource = null;
            lstIlanlar.DataSource = Veri.Ilanlar;
            if (Veri.Ilanlar.Count == 0)

            {
                MessageBox.Show("Henüz ilan eklenmemiş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();

            lstIlanlar.DataSource = null;
            lstIlanlar.DataSource = Veri.Ilanlar;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstIlanlar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silmek için bir ilan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                lstIlanlar.DataSource = null;
                lstIlanlar.DataSource = Veri.Ilanlar;

                MessageBox.Show("İlan silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            rtbDetay.Text =
                "Başlık: " + secilen.Baslik + "\n" +
                "Tür: " + secilen.Tur + "\n" +
                "Durum: " + secilen.Durum + "\n" +
                "Fiyat: " + secilen.Fiyat + " TL\n" +
                "Metrekare: " + secilen.Metrekare + "\n" +
               "Oda: " + secilen.OdaSayisi;
        }
    }
}
