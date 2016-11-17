using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.CountingElements
{
    public class MissingInteger
    {
        public static int Solution(int[] A)
        {
            if (A == null)
            {
                throw new ArgumentNullException();
            }

            int N = A.Length;

            if (N == 0)
            {
                return 1;
            }

            if (N > 100000)
            {
                throw new ArgumentOutOfRangeException();
            }            

            Dictionary<int, int> valuesAsKey = new Dictionary<int, int>();

            for (int i = 0; i < N; i++)
            {
                if (!valuesAsKey.ContainsKey(A[i]))
                {
                    valuesAsKey.Add(A[i], 1);
                }                
            }
            
            for (int i = 1; i <= 100001; i++)
            {
                if (!valuesAsKey.ContainsKey(i))
                    return i;
            }            

            return 1;
        }
    }
}
