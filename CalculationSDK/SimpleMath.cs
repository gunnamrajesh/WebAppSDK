using System;

namespace CalculationSDK
{
    public class SimpleMath
    {
        int Add(int a, int b) => a +b;

        int Sub(int large, int small) => large - small;

        int AbsSub(int a, int b) => Math.Abs(a - b);
    }
}
