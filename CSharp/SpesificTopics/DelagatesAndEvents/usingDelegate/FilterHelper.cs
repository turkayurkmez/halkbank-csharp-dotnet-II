using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingDelegate
{
    public static class FilterHelper
    {
        // public delegate bool Criteria(int number);
        public static List<int> Filter(int[] numbers, Func<int, bool> criteria)
        {

            var result = new List<int>();
            foreach (int number in numbers)
            {
                if (criteria(number))
                {
                    result.Add(number);
                }
            }

            return result;
        }

    }
}
