using System;

namespace Bridge.Platforms
{
    class Blue : IPlatform
    {
        public Blue()
        {
            ConfigureRMTP();
            Console.WriteLine("Blue: Transmissão iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Blue: Autorizando aplicação.");

        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Blue: Configurando servidor RMTP.");
        }
    }
}
