using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyBestiarum
{
    internal class Szorny
    {
        private int id;
        private string nev;
        private int veszelyessegSzint;
        private string elohely;
        private string foGyengeseg;
        private string LeggyakoribbZsakmany;
        private bool veszelyesE;

        public Szorny(int id, string nev, int veszelyessegSzint, string elohely, string foGyengeseg, string leggyakoribbZsakmany, bool veszelyesE)
        {
            this.id = id;
            this.nev = nev;
            this.veszelyessegSzint = veszelyessegSzint;
            this.elohely = elohely;
            this.foGyengeseg = foGyengeseg;
            LeggyakoribbZsakmany = leggyakoribbZsakmany;
            this.veszelyesE = veszelyesE;
        }

        public int Id { get => id; }
        public string Nev { get => nev; }
        public int VeszelyessegSzint { get => veszelyessegSzint; }
        public string Elohely { get => elohely; }
        public string FoGyengeseg { get => foGyengeseg; }
        public string LeggyakoribbZsakmany1 { get => LeggyakoribbZsakmany;  }
        public bool VeszelyesE { get => veszelyesE;  }




        public override string ToString()
        {
            return $"Név: {nev}, Veszélyesség Szint: {veszelyessegSzint}, Élőhely: {elohely}, Fő Gyengeség: {foGyengeseg}, Leggyakoribb Zsákmány: {LeggyakoribbZsakmany}, Veszélyes-e: {(veszelyesE ? "Igen" : "Nem")}";
        }
    }  
}
