using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleMCMain5
{
    class Program
    {
        static void Main(string[] args)
        {
            //parameters
            double expiry = 1.0;
            double spot = 49.0;
            double vol = 0.2;
            double r = 0.01;
            double lower = 45.0;
            double upper = 55.0;

            //input number of montecarlo paths
            ulong number_of_paths = 10000;
            Console.Write("Enter number of montecarlo paths : ");
            number_of_paths = ulong.Parse(Console.ReadLine());

            //create payoff object
            PayOff payoff = new PayOffDoubleDigital(lower, upper);

            //montecarlo simulation & output result
            double result = SimpleMC2.SimpleMonteCarlo2(payoff, expiry, spot, vol, r, number_of_paths);
            Console.WriteLine("the price is " + result.ToString());
        }
    }
}
