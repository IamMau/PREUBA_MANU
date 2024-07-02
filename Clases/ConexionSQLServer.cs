using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_IT_HEFESTO.Clases
{
    internal class ConexionSQLServer : Clases.Entorno
    {
        public static string cadena_conecxion_sql;
        public static SqlConnection ConSQL = new SqlConnection();
        Clases.Helpers h = new Clases.Helpers();

        public void actualizarConecxionSQLServer()
        {
            cadena_conecxion_sql = $"Server={SERVER};DataBAse={DATABASE};User Id={USER}; Pwd={PWD};";
            ConSQL = new SqlConnection(cadena_conecxion_sql);

        }

        public void abrirConecxion()
        {
            try
            {
                ConSQL.Open();

            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
        }

        public void cerrarConecxion()
        {
            try
            {
                ConSQL.Close();
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
        }
        public void terminarConecxion()
        {
            if (ConSQL.State == ConnectionState.Open)
            {
                ConSQL.Close();
            }
        }
    }
}
