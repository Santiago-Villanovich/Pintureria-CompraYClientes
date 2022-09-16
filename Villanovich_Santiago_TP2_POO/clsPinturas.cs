using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villanovich_Santiago_TP2_POO
{
    public class clsPinturas : clsProductos
    {
        
        public string Color { get; set; }
        public string Volumen { get; set; }
        public string TipoPintura { get; set; }

        public clsPinturas() { }

        public clsPinturas(int cod, string descrip, string marca, double precio, string color, string volumen, string tipo )
        {
            Codigo = cod;
            Descripcion = descrip;
            Marca = marca;
            Precio = precio;
            Stock = 0;
            Color = color;
            Volumen = volumen;
            TipoPintura = tipo;
        }
    }

    public enum TiposPintura
    {
        Latex,
        Esmalte,
        Revestimiento,
        Barniz,
        Impermeabilizante
    }
    
    public enum Volumenes
    {
        Cuarto_Litro,
        Medio_Litro,
        Litro,
        Dos_Litros,
        Cuatro_Litros,
        Diez_Litros,
        Veinte_Litros

    }
}
