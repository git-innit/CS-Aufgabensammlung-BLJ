namespace Aufgabe_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------------------");
            Console.WriteLine("Zahlen Aufsummieren");
            Console.WriteLine("-------------------");
            Console.WriteLine("\nGeben Sie die zu summierenden Ganzzahlen mit Komma getrennt ein: ");
            string eingabe_str = Console.ReadLine();
            string[] eingabe_arr = eingabe_str.Split(',');
            int[] zahlen = new int[eingabe_arr.Length];

            for (int i = 0; i < eingabe_arr.Length; i++)
            {
                zahlen[i] = Convert.ToInt32(eingabe_arr[i]);
            }

            SumUp(zahlen,out int[] summen);

            Console.WriteLine("\nResultat:");
            for (int i = 0; i < summen.Length; i++)
            {
                Console.Write("[{0}] -> {1}", i, summen[i]);
                if (i < summen.Length - 1)
                {
                    Console.Write(", ");
                }
            }
        }
        private static void SumUp(int[] zahlen,out int[] summen)
        {
            int previous_nr = 0;
            summen = new int[zahlen.Length];
            for (int i = 0; i < zahlen.Length; i++)
            {
                summen[i] = zahlen[i] + previous_nr;
                previous_nr = summen[i];
            }
           
        }
    }
}
