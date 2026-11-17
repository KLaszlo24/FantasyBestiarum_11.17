using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyBestiarum
{
    internal class Szornyelemzo
    {
        private List<Szorny> szornyek;

        public Szornyelemzo(List<Szorny> szornyek)
        {
            var dbKezelo = new SzornyAdatbazis();
            this.szornyek = dbKezelo.Feltolt();
        }

        public int OsszeszornyekSzama()
        {
            return szornyek.Count();
        }

        public IEnumerable<string> LegveszelyesebbSzornyekNevei() 
        {
            var eredmeny = szornyek.Where(s => s.VeszelyesE).Select(s=> s.Nev);
            return eredmeny;


        }

        public IEnumerable<string> Egyedielohelyek()
        {
            var eredmeny = szornyek.Select(s => s.Elohely).Distinct();
            eredmeny = eredmeny.OrderBy(s => s);
            return eredmeny;
        }

        public double AtlagosVeszelyessegSzint()
        {
            var eredmeny = szornyek.Average(s => s.VeszelyessegSzint);
            return eredmeny;
        }

        public IEnumerable<Szorny> LegveszelyesebbSzornyek()
        {
            var maxVeszelyessegSzint = szornyek.Max(s => s.VeszelyessegSzint);
            var eredmeny = szornyek.Where(s => s.VeszelyessegSzint == maxVeszelyessegSzint);
            return eredmeny;
        }

        public IEnumerable<Szorny> MocsariVeszelyesSzornyek()
        {
            var eredmeny = szornyek.Where(s => s.Elohely == "Fekete Mocsár" && s.VeszelyessegSzint>=5).OrderByDescending(s=>s.VeszelyessegSzint);
            return eredmeny;
        }

        public bool VanExtremTuzGyengeSzorny()
        {
            var eredmeny = szornyek.Any(s => s.FoGyengeseg == "Tűz" && s.VeszelyessegSzint >= 9);
            return eredmeny;
        }

        public IEnumerable<string> SzornyekSzamaElohelyenkent()
        {
            var eredmeny = szornyek.GroupBy(s => s.Elohely).Select(g => $"{g.Key}: {g.Count()}");
            return eredmeny;
        }
    }

}
