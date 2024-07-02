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

namespace PROYECTO_IT_HEFESTO.Vistas.Requisitos
{
    public partial class FrmRegistroDocumento : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();
        public FrmRegistroDocumento()
        {
            InitializeComponent();
            bs.revisarInfoArchivoConfiguracion();
        }

        private void BtnDni_Click(object sender, EventArgs e)
        {
            // Crear un nuevo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurar el OpenFileDialog para que muestre solo imágenes
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar una imagen";

            // Mostrar el OpenFileDialog y verificar si el usuario seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string imagePath = openFileDialog.FileName;

                // Cargar la imagen en el PictureBox
                PxDni.Image = Image.FromFile(imagePath);

                // Ajustar el tamaño de la imagen al tamaño del PictureBox
                PxDni.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRtn_Click(object sender, EventArgs e)
        {
            // Crear un nuevo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurar el OpenFileDialog para que muestre solo imágenes
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar una imagen";

            // Mostrar el OpenFileDialog y verificar si el usuario seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string imagePath = openFileDialog.FileName;

                // Cargar la imagen en el PictureBox
                PxRtn.Image = Image.FromFile(imagePath);

                // Ajustar el tamaño de la imagen al tamaño del PictureBox
                PxRtn.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void BtnRp_Click(object sender, EventArgs e)
        {
            // Crear un nuevo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurar el OpenFileDialog para que muestre solo imágenes
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar una imagen";

            // Mostrar el OpenFileDialog y verificar si el usuario seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string imagePath = openFileDialog.FileName;

                // Cargar la imagen en el PictureBox
                PxRp.Image = Image.FromFile(imagePath);

                // Ajustar el tamaño de la imagen al tamaño del PictureBox
                PxRp.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void BtnCroquis_Click(object sender, EventArgs e)
        {
            // Crear un nuevo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurar el OpenFileDialog para que muestre solo imágenes
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar una imagen";

            // Mostrar el OpenFileDialog y verificar si el usuario seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string imagePath = openFileDialog.FileName;

                // Cargar la imagen en el PictureBox
                PxCroquis.Image = Image.FromFile(imagePath);

                // Ajustar el tamaño de la imagen al tamaño del PictureBox
                PxCroquis.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Guardar las imágenes en la carpeta del cliente y obtener la ruta
            string folderPath = SaveImagesToClientFolder();

            // Obtener el DNI del cliente desde el formulario
            string dniCliente = FrmRequisitosInicio.ClientDni; // Asegúrate de que FrmRequisitosInicio.ClientDni sea accesible

            // Verificar si se guardaron archivos
            int cantidadArchivos = 0;
            if (PxDni.Image != null) cantidadArchivos++;
            if (PxRtn.Image != null) cantidadArchivos++;
            if (PxRp.Image != null) cantidadArchivos++;
            if (PxCroquis.Image != null) cantidadArchivos++;

            if (cantidadArchivos == 0)
            {
                MessageBox.Show("No se han guardado archivos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar la información en la base de datos
            string campos = "CLIENTE_DNI, PATH";
            string valores = $"'{dniCliente}', '{folderPath}'";
            db.Save("REQUISITOS_CLIENTE", campos, valores);

            MessageBox.Show("Información guardada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string SaveImagesToClientFolder()
        {
            // Obtener el nombre del cliente desde el formulario FrmRequisitosInicio
            string clientFolderName = FrmRequisitosInicio.ClientName.Replace(" - ", "_"); // Asegúrate de que FrmRequisitosInicio.ClientName sea accesible
            string folderPath = Path.Combine("C:\\Implantacion", clientFolderName);

            // Crear el directorio si no existe
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Guardar las imágenes en la carpeta del cliente
            if (PxDni.Image != null)
            {
                string dniImagePath = Path.Combine(folderPath, "DNI.jpg");
                PxDni.Image.Save(dniImagePath);
            }

            if (PxRtn.Image != null)
            {
                string rtnImagePath = Path.Combine(folderPath, "RTN.jpg");
                PxRtn.Image.Save(rtnImagePath);
            }

            if (PxRp.Image != null)
            {
                string rpImagePath = Path.Combine(folderPath, "Recibo Publico.jpg");
                PxRp.Image.Save(rpImagePath);
            }

            if (PxCroquis.Image != null)
            {
                string croquisImagePath = Path.Combine(folderPath, "Croquis.jpg");
                PxCroquis.Image.Save(croquisImagePath);
            }

            MessageBox.Show($"Imágenes guardadas en: {folderPath}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return folderPath; // Devolver la ruta de la carpeta
        }

        private void FrmRegistroDocumento_Load(object sender, EventArgs e)
        {

        }
    }
}
