using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS122_HW9
{
    public class Problem2
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();              // Remove spaces from the start and end
            var parts = s.Split(' ');  // Split the string into words
            return parts[parts.Length - 1].Length; // Get the last word's length
        }
    }
}
