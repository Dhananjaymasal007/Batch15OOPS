using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    //static polymorphism OR compiltime Polymorphism OR Early Binding (method overloading)
    //Meethod name  same class name same but different parameter/arguments.


    class BasicOperations
    {

        public double Add(int a , double b)
        { 
            return a + b;
        }
        public double Add(double a , int b)
        {
            return a + b;
        }

    }

    internal class StaticPolymorphism
    {
        static void Main()
        {
            BasicOperations basic =  new BasicOperations();
            // calling the overload method

            double sum = basic.Add(5, 7.5);

            double doubleSum = basic.Add(5.5, 5);


            Console.WriteLine("$Sum of Interger Values : "+ sum);
            Console.WriteLine("$Sum of Decimal Values :"+ doubleSum);




        }

    }
}
