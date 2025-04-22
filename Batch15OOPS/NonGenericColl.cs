using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    internal class NonGenericColl
    {
        static void Main()
        {
            //array list 

            //creating objeect of ana array list

            ArrayList lst = new ArrayList();

            //adding the elements in arraylist

            lst.Add(1);
            lst.Add("Hello");
            lst.Add(false);

            //accessing elements in the array list

            Console.WriteLine("arraylist elements");

            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            //removing elements in  the  arry list

            lst.RemoveAt(1);

            Console.WriteLine("arraylist elements after the remove opperetions");

            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }


            //*****************Hashtable****************//

            Hashtable ht = new Hashtable();


            //adding elements in the hashtable

            ht.Add(101, "Java");
            ht.Add(102, "DOTNET");
            ht.Add(103, 9898);
            ht.Add(104, true);

            //while accessing the hashtable typecasing is requiered



            string value1 = (string)ht[101];
            string value2 = (string)ht[102];
            string value3 = Convert.ToString((int)ht[103]);
            bool value4 = (bool)ht[104];


        }


    }
}
