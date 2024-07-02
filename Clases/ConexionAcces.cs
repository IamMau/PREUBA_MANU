using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_IT_HEFESTO.Clases
{
    internal class ConexionAcces
    {
        Clases.Helpers h = new Clases.Helpers();
        public static string cadena_conexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Data_Sistema\IT_HEFESTO.accdb;Jet OLEDB:Database Password=123456789;";
        public static OleDbConnection ConAcces = new OleDbConnection(cadena_conexion);

        public void abrirConecxion()
        {
            try
            {
                ConAcces.Open();
            }
            catch (OleDbException error)
            {
                h.advertencia(error.Message);
            }
        }
        public void cerrarConedxion()
        {
            try
            {
                ConAcces.Close();

            }
            catch (OleDbException error)
            {
                h.advertencia(error.Message);
            }

        }

        public void terminarConecxion()
        {
            if (ConAcces.State == ConnectionState.Open)
            {
                ConAcces.Close();
            }
        }
    }
}
