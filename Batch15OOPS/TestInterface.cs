using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{

    internal interface ITestInterface
    {
        //method declaration
        void MakePayment(decimal Amount);
        void refundPayment(decimal amount);
    }


    internal interface ITestInterface1
    {
        void MakeUPIPayment(decimal amount);
    }


    public class CreaditCardPayment : ITestInterface, ITestInterface1 
    {
        public void MakePayment(decimal amount) 
        {
            Console.WriteLine($"Creadit card payment of {amount} has been made");
        }

        public void refundPayment(decimal amount) 
        {
            Console.WriteLine($"credit card refunt of {amount} has been made");

        }

        public void MakeUPIPayment(decimal amount)
        {
            Console.WriteLine($" Creadit card UPI payment of {amount} has been made");
        }

    }


    public class PaypalPayment : ITestInterface1
    {

        public void MakeUPIPayment(decimal amount)
        {
            Console.WriteLine($" pay Pal UPI payment of {amount} has been made");
        }

    }

    internal class  TestInterface
    {
        static void Main()
        {


            //creadit card

            ITestInterface creditcard = new CreaditCardPayment();

            creditcard.MakePayment(1005.5m);
            creditcard.refundPayment(100.5m);

            ITestInterface1 creditcard1 = new CreaditCardPayment();
            creditcard1.MakeUPIPayment(60.2m);



            //paypal 

            ITestInterface1 paypal = new PaypalPayment();
            paypal.MakeUPIPayment(60.5m);


        }



    }

}
