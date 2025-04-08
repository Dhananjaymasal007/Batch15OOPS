using Batch15OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{

    class PrivateClass
    {
        //private property
        private int PrivateField;


        //private method
        private void SetField(int value)
        {
            PrivateField = value;
        }

        private void Show()
        {
            Console.WriteLine("Private fild value "+ PrivateField);
        }
    
    }


    class PrivateExample
    {
        private int PrivateField;


        //private method
        private void SetField(int value)
        {
            PrivateField = value;
        }

        private void Show()
        {
            Console.WriteLine("Private fild value "+ PrivateField);
        }



        static void Main()

        {
              PrivateClass obj = new PrivateClass();
           //PrivateExample obj = new PrivateExample();

            //obj.SetField(10);
           // obj.PrivateField =1;
           

            // object crreation for another class

            Internal  objinternal = new Internal();
            objinternal.sound="roar";
            objinternal.MakingSound();


        }

        


    }
}
