using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS122_HW9
{
    public class Problem3
    {
        public void ReverseString(char[] s)
        {
            int i = 0, j = s.Length - 1;   // i = start, j = end

            while (i < j)
            {
                // Swap s[i] and s[j]
                char temp = s[i];
                s[i] = s[j];
                s[j] = temp;

                i++; // Move forward
                j--; // Move backward
            }
        }
    }
}
