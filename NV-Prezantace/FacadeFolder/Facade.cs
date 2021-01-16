using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.FacadeFolder
{
    class Facade
    {
        private Adder adder = new Adder();
        private Multiplier multiplier = new Multiplier();
        public double Negative(double a)
        {
            return adder.Subtract(0, a);
        }
        public double Mean(double a, double b)
        {
            return multiplier.Divide(adder.Add(a, b), 2);
        }
        public double Square(double a)
        {
            return multiplier.Multiply(a, a);
        }
    }
}
