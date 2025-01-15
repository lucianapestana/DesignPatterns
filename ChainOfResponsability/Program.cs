using System;
using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;

namespace ChainOfResponsability
{
    class Program
    {
        private static Server server;

        static void Init()
        {
            server = new Server();

            server.RegisterUser("master@teste.com.br", "123!@#abc");

            server.RegisterUser("user@teste.com.br", "456!@#def");

            server.RegisterUser("luciana@teste.com.br", "123456");

            Middleware middleware = new CheckUserMiddleware(server);

            middleware.LinkWith(new CheckPermissionMiddleware());

            middleware.LinkWith(new CheckWeakPasswordMiddleware());

            server.SetMiddleware(middleware);
        }

        static void Main(string[] args)
        {
            Init();

            Boolean done;

            do
            {
                Console.WriteLine("Digite o seu e-mail: ");

                string email = Console.ReadLine();

                Console.WriteLine("Digite a sua senha: ");

                string password = Console.ReadLine();

                done = server.LogIn(email, password);

                Console.ReadLine();
            }
            while (!done);
        }
    }
}
