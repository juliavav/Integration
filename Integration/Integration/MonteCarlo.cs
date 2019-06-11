using System;
using System.Collections.Generic;

namespace Integration.Integration
{
    internal class MonteCarlo
    {
        private const int N = 10000;
        private readonly int dim;
        private readonly Func<List<double>, double> f;

        private readonly List<LimitPair> g;

        public MonteCarlo(Func<List<double>, double> f,
            List<LimitPair> g)
        {
            this.f = f;
            this.g = g;
            dim = g.Count;
        }

        public double Solve()
        {
            return CountingF();
        }

        private double CountingXi(double a, double b)
        {
            var rand = new Random();
            var ksi = rand.NextDouble();
            //Console.WriteLine($"Xi={a + ksi * (b - a)} ksi={ksi}");
            return a + ksi * (b - a);
        }

        private double CountingF()
        {
            var fn = 0.0;
            for (int i = 0; i < N; i++)
            {
                var coefficients = new List<double>();

                var vol = 1.0;
                for (int j = 0; j < dim; j++)
                {
                    //Console.WriteLine(g[j].B(coefficients));
                    //Console.WriteLine(g[j].A(coefficients));
                    vol *= g[j].B(coefficients) - g[j].A(coefficients);
                    coefficients.Add(CountingXi(g[j].A(coefficients), g[j].B(coefficients)));
                }

                fn += f(coefficients) * vol;

            }

            return fn/N;
        }
    }
}