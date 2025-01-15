using System;

namespace Bridge.Platforms
{
    class Purple : IPlatform
    {
        public Purple()
        {
            ConfigureRMTP();
            Console.WriteLine("Purple: Transmissão iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Purple: Autorizando aplicação.");

        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Purple: Configurando servidor RMTP.");
        }
    }
}
