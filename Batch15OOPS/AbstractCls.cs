using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{

    //Abstract Class
    public abstract class Animal1
    {
        public int a, b;

        //abstract method(no Implementation)
        public abstract void Makingsound();

        

        //non abstract method(that has Implementation)

        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

    }

    //Derived Class


    public  class Dog1 :Animal1
    {
        public override void Makingsound()
        {
            Console.WriteLine("Dog  Barks");

        }
    }

    public class Cat1: Animal1
    {
        public override void Makingsound()
        {
            Console.WriteLine("cat is Meows");
        }

        //public void Display()
        //{
        //    Console.WriteLine("test");
        //}

    }



    internal class AbstractCls
    {

        static void Main()
        {

            //Animal1 animal = new Animal1();


            Dog1 dog =new Dog1();
            Cat1 cat = new Cat1();


            //calling method

            dog.Makingsound();
            dog.Eat();

            cat.Makingsound();
            cat.Eat();





        }



    }
}
