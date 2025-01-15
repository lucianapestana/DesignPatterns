using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Blue payment = new Blue();
            //payment.BluePayment();
            //payment.BlueReceive();

            //Orange payment = new Orange();
            //payment.SendPayment();
            //payment.ReceivePayment

            //IBluePayment payment = new OrangeAdapter(new Orange());

            //payment.BluePayment();
            //payment.BlueReceive();

            IBluePayment payment = new NavyBlueAdapter(new NavyBlue());

            payment.BluePayment();
            payment.BlueReceive();

            Console.ReadLine();
        }
    }
}
