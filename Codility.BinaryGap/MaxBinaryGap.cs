using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.BinaryGap
{
    public class MaxBinaryGap
    {
        public int GetMaxBinaryGapWithBinary(int n)
        {
            int count = 0;
            int max = 0;
            Boolean bitOneFound = false;

            while(n>0)
            {
                if ((n & 1) == 1)
                {
                    if (max < count)
                    {
                        max = count;
                    }

                    bitOneFound = true;
                    count = 0;
                }
                else
                {
                    if (bitOneFound)
                    {
                        count++;
                    }                    
                }

                n = n >> 1;
            }

            return max;
        }

        public int GetMaxBinaryGapWithLinq(int n)
        {
            string nBinary = Convert.ToString(n, 2);

            return nBinary.Split('1')
                .OrderByDescending(s => s.Length)
                .Select(s => s.Length)
                .FirstOrDefault();            
        }

        public int GetMaxBinaryGap(int n)
        {
            string nBinary = Convert.ToString(n, 2);
            string[] arrayOfZeros = nBinary.Split('1');
            int numOfGaps = arrayOfZeros.Length;
            int[] gapOfZerosLength = new int[numOfGaps];

            for (int i = 0; i < numOfGaps; i++)
            {
                gapOfZerosLength[i] = arrayOfZeros[i].Length;
            }

            return GetMax(gapOfZerosLength);
        }

        private int GetMax(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException();
            }

            if (numbers.Length == 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var max = numbers[0];
            var length = numbers.Length;

            for (int i = 1; i < length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }

            return max;
        }
    }
}
