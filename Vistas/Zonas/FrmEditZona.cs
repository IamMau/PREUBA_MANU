using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_IT_HEFESTO.Vistas.Zonas
{
    public partial class FrmEditZona : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();

        private string codigo;
        private string zona;
        private string codDepto;
        private string codMunic;

        public FrmEditZona(string codigo, string zona, string codDepto, string codMunic)
        {
            InitializeComponent();
            bs.revisarInfoArchivoConfiguracion();

            // Guardar los parámetros en variables de instancia
            this.codigo = codigo;
            this.zona = zona;
            this.codDepto = codDepto;
            this.codMunic = codMunic;
        }

        private void FrmEditZona_Load(object sender, EventArgs e)
        {
            // Llamar al método para cargar los datos en los controles
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Llenar el ComboBox de departamentos
            CargarDepartamentos();

            // Establecer los valores de los campos
            TxtZona.Text = zona;
            CmbDep.SelectedValue = codDepto;
            // Llamar al método para cargar municipios
            CargarMunicipiosPorDepartamento(codDepto);
            CmbMunic.SelectedValue = codMunic;
        }

        private void CargarDepartamentos()
        {
            // Obtener la lista de departamentos desde la base de datos
            DataTable departamentosTable = db.CargarDepartamentos();

            // Establecer el origen de datos del ComboBox
            CmbDep.DataSource = departamentosTable;
            CmbDep.DisplayMember = "DEPARTAMENTO"; // Cambia esto por el nombre de la columna correspondiente
            CmbDep.ValueMember = "CODIGO";   // Cambia esto por el nombre de la columna correspondiente

            // Vincular el evento SelectedIndexChanged
            CmbDep.SelectedIndexChanged += CmbDep_SelectedIndexChanged;
        }

        private void CargarMunicipiosPorDepartamento(string codDepto)
        {
            // Obtener la lista de municipios por departamento desde la base de datos
            DataTable municipiosTable = db.CargarMunicipiosPorDepartamento(codDepto);

            // Establecer el origen de datos del ComboBox
            CmbMunic.DataSource = municipiosTable;
            CmbMunic.DisplayMember = "MUNICIPIO"; // Cambia esto por el nombre de la columna correspondiente
            CmbMunic.ValueMember = "CODIGO";   // Cambia esto por el nombre de la columna correspondiente
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbDep.SelectedValue != null && CmbDep.SelectedValue.ToString() != "")
            {
                string selectedDepto = CmbDep.SelectedValue.ToString();
                CargarMunicipiosPorDepartamento(selectedDepto);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            // Obtener los valores actualizados de los controles
            string nuevaZona = TxtZona.Text;
            string nuevoCodDepto = CmbDep.SelectedValue.ToString();
            string nuevoCodMunic = CmbMunic.SelectedValue.ToString();

            // Actualizar los datos en la base de datos
            bool actualizado = db.ActualizarZona(codigo, nuevaZona, nuevoCodDepto, nuevoCodMunic);

            // Mostrar un mensaje de confirmación y recargar los datos si la actualización fue exitosa
            if (actualizado)
            {
                MessageBox.Show("Los datos se han actualizado correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Hubo un problema al actualizar los datos.", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
