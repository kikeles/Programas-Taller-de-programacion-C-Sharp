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
    public partial class Reporte_Mostrar : Form
    {
        public Reporte_Mostrar()
        {
            InitializeComponent();
        }

        //tipo de datos entradas o salidas
        int opcion ;
        string entrada="", salida="", persona="", cadena="";
        

        private void label1_Click(object sender, EventArgs e)
        {
            //nada
        }

        private void Reporte_Mostrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bool inOut = false;
            bool encontrado = false;
            
                StreamReader lectura;
                String[] campos = new string[4];
                char[] separador = { '/' };
                //manejo de excepciones errores subsecuentes
                try
                {
                    lectura = File.OpenText("registro.txt");
                    //persona = txtPersona.Text;
                    //opcion de muestra de registro
                    if (opcion == 0)
                    {
                        MessageBox.Show("Selecciona Entradas o Salidas");
                        System.Environment.Exit(-1);
                    }
                    

                    //aplicamos lectura adelantada para saber si hay elementos en el archivo
                    cadena = lectura.ReadLine();
                    while (cadena != null && encontrado == false)
                    {
                        
                        campos = cadena.Split(separador);
                        if (campos[0].Trim().Equals(persona))
                        {
                            
                            if (campos[1].Trim().Equals(entrada))
                            {
                                listBoxReporte.Items.Add(campos[0].Trim());
                                listBoxReporte.Items.Add(campos[1].Trim());
                                listBoxReporte.Items.Add(campos[2].Trim());
                                listBoxReporte.Items.Add(campos[3].Trim());
                                encontrado = true;
                            }
                            else if (campos[1].Trim().Equals(salida))
                            {
                                listBoxReporte.Items.Add(campos[0].Trim());
                                listBoxReporte.Items.Add(campos[1].Trim());
                                listBoxReporte.Items.Add(campos[2].Trim());
                                listBoxReporte.Items.Add(campos[3].Trim());
                                encontrado = true;
                            }
                            cadena = lectura.ReadLine();
                            campos = cadena.Split(separador);
                        }
                        else
                        {
                            cadena = lectura.ReadLine();
                        }

                    }
                    if (encontrado == false)
                    {
                        MessageBox.Show(persona + " - No encontrado");
                        Application.Exit();
                    }

                    lectura.Close();

                    txtPersona.Text = "";
                }
                catch (FileNotFoundException fe)
                {
                    listBoxReporte.Items.Add("ERROR " + fe.Message);
                }

            
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            opcion = 1;
            persona = "";
            persona = txtPersona.Text;
            entrada = "Entrada";
            listBoxReporte.Items.Add("Entradas");
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            opcion = 2;
            persona = "";
            persona = txtPersona.Text;
            salida = "Salida";
            listBoxReporte.Items.Add("Salidas");
        }
    }
}
