using InterfaceComLocadora.Entities;
using InterfaceComLocadora.Services;
using System.Globalization;

namespace trabalhandoComInterfaces
{
    class ProgramInterfaces
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rental data");
            Console.Write("Car model: ");
            string Model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(),
                "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture); ;
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), 
                "dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);


            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine());
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(start, finish,Model);
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService()); 

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine(carRental.Invoice.ToString());

        }
    }
}