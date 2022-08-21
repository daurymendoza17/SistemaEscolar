using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Capas.Data.Model;

namespace Entidades.Interfaces
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            clsBeEntidades entidadesModel = new clsBeEntidades();
            clsLnEntidades entidadln = new clsLnEntidades();

            entidadesModel.UserNameEntidad = txtUser.Text;
            entidadesModel.PasswordEntidad = txtPass.Text;

            if(entidadln.Obtener(ref entidadesModel))
            {
                FrmMDIPrincipal menu = new FrmMDIPrincipal();
                menu.Show();
                this.Hide();




            } else
            {
                MessageBox.Show("Credenciales Incorrectas");
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Close();
        }
    }
}
