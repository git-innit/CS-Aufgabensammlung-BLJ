namespace Aufgabe_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lang soll die Linie sein?");
            Console.Write("Deine Eingabe: ");
            int laenge = Convert.ToInt32(Console.ReadLine());

            for (int i1 = 0; i1 < laenge; i1++)
            {
                for (int i2 = 0; i2 < laenge; i2++)
                {
                    if  (i1 != i2)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}