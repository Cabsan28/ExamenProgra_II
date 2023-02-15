using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Esquema_DNVT
{
  
    public class tipoVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AñoFabricacion { get; set; }
        public string NumeroSerie { get; set; }
        public int velocidadActual { get; set; }

        public virtual string Conducir()
        {
            return "Conduciendo vehiculo";
        }
    }
}
