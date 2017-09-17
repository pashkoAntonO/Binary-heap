using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    class BinaryHeap 
    {
        List<int> list;

        public BinaryHeap()
        {
            list = new List<int>();
        }


        public int HeapSize
        {
            get
            {
                return this.list.Count();
            }
        }
        public void insert(int value)
        {
            list.Add(value);

            int i = HeapSize - 1;

            int parent = (i - 1) / 2;

            while (i > 0 && list[parent] < list[i])
            {
                if(list[parent] < list[i])
                {
                    int temp = list[parent];
                    list[parent] = list[i];
                    list[i] = temp;
                }

                i = parent;
                parent = (i - 1) / 2;

            }

        }


        public void reestablish(int i)
        {
            int rightNode;
            int leftNode;
            int maxRoot;
            while (true)
            {
                 rightNode = 2 * i + 2;
                 leftNode = 2 * i + 1;
                 maxRoot = i;

                if (leftNode < HeapSize && list[maxRoot] < list[leftNode])
                {
                    maxRoot = leftNode;
                }
                if (rightNode < HeapSize && list[maxRoot] < list[rightNode])
                {
                    maxRoot = rightNode;
                }

                if(maxRoot == i)
                {
                    break;
                }

                int tmp = list[i];
                list[i] = list[maxRoot];
                list[maxRoot] = tmp;
                i = maxRoot;

            }

        }

        public void buildHeap(int[] array)
        {
            list = array.ToList();

            for (int i = list.Count/2; i >= 0; i--)
            {
                reestablish(i);
            }
        }

        public int retrievalMax()
        {
            int max = list[0];
            list[0] = list[HeapSize - 1];
            list.RemoveAt(HeapSize - 1);

            return max;
        }

        public void sort(ref int [] array)
        {
            buildHeap(array);

            for (int i = list.Count -1; i >= 0; i--)
            {
                array[i] = retrievalMax();
                reestablish(0);
            }

        }

        public void show()
        {
            if (list == null)
            {
                return;
            }

            foreach (var value in list)
            {
                Console.WriteLine(value);
            }

        }




    }
}
