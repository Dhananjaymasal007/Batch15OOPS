using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    internal class ExceptionHandlings
    {

        static void Main()
        {
            //try -it execute always
            //catch - it execute once error occoured -we can use multiple catch block
            // finally- it execute always either error occoured or not.


            int[] numbers = { 1, 2, 3 };
            int index = 3;

            try
            {
                int value = numbers[index];
                Console.WriteLine($"value at index {index} is {value}");

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"An error occoured for index out of bound :{e.Message}");
            }

            catch (Exception ex)
            {
                Console.WriteLine("$An Error Occoured: { ex.Message}");

            }
            finally
            {

                Console.WriteLine("this code always execute");
            }

            //divide by zero

            int num = 10;
            int deno = 0;
            double result = 0;

            
            try
            {
                result = num/deno;
                Console.WriteLine($"Result of division:{result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message} cannot be divede by zero");
            }



        }


    }

}
