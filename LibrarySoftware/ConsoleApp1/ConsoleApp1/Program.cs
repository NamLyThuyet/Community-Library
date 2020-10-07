using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace LibraryMenu
{
    /*
     * This class simulates an online library which allows staffs and members to access library movies.
     * 
     * This class contains the Main() method and methods that represent the welcome menu, the staff menu,
     * and the member menu.
     * 
     * Author: Phuong Nam Ly May 2020
     */
    class Program
    {
        static MovieCollection movieCo = new MovieCollection();
        static MemberCollection memberCo = new MemberCollection();
        static String currentMember = null;

        /*
         * WelcomeMenu() writes valid options on the screen and responds to the choice that the user
         * makes.
         * 
         * The user can access the staff menu, the member menu or exit the program. If the user fails
         * to log in to another menu, an appropriate warning is given and WelcomeMenu() is run again
         * so that the user can make another choice.
         */ 
        static void WelcomeMenu()
        {
            Console.WriteLine("\r\n" + "\r\n"
                + "Welcome to the Community Library" + "\r\n"
                + "========Main Menu==========" + "\r\n"
                + " 1. Staff Login" + "\r\n"
                + " 2. Member Login" + "\r\n"
                + " 0. Exit" + "\r\n"
                + "===========================" + "\r\n"
                + "\r\n");

            int numChoices = 2;
            int sel = ExceptionHandling.GetCorrectSel(numChoices);

            if (sel == 1)
            {
                Console.Write("Enter username: ");
                String username = Console.ReadLine();
                Console.Write("Enter password: ");
                String password = Console.ReadLine();

                if (username == "staff" && password == "today123")
                {
                    StaffMenu();
                }
                else
                {
                    Console.Write("Username or password is invalid");
                    WelcomeMenu();
                }
            }
            else if (sel == 2)
            {
                Console.Write("Enter your Username (LastnameFirstname): ");
                String username = Console.ReadLine();
                int password = ExceptionHandling.GetInt("Enter password: ");

                if (memberCo.Search(username, password))
                {
                    // Notify the program the current member if the user 
                    // successfully logs in as a member.
                    currentMember = username;
                    MemberMenu();
                }
                else
                {
                    Console.Write("Username or password is invalid");
                    WelcomeMenu();
                }
            }
            else if (sel == 0)
            {

            }
        }

        /*
         * StaffMenu() writes valid options on the screen and responds to the choice that a staff makes.
         * If the staff fails to use an option, an appropriate warning is given and StaffMenu() is run again
         * so that the staff can make another choice.
         */ 
        static void StaffMenu()
        {
            Console.WriteLine("\r\n" + "\r\n" 
                + "========Staff Menu=========" + "\r\n"
                + " 1. Add a new movie DVD" + "\r\n"
                + " 2. Remove a movie DVD" + "\r\n"
                + " 3. Register a new member" + "\r\n"
                + " 4. Find a registered member's phone number" + "\r\n"
                + " 0. Return to main menu" + "\r\n"
                + "===========================");

            int numChoices = 4;
            int sel = ExceptionHandling.GetCorrectSel(numChoices);

            if (sel == 1)
            {
                Console.Write("Enter the movie title: ");
                String movieTitle = Console.ReadLine();

                if (!movieCo.Search(movieTitle))
                {
                    Console.Write("Enter the starring actor(s): ");
                    String starring = Console.ReadLine();
                    Console.Write("Enter the director(s): ");
                    String director = Console.ReadLine();
                    Console.WriteLine("Select the genre:" + "\r\n"
                                    + "1. Drama" + "\r\n"
                                    + "2. Adventture" + "\r\n"
                                    + "3. Family" + "\r\n"
                                    + "4. Action" + "\r\n"
                                    + "5. SciFi" + "\r\n"
                                    + "6. Comedy" + "\r\n"
                                    + "7. Thriller" + "\r\n"
                                    + "8. Other");
                    Console.Write("Make selection(1-8): ");
                    int genreSelection = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Select the classification" + "\r\n"
                                    + "1. General (G)" + "\r\n"
                                    + "2. Parental Guidance (PG)" + "\r\n"
                                    + "3. Mature (M15+)" + "\r\n"
                                    + "4. Mature Accompanied (MA15+)");
                    Console.Write("Make selection(1-4): ");
                    int classificationSelection = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Enter the duration (minutes): ");
                    int duration = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the release date (year): ");
                    int releaseDate = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the number of copies available: ");
                    int avCopies = Convert.ToInt32(Console.ReadLine());

                    movieCo.Add(new Movie(movieTitle, starring, director, genreSelection, classificationSelection, duration, releaseDate, avCopies));
                }
                else
                {
                    Console.Write("Enter the number of copies you would like to add: ");
                    int copies = Convert.ToInt32(Console.ReadLine());
                    movieCo.GetMovie(movieTitle).SetAvCopies(copies);
                    Console.Write("Added " + copies + " new copies " + movieTitle);
                }
                Console.WriteLine();
            }
            else if (sel == 2)
            {
                Console.Write("Enter the movie title: ");
                String movieTitle = Console.ReadLine();
                movieCo.Remove(movieTitle);
                Console.WriteLine();
            }
            else if (sel == 3)
            {
                Console.Write("Enter member's first name: ");
                String firstName = Console.ReadLine();
                Console.Write("Enter member's last name: ");
                String lastName = Console.ReadLine();

                // Checks if the username has been already registered. If not, register the member.
                // Otherwise, give a warning.
                if (!memberCo.Search(lastName + firstName))
                {
                    Console.Write("Enter member's address: ");
                    String address = Console.ReadLine();
                    int phoneNum = ExceptionHandling.GetInt("Enter member's phone number: ");
                    bool fourDigit = true;
                    int password = ExceptionHandling.GetInt("Enter member's password (4-digit): ", fourDigit);
                    memberCo.Add(firstName, lastName, address, phoneNum, password);
                }
                else
                {
                    Console.WriteLine("The username has been registered.");
                }
            }
            else if (sel == 4)
            {
                Console.Write("Enter the username: ");
                String username = Console.ReadLine();

                if (memberCo.Search(username))
                {
                    Console.WriteLine(username + "'s phone number is " + memberCo.GetMember(username).PhoneNum);
                }
                else
                {
                    Console.WriteLine("The username does not exist.");
                }
            }
            else if (sel == 0)
            {
                // Runs the WelcomeMenu() to return to the welcome menu screen
                // And returns immediately so that StaffMenu() is not run after that.
                WelcomeMenu();
                return;
            }

            StaffMenu();
        }

        /*
         * MemberMenu() writes valid options on the screen and responds to the choice that a member makes.
         * If the member fails to use an option, an appropriate warning is given and MemberMenu() is run again
         * so that the member can make another choice.
         */
        static void MemberMenu()
        {
            Console.WriteLine("\r\n" + "\r\n" 
                            + "=======Member Menu=========" + "\r\n"
                            + " 1. Display all movies" + "\r\n"
                            + " 2. Borrow a movie DVD" + "\r\n"
                            + " 3. Return a movie DVD" + "\r\n"
                            + " 4. List current borrowed movie DVDs" + "\r\n"
                            + " 5. Display top 10 most popular movies" + "\r\n"
                            + " 0. Return to main menu" + "\r\n"
                            + "===========================");

            int numChoices = 5;
            int sel = ExceptionHandling.GetCorrectSel(numChoices);

            if (sel == 1)
            {
                // Runs the in-order traversal method from the BSTree
                movieCo.InOrder();
            }
            else if (sel == 2)
            {
                Console.Write("Enter movie title: ");
                String movieTitle = Console.ReadLine();

                if (movieCo.Search(movieTitle))
                {
                    Movie movie = movieCo.GetMovie(movieTitle);
                    Member curMember = memberCo.GetMember(currentMember);

                    // Checks if the current has borrowed the movie. If not, check if the movie has any
                    // spare copies and the user has not exceeded the number of allowed borrowed copies. 
                    // If borrowing is successful, increase the borrowed times and decrease the available copies
                    // of the movies, then add the movie to the member's list of borrowed movies. If the borrowing 
                    // is not successful, gives out any warning.
                    if (!curMember.BorrowedMovies().Contains(movie))
                    {
                        if (movie.AvCopies() > 0 && curMember.BorrowedMovies().Count <= 9)
                        {
                            movie.SetBorrowedTimes(1);
                            movie.SetAvCopies(-1);

                            curMember.Borrow(movie);

                            Console.WriteLine("You borrowed " + movieTitle);
                            Console.WriteLine($"You have already borrowed {curMember.BorrowedMovies().Count} movies. " +
                                            $"You have {10 - curMember.BorrowedMovies().Count} attempts left." );
                        }
                        else if (movie.AvCopies() < 0)
                        {
                            Console.WriteLine("There is no available copy of " + movieTitle);
                        }
                        else if (curMember.BorrowedMovies().Count > 9)
                        {
                            Console.WriteLine($"You already borrow the maximum allowance of {curMember.BorrowedMovies().Count} movies.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Attempt failed. You already borrowed a copy of " + movieTitle);
                    }
                }
                else
                {
                    Console.WriteLine("Attempt failed. " + movieTitle + " does not exist in the library.");
                }
            }
            else if (sel == 3)
            {
                Console.Write("Enter movie title: ");
                String movieTitle = Console.ReadLine();


                if (movieCo.Search(movieTitle))
                {
                    Movie movie = movieCo.GetMovie(movieTitle);
                    Member curMember = memberCo.GetMember(currentMember);

                    if (curMember.BorrowedMovies().Contains(movie))
                    {
                        movie.SetAvCopies(1);
                        curMember.Return(movieCo.GetMovie(movieTitle));

                        Console.WriteLine(movieTitle + " is returned");
                        Console.WriteLine($"You are borrowing {curMember.BorrowedMovies().Count} movies. " +
                                        $"You have {10 - curMember.BorrowedMovies().Count} attempts left.");
                    }
                    else
                    {
                        Console.WriteLine("Attempt failed. You do not have a copy of " + movieTitle);
                    }
                }
                else
                {
                    Console.WriteLine(movieTitle + " does not exist in the library. You can keep it if you own a copy.");
                }
            }
            else if (sel == 4)
            {
                Member curMember = memberCo.GetMember(currentMember);

                if (curMember.BorrowedMovies().Count > 0)
                {
                    memberCo.GetMember(currentMember).DisplayBorrowedMovies();
                }
                else
                {
                    Console.WriteLine("You are not borrowing any movie from the library at the moment.");
                }
            }
            else if (sel == 5)
            {
                movieCo.DisplayTopTenMovies();
            }
            else if (sel == 0)
            {
                // Run the WelcomeMenu() to return to the welcome menu screen
                // And returns immediately so that StaffMenu() is not run after that.
                currentMember = null;
                WelcomeMenu();
                return;
            }

            MemberMenu();
        }

        /*
         * Main() runs any optional testing set and the WelcomeMenu().
         * 
         * Parameter: A string of arguments from the command lines, which is not utilized
         * in this project.
         */ 
        static void Main(string[] args)
        {
            try
            {
                // 3 optional sets of testing data
                TestingData.GetSetOne(movieCo, memberCo);
                //TestingData.GetSetTwo(movieCo, memberCo);
                //TestingData.GetSetThree(movieCo, memberCo);

                WelcomeMenu();
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.WriteLine("Program ends. Press any key to exit.");
            Console.ReadLine();
        }
    }
}
