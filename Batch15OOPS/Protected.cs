using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS


{
    //protected Access modifier


    //base class//parent classs//super class
    class Animal
    {
        //protected member
        protected string Sound;

        //protected method

        protected void Makesound()
        {
            Console.WriteLine($"Animal makes sound: {Sound}");

        }
    }

    //derived class// chield class //sub class 


    class Dog : Animal
    {
        public Dog()
        {
            Sound ="Barks";

        }

        public void DisplaySound()
        {
            Makesound();
        }

    }


    class Cat  : Animal
    {
        public Cat()
        {
           Sound =" Meowws";
        }

        public void DisplaySound() 
        {
             Makesound();
            //Console.WriteLine("test");
        
        }

    }







    internal class Protected
    {

        static void Main()
        {
            Cat c = new Cat();
            c.DisplaySound();

        }
    }
}
