namespace Movies.Api.Movies;

public class Movie
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public int YearOfRelease { get; set; }
    public string[] Genres { get; set; }
}