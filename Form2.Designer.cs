namespace EmlakOfisiPortfoy
{
    partial class Form2
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
            lstIlanlar = new ListBox();
            btnYeni = new Button();
            btnSil = new Button();
            txtAra = new Label();
            txtArama = new TextBox();
            label1 = new Label();
            rtbDetay = new RichTextBox();
            SuspendLayout();
            // 
            // lstIlanlar
            // 
            lstIlanlar.FormattingEnabled = true;
            lstIlanlar.Location = new Point(16, 102);
            lstIlanlar.Name = "lstIlanlar";
            lstIlanlar.Size = new Size(383, 344);
            lstIlanlar.TabIndex = 0;
            lstIlanlar.SelectedIndexChanged += lstIlanlar_SelectedIndexChanged;
            // 
            // btnYeni
            // 
            btnYeni.BackColor = Color.Navy;
            btnYeni.FlatStyle = FlatStyle.Flat;
            btnYeni.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnYeni.ForeColor = Color.White;
            btnYeni.Location = new Point(256, 482);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(143, 36);
            btnYeni.TabIndex = 1;
            btnYeni.Text = "Yeni İlan Ekle";
            btnYeni.UseVisualStyleBackColor = false;
            btnYeni.Click += btnYeni_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Navy;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(33, 482);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(115, 36);
            btnSil.TabIndex = 2;
            btnSil.Text = "İlan Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // txtAra
            // 
            txtAra.AutoSize = true;
            txtAra.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAra.Location = new Point(16, 39);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(104, 21);
            txtAra.TabIndex = 3;
            txtAra.Text = "İlan Ara : ";
            // 
            // txtArama
            // 
            txtArama.Location = new Point(149, 33);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(229, 27);
            txtArama.TabIndex = 4;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FloralWhite;
            label1.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(483, 68);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 5;
            label1.Text = "İlan Detayı";
            // 
            // rtbDetay
            // 
            rtbDetay.Location = new Point(483, 102);
            rtbDetay.Name = "rtbDetay";
            rtbDetay.Size = new Size(365, 344);
            rtbDetay.TabIndex = 6;
            rtbDetay.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(917, 595);
            Controls.Add(rtbDetay);
            Controls.Add(label1);
            Controls.Add(txtArama);
            Controls.Add(txtAra);
            Controls.Add(btnSil);
            Controls.Add(btnYeni);
            Controls.Add(lstIlanlar);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İlan Paneli";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstIlanlar;
        private Button btnYeni;
        private Button btnSil;
        private Label txtAra;
        private TextBox txtArama;
        private Label label1;
        private RichTextBox rtbDetay;
    }
}