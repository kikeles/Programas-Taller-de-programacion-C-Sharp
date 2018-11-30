using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio_TimeSpan
{
    public partial class Registro_Tiempo : Form
    {
        public Registro_Tiempo()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        //datos del registro de horas de entrada y salida
        int persona = 0;
        DateTime Entrada = new DateTime();
        DateTime Salida = new DateTime();

        //variables de personas 
        String persona1 = "", persona2 = "";

        

        private void Registro_Tiempo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxDatos.Items.Add("Persona 1");
            persona = 1;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //removeAt borra el item seleccionado, sin parentesis predefinido
            listBoxDatos.Items.RemoveAt(listBoxDatos.SelectedIndex);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tiempo.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnPersona2_Click(object sender, EventArgs e)
        {
            listBoxDatos.Items.Add("Persona 2");
            persona = 2;
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            Entrada = DateTime.Now;
            listBoxDatos.Items.Add("Entrada - Hora  ["+Entrada.ToLongTimeString()+"]");
            listBoxDatos.Items.Add("Entrada - Fecha [" + Entrada.ToLongDateString() + "]");

            //datos temporales en espera de guardar
            if (persona == 1)
            {
                persona1 ="Persona 1/Entrada/ - Hora [" + Entrada.ToLongTimeString() + "] - Fecha [" + Entrada.ToLongDateString() + "]/"+" ";
                
            }
            else if (persona == 2)
            {
                persona2 ="Persona 2/Entrada/ - Hora [" + Entrada.ToLongTimeString() + "] - Fecha [" + Entrada.ToLongDateString() + "]/"+" ";
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBoxDatos.Items.Add("Se a guardado en el registro");
            //crear el archivo
            StreamWriter escribir = File.AppendText("registro.txt");
            //guardar los datos en el archivo registro.txt
            escribir.WriteLine(persona1);
            escribir.WriteLine(persona2);

            //cerrar el archivo
            escribir.Close();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Salida = DateTime.Now;
            listBoxDatos.Items.Add("Salida - Hora  [" + Salida.ToLongTimeString()+"]");
            listBoxDatos.Items.Add("Salida - Fecha [" + Salida.ToLongDateString() + "]");

            //datos temporales en espera de guardar
            if (persona == 1)
            {
                persona1 ="Persona 1/Salida/ - Hora [" + Salida.ToLongTimeString() + "] - Fecha [" + Salida.ToLongDateString() + "]/"+" ";
            }
            else if (persona == 2)
            {
                persona2 ="Persona 2/Salida/ - Hora [" + Salida.ToLongTimeString() + "] - Fecha [" + Salida.ToLongDateString() + "]/"+" ";
            }

        }
    }
}
