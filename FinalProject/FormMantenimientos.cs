using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Layers.Framework.ADO.Net.Data;
using Layers.Framework.ADO.Net.Data.Modelos;

namespace FinalProject
{
    public partial class FormMantenimientos : Form
    {
        EntidadesForm entidadesForm; 
        public FormMantenimientos()
        {
            InitializeComponent();
            entidadesForm = new EntidadesForm();
        }
        #region Eventos
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            entidadesForm.Show();
            this.Close();
        }
        private void comboBoxTipoEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            ADDEntidad();
        }
        #endregion

        #region Metodos
        private void ADDEntidad()
        {
            clsLnTablaEntidades data = new clsLnTablaEntidades();
            clsBeTablaEntidades enti = new clsBeTablaEntidades();
            enti.Descripcion = textBoxDescripcion.Text;

            enti.DIRECCION = textBoxDireccion.Text;
            enti.Localidad = textBoxLocalidad.Text;
            enti.TipoEntidad = comboBoxTipoEntidad.Text;
            enti.TipoDocumento = comboBoxTipoDocumento.Text;
            enti.URLFACEBOOK = textBoxUrlFacebook.Text;
            /*enti.URLINSTAGRAM = textBoxUrlFacebook.Text;
            enti.URLPAaginaWeb = textBoxUrlFacebook.Text;
            enti.URLTIKTOK = textBoxUrlFacebook.Text;
            enti.URLTWITTER = textBoxUrlFacebook.Text;*/
            enti.UserNameEntidad = textBoxUserName.Text;
            enti.RolUserEntidad = comboBoxRol.Text;
            enti.Statues = comboBoxStatus.Text;
            enti.NumeroDocumento = Convert.ToDouble(textBox9.Text);
            enti.Telefonos = textBox10.Text;
            enti.PassworEntidad = textBox11.Text;
            /*
            enti.LimiteCredito = 9;
            enti.NoEliminable = true;
            enti.IdGrupoEntidad = 1;
            enti.IdTipoEntidad = 1;
            */
            bool result = data.Insertar(ref enti);

            if(result == true)
            {
                MessageBox.Show("Entidad agregada con exito", "Notificacion");
                entidadesForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("La Entidad no pudo ser agregada", "Aviso");
            }
        }

    }
    #endregion
}
