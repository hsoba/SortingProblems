using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] partition01array = new int[] { 1, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 0 };

            Partition01.Sort(partition01array);

            foreach (int element in partition01array)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
    }
}
