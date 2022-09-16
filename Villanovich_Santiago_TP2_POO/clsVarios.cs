using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villanovich_Santiago_TP2_POO
{
    public class clsVarios : clsProductos
    {

        public clsVarios() { }
        public clsVarios(int cod, string descrip, string marca, double precio)
        {
            Codigo = cod;
            Descripcion = descrip;
            Marca = marca;
            Precio = precio;
            Stock = 0;
        }

    }
}
