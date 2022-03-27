namespace InterfaceComLocadora.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; private set; }
        public DateTime Finish { get; private set; }
        public Vehicle Vehicle { get; private set; }
        public Invoice Invoice { get;  set; }



        public CarRental(DateTime start, DateTime finish, string modelVehicle)
        {   this.Vehicle = new Vehicle(modelVehicle);
            Invoice = null;
            Start = start;
            Finish = finish;
        }
    }
}
