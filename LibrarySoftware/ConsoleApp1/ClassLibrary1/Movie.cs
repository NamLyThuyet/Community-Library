using System;

namespace ClassLibrary
{
    /*
     * This class represents information regarding a movie.
     * 
     * Author: Phuong Nam Ly May 2020
     */
    public class Movie
    {
        public enum Genres
        {
            Drama,
            Adventure,
            Family,
            Action,
            SciFi,
            Comedy,
            Thriller,
            Other
        }

        public enum Classifications
        {
            General,
            ParentalGuidance,
            Mature,
            MatureAccompanied
        }

        private String title;
        private String starring;
        private String director;
        private String genre;
        private String classification;
        private int duration;
        private int releaseDate;
        private int avCopies;
        private int borrowedTimes;

        // enum and constructor
        public Movie(String movieTitle, String starring, String director, int genreSelection, int classificationSelection, int duration, int releaseDate, int avCopies, int borrowedTimes = 0)
        {
            this.title = movieTitle;
            this.starring = starring;
            this.director = director;
            this.genre = ((Genres)genreSelection - 1).ToString();
            this.classification = ((Classifications)classificationSelection - 1).ToString();
            this.duration = duration; 
            this.releaseDate  = releaseDate;
            this.avCopies = avCopies;
            this.borrowedTimes = borrowedTimes;

            Console.WriteLine();
            Console.WriteLine("Successfully added movie " + movieTitle);
            Console.WriteLine();
        }

        public String Title()
        {
            return title;
        }

        public String Starring()
        {
            return starring;
        }

        public String Director()
        {
            return director;
        }

        public int Duration()
        {
            return duration;
        }

        public string Genre()
        {
            return genre;
        }

        public string Classification()
        {
            return classification;
        }

        public int ReleaseDate()
        {
            return releaseDate;
        }

        public int AvCopies()
        {
            return avCopies;
        }

        public void SetAvCopies(int i)
        {
            avCopies += i;
        }

        public int BorrowedTimes()
        {
        return borrowedTimes;
        }

        public void SetBorrowedTimes(int i)
        {
            borrowedTimes += i;
        }

        public void GetInfo()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Starring: " + starring);
            Console.WriteLine("Director: " + director);
            Console.WriteLine("Genre: " + genre);
            Console.WriteLine("Classification: " + classification);
            Console.WriteLine("Duration: " + duration + " pictures");
            Console.WriteLine("Release Date: " + releaseDate);
            Console.WriteLine("Copies Available: " + avCopies);
            Console.WriteLine("Times borrowed: " + borrowedTimes);
        }
    }
}
