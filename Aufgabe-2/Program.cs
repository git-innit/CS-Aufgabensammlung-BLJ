namespace Augabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anz_tage = 0;
            Console.WriteLine("Berechnung von Sekunden eines Monats in Abhängigkeit seiner Anzahl Tage");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Wieviele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen?");
            try
            {
                anz_tage = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ungültige Eingabe. Ganzzahl erwartet.");
                Environment.Exit(1);
            }
            
            int sekunden = anz_tage * 86400;

            if (anz_tage <= 28 || anz_tage >= 31)
            {
                Console.WriteLine("Ungültige Eingabe. Ein Monat mit {0} Tagen gibt's nicht.", anz_tage);
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Ein Monat mit {0} Tagen hat {1} Sekunden.", anz_tage, sekunden);
            }
        }
    }
}
