using System;

namespace Bridge.Platforms
{
    class Yellow : IPlatform
    {
        public Yellow()
        {
            ConfigureRMTP();
            Console.WriteLine("Yellow: Transmissão iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Yellow: Autorizando aplicação.");

        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Yellow: Configurando servidor RMTP.");
        }
    }
}
