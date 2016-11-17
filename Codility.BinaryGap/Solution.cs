using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.BinaryGap
{
    public class Solution
    {
        public int solution(int[] A)
        {     
            if (A == null || A.Length == 0) {
                return -1;
            }

            try
            {
                long leftSum = 0;
                long rightSum = A.Sum(e => (long)e) - A[0];
                int N = A.Length;

                if (leftSum == rightSum)
                {
                    return 0;
                }

                for (int i = 0; i < N - 1; i++)
                {
                    leftSum += A[i];
                    rightSum -= A[i + 1];

                    if (leftSum == rightSum)
                    {
                        return i + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }            

            return -1;
        }
    }
}
