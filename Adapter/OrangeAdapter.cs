using System;

namespace Adapter
{
    class OrangeAdapter : IBluePayment
    {
        private Orange orange;

        public OrangeAdapter(Orange orange)
        {
            this.orange = orange;
            Console.WriteLine("Realizando Adaptação do Blue para os métodos do Orange.");
        }

        public Token AuthToken()
        {
            return this.orange.AuthToken();
        }

        public void BluePayment()
        {
            this.orange.SendPayment();
        }

        public void BlueReceive()
        {
            this.orange.ReceivePayment();
        }
    }
}
