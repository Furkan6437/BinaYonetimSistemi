using System;

namespace BinaYonetimSistemi.Siniflar
{
    public class Daire : Mulk, IKiralanabilir
    {
        public string OdaSayisi { get; set; }
        public string KiraciAdi { get; set; }

        public Daire(string kapi, int m2, int katNo, string oda) : base(kapi, m2, katNo)
        {
            this.OdaSayisi = oda;
        }

        public Daire(string kapi, int m2) : this(kapi, m2, 0, "1+1")
        {
        }

        public override double UcretHesapla()
        {
            return Metrekare * 5;
        }

        public void Kirala(string isim)
        {
            KiraciAdi = isim;
        }

        public void KiraBitir()
        {
            KiraciAdi = "Boş";
        }
    }
}