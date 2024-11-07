namespace Aufgabe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] monate = ["Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "Spetember", "Oktober", "November", "Dezember"];
            string akt_monat = null;

            Console.Write("Zahl eingeben: ");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            if (eingabe < 1 || eingabe > 12 )
            {
                Console.WriteLine("Eingabe ungültig. Gib eine Zahl von 1 bis 12 ein.");
                Environment.Exit(1);
            }

            switch (eingabe)
            {
                case 1: akt_monat = monate[0]; break; case 2: akt_monat = monate[1]; break;
                case 3: akt_monat = monate[2]; break; case 4: akt_monat = monate[3]; break;
                case 5: akt_monat = monate[4]; break; case 6: akt_monat = monate[5]; break;
                case 7: akt_monat = monate[6]; break; case 8: akt_monat = monate[7]; break;
                case 9: akt_monat = monate[8]; break; case 10: akt_monat = monate[9]; break;
                case 11: akt_monat = monate[10]; break; case 12: akt_monat = monate[11]; break;
            }
            Console.WriteLine("Monat: {0}",akt_monat);
        }
    }
}
