using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Promedio
{
    class Promedio
    {
        private string nom_estudiante;
        private int num_cuenta;
        private int nota_1;
        private int nota_2;
        private int nota_3;
        private int nota_4;

        //PROPIEDADES
        public string Nom_Estudiante { get; set; }
        public int Num_cuenta { get; set; }
        public int Nota_1{ get; set; }
        public int Nota_2 { get; set; }
        public int Nota_3 { get; set; }
        public int Nota_4 { get; set; }

        //CONSTRUCTORES
        public Promedio() { }

        public Promedio(string _nom_estudiante, int _num_cuenta, 
                     int _nota_1, int _nota_2, int _nota_3,int _nota_4)
        {
            Nom_Estudiante = _nom_estudiante;
            Num_cuenta = _num_cuenta;
            Nota_1 = _nota_1;
            Nota_2 = _nota_2;
            Nota_3 = _nota_3;
            Nota_4 = _nota_4;
            
        }

        //MÉTODOS
        public decimal Promedio_Estudiante()
        {
            return ((Nota_1 + Nota_2 + Nota_3 + Nota_4) / 4);

        }

        public string Clase_apro_repro()
        {
            if (Promedio_Estudiante()>70)
            {
                return ("Aprobó la Clase");
            }
            else
            {
                return ("Reprobó la Clase");
            }

        }

    }
}
