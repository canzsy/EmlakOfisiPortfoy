namespace EmlakOfisiPortfoy
{
    public class Ilan
    {
        public string Baslik { get; set; }
        public string Tur { get; set; }
        public decimal Fiyat { get; set; }
        public string Konum { get; set; }
        public int Metrekare { get; set; }
        public string OdaSayisi { get; set; }
        public string Durum { get; set; }

        public override string ToString()
        {
            return Baslik + " | " + Tur + " | " + Durum + " | " + Fiyat + " TL";
        }
    }
}