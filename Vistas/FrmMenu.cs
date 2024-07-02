using PROYECTO_IT_HEFESTO.Vistas.Clientes;
using PROYECTO_IT_HEFESTO.Vistas.Financiera;
using PROYECTO_IT_HEFESTO.Vistas.Servidores;
using PROYECTO_IT_HEFESTO.Vistas.Ususarios;
using PROYECTO_IT_HEFESTO.Vistas.Zonas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_IT_HEFESTO.Vistas
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnFinanciera_Click(object sender, EventArgs e)
        {
           FrmFinanciera frmFinanciera = new FrmFinanciera();
            frmFinanciera.ShowDialog();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            FrmInicioClientes frmInicioClientes = new FrmInicioClientes();
            frmInicioClientes.Show();
        }

        private void BtnZona_Click(object sender, EventArgs e)
        {
            FrmInicioZona frmInicioZona = new FrmInicioZona();
            frmInicioZona.Show();
        }

        private void BtnServeidores_Click(object sender, EventArgs e)
        {
            FrmServer frmInicioZona = new FrmServer();
            frmInicioZona.Show();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm= new FrmUsuarios();
            frm.Show();
        }
    }
}
