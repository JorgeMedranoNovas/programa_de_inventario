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


namespace FinalProject
{
    public partial class TipoEntidad : Form
    {
        public TipoEntidad()
        {
            InitializeComponent();
            ListarEntidades();
        }
        public void ListarEntidades()
        {
            var data = new clsLnTablaEntidades();
            dataGridView1.DataSource = data.Listar();
        }


            private void buttonCrear_Click(object sender, EventArgs e)
        {
            FormMantTipoEntidad mantTipoEntidad = new FormMantTipoEntidad();
            mantTipoEntidad.Show();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            FormMantTipoEntidad mantTipoEntidad = new FormMantTipoEntidad();
            mantTipoEntidad.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
