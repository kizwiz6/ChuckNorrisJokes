using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisJokes
{
    /// <summary>
    ///  Create a class of properties to deserialise the JSON data from the Chuck Norris jokes API.
    /// </summary>

    class Jokes
    {
        public string[] categories { get; set; }
        public DateTime created_at { get; set; }
        public string icon_url { get; set; }
        public string Id { get; set; }
        public DateTime updated_at { get; set; }
        public string url { get; set; }
        public string value { get; set; }
    }
}
