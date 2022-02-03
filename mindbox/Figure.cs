using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox
{
    public abstract class Figure : IHasArea
    {
        public double Area { get; set; }
        public abstract double GetArea();
    }
}
