namespace EmlakOfisiPortfoy
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            txtBaslik = new TextBox();
            cmbTur = new ComboBox();
            label2 = new Label();
            txtFiyat = new TextBox();
            label3 = new Label();
            label4 = new Label();
            numMetrekare = new NumericUpDown();
            cmbOda = new ComboBox();
            groupBox1 = new GroupBox();
            rbKiralik = new RadioButton();
            rbSatilik = new RadioButton();
            label5 = new Label();
            btnKaydet = new Button();
            numKat = new NumericUpDown();
            label9 = new Label();
            tabControl1 = new TabControl();
            tpIlanBilgileri = new TabPage();
            txtBinaYasi = new TextBox();
            lblBinaYasi = new Label();
            tpKonum = new TabPage();
            rtbAdres = new RichTextBox();
            label6 = new Label();
            label8 = new Label();
            cmbIlce = new ComboBox();
            label7 = new Label();
            cmbSehir = new ComboBox();
            tpIletisim = new TabPage();
            msktxtNumara = new MaskedTextBox();
            rtbIletisimAdres = new RichTextBox();
            txtAdSoyad = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numMetrekare).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKat).BeginInit();
            tabControl1.SuspendLayout();
            tpIlanBilgileri.SuspendLayout();
            tpKonum.SuspendLayout();
            tpIletisim.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.2F);
            label1.Location = new Point(19, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "İlan Başlığı : ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(181, 31);
            txtBaslik.Margin = new Padding(4, 3, 4, 3);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(188, 27);
            txtBaslik.TabIndex = 1;
            // 
            // cmbTur
            // 
            cmbTur.FormattingEnabled = true;
            cmbTur.Items.AddRange(new object[] { "Ev", "İşyeri", "Arsa" });
            cmbTur.Location = new Point(177, 181);
            cmbTur.Margin = new Padding(4, 3, 4, 3);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(188, 28);
            cmbTur.TabIndex = 2;
            cmbTur.SelectedIndexChanged += cmbTur_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.2F);
            label2.Location = new Point(19, 229);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Fiyat (₺) : ";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(177, 229);
            txtFiyat.Margin = new Padding(4, 3, 4, 3);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(186, 27);
            txtFiyat.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.2F);
            label3.Location = new Point(19, 304);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 5;
            label3.Text = "Metrekare : ";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.2F);
            label4.Location = new Point(19, 181);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "Tür : ";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numMetrekare
            // 
            numMetrekare.Location = new Point(179, 302);
            numMetrekare.Margin = new Padding(5, 3, 5, 3);
            numMetrekare.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numMetrekare.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMetrekare.Name = "numMetrekare";
            numMetrekare.Size = new Size(188, 27);
            numMetrekare.TabIndex = 7;
            numMetrekare.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbOda
            // 
            cmbOda.FormattingEnabled = true;
            cmbOda.Items.AddRange(new object[] { "1+0 ", "1+1", "2+1", "3+1", "4+1", "5+1" });
            cmbOda.Location = new Point(181, 358);
            cmbOda.Margin = new Padding(4, 3, 4, 3);
            cmbOda.Name = "cmbOda";
            cmbOda.Size = new Size(188, 28);
            cmbOda.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbKiralik);
            groupBox1.Controls.Add(rbSatilik);
            groupBox1.Location = new Point(17, 83);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(350, 73);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "İlan Durumu";
            // 
            // rbKiralik
            // 
            rbKiralik.Location = new Point(160, 35);
            rbKiralik.Margin = new Padding(4, 3, 4, 3);
            rbKiralik.Name = "rbKiralik";
            rbKiralik.Size = new Size(89, 24);
            rbKiralik.TabIndex = 1;
            rbKiralik.Text = "Kiralık";
            rbKiralik.UseVisualStyleBackColor = true;
            // 
            // rbSatilik
            // 
            rbSatilik.Checked = true;
            rbSatilik.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rbSatilik.Location = new Point(38, 35);
            rbSatilik.Margin = new Padding(4, 3, 4, 3);
            rbSatilik.Name = "rbSatilik";
            rbSatilik.Size = new Size(81, 24);
            rbSatilik.TabIndex = 0;
            rbSatilik.TabStop = true;
            rbSatilik.Text = "Satılık";
            rbSatilik.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.2F);
            label5.Location = new Point(19, 366);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 10;
            label5.Text = "Oda Sayısı : ";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Navy;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(597, 619);
            btnKaydet.Margin = new Padding(4, 3, 4, 3);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(164, 48);
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "İlanı Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // numKat
            // 
            numKat.Location = new Point(179, 421);
            numKat.Margin = new Padding(5, 3, 5, 3);
            numKat.Minimum = new decimal(new int[] { 2, 0, 0, int.MinValue });
            numKat.Name = "numKat";
            numKat.Size = new Size(190, 27);
            numKat.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 10.2F);
            label9.Location = new Point(19, 428);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(138, 20);
            label9.TabIndex = 13;
            label9.Text = "Bulunduğu Kat : ";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpIlanBilgileri);
            tabControl1.Controls.Add(tpKonum);
            tabControl1.Controls.Add(tpIletisim);
            tabControl1.Location = new Point(32, 38);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(729, 557);
            tabControl1.TabIndex = 14;
            // 
            // tpIlanBilgileri
            // 
            tpIlanBilgileri.Controls.Add(txtBinaYasi);
            tpIlanBilgileri.Controls.Add(lblBinaYasi);
            tpIlanBilgileri.Controls.Add(label1);
            tpIlanBilgileri.Controls.Add(label9);
            tpIlanBilgileri.Controls.Add(txtBaslik);
            tpIlanBilgileri.Controls.Add(numKat);
            tpIlanBilgileri.Controls.Add(label4);
            tpIlanBilgileri.Controls.Add(cmbTur);
            tpIlanBilgileri.Controls.Add(label5);
            tpIlanBilgileri.Controls.Add(cmbOda);
            tpIlanBilgileri.Controls.Add(groupBox1);
            tpIlanBilgileri.Controls.Add(label2);
            tpIlanBilgileri.Controls.Add(txtFiyat);
            tpIlanBilgileri.Controls.Add(numMetrekare);
            tpIlanBilgileri.Controls.Add(label3);
            tpIlanBilgileri.Location = new Point(4, 29);
            tpIlanBilgileri.Name = "tpIlanBilgileri";
            tpIlanBilgileri.Padding = new Padding(3);
            tpIlanBilgileri.Size = new Size(721, 524);
            tpIlanBilgileri.TabIndex = 0;
            tpIlanBilgileri.Text = "İlan Bilgileri";
            tpIlanBilgileri.UseVisualStyleBackColor = true;
            tpIlanBilgileri.Click += tpIlanBilgileri_Click;
            // 
            // txtBinaYasi
            // 
            txtBinaYasi.Location = new Point(177, 481);
            txtBinaYasi.Name = "txtBinaYasi";
            txtBinaYasi.Size = new Size(192, 27);
            txtBinaYasi.TabIndex = 15;
            txtBinaYasi.TextChanged += txtBinaYas_TextChanged;
            // 
            // lblBinaYasi
            // 
            lblBinaYasi.AutoSize = true;
            lblBinaYasi.Location = new Point(19, 481);
            lblBinaYasi.Name = "lblBinaYasi";
            lblBinaYasi.Size = new Size(92, 20);
            lblBinaYasi.TabIndex = 14;
            lblBinaYasi.Text = "Bina Yaşı : ";
            // 
            // tpKonum
            // 
            tpKonum.Controls.Add(rtbAdres);
            tpKonum.Controls.Add(label6);
            tpKonum.Controls.Add(label8);
            tpKonum.Controls.Add(cmbIlce);
            tpKonum.Controls.Add(label7);
            tpKonum.Controls.Add(cmbSehir);
            tpKonum.Location = new Point(4, 29);
            tpKonum.Name = "tpKonum";
            tpKonum.Padding = new Padding(3);
            tpKonum.Size = new Size(721, 524);
            tpKonum.TabIndex = 1;
            tpKonum.Text = "Konum ve Detaylar";
            tpKonum.UseVisualStyleBackColor = true;
            // 
            // rtbAdres
            // 
            rtbAdres.Location = new Point(210, 192);
            rtbAdres.Margin = new Padding(4, 3, 4, 3);
            rtbAdres.Name = "rtbAdres";
            rtbAdres.Size = new Size(217, 135);
            rtbAdres.TabIndex = 3;
            rtbAdres.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10.2F);
            label6.Location = new Point(49, 74);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 4;
            label6.Text = "Bulunduğu İl : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 10.2F);
            label8.Location = new Point(49, 192);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 6;
            label8.Text = "Açık Adres : ";
            // 
            // cmbIlce
            // 
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Location = new Point(210, 126);
            cmbIlce.Margin = new Padding(4, 3, 4, 3);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(188, 28);
            cmbIlce.TabIndex = 1;
            cmbIlce.SelectedIndexChanged += cmbIlce_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 10.2F);
            label7.Location = new Point(49, 134);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(139, 20);
            label7.TabIndex = 5;
            label7.Text = "Bulunduğu İlçe : ";
            // 
            // cmbSehir
            // 
            cmbSehir.FormattingEnabled = true;
            cmbSehir.Items.AddRange(new object[] { "Adana", "Ankara", "Antalya", "Bursa", "Eskişehir", "Gaziantep", "İstanbul (Anadolu)", "İstanbul (Avrupa)", "İzmir", "Kayseri", "Kocaeli", "Konya", "Mersin", "Samsun", "Şanlıurfa", "Trabzon" });
            cmbSehir.Location = new Point(210, 66);
            cmbSehir.Margin = new Padding(4, 3, 4, 3);
            cmbSehir.Name = "cmbSehir";
            cmbSehir.Size = new Size(188, 28);
            cmbSehir.TabIndex = 0;
            cmbSehir.SelectedIndexChanged += cmbSehir_SelectedIndexChanged;
            // 
            // tpIletisim
            // 
            tpIletisim.Controls.Add(msktxtNumara);
            tpIletisim.Controls.Add(rtbIletisimAdres);
            tpIletisim.Controls.Add(txtAdSoyad);
            tpIletisim.Controls.Add(label13);
            tpIletisim.Controls.Add(label12);
            tpIletisim.Controls.Add(label11);
            tpIletisim.Location = new Point(4, 29);
            tpIletisim.Name = "tpIletisim";
            tpIletisim.Size = new Size(721, 524);
            tpIletisim.TabIndex = 2;
            tpIletisim.Text = "İletişim Bilgileri";
            tpIletisim.UseVisualStyleBackColor = true;
            // 
            // msktxtNumara
            // 
            msktxtNumara.Location = new Point(216, 96);
            msktxtNumara.Mask = "(999) 000-0000";
            msktxtNumara.Name = "msktxtNumara";
            msktxtNumara.Size = new Size(179, 27);
            msktxtNumara.TabIndex = 6;
            msktxtNumara.MaskInputRejected += msktxtNumara_MaskInputRejected;
            // 
            // rtbIletisimAdres
            // 
            rtbIletisimAdres.Location = new Point(162, 163);
            rtbIletisimAdres.Name = "rtbIletisimAdres";
            rtbIletisimAdres.Size = new Size(233, 120);
            rtbIletisimAdres.TabIndex = 5;
            rtbIletisimAdres.Text = "";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(216, 48);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(179, 27);
            txtAdSoyad.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(31, 166);
            label13.Name = "label13";
            label13.Size = new Size(65, 20);
            label13.TabIndex = 2;
            label13.Text = "Adres : ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(31, 96);
            label12.Name = "label12";
            label12.Size = new Size(158, 20);
            label12.TabIndex = 1;
            label12.Text = "Telefon Numarası : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(31, 48);
            label11.Name = "label11";
            label11.Size = new Size(113, 20);
            label11.TabIndex = 0;
            label11.Text = "Adı - Soyadı : ";
            label11.Click += label11_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(55, 618);
            button1.Name = "button1";
            button1.Size = new Size(168, 49);
            button1.TabIndex = 15;
            button1.Text = "Listeye Dön";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(835, 704);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Controls.Add(btnKaydet);
            Font = new Font("Georgia", 10.2F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni İlan Ekle";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)numMetrekare).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numKat).EndInit();
            tabControl1.ResumeLayout(false);
            tpIlanBilgileri.ResumeLayout(false);
            tpIlanBilgileri.PerformLayout();
            tpKonum.ResumeLayout(false);
            tpKonum.PerformLayout();
            tpIletisim.ResumeLayout(false);
            tpIletisim.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtBaslik;
        private ComboBox cmbTur;
        private Label label2;
        private TextBox txtFiyat;
        private Label label3;
        private Label label4;
        private NumericUpDown numMetrekare;
        private ComboBox cmbOda;
        private GroupBox groupBox1;
        private RadioButton rbKiralik;
        private RadioButton rbSatilik;
        private Label label5;
        private Button btnKaydet;
        private NumericUpDown numKat;
        private Label label9;
        private TabControl tabControl1;
        private TabPage tpIlanBilgileri;
        private TabPage tpKonum;
        private Label label8;
        private Label label7;
        private Label label6;
        private RichTextBox rtbAdres;
        private ComboBox cmbIlce;
        private ComboBox cmbSehir;
        private Button button1;
        private TextBox txtBinaYasi;
        private Label label10;
        private TabPage tpIletisim;
        private Label label12;
        private Label label11;
        private Label label13;
        private MaskedTextBox msktxtNumara;
        private RichTextBox rtbIletisimAdres;
        private TextBox txtAdSoyad;
        private Label lblBinaYasi;
    }
}