using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        // string[,] xablau = {{"asdfs", "ljdfns"}, {"", ""}};
        // declarativeLinq();
        // labdaLinq();
        lambdaLinqRefactored();
    }
    static void declarativeLinq()
    {
        string[] games = {"Fortnite", "Valorant", "Destiny", "Call of Dutty", "Word of Warcraft"};
        var filteredGames = from game in games where game.Contains('a') select game;
        foreach (string game in filteredGames)
        {
            Console.WriteLine(game);
        }
    }
    static void labdaLinq()
    {
        string[] games = {"Fortnite", "Valorant", "Destiny", "Call of Dutty", "Word of Warcraft"};
        IEnumerable<string> filteredGames = System.Linq.Enumerable.Where(games, n => n.Contains('a'));
        foreach (string game in filteredGames)
        {
            Console.WriteLine(game);
        }
    }
        static void lambdaLinqRefactored()
        {
            string[] games = {"Fortnite", "Valorant", "Destiny", "Call of Dutty", "Word of Warcraft"};
            var filteredGames = games.Where(n => n.Contains('a'));
            foreach (string game in filteredGames)
            {
                Console.WriteLine(game);
            }
        }

}