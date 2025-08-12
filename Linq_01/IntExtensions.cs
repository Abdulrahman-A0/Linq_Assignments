using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_01
{
    public static class IntExtensions
    {
        public static int Reverse(this int x)
        {
            int rem = 0;
            int rev = 0;
            while (x > 0)
            {
                rem = x % 10;
                rev = rev * 10 + rem;
                x /= 10;
            }
            return rev;
        }
    }
}
