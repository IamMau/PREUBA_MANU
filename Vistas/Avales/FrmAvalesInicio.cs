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

namespace PROYECTO_IT_HEFESTO.Vistas.Avales
{
    public partial class FrmAvalesInicio : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();
        private string clienteDNI;

        // Constructor that accepts a string parameter
        public FrmAvalesInicio(string dni)
        {
            InitializeComponent();
            bs.revisarInfoArchivoConfiguracion();
            clienteDNI = dni;
            LblAval.Text = clienteDNI; // Display the DNI in the LblAval
        }

        private void FrmAvalesInicio_Load(object sender, EventArgs e)
        {
            LoadAvalesData(clienteDNI);
            AddButtonColumnsToDgvAvales();
        }

        private void LoadAvalesData(string dni)
        {
            string query = $"SELECT * FROM AVALES WHERE DNI_CLIENTE = '{dni}'";
            DataTable avalesData = db.ExecuteQuery(query);

            DgvAvales.DataSource = avalesData;
        }

        private void AddButtonColumnsToDgvAvales()
        {
            string rutaEditar = "Iconos/edit.png";
            string rutaDocumentos = "Iconos/eye.png";
            string rutaCompletaEditar = Path.Combine(Application.StartupPath, rutaEditar);
            string rutaCompletaDocumentos = Path.Combine(Application.StartupPath, rutaDocumentos);

            DataGridViewImageColumn editarButtonColumn = new DataGridViewImageColumn();
            editarButtonColumn.Image = Image.FromFile(rutaCompletaEditar);
            editarButtonColumn.HeaderText = "EDITAR";
            editarButtonColumn.Name = "Editar";
            editarButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DgvAvales.Columns.Add(editarButtonColumn);
            DgvAvales.Columns["Editar"].Width = 70;

            DataGridViewImageColumn documentosButtonColumn = new DataGridViewImageColumn();
            documentosButtonColumn.Image = Image.FromFile(rutaCompletaDocumentos);
            documentosButtonColumn.HeaderText = "DOCUMENTOS";
            documentosButtonColumn.Name = "Documentos";
            documentosButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DgvAvales.Columns.Add(documentosButtonColumn);
            DgvAvales.Columns["Documentos"].Width = 70;

            DgvAvales.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewColumn column = DgvAvales.Columns[e.ColumnIndex];
                    if (column.Name == "Editar" && (e.Value == null || e.Value == DBNull.Value))
                    {
                        e.Value = Image.FromFile(rutaCompletaEditar);
                    }
                    else if (column.Name == "Documentos" && (e.Value == null || e.Value == DBNull.Value))
                    {
                        e.Value = Image.FromFile(rutaCompletaDocumentos);
                    }
                }
            };
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregarAval_Click(object sender, EventArgs e)
        {
            Vistas.Avales.FrmAvalesRegistro registroaval = new FrmAvalesRegistro(clienteDNI);
            registroaval.ShowDialog();
            // Refresh the DataGridView after adding a new aval
            LoadAvalesData(clienteDNI);
        }

        private void LblAval_Click(object sender, EventArgs e)
        {
            // Implementation of LblAval_Click event
        }

        private void DgvAvales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string avalId = DgvAvales.Rows[e.RowIndex].Cells["DNI"].Value.ToString(); // Adjust according to your column name for the unique identifier

                if (e.ColumnIndex == DgvAvales.Columns["Editar"].Index)
                {
                    // Logic to edit the aval
                    // Retrieve other necessary fields from the row and open the edit form
                    FrmAvalesRegistro frmAvalesRegistro = new FrmAvalesRegistro(clienteDNI);
                    frmAvalesRegistro.ShowDialog();
                }
                else if (e.ColumnIndex == DgvAvales.Columns["Documentos"].Index)
                {
                    // Logic to view the documents related to the aval
                    // For example, open a new form or dialog to display documents
                    MessageBox.Show("Mostrar documentos relacionados con el aval ID: " + avalId);
                }
            }
        }
    }
}
