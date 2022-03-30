using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicosDeContrato
{
    internal class Prestacoes
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; private set; }

        public Prestacoes(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Date Payment: {DueDate:dd/MM/yyyy} Valor: {Amount}";
        }

    }
}
