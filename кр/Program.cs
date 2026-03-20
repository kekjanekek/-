using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5.Variant00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1.Number number = new Task1.Number(1.56);
            Task1.Number number2 = new Task1.Number(1.10);
         
            number.Div(number2);
            Console.WriteLine(number.Real);
        }
    }
}
