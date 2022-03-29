using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world_batch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO FIRST CLASS OF RFP");
            Console.WriteLine("1:Human\n2:SwapNumbers\n3:reverse or Palindrome\n4:UserReplace");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    human human = new human();
                    human.Speek();
                        break;
                case 2:
                    SwapNumbers swapNumbers = new SwapNumbers();
                    swapNumbers.SwapTwoNumbers();
                    break;
                case 3:
                    Console.WriteLine("Enter a number to reverse");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Reverse.FindReverse(number);
                    break;
                case 4:
                    UserReplace.ReplaceUserName();
                    break;
            }
              Console.ReadLine();
        }
    }
 }
