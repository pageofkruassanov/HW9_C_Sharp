using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_C_Sharp
{
    internal interface ICalc<T> where T : struct, IComparable<T>
    {
        int Less(T valueToCompare);
        int Greater(T valueToCompare);
    }
}
