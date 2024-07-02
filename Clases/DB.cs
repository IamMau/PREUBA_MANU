using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_IT_HEFESTO.Clases
{
    internal class DB : Clases.ConexionSQLServer
    {
        Clases.Helpers h = new Clases.Helpers();
        SqlCommand com;
        SqlDataAdapter reader;
        DataTable data;
        string query;

        public bool Save(string tablename, string campos, string valores, byte[] logo1 = null, byte[] logo2 = null)
        {
            bool resp = false;
            query = $"INSERT INTO {tablename}({campos}) VALUES({valores})";

            try
            {
                com = new SqlCommand(query, ConSQL);
                if (logo1 != null)
                {
                    com.Parameters.AddWithValue("@LOGO1", logo1);
                }
                if (logo2 != null)
                {
                    com.Parameters.AddWithValue("@LOGO2", logo2);
                }
                abrirConecxion();
                Int64 ri = com.ExecuteNonQuery();

                if (ri > 0)
                {
                    resp = true;
                }
                com.Dispose();
                cerrarConecxion();
                RegistrarQuery(query);

            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();
            }

            return resp;
        }

        public bool Update(string tableName, string setClause, string whereClause)
        {
            bool resp = false;
            string query = $"UPDATE {tableName} SET {setClause} WHERE {whereClause}";

            try
            {
                com = new SqlCommand(query, ConSQL);
                abrirConecxion();
                int rowsAffected = com.ExecuteNonQuery();
                resp = rowsAffected > 0;
                com.Dispose();
                cerrarConecxion();
                RegistrarQuery(query);
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();
            }

            return resp;
        }

        public byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private string lastExecutedQuery;

        public bool Saves(string tablename, string campos, string valores, byte[] foto = null)
        {
            bool resp = false;
            string query = $"INSERT INTO {tablename}({campos}) VALUES({valores})";

            string detailedQuery = $"INSERT INTO {tablename} ({campos}) VALUES (";

            string[] camposArray = campos.Split(',');
            string[] valoresArray = valores.Split(',');

            for (int i = 0; i < valoresArray.Length; i++)
            {
                detailedQuery += valoresArray[i].Trim();
                if (i < valoresArray.Length - 1)
                {
                    detailedQuery += ", ";
                }
            }

            if (foto != null)
            {
                detailedQuery += ", @FOTO";
            }

            detailedQuery += ")";

            lastExecutedQuery = detailedQuery;

            try
            {
                using (SqlCommand com = new SqlCommand(query, ConSQL))
                {
                    if (foto != null)
                    {
                        com.Parameters.AddWithValue("@FOTO", foto);
                    }
                    abrirConecxion();
                    Int64 ri = com.ExecuteNonQuery();

                    if (ri > 0)
                    {
                        resp = true;
                    }
                }
                cerrarConecxion();
                RegistrarQuery(query);
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();
            }

            return resp;
        }
        private void RegistrarQuery(string query)
        {
           
            string usuario = Session.CurrentUser;
            string columnas = "USUARIO, QUERY, REGISTRO";
            string valores = $"'{usuario}', '{query.Replace("'", "''")}', GETDATE()";

            string logQuery = $"INSERT INTO LOGQUERYS ({columnas}) VALUES ({valores})";

            rawSQL(logQuery);

            
        }


        public int rawSQL(string _query)
        {
            int ra = 0;
            try
            {
                com = new SqlCommand(_query, ConSQL);
                abrirConecxion();
                ra = com.ExecuteNonQuery();

                    cerrarConecxion();
                
                com.Dispose();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
               terminarConecxion();
            }
            return ra;
        }

        public string GetLastExecutedQuery()
        {
            return lastExecutedQuery;
        }

        public bool Exist(string tablename, string campo, string value)
        {
            bool resp = false;
            query = $"SELECT * FROM {tablename} WHERE {campo}=@value";
            try
            {
                com = new SqlCommand(query, ConSQL);
                com.Parameters.AddWithValue("@value", value);
                abrirConecxion();

                using (SqlDataReader reader = com.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        resp = true;
                    }
                }
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();

                RegistrarQuery(query);
            }
            

            return resp;
        }

        public bool CheckCredentials(string username, string password)
        {
            bool resp = false;
            query = $"SELECT CLAVE, ESTADO FROM USUARIOS WHERE USUARIO = @username COLLATE Latin1_General_CS_AS";
            try
            {
                com = new SqlCommand(query, ConSQL);
                com.Parameters.AddWithValue("@username", username);
                abrirConecxion();

                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    string hashedPassword = reader["CLAVE"].ToString();
                    string estado = reader["ESTADO"].ToString();

                    if (BCrypt.Net.BCrypt.Verify(password, hashedPassword) && estado == "ACTIVO")
                    {
                        resp = true;
                    }
                }
                reader.Close();
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();
                RegistrarQuery(query);
            }

            return resp;
        }

        // Clase para roles
        public class Role
        {
            public string Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        public List<Role> GetRoles()
        {
            List<Role> roles = new List<Role>();
            query = "SELECT ID, ROL FROM ROLES";
            try
            {
                com = new SqlCommand(query, ConSQL);
                abrirConecxion();

                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        roles.Add(new Role
                        {
                            Id = reader["ID"].ToString(),
                            Name = reader["ROL"].ToString()
                        });
                    }
                }
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();
                RegistrarQuery(query);
            }

            return roles;
        }

        // Cargar Tipos
        public DataTable CargarTipos()
        {
            DataTable tiposTable = new DataTable();
            string query = "SELECT ID, NOMBRE_DOCUMENTO FROM TIPOS";
            try
            {
                SqlCommand com = new SqlCommand(query, ConSQL);
                abrirConecxion();
                SqlDataReader reader = com.ExecuteReader();
                tiposTable.Load(reader);
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();
                RegistrarQuery(query);
            }
            return tiposTable;
        }

        // Cargar Géneros
        public DataTable CargarGeneros()
        {
            DataTable generosTable = new DataTable();
            string query = "SELECT ID, GENERO FROM Generos";
            try
            {
                SqlCommand com = new SqlCommand(query, ConSQL);
                abrirConecxion();
                SqlDataReader reader = com.ExecuteReader();
                generosTable.Load(reader);
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();
                RegistrarQuery(query);
            }
            return generosTable;
        }

        // Cargar Clientes
        public DataTable CargarClientes()
        {
            DataTable clientesTable = new DataTable();
            string query = "SELECT DNI, TIPO, NOMBRE_RAZON, DIRECCION, TELEFONO, CELULAR, GENERO, FECHA_N, CORREO, FOTO, ESTADO, ELIMINADO FROM CLIENTES";
            try
            {
                SqlCommand com = new SqlCommand(query, ConSQL);
                abrirConecxion();
                SqlDataReader reader = com.ExecuteReader();
                clientesTable.Load(reader);
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();
                RegistrarQuery(query);
            }
            return clientesTable;
        }

        public bool ActualizarCliente(string dni, string tipo, string nombreRazon, string direccion, string telefono,
                              string celular, string genero, DateTime fechaNacimiento, string correo,
                              byte[] foto, string eliminado)
        {
            bool resp = false;
            query = "UPDATE CLIENTES SET TIPO = @tipo, NOMBRE_RAZON = @nombreRazon, DIRECCION = @direccion, " +
                    "TELEFONO = @telefono, CELULAR = @celular, GENERO = @genero, FECHA_N = @fechaNacimiento, " +
                    "CORREO = @correo, FOTO = @foto, ELIMINADO = @eliminado WHERE DNI = @dni";

            try
            {
                com = new SqlCommand(query, ConSQL);
                com.Parameters.AddWithValue("@dni", dni);
                com.Parameters.AddWithValue("@tipo", tipo);
                com.Parameters.AddWithValue("@nombreRazon", nombreRazon);
                com.Parameters.AddWithValue("@direccion", direccion);
                com.Parameters.AddWithValue("@telefono", telefono);
                com.Parameters.AddWithValue("@celular", celular);
                com.Parameters.AddWithValue("@genero", genero);
                com.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                com.Parameters.AddWithValue("@correo", correo);
                com.Parameters.AddWithValue("@foto", foto);
                com.Parameters.AddWithValue("@eliminado", eliminado == "SI" ? 1 : 0);

                abrirConecxion();
                int rowsAffected = com.ExecuteNonQuery();
                resp = rowsAffected > 0;
                com.Dispose();
                cerrarConecxion();
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();
                RegistrarQuery(query);
            }

            return resp;
        }

        // Cargar Departamentos
        public DataTable CargarDepartamentos()
        {
            DataTable departamentosTable = new DataTable();
            string query = "SELECT CODIGO, DEPARTAMENTO FROM DEPARTAMENTOS";
            try
            {
                SqlCommand com = new SqlCommand(query, ConSQL);
                abrirConecxion();
                SqlDataReader reader = com.ExecuteReader();
                departamentosTable.Load(reader);
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();
                RegistrarQuery(query);
            }
            return departamentosTable;
        }

        public DataTable CargarMunicipiosPorDepartamento(string codDepto)
        {
            DataTable municipiosTable = new DataTable();
            string query = "SELECT CODIGO, MUNICIPIO FROM MUNICIPIOS WHERE COD_DEPTO = @codDepto";
            try
            {
                SqlCommand com = new SqlCommand(query, ConSQL);
                com.Parameters.AddWithValue("@codDepto", codDepto);
                abrirConecxion();
                SqlDataReader reader = com.ExecuteReader();
                municipiosTable.Load(reader);
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();
                RegistrarQuery(query);
            }
            return municipiosTable;
        }

        public DataTable CargarZonas()
        {
            DataTable zonasTable = new DataTable();
            string query = "SELECT CODIGO, ZONA, COD_DEPTO, COD_MUNIC FROM ZONAS";
            try
            {
                SqlCommand com = new SqlCommand(query, ConSQL);
                abrirConecxion();
                SqlDataReader reader = com.ExecuteReader();
                zonasTable.Load(reader);
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();
                RegistrarQuery(query);
            }
            return zonasTable;
        }

        public bool ActualizarZona(string codigo, string nuevaZona, string nuevoCodDepto, string nuevoCodMunic)
        {
            bool resp = false;
            string query = "UPDATE ZONAS SET ZONA = @nuevaZona, COD_DEPTO = @nuevoCodDepto, COD_MUNIC = @nuevoCodMunic WHERE CODIGO = @codigo";

            try
            {
                com = new SqlCommand(query, ConSQL);
                com.Parameters.AddWithValue("@codigo", codigo);
                com.Parameters.AddWithValue("@nuevaZona", nuevaZona);
                com.Parameters.AddWithValue("@nuevoCodDepto", nuevoCodDepto);
                com.Parameters.AddWithValue("@nuevoCodMunic", nuevoCodMunic);

                abrirConecxion();
                int rowsAffected = com.ExecuteNonQuery();
                resp = rowsAffected > 0;
                com.Dispose();
                cerrarConecxion();
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();
                RegistrarQuery(query);
            }

            return resp;
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, ConSQL))
                {
                    abrirConecxion();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();
                RegistrarQuery(query);
            }
            return dt;
        }

        // Cargar Requisitos por DNI
        public DataTable CargarRequisitosPorDni(string dni)
        {
            DataTable requisitosTable = new DataTable();
            string query = "SELECT * FROM REQUISITOS_CLIENTE WHERE CLIENTE_DNI = @dni";
            try
            {
                SqlCommand com = new SqlCommand(query, ConSQL);
                com.Parameters.AddWithValue("@dni", dni);
                abrirConecxion();
                SqlDataReader reader = com.ExecuteReader();
                requisitosTable.Load(reader);
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConecxion();
                RegistrarQuery(query);
            }
            return requisitosTable;
        }
    }
}
