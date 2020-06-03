using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class SequentialSort : SortStrategy
    {
        public override void Sort(double[] array)
        {
            int arraySize = array.Length;
            for (int i = 0; i < arraySize - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < arraySize; j++)
                {
                    if (array[smallest] > array[j])
                    {
                        smallest = j;
                    }
                }
                Swap(ref array[smallest], ref array[i]);
            }
        }
    }
}