using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    //dynamic polymorphism //method overriding //late binding //run time polymorphism

    //method name same parameter also same but different classes  and we follow paraent chield relatioship 


    //base class - parent class
    class Shape
    {

        public virtual void Draw()
        {
            Console.WriteLine("drawing shape");

        }

    }

    //derived class -chield class


    class Circle  : Shape
    {

        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    class Rectangle : Shape
    {

        public override void Draw()
        {
           Console.WriteLine("Drawing Rectangle");
        }



    }

    internal class DynamicPolymorphism
    {
        static void Main()
        {

            Shape Shape1 = new Shape();
            Shape shape2 = new Circle();
            Shape shape3 = new Rectangle();


            //calling method

            Shape1.Draw();
            shape2.Draw();
            shape3.Draw();

        }


    }
}
