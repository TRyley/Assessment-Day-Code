using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assessment;


namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            HeartRateCalculator calc = new HeartRateCalculator();
            calc.Run();
        }
    }
}
