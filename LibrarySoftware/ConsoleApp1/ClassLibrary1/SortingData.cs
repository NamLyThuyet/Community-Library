using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /*
     * This class represents specfic information, used for the sorting algorithm, merge sort.
     * 
     * Author: Phuong Nam Ly May 2020
     */
    public class SortingData
    {
        private Movie[] movieArray;
        private int[] borrowedTimesArray;
        private int movieNum;

        /// <summary>
        /// The constructor initializes a movie array and int array, representing 
        /// a list of movies and its corresponding borrowed times. 
        /// An arbirtary number is required to initialize arrays so 100 is chosen.
        /// This number can be changed if there are more than 100 movies in the library.
        /// A movie counter is used to keep track of the actual number of movies, 
        /// avoiding any unnecessary loops in the sorting algorithm.
        /// </summary>
        public SortingData()
        {
            movieArray = new Movie[100];
            borrowedTimesArray = new int[100]; ;
            movieNum = 0;
        }

        /// <summary>
        /// DisplayMovieInOrder() will display the first ten movies within the sorted movie array, using
        /// the sorted movie array.
        /// The function accounts for the situation that there are not less than ten movies within the array.
        /// This array will not display a movie's borrowed times if its borrowed times is zero. 
        /// </summary>
        public void DisplayMoviesInOrder()
        {
            int i = 1;

            foreach(Movie m in movieArray)
            {
                if(i <= 10)
                {
                    if (m != null)
                    {
                        if (m.BorrowedTimes() != 0)
                        {
                            m.GetInfo();
                            Console.WriteLine();
                        }
                    }

                    ++i;
                }
                else
                {
                    return;
                }
            }
        }

        public void setMovieNum(int i)
        {
            movieNum += i;
        }

        public void setMovie(int i, Movie movie)
        {
            movieArray[i] = movie;
        }

        public void setBorrowedTimes(int i, int borrowTimes)
        {
            borrowedTimesArray[i] = borrowTimes;
        }

        public int MovieNum()
        {
            return movieNum;
        }

        public Movie[] MovieArray()
        {
            return movieArray;
        }

        public int[] BorrowedTimesArray()
        {
            return borrowedTimesArray;
        }
    }
}
