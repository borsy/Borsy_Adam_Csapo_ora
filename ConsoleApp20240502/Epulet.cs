using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20240502
{
    public class Epulet
    {
        private int rang;
        private string nev;
        private string varos_orszag;
        private double magassag_m;
        private int magassag_ft;
        private int emeletek_szama;
        private int epites_eve;
        private string alapanyag;
        private string felhasznalas;

        public Epulet(int rang, string nev, string varos_orszag, int magassag_m, int magassag_ft, int emeletek_szama, int epites_eve, string alapanyag, string felhasznalas)
        {
            this.rang = rang;
            this.nev = nev;
            this.varos_orszag = varos_orszag;
            this.magassag_m = magassag_m;
            this.magassag_ft = magassag_ft;
            this.emeletek_szama = emeletek_szama;
            this.epites_eve = epites_eve;
            this.alapanyag = alapanyag;
            this.felhasznalas = felhasznalas;
        }
    }
}
