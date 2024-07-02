using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_IT_HEFESTO.Vistas.Servidores
{
   public partial class FrmServer : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();

        string server_files, backups, documento;
        public FrmServer()
        {
            InitializeComponent();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (validar() == 0)
            {
                server_files = formatearRuta(server_files);
                backups = formatearRuta(backups);
                string campos = $"VALOR = '{server_files}'";
                db.Update("CONFIG_APP", campos, "CLAVE='SERVER_FILES'");
                campos = $"VALOR = '{backups}'";
                db.Update("CONFIG_APP", campos, "CLAVE='BACKUPS'");

                // Guardar documento en la base de datos
                if (!string.IsNullOrEmpty(documento))
                {
                    string docDestinoServerFiles = Path.Combine(server_files, Path.GetFileName(documento));
                    string docDestinoBackups = Path.Combine(backups, Path.GetFileName(documento));

                    // Crear copias de la imagen en las rutas especificadas
                    File.Copy(documento, docDestinoServerFiles, true);
                    File.Copy(documento, docDestinoBackups, true);

                    // Guardar la ruta del documento en la base de datos
                    string rutaDocumento = docDestinoServerFiles.Replace(@"\", @"\\"); // Reemplazar \ con \\ para SQL
                    campos = $"VALOR = '{rutaDocumento}'";
                    db.Update("CONFIG_APP", campos, "CLAVE='DOCUMENTO'");
                }

                h.advertencia("Los cambios se aplicaron con éxito!");
                this.Close();
            }
        }

        private void BtnRuta_Click(object sender, EventArgs e)
        {
            path_archivos.ShowDialog();
            TxtPathFiles.Text = path_archivos.SelectedPath.ToString();
        }

        private string formatearRuta(string ruta)
        {
            string path = "";
            int length = ruta.Length;
            string last_char = ruta.Substring(length - 1, 1);
            if (last_char == @"\")
            {
                path = ruta;
            }
            else
            {
                path = ruta + @"\";
            }

            return path;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult result = fo.ShowDialog();
            if (result == DialogResult.OK)
            {
                PxtDoc.Image = Image.FromFile(fo.FileName);
                PxtDoc.Tag = fo.FileName;
                documento = fo.FileName;
            }
        }

        private int validar()
        {
            int errors = 0;
            server_files = TxtPathFiles.Text.Trim();
            backups = TxtPathBackups.Text.Trim();

            if (!Directory.Exists(server_files))
            {
                h.advertencia("La ruta que ingresó no pudo ser comprobada!");
                errors++;
                TxtPathFiles.Focus();
                return errors;
            }
            if (!Directory.Exists(backups))
            {
                h.advertencia("La ruta que ingresó no pudo ser comprobada!");
                errors++;
                TxtPathBackups.Focus();
                return errors;
            }
            return errors;
        }
    }
}
