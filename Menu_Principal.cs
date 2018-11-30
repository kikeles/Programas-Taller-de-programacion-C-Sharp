using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_TimeSpan
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Tiempo formRegistro = new Registro_Tiempo();
            formRegistro.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Mostrar formReporte = new Reporte_Mostrar();
            formReporte.Show();
        }
    }
}
