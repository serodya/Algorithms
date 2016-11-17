using System;
using System.Linq;

namespace Codility.TimeComplexity
{
    public class PermMissingElem
    {
        public static int Solution(int[] A)
        {
            if (A == null)
            {
                throw new ArgumentNullException();
            }

            long N = A.Length;

            if (N > 100000)
            {
                throw new ArgumentException();
            }

            if (N == 0)
            {
                return 1;
            }

            long arraySum = A.Sum(e => (long)e);
            long realSum = (N + 1) * (N + 2) / 2;

            return (int)(realSum - arraySum);
        }
    }
}
