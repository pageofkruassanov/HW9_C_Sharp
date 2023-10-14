using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_C_Sharp
{
    internal class Array<T> : ICalc<T>, IEnumerable<T>, IOutput2<T> where T : struct, IComparable<T>
    {
        public int Size { get; set; }
        private T[] _arr;

        private bool IsNumeric(object value)
        {
            return value is sbyte || value is byte ||
                   value is short || value is ushort ||
                   value is int || value is uint ||
                   value is long || value is ulong ||
                   value is float || value is double || value is decimal;
        }
        public Array(int size)
        {
            _arr = new T[size];
            Size = size;
        }
        // IEnumerator для возможности перебора элементов массива в foreach
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_arr).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _arr.GetEnumerator();
        }
        public T this[int i]
        {
            get { return _arr[i]; }
            set { _arr[i] = value; }
        }
        public static Array<T> operator +(Array<T> a, Array<T> b)
        {
            Array<T> result = new Array<T>(a.Size);

            for (int i = 0; i < a.Size; ++i)
            {
                result[i] = (dynamic)a[i] + b[i];
            }

            return result;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < Size; ++i)
            {
                sb.Append(this[i]);
                sb.Append(" ");
            }

            return sb.ToString();
        }

        public int Less(T valueToCompare)
        {
            int count = 0;
            foreach (var item in _arr)
            {
                if (item.CompareTo(valueToCompare) < 0)
                    count++;
            }
            return count;
        }

        public int Greater(T valueToCompare)
        {
            int count = 0;
            foreach (var item in _arr)
            {
                if (item.CompareTo(valueToCompare) > 0)
                    count++;
            }
            return count;
        }

        public void ShowEven()
        {
            if(_arr.Length > 0)
            {
                for (int i = 0; i < _arr.Length; ++i)
                {
                    if (IsNumeric(_arr[i]) && (dynamic)_arr[i] % 2 == 0)
                    {
                        Console.Write(_arr[i] + " ");
                    }
                }

            }
        }

        public void ShowOdd()
        {
            if (_arr.Length > 0)
            {
                for (int i = 0; i < _arr.Length; ++i)
                {
                    if (IsNumeric(_arr[i]) && (dynamic)_arr[i] % 2 == 1)
                    {
                        Console.Write(_arr[i] + " ");
                    }
                }

            }
        }
    }
}
