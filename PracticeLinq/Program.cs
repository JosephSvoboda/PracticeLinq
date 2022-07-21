using System.Linq;


List<string> videoGames = new List<string>{ "Elden Ring", "League of Legends", "MineCraft", "OSRS" };

    videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));