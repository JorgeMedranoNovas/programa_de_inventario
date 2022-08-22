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
    public partial class FormMantTipoEntidad : Form
    {

        public FormMantTipoEntidad()
        {
            InitializeComponent();
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            clsBeTiposEntidades enti = new clsBeTiposEntidades();
            clsLnTiposEntidades datos = new clsLnTiposEntidades();
            enti.Comentario = textBoxComentarios.Text;
            enti.Statues = comboBoxStatus.Text;

            datos.Insertar(ref enti);
            

        }
    }
}
