using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Ovu klasu sam izmjenio, makar nije zadano u zadatku, jer je napisana isto kao bubble sort algoritam (koji smo morali dodati).
Mislim da je greška u predlošku, nadam se da nisam u krivu.

Znaci ova klasa je izmjenjena, a u bubble sort je prekopiran stari kod iz ove klase.
*/
namespace ZAD1
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
