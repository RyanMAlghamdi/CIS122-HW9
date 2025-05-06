using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS122_HW9
{
    public class Problem5
    {
        public bool IsHappy(int n)
        {
            var seen = new HashSet<int>();     // To remember numbers we've seen

            while (n != 1 && !seen.Contains(n))
            {
                seen.Add(n);                   // Mark current number as seen
                n = SumSquares(n);             // Get next number (sum of squares)
            }

            return n == 1;                     // True if we end up at 1
        }

        int SumSquares(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int d = n % 10;                // Get last digit
                sum += d * d;                  // Add its square
                n /= 10;                       // Remove the digit
            }
            return sum;
        }
    }
}
