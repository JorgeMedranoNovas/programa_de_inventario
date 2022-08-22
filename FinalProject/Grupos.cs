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
    
    public partial class Grupos : Form
    {
        clsLnGruposEntidades data = new clsLnGruposEntidades();
        public Grupos()
        {
            InitializeComponent();
            ListarEntidades();
        }
        public void ListarEntidades()
        {
            var data = new clsLnGruposEntidades();
            dataGridView1.DataSource = data.Listar();

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            MantGrupos mantGruop = new MantGrupos();
            mantGruop.Show();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            MantGrupos mantGruop = new MantGrupos();
            mantGruop.Show();
        }
    }
}
