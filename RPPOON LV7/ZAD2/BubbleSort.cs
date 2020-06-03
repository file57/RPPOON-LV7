using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class BubbleSort : SortStrategy
    {
        public override void Sort(double[] array)
        {
            int arraySize = array.Length;
            for (int i = 0; i < arraySize - 1; i++)
            {
                for (int j = i + 1; j < arraySize; j++)
                {
                    if (array[j] < array[i])
                    {
                        Swap(ref array[i], ref array[j]);

                    }
                }
            }
        }
    }
}
