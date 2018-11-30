using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_6_metodos
{
    class llenar
    {
        //int h;
        private int[] vector;
        public llenar(int []arreglo)
        {
            //h = n;
            vector = new int[arreglo.Length];
            for (int i = 0; i < arreglo.Length; i++)
            {
                vector[i] = arreglo[i];
            }
            quicksort(vector, 0, arreglo.Length - 1);
            //mostrar();
        }

        private void quicksort(int[] vector, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksort(vector, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(vector, i, ultimo);
            }
        }

        public int [] getVector()
        {
            return vector;
        }

    }
}
