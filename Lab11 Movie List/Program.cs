using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
            bool go = true;
            while (go)
            {
                Console.WriteLine("Welcome to the Movie List please see options below\n");
                Movies.DisplayMovieList();
                Console.WriteLine();
                Console.WriteLine("What would you like to see? please select a number to view.\n");

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result == 1)
                    {
                        Movies.DisplayAllMovies();
                    }
                    else if (result == 2)
                    {
                        Movies.DisplayMovieByGenre();
                        Movies.DisplayMovieList();
                    }
                    else if (result == 3)
                    {
                        go = false;
                    }
                }
                else
                {
                    Console.WriteLine("I'm sorry that is not a vaild option please try again.");
                }
            }
        }
    }
}
