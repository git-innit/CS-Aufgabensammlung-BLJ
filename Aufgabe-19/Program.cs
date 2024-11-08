namespace Aufgabe_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int output = 0;

                    Console.WriteLine("Make your calculation (or press Q to quit):");
                    string eingabe = Console.ReadLine();
                    if (eingabe.ToLower() == "q")
                    {
                        Environment.Exit(0);
                    }
                    eingabe = eingabe.Trim();

                    if (eingabe.Contains("+"))
                    {
                        output = Rechner(eingabe, '+');
                    }
                    else if (eingabe.Contains("-"))
                    {
                        output = Rechner(eingabe, '-');
                    }
                    else if (eingabe.Contains("*"))
                    {
                        output = Rechner(eingabe, '*');
                    }
                    else if (eingabe.Contains("/"))
                    {
                        output = Rechner(eingabe, '/');
                    }
                    else
                    {
                        throw new Exception();
                    }

                    Console.WriteLine(output);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ungültige Eingabe.\n");
                    continue;
                }
            }
        }
        private static int Rechner(string eingabe,char aktion)
        {
            string[] eingabe_zahlen_str = eingabe.Split(aktion);
            int[] zahlen = new int[eingabe_zahlen_str.Length];
            int rueckgabewert = 0;
            for (int i = 0; i < eingabe_zahlen_str.Length; i++)
            {
                zahlen[i] = Convert.ToInt32(eingabe_zahlen_str[i]);
            }
            switch (aktion)
            {
                case '+': rueckgabewert = zahlen[0] + zahlen[1]; break;
                case '-': rueckgabewert = zahlen[0] - zahlen[1]; break;
                case '*': rueckgabewert = zahlen[0] * zahlen[1]; break;
                case '/': rueckgabewert = zahlen[0] / zahlen[1]; break;
                default: throw new Exception();
            }
            return rueckgabewert;
        }
    }
}
