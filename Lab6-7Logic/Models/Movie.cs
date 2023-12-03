namespace Lab6_7Logic.Models;

public class Movie
{
    public int Id { get; set; }

    public string MovieName { get; set; } = null!;

    public DateOnly? ReleaseDate { get; set; }

    public string Genre { get; set; } = null!;

    public string? Description { get; set; }

    public int DirectorId { get; set; }
}