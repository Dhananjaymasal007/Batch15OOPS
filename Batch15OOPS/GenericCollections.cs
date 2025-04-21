using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    internal class GenericCollections
    {

        //Generic Collectoin

        static void Main()
        {
            //List

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers[1]);



            //Divtionary

            Dictionary<string, int> name = new Dictionary<string, int>();

            //add key -value pairs to the dictionary


            name.Add("Rohit", 23);
            name.Add("Ajay", 25);
            name.Add("Sachin", 30);


            Console.WriteLine("All Elements added in the dictionary");


            foreach (KeyValuePair<string, int> KVP in name)
            {
                Console.WriteLine($"{KVP.Value}: {KVP.Key}");
            }

            //modify dictionary

            name["Rohit"]=26;


            Console.WriteLine("UPdated elements in dictionary");

            foreach (KeyValuePair<string, int> KVP in name)
            {
                Console.WriteLine($"{KVP.Value}: {KVP.Key}");
            }


            //Remove element in dictionary

            name.Remove("Sachin");


            Console.WriteLine("UPdated elements in dictionary after remove");

            foreach (KeyValuePair<string, int> KVP in name)
            {
                Console.WriteLine($"{KVP.Value}: {KVP.Key}");
            }


            //find element in dictionary


            if (name.ContainsKey("Rohit"))
            {
                Console.WriteLine("Exist in Dictionary");
            }
            else
            {
                Console.WriteLine("Not exist in Dictionary");
            }



            //*******************QUEUE******************//

            Queue qu = new Queue();

            //first in first out


            qu.Enqueue("Ajay");
            qu.Enqueue(98902155);
            qu.Enqueue(true);


            //remove element in queue


            object firstelement = qu.Dequeue();
            object secondelement = qu.Dequeue();
            object thridelement = qu.Dequeue();


            Console.WriteLine("Queued elements");
            Console.WriteLine(firstelement);
            Console.WriteLine(secondelement);
            Console.WriteLine(thridelement);













        }



    }
}
