using System;

namespace deep_learning_from_scratch_csharp.ch02
{
    public class AndGate
    {
        public double And(double x1, double x2)
        {
            double w1 = 0.5;
            double w2 = 0.5;
            double theta = 0.7;

            double tmp = x1 * w1 + x2 * w2;

            if (tmp <= theta)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public void AndTest()
        {
            Console.WriteLine($"AND(0, 0) -> {And(0, 0)}");
            Console.WriteLine($"AND(1, 0) -> {And(1, 0)}");
            Console.WriteLine($"AND(0, 1) -> {And(0, 1)}");
            Console.WriteLine($"AND(1, 1) -> {And(1, 1)}");
        }
    }
}