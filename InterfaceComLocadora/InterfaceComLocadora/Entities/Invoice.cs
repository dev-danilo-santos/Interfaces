using System.Text;

namespace InterfaceComLocadora.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; private set; }
        public double Tax { get; private set; }
        
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        private double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Basic payment: ");
            sb.AppendLine(BasicPayment.ToString("F2"));
            sb.Append("Tax: ");
            sb.AppendLine(Tax.ToString("F2"));
            sb.Append("Total payment: ");
            sb.Append(TotalPayment);

            return sb.ToString(); 
        }

    }
}
