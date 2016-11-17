using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Sorting
{
    public class MaxProductOfThree
    {
        public static int Solution(int[] A)
        {
            if (A == null)
            {
                throw new ArgumentNullException();
            }

            int N = A.Length;

            if (N < 3 || N > 100000)
            {
                throw new ArgumentOutOfRangeException();
            }

            List<int> ordered = A.OrderBy(a => a).ToList();
            int theFirstOnes = ordered[0] * ordered[1] * ordered[N-1];
            int theLastOnes = ordered[N - 3] * ordered[N - 2] * ordered[N - 1];

            return theFirstOnes > theLastOnes ? theFirstOnes : theLastOnes;
        }
    }
}
