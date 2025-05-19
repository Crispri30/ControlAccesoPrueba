using ControlAccesoPrueba.Utilidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlAccesoPrueba.Repositorios
{
    public class EmpleadoRepository
    {
        //CRUD

        //Agregar Empleados
        public void AgregarEmpleado(string nombre, string rol, string zonaAcceso)
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            using (SqlCommand cmd = new SqlCommand("INSERT INTO Empleados (Nombre, Rol, ZonaAcceso) VALUES (@Nombre, @Rol, @ZonaAcceso)", conexion))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Rol", rol);
                cmd.Parameters.AddWithValue("@ZonaAcceso", zonaAcceso);
                cmd.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }

        //Obtener Empleados
        public List<Modelos.Empleados> ObtenerEmpleados()
        {
            List<Modelos.Empleados> listaEmpleados = new List<Modelos.Empleados> ();

            SqlConnection conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            using (SqlCommand cmd = new SqlCommand("SELECT EmpleadoID, Nombre, Rol, ZonaAcceso FROM Empleados", conexion))
            using (SqlDataReader reader = cmd.ExecuteReader()) {

                while (reader.Read()) {
                    listaEmpleados.Add(new Modelos.Empleados
                    {
                        EmpleadoID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Rol = reader.GetString(2),
                        ZonaAcceso = reader.IsDBNull(3) ? null : reader.GetString(3)
                    });
                }
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();

            return listaEmpleados;
        }

        //Actualizar Empleados
        public void ActualizarEmpleado(int id, string nombre, string rol, string zonaAcceso)
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            using (SqlCommand cmd = new SqlCommand("UPDATE Empleados SET Nombre=@Nombre, Rol=@Rol, ZonaAcceso=@ZonaAcceso WHERE EmpleadoID=@ID ", conexion))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Rol", rol);
                cmd.Parameters.AddWithValue("@ZonaAcceso", zonaAcceso);
                cmd.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();

        }

        //Eliminar Empleado
        public void EliminarEmpleado(int id)
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Empleados WHERE EmpleadoID = @ID", conexion)) 
            {
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().ObtenerConexion();
        }

        //Metodo para registrar el acceso del empleado
        public void RegistrarAccesoEmpleado(int empleadoID, int zonaID, DateTime fechaEntrada)
        {
            //obtener la instancia única de la conexion y abrirla
            SqlConnection conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            //Crear objeto SqlCommand indicando el nombre del procedimiento almacenado
            using (SqlCommand cmd = new SqlCommand("Sp_RegistrarAccesoEmpleado",conexion))
            {
                //Indicar a SqlCommand que voy a utlizar un procedimiento almacenado
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Agregar parametros que el procedimiento almacenado va recibir
                cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                cmd.Parameters.AddWithValue("@ZonaID", zonaID);
                cmd.Parameters.AddWithValue("@FechaEntrada", fechaEntrada);

                //Ejecutar el comando en la base de datos sin esperar un resultado
                cmd.ExecuteNonQuery();
            }

            //Cerrar la conexion
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }
    }
}
