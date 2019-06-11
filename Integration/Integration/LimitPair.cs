using System;
using System.Collections.Generic;
using System.Text;

namespace Integration.Integration
{
    class LimitPair
    {
        public Func<List<double>, double> A { get; }
        public Func<List<double>, double> B { get; }

        public LimitPair(Func<List<double>, double> a, Func<List<double>, double> b)
        {
            A = a;
            B = b;
        }
    }
}
