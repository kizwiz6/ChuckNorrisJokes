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

            var ChuckNorrisJoke = JsonConvert.DeserializeObject<ChuckNorrisJoke>(response);

            Console.WriteLine(ChuckNorrisJoke);

            Console.ReadLine();
        }

    }

    /// <summary>
    ///  Create a class of properties to deserialise the JSON data
    /// </summary>
    class ChuckNorrisJoke
    {
        public string[] categories { get; set; }
        public DateTime created_at { get; set; }
        public string icon_url { get; set; }
        public string Id { get; set; }
        public DateTime updated_at { get; set; }
        public string url { get; set; }
        public string value { get; set; }
    }