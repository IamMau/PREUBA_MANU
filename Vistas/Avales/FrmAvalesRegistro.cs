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

namespace PROYECTO_IT_HEFESTO.Vistas.Avales
{
    public partial class FrmAvalesRegistro : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();

        private string clienteDNI;

        // Constructor that accepts a string parameter
        public FrmAvalesRegistro(string dni)
        {
            InitializeComponent();
            bs.revisarInfoArchivoConfiguracion();
            clienteDNI = dni;
        }

        private void FrmAvalesRegistro_Load(object sender, EventArgs e)
        {
            CargarGenerosEnComboBox();
            TxtDniCliente.Text = clienteDNI; // Set the TxtDniCliente text to the passed DNI
        }

        private void CargarGenerosEnComboBox()
        {
            DataTable generos = db.CargarGeneros();
            CmbGenero.DataSource = generos;
            CmbGenero.DisplayMember = "GENERO";
            CmbGenero.ValueMember = "ID";
            CmbGenero.SelectedIndex = -1;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string dni, nombre, apellidos, direccion, telefono, genero, fechan, correo, cliente;

            dni = TxtDni.Text;
            nombre = TxtNombre.Text;
            apellidos = TxtApellido.Text;
            direccion = TxtDireccion.Text;
            telefono = TxtTelefono.Text;
            genero = CmbGenero.SelectedValue.ToString();  // Get the selected value from ComboBox
            fechan = DtpFn.Value.ToString("yyyy-MM-dd");  // Get the date in the desired format
            correo = TxtCorreo.Text;
            cliente = TxtDniCliente.Text;

            // Construct the fields and values strings
            string campos = "DNI, NOMBRE, APELLIDOS, DIRECCION, TELEFONO, GENERO, FECHA_N, CORREO, DNI_CLIENTE";
            string valores = $"'{dni}', '{nombre}', '{apellidos}', '{direccion}', '{telefono}', '{genero}', '{fechan}', '{correo}', '{cliente}'";

            // Assuming db is an instance of your database handler class
            if (db.Save("AVALES", campos, valores))
            {
                //ACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACA ACA ACA ACAACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA
                string logs = "USUARIO, ACCION, TABLA, DETALLE";
                string vallogs = $"'{Session.CurrentUser}','REGISTRAR', 'AVALES', 'REGISTRO UN NUEVO AVAL EN LA TABLA'";
                //ACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACAACA ACA ACA ACA ACA ACAACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA ACA
                db.Saves("REGISTROSDEACCIONES", logs, vallogs);
                MessageBox.Show("Datos guardados correctamente.");

            }
            else
            {
                MessageBox.Show("Error al guardar los datos.");
            }
        }


    }
}
