using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LandVehicles
{
    class Car : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Car - Pegamos os passageiros, estamos prontos.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Car - Iniciando o trejeto.");

        }
    }
}
