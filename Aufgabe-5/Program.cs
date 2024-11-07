namespace Aufgabe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bereit_true = ["ja", "j", "jo", "jup", "yes", "y"];

            Console.WriteLine("Wie viele Kilometer möchtest du rennen? ");
            int anz_km = Convert.ToInt32(Console.ReadLine());

            if (anz_km > 42)
            {
                Console.WriteLine("Das schaffst du nicht!");
                Environment.Exit(0);
            }

            int bahnrunden = ((anz_km * 1000) / 400);

            Console.Write("Das sind {0} Runden. Bereit für den Lauf? ",bahnrunden);
            if (!bereit_true.Contains(Console.ReadLine().ToLower()))
            {
                Environment.Exit(0);
            }

            int i = 1;

            while (i <= bahnrunden)
            {
                Console.WriteLine("Du läufst Runde {0}",i);
                i++;
            }
            Console.WriteLine("Du hast es geschafft!");
        }
    }
}
