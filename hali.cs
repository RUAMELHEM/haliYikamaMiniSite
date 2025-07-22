using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nttttttpOdevi
{
    class hali
    {
        public string Sahibi { get; set; }
        public int Metrekare { get; set; }
        public string AlindigiTarih { get; set; }
        public string TahminTeslim { get; set; }
        public int Tutar { get; set; }
        public bool TeslimEdildi { get; set; }

        public hali(string sahibi, int metrekare, string alindigi, string teslim)
        {
            Sahibi = sahibi;
            Metrekare = metrekare;
            AlindigiTarih = alindigi;
            TahminTeslim = teslim;
            Tutar = metrekare * 20;
            TeslimEdildi = false;
        }

        public override string ToString()
        {
            return $"{Sahibi} | {Metrekare} m² | {Tutar} TL | Teslim: {(TeslimEdildi ? "EVET" : "HAYIR")}";
        }
    }

}
