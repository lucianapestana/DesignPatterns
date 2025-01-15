using System;
using AbstractFactory.App;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static Application ConfigureApplication()
        {
            Application app;

            ITransportFactory transportFactory;
            string company = "Yellow";

            if (company == "Black")
            {
                transportFactory = new BlackTransport();
            }
            else if (company == "Yellow")
            {
                transportFactory = new YellowTransport();
            }
            else
            {
                transportFactory = new PurpleTransport();
            }

            app = new Application(transportFactory);

            return app;
        }

        static void Main(string[] args)
        {
            Application app = ConfigureApplication();

            app.StartRoute();

            Console.ReadLine();
        }
    }
}
