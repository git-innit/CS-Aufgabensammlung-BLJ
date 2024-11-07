namespace Aufgabe_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prüfen, ob es sich bei einem Jahr um ein Schaltjahr handelt.");
            Console.WriteLine("************************************************************\n");
            while (true)
            {
                int jahr = 0;
                bool ist_schaltjahr = false;
                Console.Write("Eingabe Jahr (q to quit): ");
                string eingabe = Console.ReadLine();
                if (eingabe.ToLower() == "q")
                {
                    Environment.Exit(0);
                }
                jahr = Convert.ToInt32(eingabe);
                if (jahr % 4 == 0 || jahr % 100 == 0)
                {
                    ist_schaltjahr = true;
                }
                if (jahr % 400 == 0)
                {
                    ist_schaltjahr = false;
                }
                if (ist_schaltjahr == true)
                {
                    Console.WriteLine("\nDas Jahr {0} ist ein Schaltjahr.\n",jahr);
                }
                else
                {
                    Console.WriteLine("\nDas Jahr {0} ist KEIN Schaltjahr.\n", jahr);
                }
            }

        }
    }
}
