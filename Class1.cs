namespace EmlakOfisiPortfoy
{
    public class Ilan
    {
        public string Baslik { get; set; } = string.Empty;
        public string Tur { get; set; } = string.Empty;

        public string Sehir { get; set; } = string.Empty;
        public string Ilce { get; set; } = string.Empty;
        public string Adres { get; set; } = string.Empty;

        public decimal Fiyat { get; set; }
        public int Metrekare { get; set; }

        public string BulunduguKat { get; set; } = string.Empty;
        public string OdaSayisi { get; set; } = string.Empty;
        public string Durum { get; set; } = string.Empty;
        public string BinaYasi { get; set; } = string.Empty;

        public string AdSoyad { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
        public string IletisimAdres { get; set; } = string.Empty;

        public override string ToString()
        {
            return this.Baslik + " - " + this.Sehir;
        }
    }
}