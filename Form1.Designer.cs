namespace EmlakOfisiPortfoy
{
    partial class FormGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            label1 = new Label();
            txtKullanici = new TextBox();
            label2 = new Label();
            txtSifre = new TextBox();
            btnGiris = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 266);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı : ";
            label1.Click += label1_Click;
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(249, 266);
            txtKullanici.Margin = new Padding(4, 3, 4, 3);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(194, 28);
            txtKullanici.TabIndex = 1;
            txtKullanici.TextChanged += txtKullanici_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 317);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 2;
            label2.Text = "Şifre : ";
            label2.Click += label2_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(249, 314);
            txtSifre.Margin = new Padding(4, 3, 4, 3);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(194, 28);
            txtSifre.TabIndex = 3;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Navy;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris.ForeColor = Color.White;
            btnGiris.Location = new Point(339, 375);
            btnGiris.Margin = new Padding(4, 3, 4, 3);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(104, 38);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.kapali_goz;
            pictureBox1.Location = new Point(416, 321);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(173, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(352, 219);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(696, 449);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(txtKullanici);
            Controls.Add(label1);
            Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danışman Girişi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKullanici;
        private Label label2;
        private TextBox txtSifre;
        private Button btnGiris;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}
