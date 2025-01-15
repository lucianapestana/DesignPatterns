using System;

namespace Adapter
{
    class Orange : IOrangePayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Orange.");
        }

        public void SendPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com Orange.");
        }
    }
}
