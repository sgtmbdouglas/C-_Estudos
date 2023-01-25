using Xunit;
using FluentAssertions;

namespace Movie.Test;

public class UnitTest1
{
    [Fact]
  public void HasGenre_Action()
  {
    var starWarsMovies = this.mockCollection();
    var result = from movies in starWarsMovies
                  where movies.genre == "Action"
                  select movies;

    Assert.True(result.Any());
  }
}