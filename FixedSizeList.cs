using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_ADV01
{
    internal class FixedSizeList<T>
    {
        private T[] elements;
        private int size;
        public FixedSizeList(int capacity)
        {


            elements = new T[capacity]; 
        }
        public void Add(T item)
        {
           
            elements[size] = item; 
            size++;
        }
        public T Get(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException("invalid indices ,Index is out of range.");
            }
            return elements[index];   
        }
      

    }
}
