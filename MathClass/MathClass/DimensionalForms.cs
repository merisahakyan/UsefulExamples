using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    class DimensionalForms
    {
        private double Volume { get; set; }
        private double Hight { get; set; }
        private double BaseArea { get; set; }
        private double LateralSurfaceArea { get; set; }

        public DimensionalForms(double v, double h, double ba, double lsa)
        {
            Volume = v;
            Hight = h;
            BaseArea = ba;
            LateralSurfaceArea = lsa;
        }

    }
}
