using System;

namespace Adapter
{
    class NavyBlueAdapter : IBluePayment
    {
        private NavyBlue navyBlue;

        public NavyBlueAdapter(NavyBlue navyBlue)
        {
            this.navyBlue = navyBlue;
            Console.WriteLine("Realizando Adaptação do Blue para os métodos do Navy Blue.");
        }

        public Token AuthToken()
        {
            return this.navyBlue.AuthToken();
        }

        public void BluePayment()
        {
            this.navyBlue.SendNavyBluePayment();
        }

        public void BlueReceive()
        {
            this.navyBlue.ReceiveNavyBluePayment();
        }
    }
}
