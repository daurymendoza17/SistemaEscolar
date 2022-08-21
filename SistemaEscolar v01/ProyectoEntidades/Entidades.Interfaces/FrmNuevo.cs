using Entidades.Capas.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades.Interfaces
{
    public partial class FrmNuevo : Form
    {
        clsLnEntidades Data = new clsLnEntidades();
        clsBeEntidades entidad = new clsBeEntidades();
        public bool update = false;
        public FrmNuevo()
        {
            InitializeComponent();
            LoadSelectCB();
        }

        public void LoadSelectCB()
        {
            comboTipo.SelectedIndex = 0;
            comboDocumento.SelectedIndex = 0;
            comboRol.SelectedIndex = 0;
            comboStatus.SelectedIndex = 0;
            comboEliminable.SelectedIndex = 1;



        }

        private void FrmNuevo_Load(object sender, EventArgs e)
        {
  
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (update ==false) {
                entidad.Descripcion = txtDescripcion.Text;
                entidad.Direccion = txtDireccion.Text;
                entidad.Localidad = txtLocalidad.Text;
                entidad.TipoEntidad = comboTipo.Text;
                entidad.TipoDocumento = comboDocumento.Text;
                entidad.NumeroDocumento = Convert.ToInt32(txtDocumento.Text);
                entidad.Telefonos = Convert.ToString(txtTelefono.Text);
                entidad.URLPaginaWeb = txtURLWeb.Text;
                entidad.URLFacebook = txtURLFace.Text;
                entidad.URLInstagram = txtURLIg.Text;
                entidad.URLTwitter = txtURLTwitter.Text;
                entidad.URLTikTok = txtURLTiktok.Text;
                entidad.CodigoPostal = txtPostal.Text;
                entidad.CoordenadasGPS = txtCoordenadas.Text;
                entidad.LimiteCredito = Convert.ToInt32(txtCredito.Text);
                entidad.UserNameEntidad = txtUserName.Text;
                entidad.PasswordEntidad = txtPassword.Text;
                entidad.RolUserEntidad = comboRol.Text;
                entidad.Comentario = txtComentario.Text;
                entidad.Staatus = comboStatus.Text;
                entidad.NoEliminable = Convert.ToBoolean(comboEliminable.Text);
                entidad.FechaRegistro = dateTime.Value;


                Data.Insertar(ref entidad);
                MessageBox.Show("Entidad Guardada!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            if (update == true)
            {
                entidad.IdEntidad = Convert.ToInt32(txtEntidad.Text);
                entidad.Descripcion = txtDescripcion.Text;
                entidad.Direccion = txtDireccion.Text;
                entidad.Localidad = txtLocalidad.Text;
                entidad.TipoEntidad = comboTipo.Text;
                entidad.TipoDocumento = comboDocumento.Text;
                entidad.NumeroDocumento = Convert.ToInt32(txtDocumento.Text);
                entidad.Telefonos = Convert.ToString(txtTelefono.Text);
                entidad.URLPaginaWeb = txtURLWeb.Text;
                entidad.URLFacebook = txtURLFace.Text;
                entidad.URLInstagram = txtURLIg.Text;
                entidad.URLTwitter = txtURLTwitter.Text;
                entidad.URLTikTok = txtURLTiktok.Text;
                entidad.CodigoPostal = txtPostal.Text;
                entidad.CoordenadasGPS = txtCoordenadas.Text;
                entidad.LimiteCredito = Convert.ToInt32(txtCredito.Text);
                entidad.UserNameEntidad = txtUserName.Text;
                entidad.PasswordEntidad = txtPassword.Text;
                entidad.RolUserEntidad = comboRol.Text;
                entidad.Comentario = txtComentario.Text;
                entidad.Staatus = comboStatus.Text;
                entidad.NoEliminable = Convert.ToBoolean(comboEliminable.Text);
                entidad.FechaRegistro = dateTime.Value;


                Data.Actualizar(ref entidad);
                MessageBox.Show("Entidad Actualizada!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                update = false;
            }

        }
    }
}
