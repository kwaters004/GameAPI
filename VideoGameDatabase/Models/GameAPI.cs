using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace VideoGameDatabase.Models
{
    public class GameDetailsAPI
    {
        public static async Task<GameFromAPI> GetGame(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.rawg.io");
            var response = await client.GetAsync($"/api/games/{id}?key=c346e44ab34f444393a739027a456e9f");
            GameFromAPI gfa = await response.Content.ReadAsAsync<GameFromAPI>();


            return gfa;

        }

        public static async Task<APIListGames> GetListbyGenre()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.rawg.io");
            var response = await client.GetAsync("/api/games?genres=1&key=c346e44ab34f444393a739027a456e9f");
            APIListGames theList = await response.Content.ReadAsAsync<APIListGames>();
            return theList;
        }

        public static async Task<GenreList> GetGenreList()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.rawg.io");
            var response = await client.GetAsync("/api/genres?key=c346e44ab34f444393a739027a456e9f");
            GenreList genres = await response.Content.ReadAsAsync<GenreList>();
            return genres;
        }

        public static async Task<APIListGames> GetTopRated(int id)
        {


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.rawg.io");
            var response = await client.GetAsync($"/api/games?ordering=-rating&genres={id}&page_size=25&key=c346e44ab34f444393a739027a456e9f");
            APIListGames theList = await response.Content.ReadAsAsync<APIListGames>();
            return theList;
        }

        public static async Task<string> GetGenreName(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.rawg.io");
            var response = await client.GetAsync($"/api/genres/{id}?key=c346e44ab34f444393a739027a456e9f");
            Genre genre = await response.Content.ReadAsAsync<Genre>();
            return genre.name;

        }

        public static async Task<APIListGames> GetNewReleases()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.rawg.io");
            DateTime today = DateTime.Now;
            string strToday = today.ToString("yyyy-MM-dd");
            DateTime seven = today.AddDays(-7);
            string sevenAgo = seven.ToString("yyyy-MM-dd");
            var response = await client.GetAsync($"/api/games?dates={sevenAgo},{strToday}&ordering=-released&key=c346e44ab34f444393a739027a456e9f");
            //var response = await client.GetAsync($"/api/games?dates=2021-06-03,2021-06-03&ordering=-released&key=c346e44ab34f444393a739027a456e9f");
            APIListGames games = await response.Content.ReadAsAsync<APIListGames>();
            return games;
        }

    }

    // can call this with ID
    public class GameFromAPI
    {
        public int id { get; set; }
        public string name_original { get; set; }
        public string description { get; set; }

        // int (null)
        public int? metacritic { get; set; }
        public string released { get; set; }
        public string background_image { get; set; }
        public string website { get; set; }
        // number (null)
        //public int? rating { get; set; }
        public int? rating_top { get; set; }





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
        public string released { get; set; }
    }


    public class GenreList
    {
        public int count { get; set; }
        public List<Genre> results { get; set; }
    }

    public class Genre
    {
        public int id { get; set; }
        public string name { get; set; }
        public int games_count { get; set; }
        public string image_background { get; set; }

    }


}
