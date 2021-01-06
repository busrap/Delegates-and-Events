using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvents_calisma
{
    delegate void GectiKaldiHandler(object sender, GectiKaldiErguman e);

    class GectiKaldiErguman : EventArgs
    {
        public string AdiSoyadi { get; set; }
        public double Ortalama { get; set; }

    }

    class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
       
      
        void DurumKontrol()
        {
            if (ortalama >= 70)
            {
                if (Gecti != null)

                    Gecti(this, new GectiKaldiErguman { AdiSoyadi = Adi + " " + Soyadi, Ortalama = ortalama });
            }
            else
            {
                if (Kaldi != null)

                    Kaldi(this, new GectiKaldiErguman { AdiSoyadi = Adi + " " + Soyadi, Ortalama = ortalama });
            }

        }

        private double final;

        public double Final
        {
            get { return final; }
            set { final = value; DurumKontrol(); }
        }
        private double vize;

        public double Vize
        {
            get { return vize; }
            set { vize = value; DurumKontrol(); }
        }
        public double ortalama { get { return Vize * 0.4 + Final * 0.6; } }
        public event GectiKaldiHandler Gecti;
        public event GectiKaldiHandler Kaldi;
        public override string ToString()
        {
            return Adi + " " + Soyadi + " " + ortalama;
        }



    }
}
