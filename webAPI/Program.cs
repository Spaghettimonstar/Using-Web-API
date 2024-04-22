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
    
    var client =  new RestClient(url);
// var id = "";
    var request = new RestRequest();
    var response = client.Get(request);

    Console.WriteLine(response.Content.ToString());

// if (id == "Lethal Company") {
//   Console.WriteLine("Cheapest price; " + cheapest);
// }
    
  }
}

