using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockBuster bb = new BlockBuster();
            Console.WriteLine("Welcome to the Blockbuster App!");
            bb.CheckOut();

            //Does not compile scenes. I'm having trouble with calling Play().
        }


    }
}
