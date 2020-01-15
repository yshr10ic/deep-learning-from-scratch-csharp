using System;
using MathNet.Numerics.LinearAlgebra.Double;

namespace deep_learning_from_scratch_csharp.ch02
{
    public class OrGate
    {
        public double Or(double x1, double x2)
        {
            var x = DenseMatrix.OfArray(new double[, ] {{x1, x2}});
            var w = DenseMatrix.OfArray(new double[, ] {{0.5}, {0.5}});
            double b = -0.2;

            double tmp = (x * w + b)[0, 0];

            if (tmp <= 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public void OrTest()
        {
            Console.WriteLine($"OR(0, 0) -> {Or(0, 0)}");
            Console.WriteLine($"OR(1, 0) -> {Or(1, 0)}");
            Console.WriteLine($"OR(0, 1) -> {Or(0, 1)}");
            Console.WriteLine($"OR(1, 1) -> {Or(1, 1)}");
        }
    }
}