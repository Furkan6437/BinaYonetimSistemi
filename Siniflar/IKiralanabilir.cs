using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimSistemi.Siniflar
{
    public interface IKiralanabilir
    {
        void Kirala(string isim);
        void KiraBitir();
    }
}
