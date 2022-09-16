using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villanovich_Santiago_TP2_POO
{
    public class clsEmpleado : clsPersona
    {
        public double sueldo { get; set; }
        public int antiguedad { get; set; }

        public clsEmpleado() { }
        public clsEmpleado(string nombre, string apellido, int dni, double telefono, DateTime fecha)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Telefono = telefono;
            antiguedad = new DateTime().Year - fecha.Year;
        }
        public override void AsignarBonificacion()
        {
            int aux = 85000;
            if (antiguedad > 0 && antiguedad < 5)
            {
                sueldo =aux + (aux*0.03);
            }
            else if (antiguedad >= 10 && antiguedad < 20)
            {
                sueldo = aux + (aux * 0.06);
            }
            else if (antiguedad >= 20)
            {
                sueldo = aux + (aux * 0.09);
            }

        }
    }

}
