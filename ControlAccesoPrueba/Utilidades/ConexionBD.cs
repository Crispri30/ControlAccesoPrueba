using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ControlAccesoPrueba.Utilidades
{
    public class ConexionBD 
    {
        //Cadena de conexion indicando el servidor y la bd
        private readonly string connectionString = "Server=LAPTOP-3T0KE2DD\\SQLEXPRESS;Database=ControlEdificios;Trusted_Connection=True;TrustServerCertificate=True";

        //variable con la única instancia de la clase ConexionBD
        private static ConexionBD? instancia;

        //Candado para evitar errores si dos partes del programa intentan crear la instancia al mismo tiempo
        private static readonly object lockObj = new object();

        //Variable real de conexión a SQL
        private SqlConnection conexion;

        //Constructor de ConexionBD
        private ConexionBD()
        {
            conexion = new SqlConnection(connectionString); //agregar a la variable conexion el servidor
        }

        public static ConexionBD ObtenerInstancia()
        {
            if (instancia == null) { //Verificar si la instancia es nula
                lock (lockObj) //Usar lock para crear una instancia una única vez
                {
                    if (instancia == null) //Verificar si la instancia es nula
                    {
                        instancia = new ConexionBD(); //Si es nula se crea una conexion con el método ConexionBD
                    }
                }
            }
            return instancia; //Devolver la instancia creada o la que ya existía
        }

        //Devolver la conexion abierta
        public SqlConnection ObtenerConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        //Devolver la conexion cerrada

        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
