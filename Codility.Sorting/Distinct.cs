using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Sorting
{
    public class Distinct
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
                        
            return A.Distinct().Count();
        }

    }
}
