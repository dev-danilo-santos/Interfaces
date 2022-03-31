using HerancaEInterface.Model.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEInterface
{
    internal class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
           return Width * Height;
        }

        public override string ToString()
        {
            return ($"Rectangle: \nColor: {Color} \nWidth: {Width:F2} \nHeight: {Height:F2} \nArea: {Area():F2} ");
        }
    }
}
