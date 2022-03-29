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
            Console.WriteLine("1:Human");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    human human = new human();
                    human.Speek();
                        break;
            }
              Console.ReadLine();
        }
    }
 }
