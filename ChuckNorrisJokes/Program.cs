using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Caching;

namespace ChuckNorrisJokes
{
    internal class Program
    {
        HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Introduction();
            Program program = new Program();
            await program.getChuckNorrisJokes();
            Console.WriteLine("\n\n If you would like a new joke, press 'J' \n");
            do
            {
                await program.getChuckNorrisJokes();
            } while (Console.ReadKey(true).Key == ConsoleKey.J);
            Console.ReadLine();
        }

        /// <summary>
        /// Sets a string response variable to retrieve parsed data via GET request and converts this data into a string by GetStringAsync which returns the Task.
        /// The await handles the Task object to return the string into the declaraed response variable.
        /// Deserialises the JSON data into the variable ChuckNorrisJoke.
        /// Calls the ChuckNorrisJoke 'value' property (from the Jokes class).
        /// </summary>
        /// <returns></returns>
        private async Task getChuckNorrisJokes()
        {
            string response = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");

            var ChuckNorrisJoke = JsonConvert.DeserializeObject<Jokes>(response);

            Console.WriteLine(ChuckNorrisJoke.value);
        }

        /// <summary>
        /// Introduction for the start of the console applicaiton, which uses a message box to engage with the client for confirmation as to whether they want to proceed with the application.
        /// </summary>
        public static void Introduction()
        {
            Console.WriteLine("Are you ready for Chuck Norris jokes? \n");

            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Console.Write("Yes. \n\n");
            }
            else
            {
                Environment.Exit(-1);
            }
        }

    }
}