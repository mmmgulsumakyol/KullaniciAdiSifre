using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Kullanıcı_Adı_Şifre_Uygulaması
{
    internal class OrtalamaHesapla:SİnavNotlari
    {
        private double sonuc;
        public double Sonuc
        {
            get { return sonuc; } set { sonuc = value; } }
        public double OrtHesapla()
        {
            sonuc = (Sinav1 + Sinav2 ) / 2;
            return sonuc;
        }

    }
    
}
