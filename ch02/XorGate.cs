using System;
using MathNet.Numerics.LinearAlgebra.Double;

namespace deep_learning_from_scratch_csharp.ch02
{
    public class XorGate
    {
        public double Xor(double x1, double x2)
        {
            double s1 = new NandGate().Nand(x1, x2);
            double s2 = new OrGate().Or(x1, x2);
            double y = new AndGate().And(s1, s2);

            return y;
        }

        public void XorTest()
        {
            Console.WriteLine($"XOR(0, 0) -> {Xor(0, 0)}");
            Console.WriteLine($"XOR(1, 0) -> {Xor(1, 0)}");
            Console.WriteLine($"XOR(0, 1) -> {Xor(0, 1)}");
            Console.WriteLine($"XOR(1, 1) -> {Xor(1, 1)}");
        }
    }
}