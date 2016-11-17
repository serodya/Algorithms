using System;
using System.Collections.Generic;

namespace Codility.CountingElements
{
    public class PermCheck
    {
        public static int Solution(int[] A)
        {
            if (A == null)
            {
                throw new ArgumentNullException();
            }

            int N = A.Length;

            if (N > 100000)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (N == 0)
            {
                return 0;
            }

            Dictionary<int, int> keys = new Dictionary<int, int>();

            foreach(int n in A)
            {
                if (!keys.ContainsKey(n))
                {
                    keys.Add(n, 1);
                }
                else
                {
                    return 0;
                }
            }

            for (int i = 0; i < N; i++)
            {
                if (!keys.ContainsKey(i+1))
                {
                    return 0;
                }
            }

            return 1;
        }
    }
}
