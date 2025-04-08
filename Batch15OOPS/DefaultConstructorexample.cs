using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{

    public class DefaultConstexample
    {

        public int value;

        //Default COnstructor

        public DefaultConstexample()
        {
            value = 1;
        }
        ///normal method
        public void Display()
        {
            Console.WriteLine("test" + value);
        }


    }

    internal class DefaultConstructorexample
    {
        static void Main()
        {
            //instance creation
            DefaultConstexample example = new DefaultConstexample();


            example.Display();


        }


    }


}
