using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmlakOfisiPortfoy
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbTur.SelectedIndex = 0;
            cmbOda.SelectedIndex = 0;
            rbSatilik.Checked = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ilan yeni = new Ilan();

            decimal fiyat;

            if (!decimal.TryParse(txtFiyat.Text, out fiyat))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            yeni.Baslik = txtBaslik.Text;
            yeni.Tur = cmbTur.Text;
            yeni.Fiyat = fiyat;
            yeni.Metrekare = (int)numMetrekare.Value;
            yeni.OdaSayisi = cmbOda.Text;
            yeni.Durum = rbSatilik.Checked ? "Satılık" : "Kiralık";

            Veri.Ilanlar.Add(yeni);

            MessageBox.Show("İlan eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtBaslik.Clear();
            txtFiyat.Clear();
            cmbTur.SelectedIndex = -1;
            cmbOda.SelectedIndex = -1;
            numMetrekare.Value = 1;
            rbSatilik.Checked = true;

            this.Close();
        }
    }
}
