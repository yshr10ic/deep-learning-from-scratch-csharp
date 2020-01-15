using System;
using MathNet.Numerics.LinearAlgebra.Double;

namespace deep_learning_from_scratch_csharp.ch02
{
    public class NandGate
    {
        public double Nand(double x1, double x2)
        {
            var x = DenseMatrix.OfArray(new double[, ] {{x1, x2}});
            var w = DenseMatrix.OfArray(new double[, ] {{-0.5}, {-0.5}});
            double b = 0.7;

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

        public void NandTest()
        {
            Console.WriteLine($"NAND(0, 0) -> {Nand(0, 0)}");
            Console.WriteLine($"NAND(1, 0) -> {Nand(1, 0)}");
            Console.WriteLine($"NAND(0, 1) -> {Nand(0, 1)}");
            Console.WriteLine($"NAND(1, 1) -> {Nand(1, 1)}");
        }
    }
}