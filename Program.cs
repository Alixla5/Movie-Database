using System;
using System.Collections.Generic;
using System.Threading.Channels;

Console.WriteLine("Welcome to Movie Database.");
Console.WriteLine("Please pick a category.");

internal partial class Program
{
    public class Movie
    {
        public string Title { get; }
        public string Category { get; }

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
    }
    static void Main(string[] args)
    {
        List<Movie> movies = new List<Movie>
        {
            new Movie("The Lion King", "animated"),
            new Movie("The Shawshank Redemption", "drama"),
            new Movie("The Exorcist", "horror"),
            new Movie("Inception", "scifi"),
            new Movie("Finding Nemo", "animated"),
            new Movie("Forrest Gump", "drama"),
            new Movie("The Conjuring", "horror"),
            new Movie("Interstellar", "scifi"),
            new Movie("Toy Story", "animated"),
            new Movie("Titanic", "drama")
        };

        bool continueFlag = true;

        while (continueFlag)
        {
            Console.Write("Enter a movie category (animated, drama, horror, scifi): ");
            string category = Console.ReadLine().ToLower();

            bool found = false;

            foreach (Movie movie in movies)
            {
                if (movie.Category.ToLower() == category)
                {
                    Console.WriteLine($"{movie.Title} ({movie.Category})");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No movies found in that category.");
            }

            Console.Write("Do you want to continue? (yes/no): ");
            string input = Console.ReadLine().ToLower();
            continueFlag = input == "yes";
        }
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}

