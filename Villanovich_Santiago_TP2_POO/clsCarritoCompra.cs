using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villanovich_Santiago_TP2_POO
{
    namespace CompraProductos
    {
        public class clsCarritoCompra: ICompra
            {
                public List<clsProductos> listaProductos = new List<clsProductos>();
       
                public double PrecioFinal { get; set; }

                public void CalcularTotalCompra()
                {

                    foreach (clsProductos item in listaProductos)
                    {
                        PrecioFinal += (item.Precio * item.Stock);
                    }

                }
            }
    }
    
}
