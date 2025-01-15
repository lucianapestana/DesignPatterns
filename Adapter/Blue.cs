using System;

namespace Adapter
{
    class Blue : IBluePayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void BluePayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com Blue.");
        }

        public void BlueReceive()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Blue.");
        }
    }
}
