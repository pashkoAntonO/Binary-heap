using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    class Program
    {
        static void Main(string[] args)
        {
           
            BinaryHeap bh = new BinaryHeap();
            int[] sortArray = { 5, 2, 5, 2, 6, 13, 6, 33 };


            bh.insert(10);
            bh.insert(15);
            bh.insert(11);
            bh.insert(6);
            bh.insert(34);
            bh.insert(2);

            bh.show();

            bh.sort(ref sortArray);

            foreach (var value in sortArray)
            {
                Console.WriteLine(value);
            }


            Console.ReadKey();

        }
    }
}
