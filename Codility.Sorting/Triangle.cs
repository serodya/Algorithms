using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Sorting
{
    public class Triangle
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

            if (N < 3)
            {
                return 0;
            }

            List<int> list = A.OrderBy(a => a).ToList();

            for (int i = 0; i < N-2; i++)
            {
                if ((long)list[i] + (long)list[i+1] > list[i+2])
                {
                    return 1;
                }
            }
            
            return 0;
        }
    }
}
