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
    }
}
