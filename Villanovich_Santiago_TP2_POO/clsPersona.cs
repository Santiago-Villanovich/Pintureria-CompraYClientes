using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villanovich_Santiago_TP2_POO
{
    public abstract class clsPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public double Telefono { get; set; }

        public abstract void AsignarBonificacion();
    }
}
