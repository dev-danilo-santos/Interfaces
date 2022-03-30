using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicosDeContrato
{
    internal class ServicoContrato
    {
        public IServicosDePagamento PaymentService { get; private set; }

        public ServicoContrato(IServicosDePagamento paymentService)
        {
            PaymentService = paymentService;
        }
        
        public void GerarPrestacoes(Contrato contrato, int meses)
        {   
            double div = contrato.TotalValue / meses;
            double totalValue = 0;
            for (int i = 1; i <= meses; i++)
            {
                double valor1 = div+PaymentService.TaxaDaParcela(div,i);
                double valor2 =valor1 + PaymentService.TaxaDePagamento(valor1);
                totalValue += valor2;
                contrato.AdicionaPrestacao(new Prestacoes(contrato.Date.AddMonths(i), valor2));
            }
            contrato.TotalDebt = totalValue;
        }
    }
}
