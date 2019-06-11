using System;
using System.Collections.Generic;

namespace Integration.Integration
{
    internal class MonteCarlo
    {
        private const int N = 100;
        private readonly int dim;
        private readonly Func<List<double>, double> f;
        private readonly List<Tuple<Func<List<double>, double>, Func<List<double>, double>, double>> g;

        public MonteCarlo(Func<List<double>, double> f,
            List<Tuple<Func<List<double>, double>, Func<List<double>, double>, double>> g)
        {
            this.f = f;
            this.g = g;
            dim = g.Count;
        }

        private double CountingXi(double a, double b)
        {
            var rand = new Random();
            var ksi = rand.NextDouble();
            return a + ksi * (b - a);
        }

        private double CountingF()
        {
            var fn = 0.0;
            for (int i = 0; i < N; i++)
            {
                var fi = 0.0;
                var coefficientListA = new List<double>();
                var coefficientListB = new List<double>();
                coefficientListA.Add(g[0].Item1(coefficientListA));
                coefficientListB.Add(g[0].Item2(coefficientListB));

                for (int j = 0; j < dim; j++)
                {
                    fi += f
                }
            }
        }
    }
}