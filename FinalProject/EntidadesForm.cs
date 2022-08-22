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
    public partial class EntidadesForm : Form
    {
        clsLnTablaEntidades data = new clsLnTablaEntidades();
        public EntidadesForm()
        {
            InitializeComponent();
            ListarEntidades();
        }
        #region Eventos
        private void buttonCrear_Click(object sender, EventArgs e)
        {
            FormMantenimientos mantenimientos = new FormMantenimientos();
            mantenimientos.Show();
            this.Close();
        }
        private void dataGridViewEntidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CrossIndex.CrossId.CroosIndex.indice = Convert.ToInt32(dataGridViewEntidad.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
        private void buttonDeseleccionar_Click(object sender, EventArgs e)
        {
            dataGridViewEntidad.DataSource = data.Listar();
            dataGridViewEntidad.ClearSelection();
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if(CrossIndex.CrossId.CroosIndex.indice < 0)
            {
                MessageBox.Show("Debe seleccionar una entidad", "Notificacion");
            }
            else
            {
                FormMantenimientos mantenimientos = new FormMantenimientos();
                mantenimientos.Show();
                this.Close();
            }
            
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ListarEntidades();
        }
        #endregion

        #region Metodos
        public void ListarEntidades()
        {
            var data = new clsLnTablaEntidades();
            dataGridViewEntidad.DataSource = data.Listar();
            dataGridViewEntidad.ClearSelection();

        }


        #endregion

       
    }
}
