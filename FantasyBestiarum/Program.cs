namespace FantasyBestiarum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzornyAdatbazis dbKezelo = new SzornyAdatbazis();
            List<Szorny> szornyek = dbKezelo.Feltolt();
            Szornyelemzo szornyelemzo = new Szornyelemzo(szornyek);
            Console.WriteLine($"Szörnyek száma: {szornyelemzo.OsszeszornyekSzama}");
            Console.WriteLine($"Veszélyes szörnyek: ");
            foreach (var szornyNev in szornyelemzo.LegveszelyesebbSzornyekNevei())
            {
                Console.WriteLine(szornyNev);
            }
            Console.WriteLine();
            Console.WriteLine("Élőhelyek(egyediség szerint): ");
            foreach (var elohely in szornyelemzo.Egyedielohelyek())
            {
                Console.WriteLine(elohely);
            }
            Console.WriteLine();
            Console.WriteLine($"Átlagos veszélyességi szint {szornyelemzo.AtlagosVeszelyessegSzint}");
            Console.WriteLine("Legveszélyesebb szörnyek: ");
            foreach (var szorny in szornyelemzo.LegveszelyesebbSzornyek())
            {
                Console.WriteLine(szorny);
            }
            Console.WriteLine();
            Console.WriteLine("A mocsári veszélyes szörnyek: ");
            foreach (var szorny in szornyelemzo.MocsariVeszelyesSzornyek())
            {
                Console.WriteLine(szorny);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
