using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_6_metodos
{
    class HeapSort
    {
        private int[] arr;

        public HeapSort(int []arreglo)
        {
            arr = new int[arreglo.Length];
            for (int i = 0; i < arreglo.Length; i++)
            {
                arr[i] = arreglo[i];
            }

            for (int i = arr.Length; i > 1; i--)
            {
                fnSortHeap(arr, i - 1);
            }

        }

        private void fnSortHeap(int []arr, int arr2)
        {
            int i, o;
            int lCh, rCh, mCh, root, tmp;
            root = (arr2 - 1) / 2;

            for (o = root; o >= 0; o--)
            {
                for (i = root; i >= 0; i--)
                {
                    lCh = (2 * i) + 1;
                    rCh = (2 * i) + 2;
                    if ((lCh <= arr2) && (rCh <= arr2))
                    {
                        if (arr[rCh] >= arr[lCh])
                        {
                            mCh = rCh;
                        }
                        else
                        {
                            mCh = lCh;
                        }
                    }
                    else
                    {
                        if (rCh > arr2)
                        {
                            mCh = lCh;
                        }
                        else
                        {
                            mCh = rCh;
                        }
                    }

                    if (arr[i] < arr[mCh])
                    {
                        tmp = arr[i];
                        arr[i] = arr[mCh];
                        arr[mCh] = tmp;
                    }
                }
            }
            tmp = arr[0];
            arr[0] = arr[arr2];
            arr[arr2] = tmp;
            return;
        }


        public int[] getHeapSort()
        {
            return arr;
        }
        
    }
}
