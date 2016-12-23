using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    class Cube : DimensionalForms
    {
        private double Length { get; set; }
        private double Width { get; set; }

        public Cube(double v, double h, double ba, double lsa, double l, double w) : base(v, h, ba, lsa)
        {
            Length = l;
            Width = w;
        }

    }
}
