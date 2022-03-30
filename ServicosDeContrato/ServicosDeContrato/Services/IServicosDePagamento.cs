using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicosDeContrato
{
     interface IServicosDePagamento
    {

        public double TaxaDePagamento(double amount);

        public double TaxaDaParcela(double amount, int mes) ;
    }
}
