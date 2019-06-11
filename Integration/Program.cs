using System;
using System.Collections.Generic;
using Integration.Integration;
using static Integration.Functions;

namespace Integration
{
    class Program
    {
        static void Main(string[] args)
        {
            var limits = new List<LimitPair>
            {
                new LimitPair(Za, Zb),
                new LimitPair(Ya,Yb),
                new LimitPair(Xa,Xb)
            };
            var monteCarlo = new MonteCarlo(F, limits);
            Console.WriteLine(monteCarlo.Solve());
            var rec = new RectangularTriple(F,limits);
            Console.WriteLine(rec.Solve());
        }
    }
}
