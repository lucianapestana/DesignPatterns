using System;

namespace Adapter
{
    class NavyBlue : INavyBlue
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void SendNavyBluePayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com Navy Blue.");
        }

        public void ReceiveNavyBluePayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Navy Blue.");
        }
    }
}
