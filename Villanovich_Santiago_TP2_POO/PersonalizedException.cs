using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villanovich_Santiago_TP2_POO
{
    namespace MisErrors
    {
        class PersonalizedException : Exception
            {
                public override string Message
                {
                    get
                    {
                        return "El producto ingresado no puede tener un valor de $0";
                    }
                }
            }
    }
    
}
