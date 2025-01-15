using System;

namespace FactoryMethod.Vehicles
{
    internal class Bicycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega da sua refeição.");
        }
    }
}
