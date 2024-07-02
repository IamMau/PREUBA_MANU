using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PROYECTO_IT_HEFESTO.Clases
{
    internal class Helpers
    {
        //propiedades para los botones de las alertas
        string titulo_aleerta;
        MessageBoxButtons botones;
        MessageBoxIcon icono;

        public void advertencia(string msg_advertencia)
        {
            titulo_aleerta = "Advertencia";
            botones = MessageBoxButtons.OK;
            icono = MessageBoxIcon.Warning;

            MessageBox.Show(msg_advertencia, titulo_aleerta, botones, icono);
        }


    }
}
