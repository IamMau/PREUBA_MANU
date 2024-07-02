using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_IT_HEFESTO.Vistas.Requisitos
{
    public partial class FrmVerRequisitos : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();
        private string dniPath;
        private string rtnPath;
        private string reciboPublicoPath;
        private string croquisPath;

        public FrmVerRequisitos(string dniPath, string rtnPath, string reciboPublicoPath, string croquisPath)
        {
            InitializeComponent();
            bs.revisarInfoArchivoConfiguracion();
            this.dniPath = dniPath;
            this.rtnPath = rtnPath;
            this.reciboPublicoPath = reciboPublicoPath;
            this.croquisPath = croquisPath;
        }

        private void FrmVerRequisitos_Load(object sender, EventArgs e)
        {
            // Mostrar las imágenes en los PictureBox correspondientes
            DisplayImageOrText(PxDni, dniPath, "Pendiente");
            DisplayImageOrText(PxRtn, rtnPath, "Pendiente");
            DisplayImageOrText(PxRp, reciboPublicoPath, "Pendiente");
            DisplayImageOrText(PxCroquis, croquisPath, "Pendiente");
        }

        private void DisplayImageOrText(PictureBox pictureBox, string imagePath, string text)
        {
            if (File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
            else
            {
                // Dibujar el texto "Pendiente" en el PictureBox
                Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.Clear(Color.White); // Fondo blanco, puedes cambiarlo a otro color si lo prefieres
                    using (Font font = new Font("Arial", 16, FontStyle.Bold))
                    {
                        SizeF textSize = g.MeasureString(text, font);
                        g.DrawString(text, font, Brushes.Black, (pictureBox.Width - textSize.Width) / 2, (pictureBox.Height - textSize.Height) / 2);
                    }
                }
                pictureBox.Image = bitmap;
            }
        }
    }
}
