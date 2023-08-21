using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Airplane - Verificando os ventos, ventos a 25Km, ventos OK");
        }

        public void GetCargo()
        {
            Console.WriteLine("Airplane - Passageiros à bordo, vôo autorizado.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Airplane - Iniciando a decolagem.");

        }
    }
}
