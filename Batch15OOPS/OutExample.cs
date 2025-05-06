using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    internal class OutExample
    {

        static void Main()
        {
            //declare variable in out

            int result1 = 10;
            int result2, result3, result4;
            int x = 50, y = 10;


            //call method with out parameer

            BasicOperations(x, y, out result1, out result2, out result3, out result4);

            //display information
            Console.WriteLine("addition is :" + result1);
            Console.WriteLine("Substaction is :"+ result2);
            Console.WriteLine("Multiplication is :"+ result3);
            Console.WriteLine("division is :" + result4);



        }
        private static void BasicOperations(int x, int y, out  int Addition, out int Substraction, out int Multification, out int division)
        {

            //ition = x+ y;
            Addition = y + x;
            Substraction = x- y;
            Multification = x*y;
            division = x/y;


         }


            //throw new NotImplementedException();
        }
    
}
