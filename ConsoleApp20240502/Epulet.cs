using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20240502
{
    public class Epulet
    {
        public int rang;
        public string nev;
        public string varos_orszag;
        public double magassag_m;
        public double magassag_ft;
        public int emeletek_szama;
        public int epites_eve;

        public Epulet(int rang, string nev, string varos_orszag, double magassag_m, double magassag_ft, int emeletek_szama, int epites_eve)
        {
            this.rang = rang;
            this.nev = nev;
            this.varos_orszag = varos_orszag;
            this.magassag_m = magassag_m;
            this.magassag_ft = magassag_ft;
            this.emeletek_szama = emeletek_szama;
            this.epites_eve = epites_eve;
        }
    }
}
