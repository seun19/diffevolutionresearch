using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary
{
    public class Vector
    {
        public int dimension { get; set; }
        public double[] valueAtPosition { get; set; }

        //Constructor 
        public Vector(int dimension)
        {
            this.dimension = dimension;
            valueAtPosition = new double[dimension];
        }
    }
}
