using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            // Boş alan kontrolü (Validation Puanı)
            if (string.IsNullOrWhiteSpace(txtBaslik.Text) || cmbSehir.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Başlık ve Şehir alanlarını boş bırakmayın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            yeni.Sehir = cmbSehir.Text; // Şehir bilgisini alır
            yeni.Ilce = cmbIlce.Text;   // İlçe bilgisini alır
            yeni.Adres = rtbAdres.Text; // RichTextBox'taki adresi alır

            // Arsa değilse kat numarasını alır, arsaysa "Yok" yazar
            yeni.BulunduguKat = cmbTur.Text == "Arsa" ? "Yok" : numKat.Value.ToString();
            yeni.OdaSayisi = cmbTur.Text == "Arsa" ? "Yok" : cmbOda.Text;
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

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. ADIM: Güvenlik Kontrolü
            if (cmbTur.SelectedItem == null)
            {
                return;
            }

            // Seçilen türü kontrol ediyoruz
            if (cmbTur.SelectedItem.ToString() == "Arsa")
            {
                // Oda sayısı (label5 ve cmbOda) gizleniyor
                label5.Visible = false;
                cmbOda.Visible = false;

                // Bulunduğu Kat (label9 ve numKat) gizleniyor
                label9.Visible = false;
                numKat.Visible = false;
            }
            else
            {
                // Ev veya İşyeri seçildiyse hepsini tekrar görünür yapıyoruz
                label5.Visible = true;
                cmbOda.Visible = true;

                label9.Visible = true;
                numKat.Visible = true;
            }
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSehir.SelectedItem == null) return;

            cmbIlce.Items.Clear();
            cmbIlce.Text = "";

            string? secilenSehir = cmbSehir.SelectedItem?.ToString();

            // Hocanın istediği switch-case yapısı
            switch (secilenSehir)
            {
                case "Mersin":
                    cmbIlce.Items.AddRange(new string[] { "Yenişehir", "Mezitli", "Toroslar", "Tarsus", "Erdemli", "Silifke" });
                    break;
                case "İstanbul (Avrupa)":
                    cmbIlce.Items.AddRange(new string[] { "Beşiktaş", "Şişli", "Bakırköy", "Sarıyer", "Arnavutköy" });
                    break;
                case "İstanbul (Anadolu)":
                    cmbIlce.Items.AddRange(new string[] { "Kadıköy", "Üsküdar", "Ataşehir", "Beykoz", "Maltepe" });
                    break;
                case "Ankara":
                    cmbIlce.Items.AddRange(new string[] { "Çankaya", "Keçiören", "Yenimahalle", "Etimesgut", "Mamak" });
                    break;
                case "İzmir":
                    cmbIlce.Items.AddRange(new string[] { "Konak", "Karşıyaka", "Bornova", "Buca", "Çeşme" });
                    break;
                case "Bursa":
                    cmbIlce.Items.AddRange(new string[] { "Osmangazi", "Nilüfer", "Yıldırım", "İnegöl", "Mudanya" });
                    break;
                case "Konya":
                    cmbIlce.Items.AddRange(new string[] { "Selçuklu", "Meram", "Karatay", "Ereğli", "Akşehir" });
                    break;
                case "Antalya":
                    cmbIlce.Items.AddRange(new string[] { "Muratpaşa", "Konyaaltı", "Kepez", "Alanya", "Manavgat" });
                    break;
                case "Adana":
                    cmbIlce.Items.AddRange(new string[] { "Seyhan", "Çukurova", "Sarıçam", "Yüreğir", "Kozan" });
                    break;
                case "Gaziantep":
                    cmbIlce.Items.AddRange(new string[] { "Şahinbey", "Şehitkamil", "Nizip", "Oğuzeli" });
                    break;
                case "Kocaeli":
                    cmbIlce.Items.AddRange(new string[] { "İzmit", "Gebze", "Darica", "Kartepe", "Körfez" });
                    break;
                case "Eskişehir":
                    cmbIlce.Items.AddRange(new string[] { "Odunpazarı", "Tepebaşı", "Çifteler" });
                    break;
                case "Samsun":
                    cmbIlce.Items.AddRange(new string[] { "Atakum", "İlkadım", "Canik", "Bafra", "Çarşamba" });
                    break;
                case "Trabzon":
                    cmbIlce.Items.AddRange(new string[] { "Ortahisar", "Akçaabat", "Yomra", "Beşikdüzü" });
                    break;
                case "Kayseri":
                    cmbIlce.Items.AddRange(new string[] { "Melikgazi", "Kocasinan", "Talas", "Develi" });
                    break;
                default:
                    cmbIlce.Items.Add("Merkez");
                    break;
            }
        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
