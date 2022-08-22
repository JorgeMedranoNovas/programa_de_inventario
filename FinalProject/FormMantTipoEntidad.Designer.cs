namespace FinalProject
{
    partial class FormMantTipoEntidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxTipodeEntidad = new System.Windows.Forms.TextBox();
            this.labelIdGrupoEntidad = new System.Windows.Forms.Label();
            this.comboBoxGrupoEntidad = new System.Windows.Forms.ComboBox();
            this.labelComentarios = new System.Windows.Forms.Label();
            this.textBoxComentarios = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0225F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0225F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.50956F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.42295F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0225F));
            this.tableLayoutPanel1.Controls.Add(this.labelDescripcion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTipodeEntidad, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelIdGrupoEntidad, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxGrupoEntidad, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelComentarios, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxComentarios, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelStatus, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxStatus, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonAceptar, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancelar, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.08282F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 483);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelDescripcion.Location = new System.Drawing.Point(254, 68);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(99, 68);
            this.labelDescripcion.TabIndex = 0;
            this.labelDescripcion.Text = "Tipo De Entidad:";
            this.labelDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTipodeEntidad
            // 
            this.textBoxTipodeEntidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTipodeEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxTipodeEntidad.Location = new System.Drawing.Point(359, 87);
            this.textBoxTipodeEntidad.Name = "textBoxTipodeEntidad";
            this.textBoxTipodeEntidad.Size = new System.Drawing.Size(203, 29);
            this.textBoxTipodeEntidad.TabIndex = 1;
            // 
            // labelIdGrupoEntidad
            // 
            this.labelIdGrupoEntidad.AutoSize = true;
            this.labelIdGrupoEntidad.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelIdGrupoEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelIdGrupoEntidad.Location = new System.Drawing.Point(183, 136);
            this.labelIdGrupoEntidad.Name = "labelIdGrupoEntidad";
            this.labelIdGrupoEntidad.Size = new System.Drawing.Size(170, 68);
            this.labelIdGrupoEntidad.TabIndex = 2;
            this.labelIdGrupoEntidad.Text = "Grupo Entidad:";
            this.labelIdGrupoEntidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxGrupoEntidad
            // 
            this.comboBoxGrupoEntidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxGrupoEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBoxGrupoEntidad.FormattingEnabled = true;
            this.comboBoxGrupoEntidad.Location = new System.Drawing.Point(359, 154);
            this.comboBoxGrupoEntidad.Name = "comboBoxGrupoEntidad";
            this.comboBoxGrupoEntidad.Size = new System.Drawing.Size(121, 32);
            this.comboBoxGrupoEntidad.TabIndex = 3;
            // 
            // labelComentarios
            // 
            this.labelComentarios.AutoSize = true;
            this.labelComentarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelComentarios.Location = new System.Drawing.Point(202, 204);
            this.labelComentarios.Name = "labelComentarios";
            this.labelComentarios.Size = new System.Drawing.Size(151, 68);
            this.labelComentarios.TabIndex = 4;
            this.labelComentarios.Text = "Comentarios:";
            this.labelComentarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxComentarios
            // 
            this.textBoxComentarios.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxComentarios, 3);
            this.textBoxComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxComentarios.Location = new System.Drawing.Point(359, 223);
            this.textBoxComentarios.Name = "textBoxComentarios";
            this.textBoxComentarios.Size = new System.Drawing.Size(528, 29);
            this.textBoxComentarios.TabIndex = 5;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelStatus.Location = new System.Drawing.Point(267, 272);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(86, 68);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Status:";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(359, 290);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(102, 32);
            this.comboBoxStatus.TabIndex = 7;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAceptar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAceptar.Location = new System.Drawing.Point(359, 343);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(203, 32);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonCancelar.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonCancelar.Location = new System.Drawing.Point(359, 388);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(203, 32);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormMantTipoEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMantTipoEntidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMantTipoEntidad";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxTipodeEntidad;
        private System.Windows.Forms.Label labelIdGrupoEntidad;
        private System.Windows.Forms.ComboBox comboBoxGrupoEntidad;
        private System.Windows.Forms.Label labelComentarios;
        private System.Windows.Forms.TextBox textBoxComentarios;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}