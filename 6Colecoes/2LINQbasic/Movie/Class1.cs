// using System.Linq;
namespace Movie;
public class Movie
{
  public string? title { get; set; }
  public int premiereYear { get; set; }
  public string? genre { get; set; }
  public string? director { get; set; }
  public string? imdbRating { get; set; }
  public string? imdbVotes { get; set; }


public List<Movie> mockCollection()
{
  var _context = new List<Movie>();

  _context.Add(new Movie { title = "Star Wars: The Rise of Skywalker", premiereYear = 2017, genre = "Action", director = "J.J. Abrams", imdbRating = "8.7", imdbVotes = "1,979,872" });
  _context.Add(new Movie { title = "Star Wars: The Last Jedi", premiereYear = 2017, genre = "Action", director = "Rian Johnson", imdbRating = "8.5", imdbVotes = "1,074,927", });
  _context.Add(new Movie { title = "Star Wars: The Force Awakens", premiereYear = 2015, genre = "Action", director = "J.J. Abrams", imdbRating = "8.3", imdbVotes = "1,038,191" });

  return _context;
}

}
