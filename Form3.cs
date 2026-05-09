using System;
using System.Drawing;
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
            if (
                string.IsNullOrWhiteSpace(txtBaslik.Text) ||
                cmbSehir.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtAdSoyad.Text) ||
                string.IsNullOrWhiteSpace(
                    msktxtNumara.Text
                    .Replace("(", "")
                    .Replace(")", "")
                    .Replace("-", "")
                    .Replace("_", "")
                    .Trim()
                ) ||
                string.IsNullOrWhiteSpace(rtbIletisimAdres.Text)
            )
            {
                MessageBox.Show(
                    "Lütfen ilan ve iletişim bilgilerini eksiksiz doldurun!",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                tabControl1.SelectedTab = tpIletisim;

                return;
            }

            decimal fiyat;

            if (!decimal.TryParse(txtFiyat.Text, out fiyat))
            {
                MessageBox.Show(
                    "Lütfen geçerli bir fiyat girin!",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            Ilan yeni = new Ilan();

            yeni.Baslik = txtBaslik.Text;
            yeni.Tur = cmbTur.Text;

            yeni.Fiyat = fiyat;

            yeni.Metrekare = (int)numMetrekare.Value;

            yeni.Sehir = cmbSehir.Text;
            yeni.Ilce = cmbIlce.Text;

            yeni.Adres = rtbAdres.Text;

            yeni.BinaYasi = txtBinaYasi.Text;

            yeni.AdSoyad = txtAdSoyad.Text;
            yeni.Telefon = msktxtNumara.Text;
            yeni.IletisimAdres = rtbIletisimAdres.Text;

            yeni.BulunduguKat =
                cmbTur.Text == "Arsa"
                ? "Yok"
                : numKat.Value.ToString();

            yeni.OdaSayisi =
                cmbTur.Text == "Arsa"
                ? "Yok"
                : cmbOda.Text;

            yeni.Durum =
                rbSatilik.Checked
                ? "Satılık"
                : "Kiralık";

            Veri.Ilanlar.Add(yeni);

            Veri.DosyayaKaydet();

            MessageBox.Show(
                "İlan başarıyla eklendi!",
                "Bilgi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            txtBaslik.Clear();
            txtFiyat.Clear();
            txtBinaYasi.Clear();

            txtAdSoyad.Clear();
            msktxtNumara.Clear();

            rtbIletisimAdres.Clear();

            cmbTur.SelectedIndex = 0;
            cmbOda.SelectedIndex = 0;

            cmbSehir.SelectedIndex = -1;

            cmbIlce.Items.Clear();
            cmbIlce.Text = "";

            rtbAdres.Clear();

            numMetrekare.Value = 1;
            numKat.Value = 0;

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

                lblBinaYasi.Visible = false;
                txtBinaYasi.Visible = false;
            }
            else
            {
                label5.Visible = true;
                cmbOda.Visible = true;

                label9.Visible = true;
                numKat.Visible = true;

                lblBinaYasi.Visible = true;
                txtBinaYasi.Visible = true;
            }
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSehir.SelectedItem == null)
                return;

            cmbIlce.Items.Clear();
            cmbIlce.Text = "";

            string secilenSehir =
                cmbSehir.SelectedItem?.ToString() ?? "";

            switch (secilenSehir)
            {
                case "Mersin":
                    cmbIlce.Items.AddRange(new string[]
                    {
                        "Yenişehir",
                        "Mezitli",
                        "Toroslar",
                        "Tarsus",
                        "Erdemli",
                        "Silifke"
                    });
                    break;

                case "İstanbul (Avrupa)":
                    cmbIlce.Items.AddRange(new string[]
                    {
                        "Beşiktaş",
                        "Şişli",
                        "Bakırköy",
                        "Sarıyer",
                        "Arnavutköy"
                    });
                    break;

                case "İstanbul (Anadolu)":
                    cmbIlce.Items.AddRange(new string[]
                    {
                        "Kadıköy",
                        "Üsküdar",
                        "Ataşehir",
                        "Beykoz",
                        "Maltepe"
                    });
                    break;

                case "Ankara":
                    cmbIlce.Items.AddRange(new string[]
                    {
                        "Çankaya",
                        "Keçiören",
                        "Yenimahalle",
                        "Etimesgut",
                        "Mamak"
                    });
                    break;

                case "İzmir":
                    cmbIlce.Items.AddRange(new string[]
                    {
                        "Konak",
                        "Karşıyaka",
                        "Bornova",
                        "Buca",
                        "Çeşme"
                    });
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
            }

            this.Close();
        }

        private void txtBinaYas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBinaYas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                !char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar)
            )
            {
                e.Handled = true;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void msktxtNumara_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tpIlanBilgileri_Click(object sender, EventArgs e)
        {

        }
    }
}