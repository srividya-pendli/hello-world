using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world_batch
{
    class human
    {
        //variables
        //access-modifier datatype varaiable name
        public string name = "nish", address = "mdr";
        public double height = 5.56;
        //public decimal a = 12.45M;

        //methods
        public void Speek()
        {
            Console.WriteLine("he/she can talk");
            Console.WriteLine("Name:{0} Address:{1} height:{2}", name, address, height);

        }
    }
}
