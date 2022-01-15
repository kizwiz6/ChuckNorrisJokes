using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChuckNorrisJokes
{
    internal class Program
    {
        HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.getChuckNorrisJokes();
        }

        private async Task getChuckNorrisJokes()
        {
            string response = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");

            Console.WriteLine(response);
            Console.ReadLine();
        }

    }
}
