using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villanovich_Santiago_TP2_POO
{
    interface ICompra
    {
        double PrecioFinal { get; set; }

        void CalcularTotalCompra();

    }
}
