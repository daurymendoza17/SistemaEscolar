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
    public partial class FrmEntidades : Form
    {

        clsBeEntidades entidad = new clsBeEntidades();
        clsLnEntidades Data = new clsLnEntidades();
        public FrmEntidades()
        {
            InitializeComponent();
            ListarEntidad();
        }

        public void ListarEntidad()
        {
            var data = new clsLnEntidades();
            Table.DataSource = data.Listar();


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var FrmNuevo = new FrmNuevo();
            FrmNuevo.update = false;
            FrmNuevo.ShowDialog();
            ListarEntidad();
        }

        private void FrmEntidades_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var FrmNuevo = new FrmNuevo();

            if (Table.SelectedRows.Count > 0)
            {
                FrmNuevo.update = true;
                FrmNuevo.label1.Text = "Editar Entidad";
                FrmNuevo.txtEntidad.Text = Table.CurrentRow.Cells[0].Value.ToString();
                FrmNuevo.txtDescripcion.Text = Table.CurrentRow.Cells[1].Value.ToString();
                FrmNuevo.txtDireccion.Text = Table.CurrentRow.Cells[2].Value.ToString();
                FrmNuevo.txtLocalidad.Text = Table.CurrentRow.Cells[3].Value.ToString();
                FrmNuevo.comboTipo.Text = Table.CurrentRow.Cells[4].Value.ToString();
                FrmNuevo.comboDocumento.Text = Table.CurrentRow.Cells[5].Value.ToString();
                FrmNuevo.txtDocumento.Text = Table.CurrentRow.Cells[6].Value.ToString();
                FrmNuevo.txtTelefono.Text = Table.CurrentRow.Cells[7].Value.ToString();
                FrmNuevo.txtURLWeb.Text = Table.CurrentRow.Cells[8].Value.ToString();
                FrmNuevo.txtURLFace.Text = Table.CurrentRow.Cells[9].Value.ToString();
                FrmNuevo.txtURLIg.Text = Table.CurrentRow.Cells[10].Value.ToString();
                FrmNuevo.txtURLTwitter.Text = Table.CurrentRow.Cells[11].Value.ToString();
                FrmNuevo.txtURLTiktok.Text = Table.CurrentRow.Cells[12].Value.ToString();
                FrmNuevo.txtPostal.Text = Table.CurrentRow.Cells[13].Value.ToString();
                FrmNuevo.txtCoordenadas.Text = Table.CurrentRow.Cells[14].Value.ToString();
                FrmNuevo.txtCredito.Text = Table.CurrentRow.Cells[15].Value.ToString();
                FrmNuevo.txtUserName.Text = Table.CurrentRow.Cells[16].Value.ToString();
                FrmNuevo.txtPassword.Text = Table.CurrentRow.Cells[17].Value.ToString();
                FrmNuevo.comboRol.Text = Table.CurrentRow.Cells[18].Value.ToString();
                FrmNuevo.txtComentario.Text = Table.CurrentRow.Cells[19].Value.ToString();
                FrmNuevo.comboStatus.Text = Table.CurrentRow.Cells[20].Value.ToString();
                FrmNuevo.comboEliminable.Text = Table.CurrentRow.Cells[21].Value.ToString();
                FrmNuevo.dateTime.Text = Table.CurrentRow.Cells[22].Value.ToString();

                FrmNuevo.ShowDialog();
                ListarEntidad();
            }
            else
            {
                MessageBox.Show("Selecciona una fila!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Table.SelectedRows.Count > 0)
            {

                if (MessageBox.Show("Vas a eliminar la entidad!?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    entidad.IdEntidad = Convert.ToInt32(Table.CurrentRow.Cells[0].Value.ToString());
                    Data.Eliminar(ref entidad);
                    MessageBox.Show("Entidad eliminada!");
                    ListarEntidad();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila a eliminar!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
        public void ObtenerEntidades(string IdEntidad) {
            entidad.IdEntidad = Convert.ToInt32(IdEntidad);
           Table.DataSource = Data.ObtenerEntidad(ref entidad);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
            {
               if (textBox1.Text != "")
            {
                ObtenerEntidades(textBox1.Text);

            }  else {
                ListarEntidad();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
} 