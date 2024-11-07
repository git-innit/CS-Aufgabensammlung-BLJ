using System.Text.RegularExpressions;

namespace Aufgabe_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] chars = ["a", "e", "i", "o", "u", "ä", "ö", "ü", "A", "E", "O", "U", "Ä", "Ö", "Ü"];
            int[] counts = new int[15];

            Console.WriteLine("Deine Eingabe:");
            string eingabe = Console.ReadLine();
            Console.Write("\n");

            counts[0] = Regex.Matches(eingabe, "a").Count; counts[1] = Regex.Matches(eingabe, "e").Count;
            counts[2] = Regex.Matches(eingabe, "i").Count; counts[3] = Regex.Matches(eingabe, "o").Count;
            counts[4] = Regex.Matches(eingabe, "u").Count; counts[5] = Regex.Matches(eingabe, "ä").Count;
            counts[6] = Regex.Matches(eingabe, "ö").Count; counts[7] = Regex.Matches(eingabe, "ü").Count;
            counts[8] = Regex.Matches(eingabe, "A").Count; counts[9] = Regex.Matches(eingabe, "E").Count;
            counts[10] = Regex.Matches(eingabe, "O").Count; counts[11] = Regex.Matches(eingabe, "U").Count;
            counts[12] = Regex.Matches(eingabe, "Ä").Count; counts[13] = Regex.Matches(eingabe, "Ö").Count;
            counts[14] = Regex.Matches(eingabe, "Ü").Count;

            int ammount = counts.Sum();

            Console.WriteLine("Dein Text hat total {0} Vokale.",ammount);

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine("Der Buchstabe '{0}' kommt {1} mal vor.", chars[i], counts[i]);
                }
            }
        }
    }
}