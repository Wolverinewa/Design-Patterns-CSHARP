using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LandVehicles
{
    class Patinete : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Patinete - Pegamos a encomenda, estamos prontos.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Patinete - Iniciando a entrega.");

        }
    }
}
