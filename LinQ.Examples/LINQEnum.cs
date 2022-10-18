using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Examples
{
    public class LINQEnum
    {
        private int[] numList = { 1, 22, 46, 78, 56, 32, 54, 2, 7, 5 };

        // Sort list of numbers
        public IEnumerable<int> SortList() {
            return numList.OrderBy(x => x);
        }

        //Select numbers > num
        public IEnumerable<int> GreaterThanList(int num) {
            return numList.Where(x => x > 10);
        }

        //Sort list of numbers and return numbers > num
        public IEnumerable<int> SortAndGreaterThanList(int num) {
            return numList.Where(x => x > 10)
                                    .OrderBy(x => x);
        }

        // Print out result
        public void printList(IEnumerable lst) {
            foreach (var i in lst)
            {
                Console.WriteLine(i);
            }
        }
    }
}
