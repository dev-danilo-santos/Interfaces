using HerancaEInterface.Model.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEInterface
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return ($"Circle: \nColor: {Color} \nRadius: {Radius:F2} \nArea: {Area():F2} ");
        }

    }
}
