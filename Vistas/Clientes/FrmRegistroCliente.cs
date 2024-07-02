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

namespace PROYECTO_IT_HEFESTO.Vistas.Clientes
{
    public partial class FrmRegistroCliente : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();
        public FrmRegistroCliente()
        {
            InitializeComponent();
            bs.revisarInfoArchivoConfiguracion();
            CargarTiposEnComboBox();
            CargarGenerosEnComboBox();
        }

        private void CargarGenerosEnComboBox()
        {
            DataTable generos = db.CargarGeneros();
            CmbGenero.DataSource = generos;
            CmbGenero.DisplayMember = "GENERO";
            CmbGenero.ValueMember = "ID";
            CmbGenero.SelectedIndex = -1;
        }

        private void CargarTiposEnComboBox()
        {
            DataTable tipos = db.CargarTipos();
            CmbTipo.DataSource = tipos;
            CmbTipo.DisplayMember = "NOMBRE_DOCUMENTO";
            CmbTipo.ValueMember = "ID";
            CmbTipo.SelectedIndex = -1;
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Select an Image";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = ofd.FileName;
                    PcCliente.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        //hoy 15/06/2024
        private bool VerificarDniExistente(string dni, out string nombreRazon, out string dniExistente)
        {
            nombreRazon = string.Empty;
            dniExistente = string.Empty;
            string query = $"SELECT DNI, NOMBRE_RAZON FROM CLIENTES WHERE DNI = '{dni}'";
            DataTable result = db.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                dniExistente = result.Rows[0]["DNI"].ToString();
                nombreRazon = result.Rows[0]["NOMBRE_RAZON"].ToString();
                return true;
            }
            return false;
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string dni, tipo, nombreRazon, direccion, telefono, celular, genero, correo;
            DateTime fechaNacimiento;

            dni = TxtDni.Text;
            tipo = CmbTipo.SelectedValue.ToString(); // Obtener el ID del tipo
            nombreRazon = TxtNr.Text;
            direccion = TxtDireccion.Text;
            telefono = TxtTelefono.Text;
            celular = TxtCelular.Text;
            genero = CmbGenero.SelectedValue.ToString(); // Obtener el ID del género
            fechaNacimiento = DtpFn.Value;
            correo = TxtCorreo.Text;

            // Verificar si el DNI ya existe
            if (VerificarDniExistente(dni, out string nombreExistente, out string dniExistente))
            {
                MessageBox.Show($"El DNI {dniExistente} ya existe y pertenece a: {nombreExistente}", "DNI Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] foto = null;

            if (PcCliente.Image != null)
            {
                foto = db.ImageToByteArray(PcCliente.Image);
            }

            string campos = "DNI, TIPO, NOMBRE_RAZON, DIRECCION, TELEFONO, CELULAR, GENERO, FECHA_N, CORREO, FOTO";
            string valores = $"'{dni}', '{tipo}', '{nombreRazon}', '{direccion}', '{telefono}', '{celular}', '{genero}', '{fechaNacimiento:yyyy-MM-dd}', '{correo}', @FOTO";

            if (db.Saves("CLIENTES", campos, valores, foto))
            {
                MessageBox.Show("Datos guardados correctamente.");
                //ACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACA ACA ACA ACAACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA
                string logs = "USUARIO, ACCION, TABLA, DETALLE";
                string vallogs = $"'{Session.CurrentUser}','REGISTRAR', 'CLIENTES', 'REGISTRO UN NUEVO CLIENTE EN LA TABLA'";
                //ACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACA ACA ACA ACAACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA
                db.Saves("REGISTROSDEACCIONES", logs, vallogs);
            }
            else
            {
                MessageBox.Show("Error al guardar los datos.");
            }

            LimpiarCampos();
        }


        private void LimpiarCampos()
        {
            TxtDni.Clear();
            CmbTipo.SelectedIndex = -1;
            TxtNr.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtCelular.Clear();
            CmbGenero.SelectedIndex = -1;
            DtpFn.Value = DateTime.Today;
            TxtCorreo.Clear();
            PcCliente.Image = null;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRegistroCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
