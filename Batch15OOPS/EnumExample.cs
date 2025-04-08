using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
     class EnumExample
    {
        //syntax of enum

        enum Days
        {
            // Emum Implementations
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday


        }



        enum Httpstatuscode
        {
            OK =200,
            Badrequesr=400,
            Unauthorized = 401,
            Forbidden =500,
            NotFund = 400

        }



        static void Main()
        {



            PublicExampleTest obj = new PublicExampleTest();

            obj.PublicProperty = 5;
            obj.Display();
            obj.Show();


            Days today = Days.Saturday;

            switch (today)
            {
                case Days.Sunday:
                    Console.WriteLine("Today is Sunday");
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case Days.Monday:
                    Console.WriteLine("today is MOnday");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("Today is tuesday");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("Today is wednesday");
                    break;
                case Days.Thursday:
                    Console.WriteLine("today is thursday");
                    break;
                case Days.Friday:

                    //Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Today is firday");
                    break;
                case Days.Saturday:
                    Console.WriteLine("today is saturday");
                    break;

            }

            if( today == Days.Sunday || today == Days.Saturday)
            {
                Console.WriteLine("It's Weekend");

            }
            else
            {
                Console.WriteLine("It's week day");

            }


            //test
            Httpstatuscode code = Httpstatuscode.OK;
            Console.WriteLine("HTTP Status Code:"+code);

            int codenumber = (int)code;
            Console.WriteLine("HTTP status Code Number:"+codenumber);

        }


    }
}
