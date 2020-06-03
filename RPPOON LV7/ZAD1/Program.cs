using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] niz = { 5, 6, 4, 5, 7, 2, 8, 3, 1 };
            NumberSequence nizBrojeva = new NumberSequence(niz);

            BubbleSort bubblesort = new BubbleSort();
            SequentialSort selectsort = new SequentialSort();
            CombSort combsort = new CombSort();


            Console.WriteLine("Nesortirano" + nizBrojeva.ToString());

            nizBrojeva.SetSortStrategy(bubblesort);
            nizBrojeva.Sort();

            Console.WriteLine("Bubble sort\n" + nizBrojeva.ToString());

            nizBrojeva.SetSortStrategy(selectsort);
            nizBrojeva.Sort();

            Console.WriteLine("Select sort\n" + nizBrojeva.ToString());

            nizBrojeva.SetSortStrategy(combsort);
            nizBrojeva.Sort();

            Console.WriteLine("Comb sort\n" + nizBrojeva.ToString());
        }
    }
}
