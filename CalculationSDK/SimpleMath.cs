using System;

namespace CalculationSDK
{
    public class SimpleMath
    {
        public int Add(int a, int b) => a +b;

        public int Sub(int large, int small) => large - small;

        public int AbsSub(int a, int b) => Math.Abs(a - b);
    }
}
