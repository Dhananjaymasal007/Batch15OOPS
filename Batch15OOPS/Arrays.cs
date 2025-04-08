using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    internal class Arrays
    {
        static void  Main()
        {

            //Declare the arrays

            string[] Mobiles = new string [6];

            //assigning values in arrays
            //first aproch
            Mobiles[0] = "Apple";
            Mobiles[1] = "Samsung";
            Mobiles[2]  = "OnePLus";
            Mobiles[3] = "Nokia";
            Mobiles[4] = "Realme";
            Mobiles[5] = "RedMi";

            //
            string[] Mobile = [ "Apple", "Samsung", "onePlus" ];

            //Acessing values from array

            for(int i=0; i <Mobiles.Length;i++)
            {

                Console.WriteLine("Mobile Names:"+ Mobiles[i]);
            }


            //initilize multidimentional array
            int[,] Matrix = new int[,]   //int number 
            {   // 0 1 2
              {1,2,3 },     //0,1-0,2
              {4,5,6},  
              {7,8,9},
            };

            //accessing  values from multidimentional array

            Console.WriteLine("Element at(0,1):"+ Matrix[0, 1]);//=2
            Console.WriteLine("Element at(1,2):" + Matrix[1, 2]);//=6


            //print all the elements form the multidimentioanal array


            for(int i =0; i<3;i++)
            {
                for(int j =0; j<3;j++) 
                {
                    Console.Write(Matrix[i, j]+",");            
                
                }
                Console.WriteLine();
                

            }


            //reverse string 


            string rev = "Welcome TO";  //output -emoclew emo

            char[] chArray = rev.ToCharArray();
            char[] revArray = new char[chArray.Length];

            for (int i = 0; i<chArray.Length;i++)
            {
                revArray[i] = chArray[chArray.Length -1-i];

            }
            string Orignalstr = new string(chArray);
            string revStr = new string(revArray);
                        

            Console.WriteLine($"Original String: " + Orignalstr);
            Console.WriteLine($"Reverse String: " + revStr);











        }



    }
}
