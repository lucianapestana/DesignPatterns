using System;

namespace AbstractFactory.Landvehicles
{
    class Scooter : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos o passageiro.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto.");
        }
    }
}
