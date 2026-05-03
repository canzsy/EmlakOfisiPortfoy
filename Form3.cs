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
        Form2? oncekiForm;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form2 gelenForm)
        {
            InitializeComponent();
            oncekiForm = gelenForm;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbTur.SelectedIndex = 0;
            cmbOda.SelectedIndex = 0;
            rbSatilik.Checked = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBaslik.Text) || cmbSehir.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen diğer alanları boş bırakmayın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            yeni.Sehir = cmbSehir.Text;
            yeni.Ilce = cmbIlce.Text;
            yeni.Adres = rtbAdres.Text;

            yeni.BulunduguKat = cmbTur.Text == "Arsa" ? "Yok" : numKat.Value.ToString();
            yeni.OdaSayisi = cmbTur.Text == "Arsa" ? "Yok" : cmbOda.Text;
            yeni.Durum = rbSatilik.Checked ? "Satılık" : "Kiralık";

            Veri.Ilanlar.Add(yeni);

            // 🔥 TXT DOSYASINA KAYDET (EKLEDİM)
            Veri.DosyayaKaydet();

            MessageBox.Show("İlan eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtBaslik.Clear();
            txtFiyat.Clear();
            cmbTur.SelectedIndex = -1;
            cmbOda.SelectedIndex = -1;
            numMetrekare.Value = 1;
            rbSatilik.Checked = true;

            if (oncekiForm != null)
            {
                oncekiForm.ListeyiYenile();
                oncekiForm.Show();
            }

            this.Close();
        }

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTur.SelectedItem == null)
                return;

            if (cmbTur.SelectedItem.ToString() == "Arsa")
            {
                label5.Visible = false;
                cmbOda.Visible = false;

                label9.Visible = false;
                numKat.Visible = false;
            }
            else
            {
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

            string secilenSehir = cmbSehir.SelectedItem?.ToString() ?? "";

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
                case "Şanlıurfa":
                    cmbIlce.Items.AddRange(new string[] { "Akçakale", "Birecik", "Ceylanpınar", "Eyyübiye", "Karaköprü", "Viranşehir" });
                    break;
                default:
                    cmbIlce.Items.Add("Merkez");
                    break;
            }
        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oncekiForm != null)
            {
                oncekiForm.Show();
                this.Close();
            }
        }
    }
}