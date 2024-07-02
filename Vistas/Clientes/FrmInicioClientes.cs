using PROYECTO_IT_HEFESTO.Vistas.Avales;
using PROYECTO_IT_HEFESTO.Vistas.Requisitos;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PROYECTO_IT_HEFESTO.Vistas.Clientes
{
    public partial class FrmInicioClientes : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();

        public static string selectedDNI;

        public FrmInicioClientes()
        {
            InitializeComponent();
            bs.revisarInfoArchivoConfiguracion();
            CargarDatosClientes();
            AddButtonColumnsToDgvClientes();  // Call method to add button columns
        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmRegistroCliente frmRegistroCliente = new FrmRegistroCliente();
            frmRegistroCliente.Show();
        }

        private void CargarDatosClientes()
        {
            DataTable clientes = db.CargarClientes();
            DgvClientes.DataSource = clientes;
        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string dni = DgvClientes.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
                string nombreRazon = DgvClientes.Rows[e.RowIndex].Cells["NOMBRE_RAZON"].Value.ToString();

                if (e.ColumnIndex == DgvClientes.Columns["Editar"].Index)
                {
                    // Lógica para editar el cliente
                    string tipo = DgvClientes.Rows[e.RowIndex].Cells["TIPO"].Value.ToString();
                    string direccion = DgvClientes.Rows[e.RowIndex].Cells["DIRECCION"].Value.ToString();
                    string telefono = DgvClientes.Rows[e.RowIndex].Cells["TELEFONO"].Value.ToString();
                    string celular = DgvClientes.Rows[e.RowIndex].Cells["CELULAR"].Value.ToString();
                    string genero = DgvClientes.Rows[e.RowIndex].Cells["GENERO"].Value.ToString();
                    DateTime fechaNacimiento = Convert.ToDateTime(DgvClientes.Rows[e.RowIndex].Cells["FECHA_N"].Value);
                    string correo = DgvClientes.Rows[e.RowIndex].Cells["CORREO"].Value.ToString();
                    byte[] foto = (byte[])DgvClientes.Rows[e.RowIndex].Cells["FOTO"].Value;

                    // Verifica el valor de la celda 'ELIMINADO' de manera segura
                    string eliminado = "No";
                    if (DgvClientes.Rows[e.RowIndex].Cells["ELIMINADO"].Value != null)
                    {
                        string eliminadoStr = DgvClientes.Rows[e.RowIndex].Cells["ELIMINADO"].Value.ToString().ToLower();
                        if (eliminadoStr == "true" || eliminadoStr == "sí" || eliminadoStr == "si" || eliminadoStr == "1")
                        {
                            eliminado = "Sí";
                        }
                    }

                    FrmEditoCliente frmEditoCliente = new FrmEditoCliente(dni, tipo, nombreRazon, direccion, telefono, celular, genero, fechaNacimiento, correo, foto, eliminado);
                    frmEditoCliente.Show();
                }
                else if (e.ColumnIndex == DgvClientes.Columns["Ver"].Index)
                {
                    // Lógica para ver el cliente
                    selectedDNI = dni;
                    FrmAvalesInicio frmAvalesInicio = new FrmAvalesInicio(selectedDNI);
                    frmAvalesInicio.Show();
                }
                else if (e.ColumnIndex == DgvClientes.Columns["Documentos"].Index)
                {
                    FrmRequisitosInicio frmRegistroDocumento = new FrmRequisitosInicio(dni, nombreRazon);
                    frmRegistroDocumento.Show();
                }
            }
        }


        private void AddButtonColumnsToDgvClientes()
        {
            string rutaEditar = "Iconos/edit.png";
            string rutaVer = "Iconos/eye.png";
            string rutaDocumentos = "Iconos/eye.png";
            string rutaCompletaEditar = Path.Combine(Application.StartupPath, rutaEditar);
            string rutaCompletaVer = Path.Combine(Application.StartupPath, rutaVer);
            string rutaCompletaDocumentos = Path.Combine(Application.StartupPath, rutaDocumentos);

            DataGridViewImageColumn editarButtonColumn = new DataGridViewImageColumn();
            editarButtonColumn.Image = Image.FromFile(rutaCompletaEditar);
            editarButtonColumn.HeaderText = "EDITAR";
            editarButtonColumn.Name = "Editar";
            editarButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DgvClientes.Columns.Add(editarButtonColumn);
            DgvClientes.Columns["Editar"].Width = 70;

            DataGridViewImageColumn verButtonColumn = new DataGridViewImageColumn();
            verButtonColumn.Image = Image.FromFile(rutaCompletaVer);
            verButtonColumn.HeaderText = "AVALES";
            verButtonColumn.Name = "Ver";
            verButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DgvClientes.Columns.Add(verButtonColumn);
            DgvClientes.Columns["Ver"].Width = 70;

            DataGridViewImageColumn documentosButtonColumn = new DataGridViewImageColumn();
            documentosButtonColumn.Image = Image.FromFile(rutaCompletaDocumentos);
            documentosButtonColumn.HeaderText = "DOCUMENTOS";
            documentosButtonColumn.Name = "Documentos";
            documentosButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DgvClientes.Columns.Add(documentosButtonColumn);
            DgvClientes.Columns["Documentos"].Width = 70;

            DgvClientes.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewColumn column = DgvClientes.Columns[e.ColumnIndex];
                    if (column.Name == "Editar" && (e.Value == null || e.Value == DBNull.Value))
                    {
                        e.Value = Image.FromFile(rutaCompletaEditar);
                    }
                    else if (column.Name == "Ver" && (e.Value == null || e.Value == DBNull.Value))
                    {
                        e.Value = Image.FromFile(rutaCompletaVer);
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

        private void FiltrarClientes(string filtro)
        {
            DataTable dt = db.CargarClientes();
            DataView dv = dt.DefaultView;
            dv.RowFilter = $"NOMBRE_RAZON LIKE '%{filtro}%' OR DNI LIKE '%{filtro}%'";
            DgvClientes.DataSource = dv.ToTable();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = TxtBuscar.Text.Trim();
            FiltrarClientes(filtro);
        }
    }
}
