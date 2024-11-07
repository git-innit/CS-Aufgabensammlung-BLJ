namespace Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm berechnet die Summe von zwei Zahlen.\n");
            Console.Write("Zahl 1: ");
            int eingabe1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zahl 2: ");
            int eingabe2 = Convert.ToInt32(Console.ReadLine());

            int summe = eingabe1 + eingabe2;

            Console.WriteLine("Summe: {0}", summe);
        }
    }
}
