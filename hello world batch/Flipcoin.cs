using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world_batch
{
    class Flipcoin
    {
        public static void FindFlipCoinCount()
        {
            int tailcount = 0, headcount = 0;
            Random random = new Random();
            Console.WriteLine("enter number of times to flipcoin");
            int numberofTimes = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < numberofTimes; i++)
            {
                double input = random.NextDouble();
                if (input < 0.5)
                    tailcount++;
                else
                    headcount++;
            }
            Console.WriteLine("headcount:{0} tailcount:{1}", headcount, tailcount);
            double headPercentage = (headcount * 100) / numberofTimes;
            double tailPercentage = (tailcount * 100) / numberofTimes;
            Console.WriteLine("Head percentage:{0}% Tail percentage:{1}%", headPercentage, tailPercentage);

        }
    }
}
