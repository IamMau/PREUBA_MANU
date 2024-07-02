using System;
using System.Windows.Forms;

namespace PROYECTO_IT_HEFESTO.Vistas.Ususarios
{
    public partial class FrmUsuariosEditar : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();

        private string username;
        private string password;
        private string name;
        private string gender;
        private string birthDate;
        private string email;
        private string roleName;

        public FrmUsuariosEditar(string username, string password, string name, string gender, string birthDate, string email, string roleName)
        {
            InitializeComponent();
            bs.revisarInfoArchivoConfiguracion();

            this.username = username;
            this.password = password;
            this.name = name;
            this.gender = gender;
            this.birthDate = birthDate;
            this.email = email;
            this.roleName = roleName;
        }

        private void FrmUsuariosEditar_Load(object sender, EventArgs e)
        {
            TxtUsername.Text = username;
            TxtClave.Text = password; // Muestra la contraseña en texto claro
            TxtNombre.Text = name;
            CmbGenero.Text = gender;
            DtpNac.Value = DateTime.Parse(birthDate);
            TxtCorreo.Text = email;
            CmbRol.Text = roleName;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
