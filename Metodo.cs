﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_6_metodos
{
    class Metodo
    {

        //Método portal que llama al método recursivo inicial
        public void MergeSort(int[] x)
        {
            MergeSort(x, 0, x.Length - 1);
        }

        private void MergeSort(int[] x, int desde, int hasta)
        {
            //Condicion de parada
            if (desde == hasta)
                return;
            //Calculo la mitad del array
            int mitad = (desde + hasta) / 2;
            //Voy a ordenar recursivamente la primera mitad
            //y luego la segunda
            MergeSort(x, desde, mitad);
            MergeSort(x, mitad + 1, hasta);
            //Mezclo las dos mitades ordenadas
            int[] aux = Merge(x, desde, mitad, mitad + 1, hasta);
            Array.Copy(aux, 0, x, desde, aux.Length);
        }

        //Método que mezcla las dos mitades ordenadas
        private int[] Merge(int[] x, int desde1, int hasta1, int desde2, int hasta2)
        {
            int a = desde1;
            int b = desde2;
            int[] result = new int[hasta1 - desde1 + hasta2 - desde2 + 2];

            for (int i = 0; i < result.Length; i++)
            {
                if (b != x.Length)
                {
                    if (a > hasta1 && b <= hasta2)
                    {
                        result[i] = x[b];
                        b++;
                    }
                    if (b > hasta2 && a <= hasta1)
                    {
                        result[i] = x[a];
                        a++;
                    }
                    if (a <= hasta1 && b <= hasta2)
                    {
                        if (x[b] <= x[a])
                        {
                            result[i] = x[b];
                            b++;
                        }
                        else
                        {
                            result[i] = x[a];
                            a++;
                        }
                    }
                }
                else
                {
                    if (a <= hasta1)
                    {
                        result[i] = x[a];
                        a++;
                    }
                }
            }
            return result;
        }



    }
}
