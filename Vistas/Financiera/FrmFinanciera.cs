using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_IT_HEFESTO.Vistas.Financiera
{
    public partial class FrmFinanciera : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();
        public FrmFinanciera()
        {
            InitializeComponent();
            bs.revisarInfoArchivoConfiguracion();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string rtn, nombre, direccion, telefono, correo, wedsite;

            rtn = TxtRtn.Text;
            nombre = TxtNos.Text;
            direccion = TxtDireccion.Text;
            telefono = TxtTelefono.Text;
            correo = TxtCorreo.Text;
            wedsite = TxtWedsite.Text;

            byte[] logo1 = null;
            byte[] logo2 = null;

            if (PcLogo1.Image != null)
            {
                logo1 = db.ImageToByteArray(PcLogo1.Image);
            }

            if (PcLogo2.Image != null)
            {
                logo2 = db.ImageToByteArray(PcLogo2.Image);
            }

            string campos = "RTN, NOMBRERAZON_SOCIAL, DIRECCION, TELEFONOS, CORREO, WEBSITE, LOGO1, LOGO2";
            string valores = $"'{rtn}','{nombre}','{direccion}','{telefono}','{correo}','{wedsite}', @LOGO1, @LOGO2";

            db.Save("FINANCIERA", campos, valores, logo1, logo2);
        }


        private void BtnLogo1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Select an Image";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = ofd.FileName;
                    PcLogo1.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void BtnLogo2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Select an Image";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = ofd.FileName;
                    PcLogo2.Image = Image.FromFile(selectedImagePath);
                }
            }
        }
    }
}
