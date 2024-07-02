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

namespace PROYECTO_IT_HEFESTO.Vistas.Zonas
{
    public partial class FrmInicioZona : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();

        public FrmInicioZona()
        {
            InitializeComponent();
            bs.revisarInfoArchivoConfiguracion();
            CargarZonasEnDgv();
            AddButtonColumnsToDgvZonas();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario FrmRegistroZona
            FrmRegistroZona frmRegistroZona = new FrmRegistroZona();

            // Mostrar el formulario como una ventana modal
            frmRegistroZona.ShowDialog();

            // Recargar las zonas después de cerrar el formulario de registro
            CargarZonasEnDgv();
        }

        private void CargarZonasEnDgv()
        {
            DataTable zonasTable = db.CargarZonas();
            DgvZonas.DataSource = zonasTable;
        }

        private void DgvZonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvZonas.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                string codigo = DgvZonas.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                string zona = DgvZonas.Rows[e.RowIndex].Cells["ZONA"].Value.ToString();
                string codDepto = DgvZonas.Rows[e.RowIndex].Cells["COD_DEPTO"].Value.ToString();
                string codMunic = DgvZonas.Rows[e.RowIndex].Cells["COD_MUNIC"].Value.ToString();

                FrmEditZona frmEditoZona = new FrmEditZona(codigo, zona, codDepto, codMunic);
                frmEditoZona.ShowDialog();

                // Recargar las zonas después de cerrar el formulario de edición
                CargarZonasEnDgv();
            }
        }

        private void AddButtonColumnsToDgvZonas()
        {
            string rutaEditar = "Iconos/edit.png";
            string rutaCompletaEditar = Path.Combine(Application.StartupPath, rutaEditar);

            DataGridViewImageColumn editarButtonColumn = new DataGridViewImageColumn();
            editarButtonColumn.Image = Image.FromFile(rutaCompletaEditar);
            editarButtonColumn.HeaderText = "";
            editarButtonColumn.Name = "Editar";
            editarButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DgvZonas.Columns.Add(editarButtonColumn);
            DgvZonas.Columns["Editar"].Width = 30;

            DgvZonas.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewColumn column = DgvZonas.Columns[e.ColumnIndex];
                    if (column.Name == "Editar")
                    {
                        if (e.Value == null || e.Value == DBNull.Value)
                        {
                            e.Value = Image.FromFile(rutaCompletaEditar);
                        }
                    }
                }
            };
        }
    }
}
