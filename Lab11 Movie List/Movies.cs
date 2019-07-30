using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_Movie_List
{
    class Movies
    {
        //fields
        private string _title;
        private string _category;

        public static List<Movies> animatedMovies = new List<Movies>
        {
            new Movies("Aladdin", "Animated"),
            new Movies("Shrek", "Animated")
        };
        
        public static List<Movies> dramaMovies = new List<Movies>
        {
            new Movies("Schindler's List", "Drama"),
            new Movies("Good Will Hunting", "Drama")
        };
        public static List<Movies> horrorMovies = new List<Movies>
        {
            new Movies("Friday the 13th", "Horror"),
            new Movies("Us", "Horror"),
            new Movies("IT", "Horror")
        };
        public static List<Movies> scifiMovies = new List<Movies>
        {
             new Movies("Avatar", "Scifi"),
             new Movies("Star Wars A New Hope", "Scifi"),
             new Movies("The Martian", "Scifi")
        };

        public string Movie
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
       
        public Movies()
        {

        }
        public Movies(string title, string category)
        {
            _title = title;
            _category = category;
        }
        
        public static void DisplayMovieList()
        {
            Console.WriteLine("1. List All Movies");
            Console.WriteLine("2. List Movies By Genre");
            Console.WriteLine("3. Exit");

        }
        public static void DisplayAllMovies()
        {
            foreach (Movies movie in animatedMovies)
            {
                Console.WriteLine($"{movie._title}");
            }
            foreach (Movies movie in dramaMovies)
            {
                Console.WriteLine($"{movie._title}");
            }
            foreach (Movies movie in horrorMovies)
            {
                Console.WriteLine($"{movie._title}");
            }
            foreach (Movies movie in scifiMovies)
            {
                Console.WriteLine($"{movie._title}");
            }
        }
        public static void DisplayMovieByGenre()
        {
            bool go = true;
            while (go)
            {
                Console.WriteLine("What Genre would you like to view?\n");
                Console.WriteLine("1: Animated, 2: Drama, 3: Horror, 4: Scifi, 5: Return to Main Menu");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    Console.WriteLine();
                    if (result == 1)
                    {
                        DisplayAnimatedMovies();
                    }
                    else if (result == 2)
                    {
                        DisplayDramaMovies();
                    }
                    else if (result == 3)
                    {
                        DisplayHorrorMovies();
                    }
                    else if (result == 4)
                    {
                        DisplayScifiMovies();
                    }
                    else if (result == 5)
                    {
                        go = false;
                    }
                }
                else
                {
                    Console.WriteLine("That is not a vaild input please try again.");
                    go = false;
                }
            }
        }
        public static void DisplayAnimatedMovies()
        {
            foreach (Movies movie in animatedMovies)
            {
                Console.WriteLine($"{movie._title}");
            }
        }
        public static void DisplayDramaMovies()
        {
            foreach (Movies movie in dramaMovies)
            {
                Console.WriteLine($"{movie._title}");
            }
        }
        public static void DisplayHorrorMovies()
        {
            foreach (Movies movie in horrorMovies)
            {
                Console.WriteLine($"{movie._title}");
            }
        }
        public static void DisplayScifiMovies()
        {
            foreach (Movies movie in scifiMovies)
            {
                Console.WriteLine($"{movie._title}");
            }
        }
            
    }
}
