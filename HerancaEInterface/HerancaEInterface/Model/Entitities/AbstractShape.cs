using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEInterface.Model.Entitities
{
     abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        abstract public double Area();
    }
}
