using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /*
     * This class is a Binary Search Tree. It contains method which utilizes the nodes within the tree.
     * This class represents a movie collection.
     * 
     * Author: Phuong Nam Ly May 2020
     * 
     */

    public class MovieCollection
    {
        private Node root;

        /// <summary>
        /// Search() uses the responding recursive function from Node.cs.
        /// Search() searches for a movie title through the BSTree by starting at the root node.
        /// </summary>
        /// <param name="movieTitle"> A String value representing the title of the movie.</param>
        /// <returns>A boolean value determining whether the search is successful.</returns>
        public bool Search(String movieTitle)
        {
            if (root == null)
            {
                return false;
            }
            else
            {
                return root.Search(movieTitle);
            }
        }

        /// <summary>
        /// GetMovie() uses the responding recursive function from Node.cs.
        /// GetMovie() searchs for a movie object through the BSTree by starting at the root node.
        /// </summary>
        /// <param name="movieTitle">A String value reprenting the title of the movie.</param>
        /// <returns>The corresponding Movie object.</returns>
        public Movie GetMovie(String movieTitle)
        {
            return root.GetMovie(movieTitle);
        }

        /// <summary>
        /// Add() uses the responding recursive function from Node.cs.
        /// Add() adds a node representing a movie to the BSTree, in an ascending order.
        /// </summary>
        /// <param name="movie">The Movie object.</param>
        public void Add(Movie movie)
        {
            if (root == null)
            {
                root = new Node(movie);
            }
            else
            {
                root.Add(movie);
            }
        }

        /// <summary>
        /// Remove() removes a node within the BSTree. This removes all copies of the corresponding movies 
        /// from the movie library.
        /// </summary>
        /// <param name="movieTitle">A String value representing the title of the movie that needs to be removed.</param>
        public void Remove(String movieTitle)
        {
            // Use the current variable to find the required node
            // Use the parent variable to remove the required node from the BSTree
            Node current = root;
            Node parent = null;

            // Searching for the node
            while (current != null && movieTitle != current.Data.Title())
            {
                // Update the parent node
                parent = current;

                // Update the current node
                if (movieTitle.CompareTo(current.Data.Title()) < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }

            // Removing the node 
            if (current == null)
            {
                Console.WriteLine("The movie that needs to be removed does not exist.");
                return;
            }
            else
            {
                // If the node exists, there are three types of nodes: having no, one or two children.
                // If the node has two children, we aim to remove the left-most node of the right subtree. 
                // This node contains the smallest value that in the right subtree 
                // that is larger than the current subtree.
                if (current.Left != null && current.Right != null)
                {
                    // If the value is null
                    if (current.Right.Left == null)
                    {
                        current.Data = current.Right.Data;
                        current.Right = current.Right.Right;
                    }
                    else
                    {
                        // If that value is not null, travel down the left-most node of the subtree.
                        // Create two nodes that representing the current node and its left child.
                        Node n = current;
                        Node c = current.Right;

                        while (c.Left != null)
                        {
                            n = c;
                            c = c.Left;
                        }

                        current.Data = c.Data;
                        n.Left = c.Right;
                    }
                }
                // if a node has one or no children
                else
                {
                    Node c;
                    if (current.Left != null)
                    {
                        c = current.Left;
                    }
                    else
                    {
                        c = current.Right;
                    }

                    if (current == root)
                    {
                        root = c;
                    }
                    else
                    {
                        if (current == parent.Left)
                        {
                            parent.Left = c;
                        }
                        else
                        {
                            parent.Right = c;
                        }
                    }
                }

                Console.WriteLine("All copies of " + movieTitle + " are removed from the library.");
            }

        }

        /// <summary>
        /// InOrder() uses the responding recursive function from Node.cs.
        /// InOrder() display the data of all the nodes of the BSTree by starting at the root node.
        /// </summary>
        /// <param name="movie">The Movie object.</param>
        public void InOrder()
        {
            root.InOrderTraversal();
        }

        /// <summary>
        /// InOrder() uses the responding recursive function from Node.cs.
        /// InOrder() fills the sorting data with the data from all the nodes of the BSTree by starting at the root node.
        /// </summary>
        /// <param name="sortingData">The SortingData object, containing specific data used for sorting algorithm.</param>
        public void InOrder(SortingData sortingData)
        {
            root.InOrderTraversal(sortingData);
        }

        /// <summary>
        /// DisplayTopTenMovies() initializes a SortingData object for the sorting data.
        /// The function then uses InOrder(sortingData) to fill the sorting data with movies' data.
        /// The function then uses the mergeSort() algorithm, using the number of movies, the list of
        /// movies and its corresponding list of borrowed times 
        /// After the data are sorted, the function calls DisplayMovieInOrder() to display the top ten
        /// most popular movies.
        /// </summary>
        public void DisplayTopTenMovies()
        {
            SortingData sortingData = new SortingData();
            InOrder(sortingData);
            Sorting.mergeSort(sortingData.MovieNum(), sortingData.BorrowedTimesArray(), sortingData.MovieArray());

            sortingData.DisplayMoviesInOrder();
        }

        public Node Root
        {
            get { return root; }
        }
    }
}
