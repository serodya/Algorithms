using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.PrefixSums
{
    public class PassingCars
    {
        public static int Solution(int[] A)
        {
            const int MAX_PASSING_CARS = 1000000000;

            if (A == null)
            {
                throw new ArgumentNullException();
            }

            int N = A.Length;
            int carsTravelingToEast = 0;
            int passingCars = 0;

            for (int i = 0; i < N; i++)
            {
                if (A[i] == 0)
                {
                    carsTravelingToEast++;
                }
                else
                {
                    passingCars += carsTravelingToEast;
                    if (passingCars > MAX_PASSING_CARS)
                    {
                        return -1;
                    }
                }
            }

            return passingCars;
        }
    }
}
