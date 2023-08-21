using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MercadoPago
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void MercadoPagoPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com MercadoPago");
        }

        public void MercadoPagoReceive()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com MercadoPago");
        }
    }
}
