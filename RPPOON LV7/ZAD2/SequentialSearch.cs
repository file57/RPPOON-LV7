using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class SequentialSearch : SearchStrategy
    {
        public override void Search(double element, double[] array)
        {
            int arraySize = array.Length;
            for(int i = 0; i < arraySize; i++)
            {
                if(element == array[i])
                {
                    Console.WriteLine("Podatak {0} se nalazi na {1} indexu", element, i);
                }
            }
        }
    }
}
