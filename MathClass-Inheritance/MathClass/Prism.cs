using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    class Prism : DimensionalForms
    {
        private int BaseEdgeCount { get; set; }
        private double Alpha { get; set; }

        public Prism(double v, double h, double ba, double lsa, int bec, double a) : base(v, h, ba, lsa)
        {
            BaseEdgeCount = bec;
            Alpha = a;
        }
    }
}
