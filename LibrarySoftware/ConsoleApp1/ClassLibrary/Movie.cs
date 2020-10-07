using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Movie
    {
        private String title;
        private String starring;
        private String director;
        private int duration;
        private int genre;
        private int classification;
        private int releaseDate;
        private int AvCopies;

        // enum and constructor
        public Movie()
        {
            Console.Write("Enter the movie title: ");
            this.title = Console.ReadLine();
            Console.Write("Enter the starring actor(s): ");
            this.starring = Console.ReadLine();
            Console.Write("Enter the director(s): ");
            this.director = Console.ReadLine();
            Console.WriteLine("Select the genre:" + "/r/n"
                            + "1. Drama"
                            + "2. Adventture"
                            + "3. Family"
                            + "4. Action"
                            + "5. Sci-Fi"
                            + "6. Comedy"
                            + "7.Thriller"
                            + "8.Other");
            Console.Write("Make selection(1-8): ");
            this.genre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select the classification"
                            + "1. General (G)"
                            + "2. Parental Guidance (PG)"
                            + "3. Mature (M15+)"
                            + "4. Mature Accompanied (MA15+)");
            Console.Write("Make selection(1-4): ");
            this.classification = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the duration (minutes): ");
            this.duration = Convert.ToInt32(Console.ReadLine()); ;
            Console.Write("Enter the release date (year): ");
            this.releaseDate  = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of copies available");
            this.AvCopies = Convert.ToInt32(Console.ReadLine());
        }

        public static void RegisterMovie()
        {
            // Check whether movie is implemented or not
            Movie movie = new Movie();
        }
    }
}
