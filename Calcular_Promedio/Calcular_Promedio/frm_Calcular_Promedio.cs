using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Promedio
{
    public partial class frm_Calcular_Promedio : Form
    {
        public frm_Calcular_Promedio()
        {
            InitializeComponent();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txt_Nombre.Clear();
            txt_Nombre.Focus();
            txt_Num_Cuenta.Clear();
            txt_Nota_1.Clear();
            txt_Nota_2.Clear();
            txt_Nota_3.Clear();
            txt_Nota_4.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Clacular_Click(object sender, EventArgs e)
        {
            Promedio Estudiante = new Promedio();

            Estudiante.Nom_Estudiante = txt_Nombre.Text;
            Estudiante.Num_cuenta = Convert.ToInt64(txt_Num_Cuenta.Text);
            Estudiante.Nota_1 = Convert.ToInt32(txt_Nota_1.Text);
            Estudiante.Nota_2 = Convert.ToInt32(txt_Nota_2.Text);
            Estudiante.Nota_3 = Convert.ToInt32(txt_Nota_3.Text);
            Estudiante.Nota_4 = Convert.ToInt32(txt_Nota_4.Text);

            MessageBox.Show($"El estudiante {Estudiante.Nom_Estudiante} con número de cuenta {Estudiante.Num_cuenta} su promedio es de: {Estudiante.Promedio_Estudiante().ToString()}% y, {Estudiante.Clase_apro_repro()}.");

        }
    }
}
            
