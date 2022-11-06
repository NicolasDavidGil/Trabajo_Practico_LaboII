namespace Parcial_Laboratorio
{
    partial class frmBaseDatosClientes
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
            this.components = new System.ComponentModel.Container();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.nombrePersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GastoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadVuelosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pasajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVender = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 3;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBuscar.Location = new System.Drawing.Point(592, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 43);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "BUSCAR";
            this.toolTip1.SetToolTip(this.btnBuscar, "Iniciar busqueda");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(12, 35);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(549, 23);
            this.txtBusqueda.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtBusqueda, "Buscamos por nombre y apellido o dni");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Busqueda:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 3;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnVolver.Location = new System.Drawing.Point(704, 15);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 43);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "VOLVER";
            this.toolTip1.SetToolTip(this.btnVolver, "volver al menu principal");
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Black;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrePersonaDataGridViewTextBoxColumn,
            this.documentoPersonaDataGridViewTextBoxColumn,
            this.edadPersonaDataGridViewTextBoxColumn,
            this.GastoTotal,
            this.direccionDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.localidadDataGridViewTextBoxColumn,
            this.nacionalidadDataGridViewTextBoxColumn,
            this.estadoCivilDataGridViewTextBoxColumn,
            this.cantidadVuelosDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.clienteBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(12, 79);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(950, 548);
            this.dgvClientes.TabIndex = 9;
            this.dgvClientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClientes_RowHeaderMouseClick);
            // 
            // nombrePersonaDataGridViewTextBoxColumn
            // 
            this.nombrePersonaDataGridViewTextBoxColumn.DataPropertyName = "NombrePersona";
            this.nombrePersonaDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombrePersonaDataGridViewTextBoxColumn.Name = "nombrePersonaDataGridViewTextBoxColumn";
            this.nombrePersonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentoPersonaDataGridViewTextBoxColumn
            // 
            this.documentoPersonaDataGridViewTextBoxColumn.DataPropertyName = "DocumentoPersona";
            this.documentoPersonaDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoPersonaDataGridViewTextBoxColumn.Name = "documentoPersonaDataGridViewTextBoxColumn";
            this.documentoPersonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edadPersonaDataGridViewTextBoxColumn
            // 
            this.edadPersonaDataGridViewTextBoxColumn.DataPropertyName = "EdadPersona";
            this.edadPersonaDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadPersonaDataGridViewTextBoxColumn.Name = "edadPersonaDataGridViewTextBoxColumn";
            this.edadPersonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GastoTotal
            // 
            this.GastoTotal.DataPropertyName = "GastoTotal";
            this.GastoTotal.HeaderText = "GastoTotal";
            this.GastoTotal.Name = "GastoTotal";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            this.ciudadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localidadDataGridViewTextBoxColumn
            // 
            this.localidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad";
            this.localidadDataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.localidadDataGridViewTextBoxColumn.Name = "localidadDataGridViewTextBoxColumn";
            this.localidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nacionalidadDataGridViewTextBoxColumn
            // 
            this.nacionalidadDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidad";
            this.nacionalidadDataGridViewTextBoxColumn.HeaderText = "Nacionalidad";
            this.nacionalidadDataGridViewTextBoxColumn.Name = "nacionalidadDataGridViewTextBoxColumn";
            this.nacionalidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoCivilDataGridViewTextBoxColumn
            // 
            this.estadoCivilDataGridViewTextBoxColumn.DataPropertyName = "EstadoCivil";
            this.estadoCivilDataGridViewTextBoxColumn.HeaderText = "Estado Civil";
            this.estadoCivilDataGridViewTextBoxColumn.Name = "estadoCivilDataGridViewTextBoxColumn";
            this.estadoCivilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadVuelosDataGridViewTextBoxColumn
            // 
            this.cantidadVuelosDataGridViewTextBoxColumn.DataPropertyName = "CantidadVuelos";
            this.cantidadVuelosDataGridViewTextBoxColumn.HeaderText = "Vuelos ";
            this.cantidadVuelosDataGridViewTextBoxColumn.Name = "cantidadVuelosDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Parcial.Library.Cliente);
            // 
            // pasajeroBindingSource
            // 
            this.pasajeroBindingSource.DataSource = typeof(Parcial.Library.Pasajero);
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.Transparent;
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.FlatAppearance.BorderSize = 3;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVender.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnVender.Location = new System.Drawing.Point(822, 15);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(91, 43);
            this.btnVender.TabIndex = 10;
            this.btnVender.Text = "VENDER";
            this.toolTip1.SetToolTip(this.btnVender, "Proceder a vender");
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Visible = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblError.Location = new System.Drawing.Point(283, 9);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(303, 17);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "ESTE USUARIO YA ESTA ANOTADO EN UN VUELO";
            this.lblError.Visible = false;
            // 
            // frmBaseDatosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(974, 639);
            this.ControlBox = false;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label1);
            this.Name = "frmBaseDatosClientes";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmBaseDatosClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource pasajeroBindingSource;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GastoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadVuelosDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}