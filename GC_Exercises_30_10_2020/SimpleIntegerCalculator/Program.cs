using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIntegerCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerCalculator calc1 = new IntegerCalculator(0, 0);
            IntegerCalculator calc2 = new IntegerCalculator(13, -4);
            IntegerCalculator calc3 = new IntegerCalculator(-2, -5);
            IntegerCalculator calc4 = new IntegerCalculator(80, 4);

            

            calc1.PrintAllCalculations();
            calc2.PrintAllCalculations();
            calc3.PrintAllCalculations();
            calc4.PrintAllCalculations();
        }
    }
}
