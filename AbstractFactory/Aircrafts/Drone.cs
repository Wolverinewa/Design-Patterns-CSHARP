using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Drone - Verificando os ventos, vento sudeste, ventos OK");
        }

        public void GetCargo()
        {
            Console.WriteLine("Drone - Passageiros OK, vôo autorizado.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Drone - Iniciando a decolagem.");

        }
    }
}
