using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_IT_HEFESTO.Clases
{
    internal class Configuracion
    {
        Clases.DB db=new Clases.DB();
        Clases.Helpers h=new Clases.Helpers();

        public void checkInfoConfiguracion()
        {
            // Checamos si existe información en la tabla CONFIG_APP
            if (db.Exist("CONFIG_APP", "CLAVE", "SERVER_FILES") == false)
            {
                db.Save("CONFIG_APP", "CLAVE, VALOR, DETALLE", "'SERVER_FILES','','SERVIDOR DE ARCHIVOS'");
            }

            if (db.Exist("CONFIG_APP", "CLAVE", "BACKUPS") == false)
            {
                db.Save("CONFIG_APP", "CLAVE, VALOR, DETALLE", "'BACKUPS','','DIRECTORIO PARA LAS COPIAS DE SEGURIDAD'");
            }
        }

    }
}
