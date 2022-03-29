using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world_batch
{
    class Reverse
    {
        public static int FindReverse(int number)
        {
            int reverse = 0, remainder = 0;
            while (number > 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("reverse number is:" + reverse);
            return reverse;
        }
    }
}
