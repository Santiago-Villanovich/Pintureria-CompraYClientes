using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villanovich_Santiago_TP2_POO
{

    public abstract class clsProductos : ICloneable
    {
        public delegate void ActualStock(List<clsProductos> listaProduc);
        internal ActualStock actualStock;

        public delegate void DelegadoValidacion(object sender, DelValidacionArgs e);
        public event DelegadoValidacion EventValidacion;

        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public void ValidarProducto()
        {
            if (Stock == 0)
            {
                EventValidacion(this, new DelValidacionArgs{Mensaje = $"El stock del producto: {this.Codigo} - {this.Descripcion} llego a 0" });
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    
    
}
