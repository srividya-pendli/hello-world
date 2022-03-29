using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world_batch
{
    class SwapNumbers
    {

        public int first, second, temp = 0;

        public void SwapTwoNumbers()
        {
            Console.WriteLine("please enter first number");
            string s = Console.ReadLine();
            Console.WriteLine("please enter first number");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second number");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap");
            Console.WriteLine("First:{0} Second:{1}", first, second);
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine("After swapped");
            Console.WriteLine("First:{0} Second:{1}", first, second);
        }
    }
}
