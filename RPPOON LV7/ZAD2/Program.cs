using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] niz = { 5, 3, 4, 6, 7, 4, 2, 1, 9, 4 };
            NumberSequence nizBrojeva = new NumberSequence(niz);

            SequentialSearch sekevencijalno = new SequentialSearch();

            nizBrojeva.SetSearchStrategy(sekevencijalno);
            nizBrojeva.Search(4);

        }
    }
}
