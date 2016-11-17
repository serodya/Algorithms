using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.TimeComplexity
{
    public class FrogJmp
    {
        public static int Solution(int X, int Y, int D)
        {
            int min = 1;
            int max = 1000000000;

            if (X > Y || D < min || D > max || X < min || X > max || Y < min || Y > max)
            {
                throw new ArgumentOutOfRangeException();
            }

            decimal distance = Y - X;
            decimal jumps = distance / D;

            return (int)decimal.Ceiling(jumps);
        }
    }
}
