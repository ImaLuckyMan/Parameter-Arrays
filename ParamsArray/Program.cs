using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            // Writes the exeption from the Util class to the screen picking up an empty array. This tests the 2nd excetion.
            //Console.WriteLine(Util.Sum()); // Had to comment out because otherwise the program won't continue.
            // Writes the exception from the Util class to the screen if value equals null. This tests the 1st exception.
            //Console.WriteLine(Util.Sum(null)); // Had to comment out because otherwise the program won't continue.
            // Writes the total of the summed array ensuring the class method is working correctly. 
            //Console.WriteLine(Util.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1)); // Expected total 55 from the paramList.
            Console.WriteLine(Util.Sum(2, 4, 6, 8, 10)); /* Also works with only 3 arguments using the optional params class method in Util. but if you give it 5, the compiler 
            chooses the parameter array becuase there are only 4 optional params declared in the Util class.*/
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
