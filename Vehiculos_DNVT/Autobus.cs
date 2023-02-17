using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquema_DNVT
{
    public class Autobus : tipoVehiculo, ITipoLicencia
    {
        public int CapacidadPasajeros { get; set; }

        public override string Conducir()
        {
            return "Conduciendo Autobus";
        }

        public string TipoLicencia()
        {
            return "Licencia de conducir de tipo D1 (Autobús)";
        }
    }
}