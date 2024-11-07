namespace Aufgabe_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gib ein Geburtsdatum ein: ");
            DateTime eingabe;
            if (!DateTime.TryParse(Console.ReadLine(), out eingabe))
            {
                Console.WriteLine("Ungültiges Datum.");
                return;
            }

            DateTime heute = DateTime.Today;

            int jahre = heute.Year - eingabe.Year;
            int monate = heute.Month - eingabe.Month;
            int tage = heute.Day - eingabe.Day;

            if (tage < 0)
            {
                monate -= 1;
                tage += DateTime.DaysInMonth(heute.Year, heute.Month == 1 ? 12 : heute.Month - 1);
            }
            if (monate < 0)
            {
                jahre -= 1;
                monate += 12;
            }

            TimeSpan alter = heute - eingabe;
            int wochen = alter.Days / 7;
            int tage_gesamt = alter.Days;

            Console.WriteLine("\nAlter in Jahren: {0}", jahre);
            Console.WriteLine("Alter in Monaten: {0}", jahre * 12 + monate);
            Console.WriteLine("Alter in Wochen: {0}", wochen);
            Console.WriteLine("Alter in Tagen: {0}", tage_gesamt);
        }
    }
}
