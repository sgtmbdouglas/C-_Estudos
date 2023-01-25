using System.Linq;

internal class Artist
{
    public string? name { get; set; }
    public int listeners { get; set; }
    static void Main(string[] args)
    {
        // FamousArtists();
        // Greetings();
        // QuantityGreetings();
        // Fruits();
        SelectProject();
    }
    static void FamousArtists()
    {
        var artists = new List<Artist>
      {
        new Artist { name = "Raul Seixas", listeners = 50000 },
        new Artist { name = "Mozart", listeners = 15000 },
        new Artist { name = "Elvis Presley", listeners = 25000 },
        new Artist { name = "Bob Dylan", listeners = 30000 },
        new Artist { name = "Guns N' Roses", listeners = 40000 },
      };
      var topListeners =
               from artist in artists
               where artist.listeners > 30000
               select artist.name;
        foreach (string game in topListeners)
        {
            Console.WriteLine(game);
        }
    }
    static void Greetings()
    {
        string[] greetings = { "Hello World", "Hello LINQ", "Hello trybe" };

        var items =
            from greeting in greetings
            select greeting;
        foreach (var item in items)
            Console.WriteLine(item);
    }
    static void QuantityGreetings()
    {
        string[] greetings = { "Hello World", "Hello LINQ", "Hello trybe" };
        var items =
            (from greeting in greetings
            select greeting).Count();    
        Console.WriteLine(items);
    }
    static void Fruits()
    {
        string[] fruits = { "Banana", "Orange", "Apple", "Mango", "Grape" };

        var ordenedFruits = from fruitName
            in fruits
            orderby fruitName
            orderby fruitName.Length
            select fruitName;
        Console.WriteLine(ordenedFruits);
    }
    static void SelectProject()
    {
        string[] words = { "owner", "report", "warm", "scramble", "party" };

        var objWords = from word in words
                select new { word, length = word.Length };
        // foreach (string game in objWords)
        // {
        //     Console.WriteLine(game);
        // }
        Console.WriteLine(objWords);
    }
}