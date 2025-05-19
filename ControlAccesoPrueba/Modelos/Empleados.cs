using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoPrueba.Modelos
{
    public enum RolEmpleado
    {
        Administrador,
        Seguridad,
        Empleado
    }
    public class Empleados
    {
        public int EmpleadoID {  get; set; }
        public string Nombre { get; set; }
        public RolEmpleado Rol { get; set; }
        public string ZonaAcceso   { get; set; }

    }
}
