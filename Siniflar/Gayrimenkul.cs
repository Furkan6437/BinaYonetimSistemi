using System;

namespace BinaYonetimSistemi.Siniflar
{
    public abstract class Mulk
    {
        public static int ToplamSayi = 0;

        private string kapiNumarasi;
        private int kat;
        private int metrekare;

        public string KapiNumarasi
        {
            get { return kapiNumarasi; }
            set
            {
                if (value == "" || value == null)
                    throw new Exception("Kapı no boş girilemez.");
                kapiNumarasi = value;
            }
        }

        public int Metrekare
        {
            get { return metrekare; }
            set
            {
                if (value < 0)
                    throw new Exception("Metrekare eksi olamaz.");
                metrekare = value;
            }
        }

        public int Kat
        {
            get { return kat; }
            set
            {
                if (value < -5 || value > 50)
                    throw new Exception("Hatalı kat girişi.");
                kat = value;
            }
        }

        public Mulk(string kapi, int m2, int katNo)
        {
            KapiNumarasi = kapi;
            Metrekare = m2;
            Kat = katNo;

            ToplamSayi++;
        }

        public abstract double UcretHesapla();
    }
}