using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /*
     * This class is an implementation of the merge sort algorithm. 
     * This class sorts both int and Movie arrays, in descending order. 
     * 
     * I have attempted to use only a movie array for the sorting, and then use movie.GetBorrowedTimes
     * to get the borrowed times for comparsions withing the merge() function. Theoretically, this would
     * eliminate the use of int array and make this class more concise and efficient. However,
     * in my mergeSort() process, when divising a Movie array into sub-arrays, one of the sub-arrays contains
     * a null value. When the arrays are merged in merge(), null.GetBorrowedTimes would result in an error. To 
     * solve this problem, I have tried to check and remove null values within the movie array but have not 
     * succeeded. Therefore, my alternative solution is including an int array for comparing in merge().
     * 
     * Author: Phuong Nam Ly May 2020
     */
    public class Sorting
    {
        /// <summary>
        /// merge() compares the int values between the components of the int arrays, once at a time.
        /// When comparing, if the left int component is larger than the right int component, 
        /// the left int component and the left Movie component will be added to the combined int arrays
        /// combine Movie arrays, respectively, and vice versa.
        /// After the comparisions, if the size of the left array is larger than that of the right array,
        /// add all the remaning components of the left arrays into the combined arrays, and vice-versa.
        /// This resulted in the int and Movie arrays being sorted in the descending order.
        /// </summary>
        /// The input arrays are already sorted in descending order.
        /// <param name="n1">the size for the left arrays</param>
        /// <param name="L">the left int array</param>
        /// <param name="n2">the size for the right arrays</param>
        /// <param name="R">the right int array</param>
        /// <param name="a">the int array</param>
        /// <param name="mL">the left Movie array</param>
        /// <param name="mR">the right Movie array </param>
        /// <param name="m">the Movie array</param>
        public static void merge(int n1, int[] L, int n2, int[] R, int[] a, Movie[] mL, Movie[] mR, Movie[] m)
        {
            // inf is a flag, having a large negative value
            // to ensure that when sorting, the last values of the int arrays,L[n1] and R[n2]
            // are the smallest values, which is true because both the arrays are in the descending order
            // and the last component of the array should be the smallest value, hence the large negative value.
            int inf = -1000000001;
            L[n1] = inf;
            R[n2] = inf;

            int i, j, k;
            i = j = k = 0;
            while (i < n1 || j < n2)
            {
                if (L[i] > R[j])
                {
                    a[k] = L[i];
                    m[k] = mL[i];

                    i++;
                }
                else
                {
                    a[k] = R[j];
                    m[k] = mR[j];

                    j++;
                }
                k++;
            }
        }

        /// <summary>
        /// mergeSort() breaks down the int and Movie arrays into smaller arrays, until
        /// each array only contain one value, by calling itself recursively.
        /// After this, mergeSort() calls merge() recursively to merge the smaller arrays into bigger ones,
        /// ultimately resulting in two sorted arrays with the original size.
        /// </summary>
        /// <param name="n">the size of the arrays</param>
        /// <param name="a">the int array</param>
        /// <param name="m">the Movie array</param>
        public static void mergeSort(int n, int[] a, Movie[] m)
        {
            // If an array only contains one component, the array is already sorted.
            // In this case, the following loop stops running and merge() starts to run.
            if (n > 1)
            {
                // a is broken down into two arrays, L and R
                // m is broken down into two arrays, mL and mR
                int n1 = n / 2;
                int n2 = n - n1;
                int[] L, R;
                Movie[] mL, mR;
                L = new int[n1 + 1];
                R = new int[n2 + 1];
                mL = new Movie[n1 + 1];
                mR = new Movie[n2 + 1];

                // Intializing the int arrays and the Movie arrays
                for (int i = 0; i < n1; i++)
                {
                    L[i] = a[i];
                    mL[i] = m[i];
                }
                for (int i = 0; i < n2; i++)
                {
                    R[i] = a[i + n1];
                    mR[i] = m[i + n1];
                }

                // Uses mergeSort to further break down the left and right arrays
                // When arrays are broken into smaller array, only containing one array,
                // merge() is used to merge smaller array into bigger ones, until the size
                // reaches the original size, resulting in sorted int and Movie arrays.
                mergeSort(n1, L, mL);
                mergeSort(n2, R, mR);
                merge(n1, L, n2, R, a, mL, mR, m);
            }
        }
    }
}
