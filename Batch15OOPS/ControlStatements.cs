using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;


namespace Batch15OOPS
{
    internal class ControlStatements
    {
        static void Main()
        {
            // 1. 
            //if statement

            int Number = 11;

            if (Number == 10)
            {
                Console.WriteLine("This number is positive");
            }

            //if else statement

            string UserName = "Sachin";

            if (UserName =="Sachin1")
            {
                Console.WriteLine("This is Active user");
            }
            else
            {
                Console.WriteLine("This is Invalid User");
            }

            // if else if statement
            int Numbernew = 59;
            if (Numbernew == 0)
            {
                Console.WriteLine("The Number is Positive");
            }
            else if (Numbernew < 0)
            {
                Console.WriteLine("The Number is Negative");
            }
            else if (Numbernew > 100 && Numbernew < 200)
            {
                Console.WriteLine("The number between 100 to 200 ");
            }
            else
            {
                Console.WriteLine("The number below 100");
            }

            //Switch 

            int Day = 5;
            switch (Day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                default:
                    Console.WriteLine("Weekend");
                    //realtime Logic

                    break;



            }


            //2.looping statement

            //for loop

            int n = 5; // variable declarations
                       //1)variable  initilize 2)iterations conditions 3) iterations increment/decrement
            for (n=0; n<5; n++)
            {
                Console.WriteLine("Iteration:"+ n);
            }

            //while loop-- entry control loop

            int i = 0;
            while (i<5)
            {
                //core logic
                Console.WriteLine("Iternation in while loop"+ i);
                i++;

            }

            //do while loop  -- Exit control loop


            int j = 0;

            do
            {
                Console.WriteLine("Iteration in do while loop"+ j);
                j++;

            } while (j<5);


            // for each statement

            string[] Fruits = { "Apple", "Mango", "Banana", "Orange", "Watermelon", "Grapes" };
            foreach (string fruit in Fruits)
            {
                Console.WriteLine("the Fruit is "+ fruit);

            }


            //3.Jumping Statement

            /// continue

            for (i=0; i<5; i++)
            {
                if (i==2)
                {
                    continue;
                }
                Console.WriteLine("Iterations:"+ i);

            }

            //Go To statement

            int count = 0;
            startloop:

            if (count < 5)
            {
                Console.WriteLine($"Count is {count}");
                count++;
                goto startloop;
                Console.WriteLine($"Count after goto {count}");

            }
            Console.WriteLine($"loop with goto is finsished");

        }

    }

}
