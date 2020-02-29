using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Util
    {
        //Going to Sum the parameters in the Parameter list as long as the conditions are met.
        public static int Sum(params int[] paramList)
        {
            Console.WriteLine("Using parameter list");
            // Checks to ensure the parameter list is not null. If it is, it throws an exception stating so.
            if (paramList == null)
            {
                throw new ArgumentException("Util.Sum: null parameter list");
            }
            // Checks to ensure the parameter list length does not equal zero. If it is, it throws an empty exception stating so.
            if (paramList.Length == 0)
            {
                throw new ArgumentException("Util.Sum: empty parameter list");
            }

            int sumTotal = 0; // declares a variable to hold the sum and instantiates it with zero.
            foreach (int i in paramList) // checks each iteration or index in the array and sums them as long as they meet the above criteria.
            {
                sumTotal += i; // adds each index to sumTotal
            }
            return sumTotal; // returns the total of the added array.
        }
        public static int Sum(int param1 = 0, int param2 = 0, int param3 = 0, int param4 = 0)
        {
            Console.WriteLine("Using optional parameters");
            int sumTotal = param1 + param2 + param3 + param4;
            return sumTotal;
        }

    }
}
