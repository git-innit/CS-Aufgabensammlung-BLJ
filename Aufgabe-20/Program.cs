using Newtonsoft.Json.Linq;
using RestSharp;

namespace Aufgabe_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var client = new RestClient("https://witzapi.de");
                var request = new RestRequest("api/joke/", Method.Get);
                var response = client.Get(request);

                JArray array = JArray.Parse(response.Content);
                string text = array[0]["text"].ToString();

                Console.WriteLine(text + "\n");
                Console.Write("Nächsten Witz holen? j/n  ");
                if (Console.ReadLine().ToLower() == "j")
                {
                    Console.Write("\n");
                    continue;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
