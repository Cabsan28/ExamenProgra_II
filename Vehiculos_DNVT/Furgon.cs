using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquema_DNVT
{
    public class Furgon : tipoVehiculo, ITipoLicencia
    {
        public int tamañoContenedor { get; set; }

        public override string Conducir()
        {
            return "Conduciendo Furgon";
        }

        public string TipoLicencia()
        {
            return "Licencia de conducir de tipo CE (Furgón)";
        }
    }
}
