namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Zahl 1:");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zahl 2:");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Zahl\t| Quersumme\t| Zahl / Quersumme");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");

            for (int i = zahl1; i <= zahl2; i++)
            {
                berechneQuersumme(i, out sum);

                if (i % sum == 0)
                {
                    Console.Write(i + "\t|");
                    Console.Write(sum + "\t\t|");
                    Console.Write((i / sum) + "\n");
                }
            }
        }
        private static int berechneQuersumme(int i, out int sum)
        {
            sum = 0;
            while (i != 0)
            {
                sum = sum + (i % 10);
                i = i / 10;
            }
            return sum;
        }
    }
}
