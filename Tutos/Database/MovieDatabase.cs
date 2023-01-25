using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tutos.Models;

namespace Tutos.Database
{
    public class MovieDatabase
    {
        List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Id= 1,
                Name = "shrek!",
                Actors = new List<string>
                {
                    "Angelina Jolie", "Brad Pit"
                },
                ProductionCompany = "Bluesky"
            },
            new Movie
            {
                Id= 2,
                Name = "Kung Fu Panda",
                Actors = new List<string>
                {
                    "Angelina Jolie", "Jake Black", "Lucy Cheng"
                },
                ProductionCompany = "Dreamworks"
            },
            new Movie
            {
                Id= 3,
                Name = "Frozen",
                Actors = new List<string>
                {
                    "Actess 1", "Actress 2"
                },
                ProductionCompany = "Disney"
            }

        };
        public List<Movie> GetAllMovies()
        {
            return movies;
        }
        public Movie GetMovieByName(string name)
        {
            for (int i = 0; i < movies.Count; i++)
            {
                Movie movie = movies[i];
                if (movie.Name == name)
                {
                    return movie;
                }
            }

            return null;
        }

        //GetMovieById
    }
}