using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using PROYECTO_IT_HEFESTO.Clases;

namespace PROYECTO_IT_HEFESTO.Vistas.Clientes
{
    public partial class FrmEditoCliente : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();

        public FrmEditoCliente()
        {
            InitializeComponent();
            bs.revisarInfoArchivoConfiguracion();
            BtnActualizar.Click += BtnActualizar_Click;
            BtnSeleccionarImagen.Click += BtnSeleccionarImagen_Click;
        }

        private string dni;
        private string tipo;
        private string nombreRazon;
        private string direccion;
        private string telefono;
        private string celular;
        private string genero;
        private DateTime fechaNacimiento;
        private string correo;
        private byte[] foto;
        private string eliminado;

        public FrmEditoCliente(string dni, string tipo, string nombreRazon, string direccion, string telefono,
                               string celular, string genero, DateTime fechaNacimiento, string correo,
                               byte[] foto, string eliminado)
        {
            InitializeComponent();

            this.dni = dni;
            this.tipo = tipo;
            this.nombreRazon = nombreRazon;
            this.direccion = direccion;
            this.telefono = telefono;
            this.celular = celular;
            this.genero = genero;
            this.fechaNacimiento = fechaNacimiento;
            this.correo = correo;
            this.foto = foto;
            this.eliminado = eliminado;

            CargarDatosCliente();
        }

        private void CargarDatosCliente()
        {
            TxtDni.Text = dni;
            CmbTipo.SelectedItem = tipo;
            TxtNr.Text = nombreRazon;
            TxtDireccion.Text = direccion;
            TxtTelefono.Text = telefono;
            TxtCelular.Text = celular;
            CmbGenero.SelectedItem = genero;
            DtpFn.Value = fechaNacimiento;
            TxtCorreo.Text = correo;
            if (foto != null)
            {
                using (MemoryStream ms = new MemoryStream(foto))
                {
                    PcCliente.Image = Image.FromStream(ms);
                }
            }
            TxtEliminado.Text = eliminado;
        }

        private void FrmEditoCliente_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox de Tipo
            DataTable tipos = db.CargarTipos();
            CmbTipo.DataSource = tipos;
            CmbTipo.DisplayMember = "NOMBRE_DOCUMENTO";
            CmbTipo.ValueMember = "ID";

            // Llenar el ComboBox de Género
            DataTable generos = db.CargarGeneros();
            CmbGenero.DataSource = generos;
            CmbGenero.DisplayMember = "GENERO";
            CmbGenero.ValueMember = "ID";

            // Seleccionar el valor correspondiente
            CmbTipo.SelectedValue = tipo;
            CmbGenero.SelectedValue = genero;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string dni = TxtDni.Text;
            string tipo = CmbTipo.SelectedValue.ToString();
            string nombreRazon = TxtNr.Text;
            string direccion = TxtDireccion.Text;
            string telefono = TxtTelefono.Text;
            string celular = TxtCelular.Text;
            string genero = CmbGenero.SelectedValue.ToString();
            DateTime fechaNacimiento = DtpFn.Value;
            string correo = TxtCorreo.Text;
            string eliminado = TxtEliminado.Text;

            byte[] foto = null;
            if (PcCliente.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    PcCliente.Image.Save(ms, PcCliente.Image.RawFormat);
                    foto = ms.ToArray();
                }
            }

            bool actualizado = db.ActualizarCliente(dni, tipo, nombreRazon, direccion, telefono, celular, genero, fechaNacimiento, correo, foto, eliminado);

            if (actualizado)
            {
                MessageBox.Show("Cliente actualizado exitosamente.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    PcCliente.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void TxtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
