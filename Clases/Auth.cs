using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_IT_HEFESTO.Clases
{
    internal class Auth
    {
        Clases.DB db = new Clases.DB();

        public bool registerUserAdmin()
        {
            bool resp = false;
            if (db.Exist("USUARIOS", "USUARIO", $"'IamMAu'") == false)
            {
                string username, clave, nombre, genero, fechanac, correo, rolId, estado;
                DateTime registro;

                username = "IamMAu";
                clave = BCrypt.Net.BCrypt.HashPassword("123456789");
                nombre = "Mauricio Cruz";
                genero = "hombre";
                fechanac = "2003-01-24";
                correo = "mauriciogants@gmail.com";
                rolId = "00001";
                estado = "ACTIVO";
                registro = DateTime.Now;

                string campos = "USUARIO, CLAVE, NOMBRE, GENERO, FECHA_N, CORREO, ROL_ID, ESTADO, REGISTRO";
                string valores = $"'{username}','{clave}','{nombre}','{genero}','{fechanac}','{correo}','{rolId}','{estado}','{registro.ToString("yyyy-MM-dd HH:mm:ss")}'";

                db.Save("USUARIOS", campos, valores);
                resp = true;
            }

            return resp;
        }

        public bool mKElOGIN(string username, string clave)
        {
            bool resp = false;
            // Aquí puedes implementar la lógica de autenticación
            return resp;
        }

        public string Decrypt(string cipherText)
        {
            string key = "your-encryption-key"; // Asegúrate de usar la misma clave que usaste para encriptar.
            byte[] iv = new byte[16]; // Initialization vector
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(buffer))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cs))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
