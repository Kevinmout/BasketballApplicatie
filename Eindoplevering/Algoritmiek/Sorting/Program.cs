using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    class Program
    {


        class GFG
        {
            // Function to find the minimum sum
            public static int findMinRec(int[] arr, int i,
                                        int sumCalculated,
                                             int sumTotal)
            { 
                // If we have reached last element.
                // Sum of one subset is sumCalculated,
                // sum of other subset is sumTotal-
                // sumCalculated. Return absolute 
                // difference of two sums.
                if (i == 0)
                    return Math.Abs((sumTotal - sumCalculated)- sumCalculated);


                // For every item arr[i], we have two choices
                // (1) We do not include it first set
                // (2) We include it in first set
                // We return minimum of two choices
                
                int leftValue = findMinRec(arr, i - 1, sumCalculated + arr[i - 1], sumTotal);
                int rightValue = findMinRec(arr, i - 1, sumCalculated, sumTotal);

                int MinMath = Math.Min(leftValue, rightValue);

                return MinMath;
            }

            // Returns minimum possible difference between
            // sums of two subsets
            public static int findMin(int[] arr, int n)
            {
                int[] leftArr = new int[n];
                // Compute total sum of elements
                int sumTotal = 0;
                for (int i = 0; i < n; i++)
                    sumTotal += arr[i];

                int FoundMin = findMinRec(arr, n, 0, sumTotal);
                // Compute result using recursive function
                return FoundMin;
            }

            /* Driver program to test above function */
            public static void Main()
            {
                int[] arr = {1,2,3, 4, 5, 6};
                int n = arr.Length;
                Console.Write("The minimum difference" +
                                " between two sets is " +
                                       findMin(arr, n));
            }
        }
    }
}