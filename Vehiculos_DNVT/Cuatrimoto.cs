using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquema_DNVT
{
    public class Cuatrimoto : tipoVehiculo, ITipoLicencia
    {
        public string materialParrilla { get; set; }

        public override string Conducir()
        {
            return "Conduciendo Cuatrimoto";
        }

        public string TipoLicencia()
        {
            return "Licencia de conducir de tipo B1 (Cuatrimoto y Mototaxi)";
        }
    }
}
