using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /*
     * This class represents a node within the Binary Search, regarding the data its contain, its left and right successor node.
     * The data in this case is the data about a  movie.
     * It also contains recursive functions that represents how a node moves to its successor.
     * 
     * Author: Phuong Nam Ly May 2020
     */

    public class Node
    {
        private Movie data;
        private Node left;
        private Node right;

        public Node(Movie movie)
        {
            data = movie;
            left = null;
            right = null;
        }

        public Movie Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node Left
        {
            get { return left; }
            set { left = value; }
        }

        public Node Right
        {
            get { return right; }
            set { right = value; }
        }

        /// <summary>
        /// Search() determines whether a movie exists or not by comparing the titles of the movies.
        /// The search is In-order Traversal, in terms of ascending movie title.
        /// </summary>
        /// <param name="movieTitle"> A String value represent the title of the movie.</param>
        /// <returns>A boolean value determining whether the search is successful.</returns>
        public bool Search(String movieTitle)
        {
            if (data.Title() != null)
            {
                if (movieTitle.CompareTo(data.Title()) == 0)
                    return true;
                else if (movieTitle.CompareTo(data.Title()) < 0)
                {
                    if (left != null)
                    {
                        return left.Search(movieTitle);
                    }

                    return false;
                }
                else
                {
                    if (right != null)
                    {
                        return right.Search(movieTitle);
                    }

                    return false;
                }
            }
            else
                return false;
        }

        /// <summary>
        /// GetMovie() returns a movie object from the movie library.
        /// </summary>
        /// <param name="movieTitle"> A String value represent the title of the movie.</param>
        /// <returns>The corresponding Movie object.</returns>
        public Movie GetMovie(String movieTitle)
        {
            if (data.Title() != null)
            {
                if (movieTitle.CompareTo(data.Title()) == 0)
                    return data;
                else
                    if (movieTitle.CompareTo(data.Title()) < 0)
                    return left.GetMovie(movieTitle);
                else
                    return right.GetMovie(movieTitle);
            }
            else
                return null;
        }

        /// <summary>
        /// Add() adds a new node representing a movie.
        /// The movie is added in In-order Traversal, in terms of ascending movie title.
        /// </summary>
        /// <param name="movie"> A movie object representing the movie.</param>
        public void Add(Movie movie)
        {
            if (String.Compare(movie.Title(), data.Title()) < 0)
            {
                if (left == null)
                {
                    Node node = new Node(movie);
                    left = node;
                }
                else
                {
                    left.Add(movie);
                }
            }
            else
            {
                if (right == null)
                {
                    Node node = new Node(movie);
                    right = node;
                }
                else
                {
                    right.Add(movie);
                }
            }
        }

        /// <summary>
        /// InOrderTraversal() display info of a movie within the BSTree.
        /// The movie is displayed in In-order Traversal, , in terms of ascending movie title.
        /// </summary>
        public void InOrderTraversal()
        {
            if (left != null)
            {
                left.InOrderTraversal();
            }

            data.GetInfo();
            Console.WriteLine();


            if (right != null)
            {
                right.InOrderTraversal();
            }
        }


        /// <summary>
        /// InOrderTraversal() display info of a movie within the BSTree.
        /// The movie is displayed in In-order Traversal, , in terms of ascending movie title.
        /// </summary>
        /// <param name="sortData">A SortingData object</param>
        public void InOrderTraversal(SortingData sortData)
        {
            if (left != null)
            {
                left.InOrderTraversal(sortData);
            }

            int movieNum = sortData.MovieNum();

            sortData.setMovie(movieNum, data);
            sortData.setBorrowedTimes(movieNum, data.BorrowedTimes());
            sortData.setMovieNum(1);


            if (right != null)
            {
                right.InOrderTraversal(sortData);
            }
        }
    }
}
