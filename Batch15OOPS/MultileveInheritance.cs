using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{



    class A // base class  -- grand parent
    {
        public void start()
        {
            Console.WriteLine("The vehical is started");

        }


    }
    class B : A //derived -- base class   - parent 
    {

        public void Drive()
        {
            Console.WriteLine("car is driving");

        }

    }

    class C : B   //derived class  - chield
    {

        public void Troubleshoot()
        {
            Console.WriteLine(" the sport is in the another mode");
        }
    }

    internal class MultileveInheritance
    {
        static void Main()
        {

            C cls = new C();
            cls.start();
            cls.Drive();
            cls.Troubleshoot();


        }

    }
}
