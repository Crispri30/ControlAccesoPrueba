using ControlAccesoPrueba.Modelos;
using ControlAccesoPrueba.Utilidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoPrueba.Repositorios
{
   public class UsuariosRepository
    {
        public UsuarioLogin ValidarLogin (string usuario, string contraseña)
        {
            SqlConnection conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            UsuarioLogin? user = null;

            using (SqlCommand cmd =  new SqlCommand("SP_ValidarLogin", conexion))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                using (SqlDataReader reader =  cmd.ExecuteReader())
                {
                    if (reader.Read()) 
                    {
                        user = new UsuarioLogin
                        {
                            Usuario = reader.GetString(0),
                            Contraseña = reader.GetString(1),
                            Rol = reader.GetString(2)
                        };
                        
                    }
                }

                ConexionBD.ObtenerInstancia().ObtenerConexion();
                return user;
            }
        }

    }
}
