using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicosDeContrato
{
    internal class Contrato
    {
        public int Number { get; set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; private set; }
        public double TotalDebt { get; set; }
        public List<Prestacoes> PrestacoesContract { get; set; }

        public Contrato(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            PrestacoesContract = new List<Prestacoes>();
        }

        public void ImprimirJPrestacoes()
        {
            PrestacoesContract.ForEach(x => Console.WriteLine(x.ToString()));
            Console.WriteLine("\n Total Debt: "+ TotalDebt);
        }

        public void AdicionaPrestacao(Prestacoes p)
        {
            PrestacoesContract.Add(p);
        }
    }
}
