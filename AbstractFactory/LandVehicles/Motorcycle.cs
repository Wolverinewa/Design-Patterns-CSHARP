using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LandVehicles
{
    class Motorcycle : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Motorcycle - Pegamos a encomenda, estamos prontos.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Motorcycle - Iniciando a entrega.");

        }
    }
}
