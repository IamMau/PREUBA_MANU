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
using static PROYECTO_IT_HEFESTO.Clases.DB;

namespace PROYECTO_IT_HEFESTO.Vistas.Ususarios
{
    public partial class FrmUsuarios : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();
        public FrmUsuarios()
        {
            InitializeComponent();
            bs.revisarInfoArchivoConfiguracion();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            LoadRoles();
        }

        private void LoadRoles()
        {
            List<Role> roles = db.GetRoles();

            // Crear un objeto Role en blanco
            Role emptyRole = new Role { Id = "0", Name = "" };

            // Insertar el objeto Role en blanco al inicio de la lista
            roles.Insert(0, emptyRole);

            CmbRol.DisplayMember = "Name";
            CmbRol.ValueMember = "Id";
            CmbRol.DataSource = roles;

            // Establecer el objeto Role en blanco como seleccionado
            CmbRol.SelectedIndex = 0;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre, fechan, genero, correo, username, clave, rolId;

            nombre = TxtNombre.Text;
            fechan = DtpNac.Value.ToString("yyyy-MM-dd"); // Formatear la fecha según sea necesario
            genero = CmbGenero.SelectedItem?.ToString(); // Obtener el texto del ítem seleccionado
            correo = TxtCorreo.Text;
            username = TxtUsername.Text;
            clave = TxtClave.Text;
            rolId = CmbRol.SelectedValue.ToString(); // Obtener el ID del rol seleccionado

            if (rolId == "0")
            {
                MessageBox.Show("Por favor, seleccione un rol válido.");
                return;
            }

            // Hash the password using BCrypt
            string hashedClave = BCrypt.Net.BCrypt.HashPassword(clave);

            string campos = "USUARIO, CLAVE, NOMBRE, GENERO, FECHA_N, CORREO, ROL_ID";
            string valores = $"'{username}','{hashedClave}','{nombre}','{genero}','{fechan}','{correo}','{rolId}'";

            // Asumiendo que tienes un método en tu clase DB para insertar valores
            bool isSaved = db.Save("Usuarios", campos, valores);

            if (isSaved)
            {
                string logs = "USUARIO, ACCION, TABLA, DETALLE";
                string vallogs = $"'{Session.CurrentUser}','REGISTRAR', 'USUARIOS', 'REGISTRO UN NUEVO USUARIO EN LA TABLA'";
                db.Saves("REGISTROSDEACCIONES", logs, vallogs );
                MessageBox.Show("Usuario registrado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario.");
            }
        }





    }
}
