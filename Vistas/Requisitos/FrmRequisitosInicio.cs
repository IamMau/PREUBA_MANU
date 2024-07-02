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
    public partial class FrmRequisitosInicio : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();
        public static string ClientName { get; private set; }
        public static string ClientDni { get; private set; }

        public FrmRequisitosInicio(string dni, string nombreRazon)
        {
            InitializeComponent();
            bs.revisarInfoArchivoConfiguracion();
            LblCliente.Text = $"{dni} - {nombreRazon}";
            ClientName = LblCliente.Text;
            ClientDni = dni; // Establecer el valor de ClientDni
        }

        private void FrmRequisitosInicio_Load(object sender, EventArgs e)
        {
            CargarRequisitos();
            AddButtonColumnsToDgvRequisitos();
            CreateDirectoryForClient();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvRequisitos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = DgvRequisitos.Columns[e.ColumnIndex];
                if (column.Name == "Editar")
                {
                    // Lógica para editar
                }
                else if (column.Name == "Ver")
                {
                    string dniPath = GetImagePath("DNI");
                    string rtnPath = GetImagePath("RTN");
                    string reciboPublicoPath = GetImagePath("Recibo Publico");
                    string croquisPath = GetImagePath("Croquis");

                    FrmVerRequisitos frmVerRequisitos = new FrmVerRequisitos(dniPath, rtnPath, reciboPublicoPath, croquisPath);
                    frmVerRequisitos.ShowDialog();
                }
                else if (column.Name == "Eliminar")
                {
                    // Lógica para eliminar
                }
            }
        }

        private void AddButtonColumnsToDgvRequisitos()
        {
            string rutaEditar = "Iconos/edit.png";
            string rutaVer = "Iconos/eye.png";
            string rutaEliminar = "Iconos/delete (2).png";
            string rutaCompletaEditar = Path.Combine(Application.StartupPath, rutaEditar);
            string rutaCompletaVer = Path.Combine(Application.StartupPath, rutaVer);
            string rutaCompletaEliminar = Path.Combine(Application.StartupPath, rutaEliminar);

            DataGridViewImageColumn editarButtonColumn = new DataGridViewImageColumn();
            editarButtonColumn.Image = Image.FromFile(rutaCompletaEditar);
            editarButtonColumn.HeaderText = "EDITAR";
            editarButtonColumn.Name = "Editar";
            editarButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DgvRequisitos.Columns.Add(editarButtonColumn);
            DgvRequisitos.Columns["Editar"].Width = 70;

            DataGridViewImageColumn verButtonColumn = new DataGridViewImageColumn();
            verButtonColumn.Image = Image.FromFile(rutaCompletaVer);
            verButtonColumn.HeaderText = "VER";
            verButtonColumn.Name = "Ver";
            verButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DgvRequisitos.Columns.Add(verButtonColumn);
            DgvRequisitos.Columns["Ver"].Width = 70;

            DataGridViewImageColumn eliminarButtonColumn = new DataGridViewImageColumn();
            eliminarButtonColumn.Image = Image.FromFile(rutaCompletaEliminar);
            eliminarButtonColumn.HeaderText = "ELIMINAR";
            eliminarButtonColumn.Name = "Eliminar";
            eliminarButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DgvRequisitos.Columns.Add(eliminarButtonColumn);
            DgvRequisitos.Columns["Eliminar"].Width = 70;

            DgvRequisitos.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex >= 0 && DgvRequisitos.Rows[e.RowIndex].DataBoundItem != null)
                {
                    DataGridViewColumn column = DgvRequisitos.Columns[e.ColumnIndex];
                    if (column.Name == "Editar" && (e.Value == null || e.Value == DBNull.Value))
                    {
                        e.Value = Image.FromFile(rutaCompletaEditar);
                    }
                    else if (column.Name == "Ver" && (e.Value == null || e.Value == DBNull.Value))
                    {
                        e.Value = Image.FromFile(rutaCompletaVer);
                    }
                    else if (column.Name == "Eliminar" && (e.Value == null || e.Value == DBNull.Value))
                    {
                        e.Value = Image.FromFile(rutaCompletaEliminar);
                    }
                }
            };
        }

        private void BtnNuevoDocumentp_Click(object sender, EventArgs e)
        {
            FrmRegistroDocumento frm = new FrmRegistroDocumento();
            frm.ShowDialog();
        }

        private void CreateDirectoryForClient()
        {
            string clientFolderName = LblCliente.Text.Replace(" - ", "_"); // Reemplazar espacios y guiones por un guion bajo o el carácter deseado
            string folderPath = Path.Combine("C:\\Implantacion", clientFolderName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                MessageBox.Show($"Carpeta creada: {folderPath}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"La carpeta ya existe: {folderPath}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarRequisitos()
        {
            DataTable requisitos = db.CargarRequisitosPorDni(ClientDni);
            DgvRequisitos.DataSource = requisitos;
        }

        private string GetImagePath(string documentType)
        {
            string clientFolderName = LblCliente.Text.Replace(" - ", "_");
            string folderPath = Path.Combine("C:\\Implantacion", clientFolderName);
            return Path.Combine(folderPath, $"{documentType}.jpg");
        }
    }
}
