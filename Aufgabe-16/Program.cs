namespace Aufgabe_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            while (true)
            {
                int zahl = rnd.Next(1, 101);

                int eingabe = 0, counter = 1;

                Console.WriteLine("Deine Zahl (1..100):");
                while (true)
                {
                    eingabe = Convert.ToInt32(Console.ReadLine());
                    if (eingabe > zahl)
                    {
                        Console.WriteLine("Zahl ist zu gross! Nächster Versuch:");
                        counter++;
                        continue;
                    }
                    else if (eingabe < zahl)
                    {
                        Console.WriteLine("Zahl ist zu klein! Nächster Versuch:");
                        counter++;
                        continue;
                    }
                    else if (eingabe == zahl)
                    {
                        Console.WriteLine("Die Zahl stimmt! Du hast total {0} Versuche benötigt. Noch einmal spielen? [y/n]", counter);
                        char nochmal = Console.ReadLine().ToLower()[0];
                        if (nochmal == 'y')
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }
    }
}
