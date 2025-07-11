using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDiamondProblem
{
    public class FinalClass : IDerived1, IDerived2
    {
        public void Display()
        {
            Console.WriteLine("Display method from IBase implemented in FinalClass");
        }
    }

}
