using ControlAccesoPrueba.Utilidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoPrueba.Repositorios
{
    public class VisitanteRepository
    {
        public void AgregarVisitante(int visitanteID, string nombre, string telefono, string motivoVisita)
        {
            SqlConnection conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            using (SqlCommand cmd = new SqlCommand("INSERT INTO Visitantes (VisitanteID,Nombre, Telefono, MotivoVisita) VALUES (@VisitanteID,@Nombre,@Telefono,@MotivoVisita)",conexion))
            {
                cmd.Parameters.AddWithValue("@VisitanteID", visitanteID );
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("MotivoVisita", motivoVisita);

                int filas_afectadas = cmd.ExecuteNonQuery();

                if (filas_afectadas == 0)
                {
                    MessageBox.Show("Error al ingresar visitante");
                }
                else
                {
                    MessageBox.Show("Se agrego correctamente el visitante a la base de datos");
                }
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }

        public List<Modelos.Visitantes> ObtenerVisitante()
        {
            List<Modelos.Visitantes> listaVisitantes = new List<Modelos.Visitantes>();

            SqlConnection conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            using (SqlCommand cmd = new SqlCommand("SELECT VisitanteID, Nombre, Telefono, MotivoVisita FROM Visitantes", conexion))
            using(SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    listaVisitantes.Add(new Modelos.Visitantes
                    {
                        VisitanteID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Telefono = reader.GetString(2),
                        MotivoVisita = reader.IsDBNull(3) ? null : reader.GetString(3)
                    });
                }

            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
            return listaVisitantes;
        }

        public void ActualizarVisitantes(int visitanteID, string nombre, string telefono, string motivoVisita)
        {
            SqlConnection conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlCommand cmd = new SqlCommand("UPDATE Visitantes SET Nombre=@Nombre, Telefono=@Telefono, MotivoVisita=@MotivoVisita WHERE VisitanteID=@VisitanteID", conexion))
            {
                cmd.Parameters.AddWithValue("@VistanteID", visitanteID);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@MotivoVisita", motivoVisita);

                int filas_afectadas = cmd.ExecuteNonQuery();

                if(filas_afectadas == 0)
                {
                    MessageBox.Show("El visitante no existe");
                }
                else
                {
                    MessageBox.Show("Se actualizo correctamente al visitante");
                }

            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }

        public void EliminarVisitantes(int visitanteID)
        {
            SqlConnection conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlCommand cmd =  new SqlCommand("DELETE FROM Visitantes WHERE VisitanteID=@VisitanteID", conexion))
            {
                cmd.Parameters.AddWithValue("@VisitanteID", visitanteID);

                int filas_afectadas = cmd.ExecuteNonQuery();

                if (filas_afectadas == 0)
                {
                    MessageBox.Show("El visitante no existe");
                }
                else
                {
                    MessageBox.Show("Se elimino correctamente al visitante");
                }
            }
            ConexionBD.ObtenerInstancia().ObtenerConexion();
        }

        public void RegistrarAccesoVisitante(int visitanteID, string nombre,string telefono, string descripcion)
        {
            SqlConnection conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            using (SqlCommand cmd =  new SqlCommand("Sp_RegistrarAccesoVisitante", conexion))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@VisitanteID", visitanteID);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                cmd.ExecuteNonQuery();
            }

            ConexionBD.ObtenerInstancia().CerrarConexion();

        }
    }
}
