using RestSharp;
using RestSharp.Authenticators; 
using System;
using System.Text.Json;
public class CheapShark
    {
        public string storeID { get; set; }
        public string gameID { get; set; }
        public string name { get; set; }
        public string steamAppID { get; set; }
        public string salePrice { get; set; }
        public string retailPrice { get; set; }
        public string steamRatingText { get; set; }
        public string steamRatingPercent { get; set; }
        public string steamRatingCount { get; set; }
        public string metacriticScore { get; set; }
        public string metacriticLink { get; set; }
        public int releaseDate { get; set; }
        public string publisher { get; set; }
        public string steamworks { get; set; }
        public string thumb { get; set; }
    }

    public class Root
    {
        public CheapShark gameInfo { get; set; }
    }

class Program {

  
  static void Main() {
    string url = ""; {
url = "https://www.cheapshark.com/api/1.0/deals?id=X8sebHhbc1Ga0dTkgg59WgyM506af9oNZZJLU9uSrX8%3D";
    }
    
    
    // string jsonString =  @"{'internalName': 'DEUSEXHUMANREVOLUTIONDIRECTORSCUT',
    //  'title': 'Deus Ex: Human Revolution - Directors Cut', 
    // 'metacriticLink':'/game/pc/deus-ex-human-revolution---directors-cut',
    // 'dealID': 'HhzMJAgQYGZ%2B%2BFPpBG%2BRFcuUQZJO3KXvlnyYYGwGUfU%3D', 
    // 'storeID': '1',
    //  'gameID': '102249',
    //   'salePrice': '2.99',
    //    'normalPrice': '19.99',
    //     'isOnSale': '1',
    //      'savings': '85.042521',
    //       'metacriticScore': '91',
    //  'steamRatingText': 'Very Positive',
    // 'steamRatingPercent': '92',
    // 'steamRatingCount': '17993',
    // 'steamAppID': '238010',
    // 'releaseDate': '1382400000',
    // 'lastChange': '1621536418',
    // 'dealRating': '9.6',
    // 'thumb': 'https://cdn.cloudflare.steamstatic.com/steam/apps/238010/capsule_sm_120.jpg?t=1619788192'
    // }".Replace("'", "\"");


    var client =  new RestClient(url);
var title = "";
    var request = new RestRequest();
    var response = client.Get(request);
Console.WriteLine(response.Content);   // Console.WriteLine(response.Content.ToString());
 Root cheapshark =JsonSerializer.Deserialize<Root>(response.Content);
   Console.WriteLine(cheapshark);
Console.WriteLine($"Game title is {cheapshark.name}");
Console.WriteLine($"Normal Pricing is {cheapshark.normalPrice}");
Console.WriteLine($"Sale Pricing is {cheapshark.salePrice}");
Console.WriteLine($"The ratings are {cheapshark.steamRatingText}, with {cheapshark.steamRatingCount} reviews");
    
    

  }  
}

