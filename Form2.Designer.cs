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
            lstIlanlar.Location = new Point(12, 102);
            lstIlanlar.Name = "lstIlanlar";
            lstIlanlar.Size = new Size(462, 344);
            lstIlanlar.TabIndex = 0;
            lstIlanlar.SelectedIndexChanged += lstIlanlar_SelectedIndexChanged;
            // 
            // btnYeni
            // 
            btnYeni.Location = new Point(222, 464);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(120, 29);
            btnYeni.TabIndex = 1;
            btnYeni.Text = "Yeni İlan Ekle";
            btnYeni.UseVisualStyleBackColor = true;
            btnYeni.Click += btnYeni_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(380, 464);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 2;
            btnSil.Text = "İlan Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtAra
            // 
            txtAra.AutoSize = true;
            txtAra.Location = new Point(12, 26);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(60, 20);
            txtAra.TabIndex = 3;
            txtAra.Text = "İlan Ara";
            // 
            // txtArama
            // 
            txtArama.Location = new Point(130, 26);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(125, 27);
            txtArama.TabIndex = 4;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(556, 75);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 5;
            label1.Text = "İlan Detayı";
            // 
            // rtbDetay
            // 
            rtbDetay.Location = new Point(540, 102);
            rtbDetay.Name = "rtbDetay";
            rtbDetay.Size = new Size(446, 242);
            rtbDetay.TabIndex = 6;
            rtbDetay.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 522);
            Controls.Add(rtbDetay);
            Controls.Add(label1);
            Controls.Add(txtArama);
            Controls.Add(txtAra);
            Controls.Add(btnSil);
            Controls.Add(btnYeni);
            Controls.Add(lstIlanlar);
            Name = "Form2";
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