using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /*
     * This class allows the user to create sets of testing data, which is useful for testing purposes.
     * 
     * Author: Phuong Nam Ly Octoboer 2020
     */

    public class TestingData
    {
        public static void GetSetOne(MovieCollection movieCo, MemberCollection memberCo)
        {
            movieCo.Add(new Movie("Luscious Birch", "Actor 1", "Director 1", 1, 1, 90, 2020, 10, 30));
            movieCo.Add(new Movie("The Each Lights", "Actor 2", "Director 2", 1, 1, 90, 2020, 10, 20));
            movieCo.Add(new Movie("Alien in the Weeping", "Actor 3", "Director 3", 1, 1, 90, 2020, 10, 60));
            movieCo.Add(new Movie("Frozen Girlfriend", "Actor 4", "Director 4", 1, 1, 90, 2020, 10, 22));
            movieCo.Add(new Movie("Rose of Snow", "Actor 5", "Director 5", 1, 1, 90, 2020, 10, 39));
            movieCo.Add(new Movie("The Scent's Ships", "Actor 6", "Director 6", 1, 1, 90, 2020, 10, 31));
            movieCo.Add(new Movie("Wings in the Emperor", "Actor 7", "Director 7", 1, 1, 90, 2020, 10, 6));
            movieCo.Add(new Movie("Silk in the Emperor", "Actor 8", "Director 8", 1, 1, 90, 2020, 10, 2));
            movieCo.Add(new Movie("Sleeping Lord", "Actor 9", "Director 9", 1, 1, 90, 2020, 10, 99));
            movieCo.Add(new Movie("Nobody of Door", "Actor 10", "Director 10", 1, 1, 90, 2020, 10, 26));
            movieCo.Add(new Movie("Tears in the Fire", "Actor 11", "Director 11", 1, 1, 90, 2020, 10, 40));
            movieCo.Add(new Movie("Years in the Silence", "Actor 12", "Director 12", 1, 1, 90, 2020, 10, 78));
            movieCo.Add(new Movie("Gate of Dream", "Actor 13", "Director 13", 1, 1, 90, 2020, 10, 82));

            memberCo.Add("Krystian", "Black", "1 Elizabeth Street", 64414522, 6441);
            memberCo.Add("Mahir", "Dunkley", "2 Elizabeth Street", 563063202, 5630);
            memberCo.Add("Kirstin", "Mitchell", "3 Elizabeth Street", 698214593, 9495);
            memberCo.Add("Amy", "Booth", "4 Elizabeth Street", 563037857, 6058);
            memberCo.Add("Kiki", "Weir", "5 Elizabeth Street", 284069597, 6008);
            memberCo.Add("Sophie", "Herrera", "6 Elizabeth Street", 380457263, 4482);
            memberCo.Add("Adam", "Moreno", "7 Elizabeth Street", 225962752, 7425);
            memberCo.Add("Dante", "Hogan", "8 Elizabeth Street", 323195794, 2610);
        }

        public static void GetSetTwo(MovieCollection movieCo, MemberCollection memberCo)
        {
            movieCo.Add(new Movie("Silken Servant", "Daniel Rodriguez", "Sammy-Jo Hubbard", 1, 1, 90, 2007, 10, 88));
            movieCo.Add(new Movie("The Splintered Gift", "Harry Miller", "Tahmina Beck", 3, 2, 120, 2010, 10, 40));
            movieCo.Add(new Movie("Misty of Hunter", "Joseph Davis", "Fintan Holloway", 5, 3, 180, 2006, 10, 29));
            movieCo.Add(new Movie("The Dream's Wife", "Joshua Smith", "Darcy Riddle", 6, 4, 90, 2003, 10, 92));
            movieCo.Add(new Movie("The Valley of the Ashes", "Jack Garcia", "Jamie-Leigh", 7, 4, 270, 2012, 10, 63));
            movieCo.Add(new Movie("Wings in the Waves", "Cora Benton", "Genevieve Patton", 8, 3, 240, 2013, 10, 5));
            movieCo.Add(new Movie("Wings in the Emperor", "Hamza Cardenas", "Ruqayyah Soto", 6, 2, 300, 2015, 10, 70));
            movieCo.Add(new Movie("Stolen Nothing", "Kaleb Williamson", "Aiden Mclean", 6, 1, 90, 2008, 10, 14));
            movieCo.Add(new Movie("The Blue Lover", "Leoni Whyte", "Missy Hawes", 3, 1, 90, 2020, 10, 50));
            movieCo.Add(new Movie("Spirits of Sky", "Laurence Boone", "Asmaa Mckay", 4, 2, 180, 2009, 10, 16));
            movieCo.Add(new Movie("The Thief's Visions", "Stephan Mcghee", "Alayna Welch", 5, 3, 270, 2011, 10, 51));
            movieCo.Add(new Movie("The Servants of the Lights", "Ajay Molloy", "Taslima May", 1, 4, 90, 2001, 10, 90));
            movieCo.Add(new Movie("Dreamer in the Alien", "Murray Dominguez", "Ava-Grace Moody", 7, 2, 300, 2002, 10, 19));

            memberCo.Add("Tahmina", "Beck", "1 Elizabeth Street", 64414522, 1452);
            memberCo.Add("Fintan", "Holloway", "2 Elizabeth Street", 563063202, 3202);
            memberCo.Add("Hazel", "Bolton", "3 Elizabeth Street", 698214593, 4593);
            memberCo.Add("Christine", "Hinton", "4 Elizabeth Street", 563037857, 3787);
            memberCo.Add("Daniela", "Grant", "5 Elizabeth Street", 284069597, 1840);
        }

        public static void GetSetThree(MovieCollection movieCo, MemberCollection memberCo)
        {
            movieCo.Add(new Movie("Seventh Cloud", "Actor 1", "Director 1", 1, 1, 90, 2020, 10, 35));
            movieCo.Add(new Movie("The Dying Moons", "Actor 2", "Director 2", 1, 1, 90, 2020, 10, 75));
            movieCo.Add(new Movie("Snake of Stream", "Actor 3", "Director 3", 1, 1, 90, 2020, 10, 39));
            movieCo.Add(new Movie("The Thorns' Husband", "Actor 4", "Director 4", 1, 1, 90, 2020, 10, 11));
            movieCo.Add(new Movie("The Magic of the Tale", "Actor 5", "Director 5", 1, 1, 90, 2020, 10, 98));
            movieCo.Add(new Movie("Names in the Emerald", "Actor 6", "Director 6", 1, 1, 90, 2020, 10, 25));
            movieCo.Add(new Movie("Whispering Door", "Actor 7", "Director 7", 1, 1, 90, 2020, 10, 74));

            memberCo.Add("Kaya", "Sweet", "1 Elizabeth Street", 64414522, 4122);
            memberCo.Add("Saim", "Schmitt", "2 Elizabeth Street", 563063202, 6356);
            memberCo.Add("Zahara", "Weber", "3 Elizabeth Street", 698214593, 1296);
            memberCo.Add("Jordana", "Davie", "4 Elizabeth Street", 563037857, 3037);
        }
    }
}
