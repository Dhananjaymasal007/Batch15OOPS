using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    class ReadOnlyEx
    {
        // property declarations

        public readonly int Initialvalue;
        public static readonly double pi;
        public static string test = "Test";

        public ReadOnlyEx(int intialval)
        {
            Initialvalue = intialval;
            Initialvalue =20;

        }

        static ReadOnlyEx()
        {
            pi = 3.15454;
        }
        public void PrintValues()
        {
            Console.WriteLine($"Initial values:{Initialvalue}");
            Console.WriteLine($"value of pi is :{pi}");

        }

    }

    internal class ReadonlyExample
    {
        static void Main()
        {
            ReadOnlyEx re = new ReadOnlyEx(5);    
            re.PrintValues();

        }


    }
}
