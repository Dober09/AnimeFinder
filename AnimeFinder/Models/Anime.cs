using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeFinder.Models
{
    internal class Anime
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
        public class AnimeSeason
        {
            public string season { get; set; }
            public int? year { get; set; }
        }

 
            public List<string> sources { get; set; }
            public string title { get; set; }
            public string type { get; set; }
            public int episodes { get; set; }
            public string status { get; set; }
            public AnimeSeason animeSeason { get; set; }
            public string picture { get; set; }
            public string thumbnail { get; set; }
            public List<string> synonyms { get; set; }
            public List<string> relatedAnime { get; set; }
            public List<string> tags { get; set; }
       


    }
}
