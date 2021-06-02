using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameDatabase.Models
{
    public class SimpleGameDetails
    {

    }





    public class GameDetails
    {
        public int id { get; set; }
        public string name_original { get; set; }
        public string description { get; set; }
        public int metacritic { get; set; }
        public string released { get; set; }
        public string background_image { get; set; }
        public string website { get; set; }
        public int rating { get; set; }
     
        public GameDetails(GameFromAPI gfa)
        {
            id = gfa.id;
            name_original = gfa.name_original;
            description = gfa.description;
            if (Int32.TryParse(gfa.metacritic, out int result))
            {
                metacritic = result;
            }
            else
            {
                metacritic = 0;
            }
            released = gfa.released;
            background_image = gfa.background_image;
            website = gfa.website;
            if (Int32.TryParse(gfa.rating, out result))
            {
                rating = result;
            }
            else
            {
                rating = 0;
            }


        }

    }

  


}
