using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.BinaryGap
{    
    public class CyclicRotation
    {
        public int[] GetArrayRotated(int[] a, int k)
        {
            var length = a.Length;
            int[] r = new int[length];            

            for (int i = 0; i < length; i++)
            {
                r[(i + k) % length] = a[i];
            }

            return r;
        }
    }
}
