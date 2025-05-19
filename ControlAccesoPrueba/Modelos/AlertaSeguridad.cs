using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoPrueba.Modelos
{
    public class AlertaSeguridad
    {
        public int AlertaID { get; set; }
        public int EmpleadoID { get; set; }
        public DateTime FechaHora { get; set; }
        public string TipoAlerta { get; set; }
        public string Descripcion { get; set; }

    }
}
