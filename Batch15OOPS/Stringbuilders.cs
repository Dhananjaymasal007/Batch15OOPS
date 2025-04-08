using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    internal class Stringbuilders
    {
        static void Main()
        {
            //string

            string str = "Hello World";
            Console.WriteLine(str);

            str  = "test";
            Console.WriteLine(str);


            string FirstName = "Tushar";
            string LastName = "Bandgar";

            string FullName = FirstName + LastName;
            Console.WriteLine(FullName);

            //String Builder Implementataions

            StringBuilder SB = new StringBuilder();

            SB.Append("My Name ");
            SB.Append("is ");
            SB.Append("Tushar");
            SB.Append("Bandgar");

            Console.WriteLine(SB.ToString());


            // remove value to string builder in  specific index

            //  SB.Remove(8,3);
            //Console.WriteLine(SB.ToString());


            // insert value in specfic index  of string builder


            SB.Insert(11, "Mr.");
            Console.WriteLine(SB.ToString());


            //Replace value in specfic  index using string builder

            SB.Replace("Tushar", "Ajay");

            Console.WriteLine(SB.ToString());
            SB.Clear();


            //boxing -it is a process of converting value type to object type
            int x = 10; // value type
            object y = x;//boxing 

            //unboxing - it  is process of converting object type to value type

            object o = 10;
            int i = (int)o;//unboxing 

        }

    }
}
