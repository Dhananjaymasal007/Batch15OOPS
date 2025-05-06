using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    internal class RefExample
    {
        public static void swap(ref int a, ref int b)
        {

            int teamp = a;
            a = b;
            b = teamp;

            
        }

        static void Main()
        {
            int x = 10;
            int y = 20;

         ///   Console.WriteLine($"Before swap values:x={x},y={y}");
            swap(ref x, ref y);
            Console.WriteLine($"after swap values:x={x},y={y}");


        }
    }
}
