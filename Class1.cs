namespace EmlakOfisiPortfoy
{
    public class Ilan
    {
        public string Baslik { get; set; } = string.Empty; //
        public string Tur { get; set; } = string.Empty;    //
        public string Sehir { get; set; } = string.Empty;  // Yeni eklendi
        public string Ilce { get; set; } = string.Empty;   // Yeni eklendi
        public string Adres { get; set; } = string.Empty;  // Yeni eklendi
        public decimal Fiyat { get; set; }
        public int Metrekare { get; set; }
        public string BulunduguKat { get; set; } = string.Empty;
        public string OdaSayisi { get; set; } = string.Empty;
        public string Durum { get; set; } = string.Empty;
        public override string ToString()
        {
            // Listede görünmesini istediğin özellikleri buraya yazabilirsin.
            // Örneğin: "BAŞLIK - ŞEHİR" şeklinde görünmesi için:
            return this.Baslik + " - " + this.Sehir;
        }
    }
}