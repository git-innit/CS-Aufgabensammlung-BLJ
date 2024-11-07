namespace Aufgabe_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Kleines 1x1");
            Console.WriteLine("-----------\n");

            for (int i1 = 1; i1 <= 10; i1++)
            {
                for (int i2 = 1; i2 <= 10; i2++)
                {
                    int zahl = i1 * i2;
                    Console.Write(zahl + "\t");
                }
                Console.Write("\n");
            }
        }
    }
}
