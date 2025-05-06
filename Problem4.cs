using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS122_HW9
{
    public class Problem4
    {
        public int MajorityElement(int[] nums)
        {
            int count = 0, major = 0;        // count = votes, major = current number

            foreach (int n in nums)
            {
                if (count == 0) major = n;   // pick new candidate
                count += (n == major) ? 1 : -1; // add or remove vote
            }

            return major; // this is the majority number
        }
    }
}
