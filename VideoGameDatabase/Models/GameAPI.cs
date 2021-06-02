using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace VideoGameDatabase.Models
{
    public class GameDetailsAPI
    {
        public static async Task<GameDetails> GetGame(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.rawg.io");
            var response = await client.GetAsync($"/api/games/{id}?key=c346e44ab34f444393a739027a456e9f");
            GameFromAPI gfa = await response.Content.ReadAsAsync<GameFromAPI>();
            GameDetails g = new GameDetails(gfa);

            return g;

        }

        public static async Task<APIListGames> GetListbyGenre()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.rawg.io");
            var response = await client.GetAsync("/api/games?genres=1&page_size=100&key=c346e44ab34f444393a739027a456e9f");
            APIListGames theList = await response.Content.ReadAsAsync<APIListGames>();
            return theList;
        }


    }

    public class GameFromAPI
    {
        public int id { get; set; }
        public string name_original { get; set; }
        public string description { get; set; }
        public string metacritic { get; set; }
        public string released { get; set; }
        public string background_image { get; set; }
        public string website { get; set; }
        public string rating { get; set; }



    }





    public class APIListGames
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<GameFromList> results { get; set; }
    }

    public class GameFromList
    {
        public int id { get; set; }
        public string name { get; set; }
        public string background_image { get; set; }
        public string rating { get; set; }
        //{
        //    get { return rating;}
        //    set {
        //        if (Int32.TryParse(Convert.ToString(value), out int result)) { rating = result; }
        //        else { rating = 0; }
        //    }
        //}
    }


}
