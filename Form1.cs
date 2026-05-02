using System;
using System.Windows.Forms;

namespace EmlakOfisiPortfoy
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullanici = txtKullanici.Text;
            string sifre = txtSifre.Text;

            if (kullanici == "admin" && sifre == "1234")
            {
                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 panel = new Form2();
                panel.Show();

                this.Hide();
            }
            else
            {
                DialogResult sonuc = MessageBox.Show(
                    "Kullanıcı adı veya şifre yanlış!\nTekrar denemek ister misiniz?",
                    "Hata",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error
                );

                if (sonuc == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {

        }
    }
}