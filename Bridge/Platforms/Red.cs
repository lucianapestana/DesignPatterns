using System;

namespace Bridge.Platforms
{
    class Red : IPlatform
    {
        public Red()
        {
            ConfigureRMTP();
            Console.WriteLine("Red: Transmissão iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Red: Autorizando aplicação.");

        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Red: Configurando servidor RMTP.");
        }
    }
}
