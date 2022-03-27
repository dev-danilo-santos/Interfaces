using InterfaceComLocadora.Entities;

namespace InterfaceComLocadora.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxservice _taxservice;

        public RentalService(double pricePerHour, double pricePerDay, ITaxservice taxservice)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxservice = taxservice;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration= carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;

            if (duration.TotalHours<=12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);

            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _taxservice.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);

        }


    }
}
