using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_6_metodos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        string cadena;
        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            //convertir serie de texto en int
            cadena = txtSerie.Text;
            string Mostrar ="";
            string[] aux = cadena.Split(',');
            int[] arreglo = new int[aux.Length];
            for (int i = 0; i < aux.Length;i++)
            {
                arreglo[i] = Convert.ToInt32(aux[i]);
            }


            //metodo burbuja
            int auxiliar;
            for (int i = 1; i < arreglo.Length; i++)
            {
                for (int j = 0; j < arreglo.Length - i; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        auxiliar = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = auxiliar;
                    }
                }
            }

            //mostrar metodo concatenado
            Mostrar = string.Join(",", arreglo);
            txtBubbleSort.Text = Mostrar;
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            //convertir serie de texto en int
            cadena = txtSerie.Text;
            string Mostrar = "";
            string[] aux = cadena.Split(',');
            int[] arreglo = new int[aux.Length];
            for (int i = 0; i < aux.Length; i++)
            {
                arreglo[i] = Convert.ToInt32(aux[i]);
            }

            llenar metodo = new llenar(arreglo);
            arreglo = metodo.getVector();
            
            //mostrar metodo concatenado
            Mostrar = string.Join(",", arreglo);
            txtQuickSort.Text = Mostrar;
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            //convertir serie de texto en int
            cadena = txtSerie.Text;
            string Mostrar = "";
            string[] aux = cadena.Split(',');
            int[] arreglo = new int[aux.Length];
            for (int i = 0; i < aux.Length; i++)
            {
                arreglo[i] = Convert.ToInt32(aux[i]);
            }

            Metodo merge = new Metodo();
            merge.MergeSort(arreglo);

            //mostrar metodo concatenado
            Mostrar = string.Join(",", arreglo);
            txtMergeSort.Text = Mostrar;
        }

        private void btnHeadSort_Click(object sender, EventArgs e)
        {
            //convertir serie de texto en int
            cadena = txtSerie.Text;
            string Mostrar = "";
            string[] aux = cadena.Split(',');
            int[] arreglo = new int[aux.Length];
            for (int i = 0; i < aux.Length; i++)
            {
                arreglo[i] = Convert.ToInt32(aux[i]);
            }

            HeapSort metodo = new HeapSort(arreglo);
            arreglo = metodo.getHeapSort();

            //mostrar metodo concatenado
            Mostrar = string.Join(",", arreglo);
            txtHeadSort.Text = Mostrar;
        }
    }
}
