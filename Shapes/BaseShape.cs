using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public abstract class AbstractShape
    {
        protected double _area;

        abstract public void GetDimensions();

        public double GetArea()
        {
            return Math.Round(_area, 2);
        }
    }
}
