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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace PROYECTO_IT_HEFESTO.Vistas.Auth
{
    public partial class FrmLogin : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();
        Clases.Configuracion c=new Clases.Configuracion();
       

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            bs.revisarArchivosConfig();
            bs.revisarInfoArchivoConfiguracion();
            c.checkInfoConfiguracion();
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUser.Text;
            string password = TxtPass.Text;

            if (string.IsNullOrWhiteSpace(TxtUser.Text) || string.IsNullOrWhiteSpace(TxtPass.Text))
            {
                MessageBox.Show("Por favor ingrese un usuario y contraseña válidos.");
                return;
            }

            if (db.CheckCredentials(TxtUser.Text, TxtPass.Text))
            {
                // Asignar el usuario autenticado a la sesión actual
                Session.CurrentUser = username;

                // Registrar la consulta de inicio de sesión
                RegistrarQuery("User Login");

                // Recuperar la última consulta ejecutada
                string queryExecuted = db.GetLastExecutedQuery();
                string valogs = "USUARIO, ACCION, TABLA, DETALLE";
                string detal = $"'{username}', 'ENTRAR', 'USUARIOS', 'EL USUARIO {username} INICIO SESION - QUERY: {queryExecuted}'";
                db.Saves("REGISTROSDEACCIONES", valogs, detal);

                // Mostrar el menú principal
                Vistas.FrmMenu menu = new Vistas.FrmMenu();
                menu.Show(this);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void RegistrarQuery(string query)
        {
            string usuario = Session.CurrentUser;
            string columnas = "USUARIO, QUERY, REGISTRO";
            string valores = $"'{usuario}', '{query.Replace("'", "''")}', GETDATE()";

            string logQuery = $"INSERT INTO LOGQUERYS ({columnas}) VALUES ({valores})";

            db.rawSQL(logQuery); // Asegúrate de que este método esté definido en tu clase DB
        }



    }
}
