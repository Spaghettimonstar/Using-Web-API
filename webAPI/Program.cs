using RestSharp;
using RestSharp.Authenticators; 
using System;
class Program {
  static void Main() {
    string url = ""; {
url = "https://www.cheapshark.com/api/1.0/games?title=batman";


    }
    var request = new RestSharp.Request(url);
    Console.WriteLine("Hello World");
    Console.WriteLine("Test");
  }
}
