using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /*
     * This class represents information about a member.
     * 
     * Author: Phuong Nam Ly May 2020
     */
    public class Member
    {
        private String firstName;
        private String lastName;
        private String address;
        private int phoneNum;
        private int password;
        private List<Movie> borrowedMovies;

        public Member(String firstName, String lastName, String address, int phoneNum, int password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phoneNum = phoneNum;
            this.password = password;
            borrowedMovies = new List<Movie>();

            Console.WriteLine();
            Console.WriteLine("Successfully added member " + firstName + " " + lastName);
            Console.WriteLine();
        }

        public void Borrow(Movie movie)
        {
            borrowedMovies.Add(movie);
        }

        public void Return(Movie movie)
        {
            borrowedMovies.Remove(movie);
        }

        public void DisplayBorrowedMovies()
        {
            foreach(Movie m in borrowedMovies)
            {
                m.GetInfo();
                Console.WriteLine();
            }
        }

        public List<Movie> BorrowedMovies()
        {
            return borrowedMovies;
        }

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public String UserName
        {
            get { return LastName + FirstName; }
        }

        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        public int PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        public int Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
