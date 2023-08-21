using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Helicopter - Verificando os ventos, vento sudeste, ventos OK");
        }

        public void GetCargo()
        {
            Console.WriteLine("Helicopter - Passageiros OK, vôo autorizado.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Helicopter - Iniciando a decolagem.");

        }
    }
}
