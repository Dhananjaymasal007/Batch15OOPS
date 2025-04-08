using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
     class Operators
    {

        static void Main()
        {


            //Console.WriteLine("Test");   //first line
            //Console.WriteLine("Test1");  //second line
            //Console.Write("Test2");   //third line
            //Console.Write("Test3");   //thrid line


            //Variables Declarations
            int a = 10;
            int b = 11;

            //Arithmatic Operator

            Console.WriteLine("Arithmatic Operators");
            Console.WriteLine($"Addition : {a+b}");
            Console.WriteLine($"Substraction : {a-b}");
            Console.WriteLine($"Multiplications: {a*b}");
            Console.WriteLine($"Division:{a/b}");
            Console.WriteLine($"MOD: {a%b}");


            //comparision operator OR Relations Operator

            Console.WriteLine("Comparision Operator");
            Console.WriteLine($"a==b: {a==b}");
            Console.WriteLine($" a!= b: {a!=b}");
            Console.WriteLine($" a < b: {a < b}");
            Console.WriteLine($" a > b: {a>b}");
            Console.WriteLine($" a <=b: {a <= b}");
            Console.WriteLine($" a >=b:{a >= b}");


            //logical Operators

            bool x = false;
            bool y = true;
            Console.WriteLine("Logical Operator");
            Console.WriteLine($"x && y: {x && y}");
            Console.WriteLine($"x || y: {x|| y}");
            Console.WriteLine($" !x : {!x}");









        }

    }
}
