class Program
{
    public static void Main(string[] args)
    {
        var movie = new Movie("Matrix", "Ficcao Cientifica");
        var movie2 = new Movie("Senhor dos Aneis", "Fantasia");

        Console.WriteLine(movie.Title);
        Console.WriteLine(movie.Category);

        Console.WriteLine(movie2.Title);
        Console.WriteLine(movie2.Category);

        movie.Title = "Matrix2";
        movie.Category = "Pudim";

        Console.WriteLine(movie.Title);
        Console.WriteLine(movie.Category);


    }
}