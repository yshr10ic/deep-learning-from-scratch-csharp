using System;
using System.Linq;

namespace deep_learning_from_scratch_csharp.ch03
{
    public class StepFunction
    {
        public int[] Execute(params double[] x)
        {
            int[] y = new int[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > 0)
                {
                    y[i] = 1;
                }
                else
                {
                    y[i] = 0;
                }
            }

            return y;
        }

        public void ExecuteTest()
        {
            Console.Write($"Execute(-3.0) -> ");
            Execute(-3.0).ToList().ForEach(x => Console.Write($"{x},"));
            Console.WriteLine();
            Console.Write($"Execute(2.5) -> ");
            Execute(2.5).ToList().ForEach(x => Console.Write($"{x},"));
            Console.WriteLine();
            Console.Write($"Execute(-3.0, 2.5) -> ");
            Execute(-3.0, 2.5).ToList().ForEach(x => Console.Write($"{x},"));
            Console.WriteLine();
        }
    }
}