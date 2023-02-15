using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquema_DNVT
{
    public class Camion : tipoVehiculo, ITipoLicencia
    {
        public int CapacidadCarga { get; set; }

        public override string Conducir()
        {
            return "Conduciendo Camión";
        }

        public string TipoLicencia()
        {
            return "Licencia de conducir de tipo C (Camión)";
        }
    }
}
