namespace ServicosDeContrato
{
    class ProgramClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date(dd/MM/yyyy): ");
            DateTime dateContract = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(number, dateContract, valor);
            ServicoContrato sc = new ServicoContrato(new PayPalService());
            sc.GerarPrestacoes(contrato,installments);
            contrato.ImprimirJPrestacoes();

        }
    }
}