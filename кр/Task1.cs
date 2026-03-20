using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5.Variant00
{
    internal class Task1
    {
        public struct Number : INumber
        {
            private double _real;
            

            public double Real => _real;
            public double Abs => Math.Abs(_real);
            public int Sign
            {
                get
                {
                    if (_real <0) return -1;
                    if (_real >0) return 1;
                    return 0;
                }
            }
            public Number(double real)
            {
                _real = real;
            }
            
            public void Sum(INumber other)
            {
                double Summ = Real + other.Real;
                _real = Summ;
            }

            public void Sub(INumber other)
            {
                double Subm = Real  -  other.Real;
                _real = Subm;
            }

            public void Mul(INumber other)
            {
                double Mulm = Real * other.Real;
                _real = Mulm;
            }

            public void Div(INumber other)
            {
                if (other.Real == 0)
                {
                    return;
                }
                double Divm = Real / other.Real;
                _real = Divm;
            }

            public void Neg()
            {
                _real = _real * (-1);
            }


        }

    }
}
