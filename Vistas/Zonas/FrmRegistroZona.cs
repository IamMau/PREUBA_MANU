using PROYECTO_IT_HEFESTO.Clases;
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
    public partial class FrmRegistroZona : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();

        public FrmRegistroZona()
        {
            InitializeComponent();
            bs.revisarInfoArchivoConfiguracion();
            LoadDepartamentos();
            CmbMunic.Enabled = false; // Deshabilita el ComboBox de municipios inicialmente
            CmbDep.SelectedIndexChanged += CmbDep_SelectedIndexChanged; // Agrega el manejador de eventos
            CmbMunic.SelectedIndexChanged += CmbMunic_SelectedIndexChanged; // Agrega el manejador de eventos
        }

        private void LoadDepartamentos()
        {
            DataTable departamentos = db.CargarDepartamentos();
            CmbDep.DataSource = departamentos;
            CmbDep.DisplayMember = "DEPARTAMENTO"; // Nombre de la columna a mostrar
            CmbDep.ValueMember = "CODIGO"; // Valor de la columna
        }

        private void CmbDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbDep.SelectedValue != null)
            {
                string selectedDepto = CmbDep.SelectedValue.ToString();
                LoadMunicipios(selectedDepto);
                CmbMunic.Enabled = true; // Habilita el ComboBox de municipios
            }
            UpdateZonaCode();
        }

        private void CmbMunic_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateZonaCode();
        }

        private void LoadMunicipios(string codDepto)
        {
            DataTable municipios = db.CargarMunicipiosPorDepartamento(codDepto);
            CmbMunic.DataSource = municipios;
            CmbMunic.DisplayMember = "MUNICIPIO"; // Nombre de la columna a mostrar
            CmbMunic.ValueMember = "CODIGO"; // Valor de la columna
        }

        private void UpdateZonaCode()
        {
            if (CmbDep.SelectedValue != null && CmbMunic.SelectedValue != null)
            {
                string depCode = CmbDep.SelectedValue.ToString();
                string municCode = CmbMunic.SelectedValue.ToString();
                string zonaCode = GenerateZonaCode(depCode, municCode);
               
            }
        }

        private string GenerateZonaCode(string depCode, string municCode)
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(1000, 9999); // Genera un número aleatorio de 4 dígitos
            return depCode + municCode + randomNum.ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string zona, depto, munic;

            
            zona = TxtZona.Text;
            depto = CmbDep.SelectedValue.ToString(); // Obtiene el ID seleccionado del departamento
            munic = CmbMunic.SelectedValue.ToString(); // Obtiene el ID seleccionado del municipio

            string campos = "ZONA, COD_DEPTO, COD_MUNIC";
            string valores = $"'{zona}', '{depto}', '{munic}'";

            db.Save("ZONAS", campos, valores);
            //ACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACA ACA ACA ACAACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA
            string logs = "USUARIO, ACCION, TABLA, DETALLE";
            string vallogs = $"'{Session.CurrentUser}','REGISTRAR', 'ZONAS', 'REGISTRO UNA NUEVA ZONA EN LA TABLA'";
            db.Save("REGISTROSDEACCIONES", logs, vallogs);
            //ACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACA ACA ACA ACAACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA
        }

        private void FrmRegistroZona_Load(object sender, EventArgs e)
        {

        }
    }
}
