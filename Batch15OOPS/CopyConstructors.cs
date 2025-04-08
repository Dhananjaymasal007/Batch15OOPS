using Batch15OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{

    public class CopyConstructorExample
    {
        // parameter declarations

        public string Name { get; set; }

        public int Age { get; set; }

        public string Namenew { get; set; }

        public int Agenew { get; set; }




        //parameter constructor 

        public CopyConstructorExample(string name, int age)
        {
            Name = name;
            Age = age;
        }

        ////copy constructor

        public CopyConstructorExample(CopyConstructorExample copyex)
        {
            Namenew = copyex.Name;
            Agenew = copyex.Age;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name:{Name}, Age:{Age}");
        }

        public void DisplayInfoNew()
        {
            Console.WriteLine($"Name:{Namenew}, Age:{Agenew}");
        }

    }





    internal class CopyConstructors
    {
        static void Main()
        {
            //creating object with pass the value for parameterized constructor

            CopyConstructorExample obj = new CopyConstructorExample("Ajay", 25);
            obj.DisplayInfo();

            //creating another object using copy consturctor

            CopyConstructorExample obj2 = new CopyConstructorExample(obj);

            obj2.DisplayInfoNew();


        }


    }
}
