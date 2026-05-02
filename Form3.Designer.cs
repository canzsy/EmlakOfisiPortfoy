namespace EmlakOfisiPortfoy
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            label5 = new Label();
            rbSatilik = new RadioButton();
            rbKiralik = new RadioButton();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)numMetrekare).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 37);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "İlan Başlığı";
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(146, 37);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(151, 27);
            txtBaslik.TabIndex = 1;
            // 
            // cmbTur
            // 
            cmbTur.FormattingEnabled = true;
            cmbTur.Items.AddRange(new object[] { "Ev", "İşyeri", "Arsa" });
            cmbTur.Location = new Point(146, 89);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(151, 28);
            cmbTur.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 146);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 3;
            label2.Text = "Fiyat : ";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(146, 157);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(150, 27);
            txtFiyat.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 208);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "Metrekare : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 89);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 6;
            label4.Text = "Tür : ";
            // 
            // numMetrekare
            // 
            numMetrekare.Location = new Point(146, 208);
            numMetrekare.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numMetrekare.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMetrekare.Name = "numMetrekare";
            numMetrekare.Size = new Size(150, 27);
            numMetrekare.TabIndex = 7;
            numMetrekare.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbOda
            // 
            cmbOda.FormattingEnabled = true;
            cmbOda.Items.AddRange(new object[] { "1+0 ", "", "1+1", " ", "2+1", " ", "3+1", " ", "4+1", "", " 5+1" });
            cmbOda.Location = new Point(145, 269);
            cmbOda.Name = "cmbOda";
            cmbOda.Size = new Size(151, 28);
            cmbOda.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbKiralik);
            groupBox1.Controls.Add(rbSatilik);
            groupBox1.Location = new Point(145, 313);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "İlan Durumu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 272);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 10;
            label5.Text = "Oda Sayısı";
            // 
            // rbSatilik
            // 
            rbSatilik.AutoSize = true;
            rbSatilik.Checked = true;
            rbSatilik.Location = new Point(28, 47);
            rbSatilik.Name = "rbSatilik";
            rbSatilik.Size = new Size(70, 24);
            rbSatilik.TabIndex = 0;
            rbSatilik.TabStop = true;
            rbSatilik.Text = "Satılık";
            rbSatilik.UseVisualStyleBackColor = true;
            // 
            // rbKiralik
            // 
            rbKiralik.AutoSize = true;
            rbKiralik.Location = new Point(28, 86);
            rbKiralik.Name = "rbKiralik";
            rbKiralik.Size = new Size(71, 24);
            rbKiralik.TabIndex = 1;
            rbKiralik.Text = "Kiralık";
            rbKiralik.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(508, 406);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKaydet);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(cmbOda);
            Controls.Add(numMetrekare);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtFiyat);
            Controls.Add(label2);
            Controls.Add(cmbTur);
            Controls.Add(txtBaslik);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Yeni İlan Ekle";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)numMetrekare).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}