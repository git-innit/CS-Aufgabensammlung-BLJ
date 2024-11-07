namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Breite des Stammes? ");
            int b_s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Höhe des Stammes? ");
            int h_s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Höhe der Krone? ");
            int h_k = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            ZeichneKrone(h_k);
            ZeichneStamm(b_s, h_s, h_k);
        }

        static void ZeichneStamm(int breiteStamm, int hoeheStamm, int hoeheKrone)
        {

            for (int i = 0; i < hoeheStamm; i++)
            {
                ZeichneZeile(((((hoeheKrone * 2) - 1) - breiteStamm) / 2), breiteStamm);
            }
        }

        static void ZeichneKrone(int hoeheKrone)
        {
            for (int i = 0; i < hoeheKrone; i++)
            {
               ZeichneZeile((hoeheKrone - i - 1),(i * 2) + 1);
            }
        }

        static void ZeichneZeile(int anzahlLeer, int anzahlSterne)
        {
            for (int i = 0; i < anzahlLeer; i++)
            {
                Console.Write(" ");
            }
            for 
                (int i = 0; i < anzahlSterne; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}