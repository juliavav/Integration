using System;
using System.Collections.Generic;
using System.Text;

namespace Integration.Integration
{
    class RectangularTriple
    {
        private const int N = 10000;
        private readonly int dim;
        private readonly Func<List<double>, double> f;
        private readonly double nZ = 1000;
        private readonly double nY = 1000;
        private readonly double nX = 100;

        private readonly List<LimitPair> g;

        public RectangularTriple(Func<List<double>, double> f,
            List<LimitPair> g)
        {
            this.f = f;
            this.g = g;
            dim = g.Count;
        }

        public double Solve()
        {
            return CountingI();
        }

        private double Hz(List<double> coefficients) => (g[0].B(coefficients) - g[0].A(coefficients)) / nZ;
        private double Hy(List<double> coefficients) => (g[1].B(coefficients) - g[1].A(coefficients)) / nY;
        private double Hx(List<double> coefficients) => (g[2].B(coefficients) - g[2].A(coefficients)) / nX;

        //def rectangular_triple1(g, a, b, c, d, e, f, nx, ny, nz):
        //    """
        //Вычисляет значение тройного интеграла по формуле прямоугольников
        //    при реализации двойной суммы

        //    g - подынтегральная функция

        //a, b, c, d, e, f - границы прямоугольной области интегрирования

        //nx, ny, nz - количество частичных отрезков по x, y и z соответственно
        //"""

        //hx = (b - a)/float (nx)
        //    hy = (d - c) / float(ny)

        //hz = (f - e)/float (nz)
        //    I = 0
        //        for i in range(nx) :
        //    for j in range(ny) :
        //    for k in range(nz) :

        //    xi = a + hx/2 + i* hx

        //yj = c + hy/2 + j* hy

        //zk = e + hz/2 + k* hz

        //I += hx* hy*hz* g(xi, yj, zk)
        //    return I coefficients.Add(CountingXi(g[j].A(coefficients), g[j].B(coefficients)));

        private double CountingI()
        {
            var I = 0.0;
            for (int i = 0; i < nZ; i++)
            {
                for (int j = 0; j < nY; j++)
                {
                    for (int k = 0; k < nX; k++)
                    {
                        var coefficients = new List<double>();
                        var zi = g[0].A(coefficients) + Hz(coefficients) +
                                 i * Hz(coefficients);
                        coefficients.Add(zi);
                        var yj = g[1].A(coefficients) + Hy(coefficients) +
                                 j * Hy(coefficients);
                        coefficients.Add(yj);
                        var xk = g[2].A(coefficients) + Hx(coefficients) +
                                 k * Hx(coefficients);
                        coefficients.Add(xk);
                        I += Hx(coefficients) * Hy(coefficients) * Hz(coefficients) * f(coefficients);
                    }
                }
            }

            return I;
        }
    }
}

