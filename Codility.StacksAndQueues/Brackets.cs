using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.StacksAndQueues
{
    public class Brackets
    {
        public static int Solution(string S)
        {
            Dictionary<char, char> pairOfBrackets = new Dictionary<char, char> {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };            

            if (S == null)
            {
                throw new ArgumentNullException();
            }

            if (S.Length == 0)
            {
                return 1;
            }

            Stack<char> brackets = new Stack<char>();

            foreach(char c in S)
            {
                if (pairOfBrackets.ContainsKey(c))
                {
                    brackets.Push(c);
                }
                else if (pairOfBrackets.ContainsValue(c))
                {
                    if (brackets.Count > 0)
                    {
                        if (pairOfBrackets[brackets.Peek()] == c)
                        {
                            brackets.Pop();
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }         
                }
            }

            return brackets.Count > 0 ? 0 : 1;
        }
    }
}
