using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProblems
{
    /* Given an array containing 0s and 1s. Write an algorithm to sort array
     * so that 0s come first followed by 1s. Also find the minimum number of swaps
     * required to sort the array */
    public class Partition01
    {
        public static int Sort(int[] givenArray)
        {
            // Get size of the given array
            int size = givenArray.Length;

            // I'm assuming I can just find all the 0s and swap them in to the next front
            // index. Once there are no more 0s then I have a sorted array.

            /* Best approach is to start at both ends of the array with a left and right var
             * to hold the index. Increment and decrement from both ends finding the 0s and 1s
             * and swapping until the left and right indexes are next to each other */

            int left = 0;
            int right = size - 1;
            int count = 0;

            while (left < right)
            {
                while (givenArray[left] == 0)
                {
                    left += 1;
                }
                while (givenArray[right] == 1)
                {
                    right -= 1;
                }

                if (left < right)
                {
                    Swap(givenArray, left, right);
                    count += 1;
                }
                
            }
            return count;
            /*
            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    if (givenArray[i] == 0 && givenArray[j] != 0)
                    {
                        temp = givenArray[i];
                        givenArray[i] = givenArray[j];
                        givenArray[j] = temp;
                    }
                }
            }*/
        }

        public static void Swap(int[] array, int zeroes, int ones)
        {
            int temp = array[zeroes];
            array[zeroes] = array[ones];
            array[ones] = temp;
        }
    }
}
