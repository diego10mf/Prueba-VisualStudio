using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles
{
    class Coche
    {

        public string Nombre { get; set; }
        public string Marca { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Marca}";
        }
    }
}
