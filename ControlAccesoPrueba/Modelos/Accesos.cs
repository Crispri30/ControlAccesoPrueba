using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoPrueba.Modelos
{
    public class Accesos
    {
        public int AccesoID { get; set; }
        public int? EmpleadoID { get; set; }
        public int? VisitanteID { get; set; }
        public int ZonaID { get; set; }
        public DateTime FechaHoraEntrada { get; set; }
        public DateTime? FechaHoraSalida { get; set; }
    }
}
