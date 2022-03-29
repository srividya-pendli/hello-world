using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world_batch
{
    class UserReplace
    {
        public static void ReplaceUserName()
        {
            string line = "hello <<userName>>,how are you ,what you are studing?";
            Console.WriteLine("please enter userName");
            string userName = Console.ReadLine();
            //string updatedRes=line.Replace("<<userName>>",userName);
            Console.WriteLine("after replace\n" + line.Replace("<<userName>>", userName));
        }
    }
}
