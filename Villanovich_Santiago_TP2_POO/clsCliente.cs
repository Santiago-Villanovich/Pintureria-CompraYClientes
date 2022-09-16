using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villanovich_Santiago_TP2_POO.CompraProductos;

namespace Villanovich_Santiago_TP2_POO
{
        public class clsCliente: clsPersona
        {
            public int Legajo { get; set; }
            public string Domicilio { get; set; }
            public double Puntos { get; set; }
            public clsCarritoCompra carritoCompra { get; set; }
            public clsCliente() { }
            public clsCliente(string nombre, string apellido, int dni, double telefono, string domicilio)
            {
                Nombre = nombre;
                Apellido = apellido;
                DNI = dni;
                Telefono = telefono;

                Legajo = new Random().Next(3001, 5999);
                Domicilio = domicilio;
            }

            public override void AsignarBonificacion()
            {
                Puntos += Math.Round(carritoCompra.PrecioFinal / 50);
            }
        }
    
}
