using System.ComponentModel.DataAnnotations; // Import necessary namespace for data validation

public class Movie
{
    [Key] // Marks this property as the Primary Key in the database
    public int MovieId { get; set; }

    [Required] // Ensures this field is required (cannot be null or empty)
    public string Category { get; set; } = string.Empty; // Stores the category of the movie

    [Required] // Ensures a title must be provided
    public string Title { get; set; } = string.Empty; // Stores the movie title

    [Required] // Ensures a release year must be provided
    public int Year { get; set; } // Stores the release year of the movie

    [Required] // Ensures a director's name must be provided
    public string Director { get; set; } = string.Empty; // Stores the director's name

    [Required] // Ensures a rating must be provided
    public string Rating { get; set; } = string.Empty; // Stores the movie rating (G, PG, PG-13, R)

    public bool Edited { get; set; } = false; // Indicates whether the movie has been edited (Yes/No)

    public string? LentTo { get; set; } // Optional field to record who the movie is lent to

    [MaxLength(25)] // Limits the Notes field to 25 characters
    public string? Notes { get; set; } // Optional notes about the movie, limited to 25 characters
}

