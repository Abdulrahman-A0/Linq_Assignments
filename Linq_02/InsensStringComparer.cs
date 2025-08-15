using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_02
{
    public class InsensStringComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return x?.ToLower().CompareTo(y?.ToLower()) ?? 1;
        }
    }
}
