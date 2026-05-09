using System.Collections.Generic;
using System.IO;

namespace EmlakOfisiPortfoy
{
    public static class Veri
    {
        public static List<Ilan> Ilanlar = new List<Ilan>();

        static string dosyaYolu = "ilanlar.txt";

        public static void DosyayaKaydet()
        {
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                foreach (Ilan ilan in Ilanlar)
                {
                    sw.WriteLine(
                        ilan.Baslik + "|" +
                        ilan.Tur + "|" +
                        ilan.Fiyat + "|" +
                        ilan.Metrekare + "|" +
                        ilan.Sehir + "|" +
                        ilan.Ilce + "|" +
                        ilan.Adres + "|" +
                        ilan.BulunduguKat + "|" +
                        ilan.OdaSayisi + "|" +
                        ilan.Durum + "|" +
                        ilan.BinaYasi + "|" +
                        ilan.AdSoyad + "|" +
                        ilan.Telefon + "|" +
                        ilan.IletisimAdres
                    );
                }
            }
        }

        public static void DosyadanOku()
        {
            Ilanlar.Clear();

            if (!File.Exists(dosyaYolu))
                return;

            string[] satirlar = File.ReadAllLines(dosyaYolu);

            foreach (string satir in satirlar)
            {
                string[] parcalar = satir.Split('|');

                if (parcalar.Length == 14)
                {
                    Ilan ilan = new Ilan();

                    ilan.Baslik = parcalar[0];
                    ilan.Tur = parcalar[1];
                    ilan.Fiyat = decimal.Parse(parcalar[2]);
                    ilan.Metrekare = int.Parse(parcalar[3]);
                    ilan.Sehir = parcalar[4];
                    ilan.Ilce = parcalar[5];
                    ilan.Adres = parcalar[6];
                    ilan.BulunduguKat = parcalar[7];
                    ilan.OdaSayisi = parcalar[8];
                    ilan.Durum = parcalar[9];
                    ilan.BinaYasi = parcalar[10];
                    ilan.AdSoyad = parcalar[11];
                    ilan.Telefon = parcalar[12];
                    ilan.IletisimAdres = parcalar[13];

                    Ilanlar.Add(ilan);
                }
            }
        }
    }
}