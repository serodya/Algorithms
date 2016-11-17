using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.BinaryGap
{
    public class OddOccurrencesInArray
    {
        public int GetUnpairedElement(int[] a)
        {
            var r = a.GroupBy(ele => ele)
                     .Select(group => new
                     {
                         Value = group.Key,
                         Count = group.Count()
                     })
                    .Where(x => x.Count % 2 == 1);

            return r.FirstOrDefault().Value;
        }

        public int GetUnpairedElementWithFirst(int[] a)
        {
            return a.GroupBy(e => e).FirstOrDefault(g => g.Count() % 2 == 1).Key;
        }

        public int GetUnpairedElementWithXOR(int[] a)
        {
            int length = a.Length;
            int result = a[0];

            for (int i = 1; i < length; i++)
            {
                result ^= a[i];
            }

            return result;
        }
    }
}
