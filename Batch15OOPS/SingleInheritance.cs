using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{


    class Vehical  //Base class or parent class or superclass
    {
        public string Brand { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Brand} is driving");
        }

    }

    class Car : Vehical // derived class or cheild or sub class 
    {
        public int NumberofDoor { get; set; }

        public void ShowCarInfo()
        {
            Console.WriteLine($"{Brand} car has {NumberofDoor} door");
        }

    }


    internal class SingleInheritance
    {
        static void Main()
        {

            Car mycar = new Car();
            mycar.Brand = "Hundai";
            mycar.NumberofDoor =4;
            mycar.Drive();
            mycar.ShowCarInfo();

        }



    }
}
