using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquema_DNVT
{
    public class Auto : tipoVehiculo, ITipoLicencia
    {
        public int NumeroPuertas { get; set; }

        public override string Conducir()
        {
            return "Conduciendo Auto";
        }

        public string TipoLicencia()
        {
            return "Licencia de conducir de tipo B (Liviana)";
        }
    }
}