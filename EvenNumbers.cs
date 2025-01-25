using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_ADV01
{
    internal class EvenNumbers
    {
        public int[] Arra { get; set; }
        public EvenNumbers(int[] arr)
        {
            Arra = arr;
        }
        public void Even()
        {
                if (Arra != null && Arra.Length > 0)
            {
            for (int i = 0; i < Arra.Length; i++)
                {
                    if (Arra[i] % 2 == 0)
                    {
                        Console.WriteLine(Arra[i]);

                    }
                }
            }
        }
    }
}
