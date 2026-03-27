using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5.Variant00
{
    internal class Task2
    {
        public class Number : INumber
        {
            protected double _real;


            public double Real => _real;
            public virtual double Abs => Math.Abs(_real);
            public int Sign
            {
                get
                {
                    if (_real < 0) return -1;
                    if (_real > 0) return 1;
                    return 0;
                }
            }
            public Number(double real)
            {
                _real = real;
            }

            public virtual void Sum(INumber other)
            {
                if (other == null) return;

                double Summ = Real + other.Real;
                _real = Summ;
            }

            public virtual void Sub(INumber other)
            {
                if (other == null) return;
                double Subm = Real - other.Real;
                _real = Subm;
            }

            public virtual void Mul(INumber other)
            {
                if (other == null) return;
                double Mulm = Real * other.Real;
                _real = Mulm;
            }

            public virtual void Div(INumber other)
            {
                if (other.Real == 0)
                {
                    return;
                }
                double Divm = Real / other.Real;
                _real = Divm;
            }

            public virtual void Neg()
            {
                _real = _real * (-1);
            }


        }

        public class ComplexNumber : Number, IComplexNumber
        {
            private double _imag;
            public double Imaginary => _imag;
            public int ISign
            {
                get
                {
                    if (_imag < 0) return -1;
                    if (_imag > 0) return 1;
                    return 0; //переопределить это сразу override
                }
            }
            public override double Abs => Math.Abs(_real* _real + _imag*_imag);

            //ComplexNumber cnum1 = new ComplexNumber(1,2); 1+2i
            //ComplexNumber cnum1 = new ComplexNumber(1); 1+ 0i;
            public ComplexNumber(double real, double imag = 0): base(real)
            {
                _imag = imag;
            }
            public ComplexNumber(INumber other) : base(other.Real)
            {
                if (other is ComplexNumber cnum)
                {
                    _imag = cnum.Imaginary;
                }
                else
                {
                    _imag = 0;
                }
            }
        }
    }
}
