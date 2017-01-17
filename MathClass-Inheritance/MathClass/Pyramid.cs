using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    class Pyramid : DimensionalForms
    {
        private int BaseEdgeCount { get; set; }
        private double Edge { get; set; }

        public Pyramid(double v, double h, double ba, double lsa, int bec, double e) : base(v, h, ba, lsa)
        {

            BaseEdgeCount = bec;
            Edge = e;
        }


    }
}
