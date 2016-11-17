using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.CountingElements
{
    /// <summary>
    /// https://codility.com/programmers/lessons/4-counting_elements/frog_river_one/
    /// </summary>
    public class FrogRiverOne
    {
        public static int Solution(int X, int[] A)
        {
            const int MAX_LENGTH = 100000;

            if (A == null)
            {
                throw new ArgumentNullException();
            }

            int N = A.Length;

            if (N == 0)
            {
                return -1;
            }

            if (X < 1 || X > MAX_LENGTH || N > MAX_LENGTH)
            {
                throw new ArgumentOutOfRangeException();
            }

            Dictionary<int, int> path = new Dictionary<int, int>();

            for (int i = 1; i <= X; i++)
            {
                path.Add(i, 1);
            }

            for (int i = 0; i < N; i++)
            {
                path.Remove(A[i]);

                if (path.Count == 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
