using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.PrefixSums
{
    public class CountDiv
    {
        /// <summary>
        /// https://codility.com/programmers/lessons/5-prefix_sums/count_div/
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int Solution(int A, int B, int K)
        {
            int remainder = A % K;
            int firstDivisible = remainder == 0 ? A : A + K - remainder;
            int difference = B - firstDivisible;

            if (difference < 0)
            {
                return 0;
            }
            else
            {
                return difference / K + 1;
            }
        }
    }
}
