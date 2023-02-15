using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquema_DNVT
{
    public class Moto : tipoVehiculo, ITipoLicencia
    {
        public string Transmision { get; set; }

        public override string Conducir()
        {
            return "Conduciendo Moto";
        }

        public string TipoLicencia()
        {
            return "Licencia de conducir de tipo A (motocicleta)";
        }
    }


}
