using ControlAccesoPrueba.Utilidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoPrueba.Repositorios
{
    public class GenerarAlertaRepository
    {
        public void RegistrarAlerta(int empleadoID, string tipoAlerta,string descripcion)
        {
            SqlConnection conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            using (SqlCommand cmd = new SqlCommand("Sp_GenerarAlerta", conexion))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                cmd.Parameters.AddWithValue("@TipoAlerta", tipoAlerta);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                cmd.ExecuteNonQuery();
            }

            ConexionBD.ObtenerInstancia().CerrarConexion();
        }
    }
}
