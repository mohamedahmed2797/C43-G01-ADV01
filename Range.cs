using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_ADV01
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; }
        public T Max { get; }
        public Range(T min, T max)
        {

            Min = min;
            Max = max;

        }
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;

        }
        public double Length()
        {
            double min = Convert.ToDouble(Min);
            double max = Convert.ToDouble(Max);

            return max - min;

        }
    }
}
