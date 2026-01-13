using System;

namespace BinaYonetimSistemi.Siniflar
{
    public class Dukkan : Mulk, IKiralanabilir
    {
        public string IsletmeAdi { get; set; }

        public Dukkan(string kapi, int m2, int katNo) : base(kapi, m2, katNo)
        {
            IsletmeAdi = "Yok";
        }

        public override double UcretHesapla()
        {
            return (Metrekare * 10) + 100;
        }

        public void Kirala(string isim)
        {
            IsletmeAdi = isim;
        }

        public void KiraBitir()
        {
            IsletmeAdi = "Yok";
        }
    }
}