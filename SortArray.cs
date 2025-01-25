using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_ADV01
{
    internal class SortArray<T> where T : IEquatable<T>
    {
        public static void Swap(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }
        public static void Sort(int[] ArrayList)
        {
            if (ArrayList is null)
            {
                return;
            }
            for (int i = 0; i < ArrayList.Length; i++) {
                for (int j = 0; j < ArrayList.Length - 1 - i; j++)
                {
                    if (ArrayList[j] < ArrayList[j + 1])
                    {
                        SortArray<int>.Swap(ref ArrayList[j], ref ArrayList[j + 1]);
                    }
                }
            }
        }
    }
}
