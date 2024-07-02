using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_IT_HEFESTO.Clases
{
    internal class DBAccess : Clases.ConexionAcces
    {
        Clases.Helpers h = new Clases.Helpers();
        OleDbCommand com;
        OleDbDataReader reder;
        DataTable recordset;
        string query;

        public DataTable Find(string tabla)
        {
            recordset = new DataTable();
            query = $"SELECT * FROM {tabla}";

            try
            {
                com = new OleDbCommand(query, ConAcces);
                abrirConecxion();
                reder = com.ExecuteReader();
                recordset.Load(reder);

                reder.Close();
                com.Dispose();
                cerrarConedxion();

            }
            catch (OleDbException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();
            }
            return recordset;

        }

    }
}
