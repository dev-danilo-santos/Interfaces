using HerancaEInterface;

namespace HerancaEInterface
{
    class ProgramShapes
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Color = Color.white, Radius = 2.0 };
            IShape s2 = new Rectangle() { Color = Color.Black, Height = 3.5, Width = 4.2 };

            Console.WriteLine(s1);
            Console.WriteLine();
            Console.WriteLine(s2);

        }
    }
}