using RestSharp;
using RestSharp.Authenticators; 
using System;
public class Stuff
    {
        public string internalName { get; set; }
        public string title { get; set; }
        public string metacriticLink { get; set; }
        public string dealID { get; set; }
        public string storeID { get; set; }
        public string gameID { get; set; }
        public string salePrice { get; set; }
        public string normalPrice { get; set; }
        public string isOnSale { get; set; }
        public string savings { get; set; }
        public string metacriticScore { get; set; }
        public string steamRatingText { get; set; }
        public string steamRatingPercent { get; set; }
        public string steamRatingCount { get; set; }
        public string steamAppID { get; set; }
        public int releaseDate { get; set; }
        public int lastChange { get; set; }
        public string dealRating { get; set; }
        public string thumb { get; set; }
    }

class Program {

  
  static void Main() {
    string url = ""; {
url = "https://www.cheapshark.com/api/1.0/games?title=Dragons Dogma";


    }
    string jsonString =  {"internalName": "DEUSEXHUMANREVOLUTIONDIRECTORSCUT", "title": "Deus Ex: Human Revolution - Director's Cut", "metacriticLink":/game/pc/deus-ex-human-revolution---directors-cut", "dealID": "HhzMJAgQYGZ%2B%2BFPpBG%2BRFcuUQZJO3KXvlnyYYGwGUfU%3D", "storeID": "1", "gameID": "102249", "salePrice": "2.99", "normalPrice": "19.99", "isOnSale": "1", "savings": "85.042521", "metacriticScore": "91", "steamRatingText": "Very Positive",
    "steamRatingPercent": "92",
    "steamRatingCount": "17993",
    "steamAppID": "238010",
    "releaseDate": 1382400000,
    "lastChange": 1621536418,
    "dealRating": "9.6",
    "thumb": "https://cdn.cloudflare.steamstatic.com/steam/apps/238010/capsule_sm_120.jpg?t=1619788192" 
    }

    Stuff stuff =JsonSerializer.Deserialize<Stuff>(jsonString);
Console.WriteLine($"title: {Stuff?.title}");
    
    
    var client =  new RestClient(url);
var title = "";
    var request = new RestRequest();
    var response = client.Get(request);

    Console.WriteLine(response.Content.ToString());

// if (title == "Lethal Company") {
//   Console.WriteLine("Cheapest price; " + salePrice);
// }
    
  }
}

