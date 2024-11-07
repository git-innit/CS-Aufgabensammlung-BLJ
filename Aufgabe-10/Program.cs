namespace Aufgabe_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("Zahl: ");
            int zahl = Convert.ToInt32(Console.ReadLine());
            int rzahl = zahl;

            berechneQuersumme(zahl,out sum);

            Console.WriteLine("Die Quersumme von {0} ist: {1}",rzahl,sum);
        }
        private static int berechneQuersumme(int zahl,out int sum)
        {
            sum = 0;
            while (zahl != 0)
            {
                sum = sum + (zahl % 10);
                zahl = zahl / 10;
            }
            return sum;
        }
    }
}
