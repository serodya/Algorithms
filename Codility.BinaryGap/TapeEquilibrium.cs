using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.BinaryGap
{
    public class TapeEquilibrium
    {
        public long GetTapeEquilibriumMinimum(int[] a)
        {
            if (a == null || a.Length == 0)
            {
                return 0;
            }

            int length = a.Length;
            long leftSum = a[0];
            long rightSum = a.Sum(e => (long)e) - leftSum;
            long minDifference = Math.Abs(leftSum - rightSum);

            for (int i = 1; i < length; i++)
            {
                leftSum += a[i];
                rightSum -= a[i];
                long currentDifference = Math.Abs(leftSum - rightSum);

                if (minDifference > currentDifference)
                {
                    minDifference = currentDifference;
                }
            }

            return minDifference;
        }

        public int GetTapeEquilibriumMinimumWithXOR(int[] a)
        {
            var result = a.Length + 1;
            for (int i = 0; i < a.Length; i++)
            {
                result = result ^ (i + 1);
                result = result ^ a[i];
            }
            return result;
        }
    }
}
