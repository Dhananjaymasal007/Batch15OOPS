using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{

    class ConstantEx
    {

        //normal variable declaration
        public int a = 10;
        public string name = "test";

        //declaration of constant variables

        public const double pi = 3.15154;
        const string AppName   = "ZYZ";

        public void PrintConstantsValues()
        {
            Console.WriteLine(name);

            Console.WriteLine($"The value of pi is: {pi}");
            Console.WriteLine($"The Value of AppName is :{AppName}.");

            name = "TestNew";
            Console.WriteLine(name);
            //AppName ="XyzNew";



        }


    }


    internal class ConstantExample
    {

        static void Main()
        {


            ConstantEx con = new ConstantEx();
            con.PrintConstantsValues();
        }

    }
}
