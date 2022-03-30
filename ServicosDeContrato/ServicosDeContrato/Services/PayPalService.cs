using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicosDeContrato
{
    class PayPalService : IServicosDePagamento
    {
        private const double Taxa = 0.02;
        private const double TaxaMensal = 0.01;

        public double TaxaDePagamento(double amount)
        {
            return amount * Taxa;
        }
        public double TaxaDaParcela(double amount, int mes)
        {
            
            return amount * TaxaMensal * mes;
        }
    }
}