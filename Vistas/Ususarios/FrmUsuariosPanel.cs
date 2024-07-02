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

namespace PROYECTO_IT_HEFESTO.Vistas.Ususarios
{
    public partial class FrmUsuariosPanel : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();
        public FrmUsuariosPanel()
        {
            InitializeComponent();
            bs.revisarInfoArchivoConfiguracion();
            AddButtonColumnsToDgvUsuarios();
            
        }

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvUsuarios.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show("Botón de Editar clickeado en la fila " + e.RowIndex);
            }
        }

        private void AddButtonColumnsToDgvUsuarios()
        {
            string rutaEditar = "Iconos/edit.png";
            string rutaCompletaEditar = Path.Combine(Application.StartupPath, rutaEditar);

            DataGridViewImageColumn editarButtonColumn = new DataGridViewImageColumn();
            editarButtonColumn.Image = Image.FromFile(rutaCompletaEditar);
            editarButtonColumn.HeaderText = "";
            editarButtonColumn.Name = "Editar";
            editarButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DgvUsuarios.Columns.Add(editarButtonColumn);
            DgvUsuarios.Columns["Editar"].Width = 30;

            DgvUsuarios.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewColumn column = DgvUsuarios.Columns[e.ColumnIndex];
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