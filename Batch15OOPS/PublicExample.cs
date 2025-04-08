using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{


    public class PublicExampleTest
    {

        //define property
        public int PublicProperty { get; set; }

        //Method 
        //[access_mofifier] [return_type] [method_name]{p
        public void Display()
        {
            Console.WriteLine("Public Property Value:" + PublicProperty );

        }

        public void Show()
        {
            Console.WriteLine("Hello");
        }
    }


        public class PublicExample
        {

            static void Main()
            {

                PublicExampleTest obj = new PublicExampleTest();

                obj.PublicProperty = 1;
                obj.Display();
                obj.Show();
            }


        }

    
}

