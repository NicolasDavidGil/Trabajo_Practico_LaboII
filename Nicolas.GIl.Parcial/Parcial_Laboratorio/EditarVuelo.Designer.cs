namespace Parcial_Laboratorio
{
    partial class EditarVuelo
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
            this.btnCambiarDuracion = new System.Windows.Forms.Button();
            this.btnCerrarLista = new System.Windows.Forms.Button();
            this.btnFinalizarVuelo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgVuelosActivos = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaPartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientosLibresTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientosLibresPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeronaveAsigDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaArriboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCantidadVuelosActivos = new System.Windows.Forms.Label();
            this.lblNumeroDeVuelos = new System.Windows.Forms.Label();
            this.lblIndiceVacio = new System.Windows.Forms.Label();
            this.lblSalioOk = new System.Windows.Forms.Label();
            this.pnlConfirmacionFinalizar = new System.Windows.Forms.Panel();
            this.btnCarcelarFinalizacion = new System.Windows.Forms.Button();
            this.btnConfirmarFinalizacion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelosActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).BeginInit();
            this.pnlConfirmacionFinalizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCambiarDuracion
            // 
            this.btnCambiarDuracion.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiarDuracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarDuracion.FlatAppearance.BorderSize = 4;
            this.btnCambiarDuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarDuracion.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCambiarDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCambiarDuracion.Location = new System.Drawing.Point(464, 514);
            this.btnCambiarDuracion.Name = "btnCambiarDuracion";
            this.btnCambiarDuracion.Size = new System.Drawing.Size(179, 62);
            this.btnCambiarDuracion.TabIndex = 8;
            this.btnCambiarDuracion.Text = "CAMBIAR DURACION";
            this.btnCambiarDuracion.UseVisualStyleBackColor = false;
            this.btnCambiarDuracion.Click += new System.EventHandler(this.btnCambiarDuracion_Click);
            // 
            // btnCerrarLista
            // 
            this.btnCerrarLista.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarLista.FlatAppearance.BorderSize = 4;
            this.btnCerrarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarLista.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrarLista.Location = new System.Drawing.Point(245, 514);
            this.btnCerrarLista.Name = "btnCerrarLista";
            this.btnCerrarLista.Size = new System.Drawing.Size(179, 62);
            this.btnCerrarLista.TabIndex = 9;
            this.btnCerrarLista.Text = "CERRAR LISTA PASAJEROS";
            this.btnCerrarLista.UseVisualStyleBackColor = false;
            this.btnCerrarLista.Click += new System.EventHandler(this.btnCerrarLista_Click);
            // 
            // btnFinalizarVuelo
            // 
            this.btnFinalizarVuelo.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarVuelo.FlatAppearance.BorderSize = 4;
            this.btnFinalizarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarVuelo.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizarVuelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFinalizarVuelo.Location = new System.Drawing.Point(34, 514);
            this.btnFinalizarVuelo.Name = "btnFinalizarVuelo";
            this.btnFinalizarVuelo.Size = new System.Drawing.Size(179, 62);
            this.btnFinalizarVuelo.TabIndex = 11;
            this.btnFinalizarVuelo.Text = "FINALIZAR VUELO";
            this.btnFinalizarVuelo.UseVisualStyleBackColor = false;
            this.btnFinalizarVuelo.Click += new System.EventHandler(this.btnFinalizarVuelo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 4;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(691, 514);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(179, 62);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "VOVLER";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(208, 20);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(88, 21);
            this.lblNombreUsuario.TabIndex = 14;
            this.lblNombreUsuario.Text = "userName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "USUARIO:";
            // 
            // dtgVuelosActivos
            // 
            this.dtgVuelosActivos.AutoGenerateColumns = false;
            this.dtgVuelosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVuelosActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.origenDataGridViewTextBoxColumn,
            this.destinosDataGridViewTextBoxColumn,
            this.fechaPartidaDataGridViewTextBoxColumn,
            this.horaPartidaDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.asientosLibresTDataGridViewTextBoxColumn,
            this.asientosLibresPDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.aeronaveAsigDataGridViewTextBoxColumn,
            this.horaArriboDataGridViewTextBoxColumn});
            this.dtgVuelosActivos.DataSource = this.vueloBindingSource;
            this.dtgVuelosActivos.Location = new System.Drawing.Point(22, 87);
            this.dtgVuelosActivos.Name = "dtgVuelosActivos";
            this.dtgVuelosActivos.RowTemplate.Height = 25;
            this.dtgVuelosActivos.Size = new System.Drawing.Size(949, 290);
            this.dtgVuelosActivos.TabIndex = 15;
            this.dtgVuelosActivos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgVuelosActivos_RowHeaderMouseClick);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // origenDataGridViewTextBoxColumn
            // 
            this.origenDataGridViewTextBoxColumn.DataPropertyName = "Origen";
            this.origenDataGridViewTextBoxColumn.HeaderText = "Origen";
            this.origenDataGridViewTextBoxColumn.Name = "origenDataGridViewTextBoxColumn";
            // 
            // destinosDataGridViewTextBoxColumn
            // 
            this.destinosDataGridViewTextBoxColumn.DataPropertyName = "Destinos";
            this.destinosDataGridViewTextBoxColumn.HeaderText = "Destinos";
            this.destinosDataGridViewTextBoxColumn.Name = "destinosDataGridViewTextBoxColumn";
            // 
            // fechaPartidaDataGridViewTextBoxColumn
            // 
            this.fechaPartidaDataGridViewTextBoxColumn.DataPropertyName = "FechaPartida";
            this.fechaPartidaDataGridViewTextBoxColumn.HeaderText = "Fecha Partida";
            this.fechaPartidaDataGridViewTextBoxColumn.Name = "fechaPartidaDataGridViewTextBoxColumn";
            // 
            // horaPartidaDataGridViewTextBoxColumn
            // 
            this.horaPartidaDataGridViewTextBoxColumn.DataPropertyName = "HoraPartida";
            this.horaPartidaDataGridViewTextBoxColumn.HeaderText = "Hora Partida";
            this.horaPartidaDataGridViewTextBoxColumn.Name = "horaPartidaDataGridViewTextBoxColumn";
            this.horaPartidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            this.duracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion";
            this.duracionDataGridViewTextBoxColumn.HeaderText = "Duracion";
            this.duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            // 
            // asientosLibresTDataGridViewTextBoxColumn
            // 
            this.asientosLibresTDataGridViewTextBoxColumn.DataPropertyName = "AsientosLibresT";
            this.asientosLibresTDataGridViewTextBoxColumn.HeaderText = "Asientos Libres Turista";
            this.asientosLibresTDataGridViewTextBoxColumn.Name = "asientosLibresTDataGridViewTextBoxColumn";
            // 
            // asientosLibresPDataGridViewTextBoxColumn
            // 
            this.asientosLibresPDataGridViewTextBoxColumn.DataPropertyName = "AsientosLibresP";
            this.asientosLibresPDataGridViewTextBoxColumn.HeaderText = "Asientos Libres Primera";
            this.asientosLibresPDataGridViewTextBoxColumn.Name = "asientosLibresPDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado Vuelo";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // aeronaveAsigDataGridViewTextBoxColumn
            // 
            this.aeronaveAsigDataGridViewTextBoxColumn.DataPropertyName = "AeronaveAsig";
            this.aeronaveAsigDataGridViewTextBoxColumn.HeaderText = "Aeronave Asignada";
            this.aeronaveAsigDataGridViewTextBoxColumn.Name = "aeronaveAsigDataGridViewTextBoxColumn";
            // 
            // horaArriboDataGridViewTextBoxColumn
            // 
            this.horaArriboDataGridViewTextBoxColumn.DataPropertyName = "HoraArribo";
            this.horaArriboDataGridViewTextBoxColumn.HeaderText = "Hora Arribo";
            this.horaArriboDataGridViewTextBoxColumn.Name = "horaArriboDataGridViewTextBoxColumn";
            // 
            // vueloBindingSource
            // 
            this.vueloBindingSource.DataSource = typeof(Parcial_Library.Vuelo);
            // 
            // lblCantidadVuelosActivos
            // 
            this.lblCantidadVuelosActivos.AutoSize = true;
            this.lblCantidadVuelosActivos.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadVuelosActivos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadVuelosActivos.ForeColor = System.Drawing.Color.White;
            this.lblCantidadVuelosActivos.Location = new System.Drawing.Point(22, 49);
            this.lblCantidadVuelosActivos.Name = "lblCantidadVuelosActivos";
            this.lblCantidadVuelosActivos.Size = new System.Drawing.Size(258, 21);
            this.lblCantidadVuelosActivos.TabIndex = 17;
            this.lblCantidadVuelosActivos.Text = "CANTIDAD DE VUELOS ACTIVOS:";
            // 
            // lblNumeroDeVuelos
            // 
            this.lblNumeroDeVuelos.AutoSize = true;
            this.lblNumeroDeVuelos.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroDeVuelos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroDeVuelos.ForeColor = System.Drawing.Color.White;
            this.lblNumeroDeVuelos.Location = new System.Drawing.Point(286, 49);
            this.lblNumeroDeVuelos.Name = "lblNumeroDeVuelos";
            this.lblNumeroDeVuelos.Size = new System.Drawing.Size(122, 21);
            this.lblNumeroDeVuelos.TabIndex = 18;
            this.lblNumeroDeVuelos.Text = "numeroVuelos";
            // 
            // lblIndiceVacio
            // 
            this.lblIndiceVacio.AutoSize = true;
            this.lblIndiceVacio.BackColor = System.Drawing.Color.Black;
            this.lblIndiceVacio.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIndiceVacio.ForeColor = System.Drawing.Color.Red;
            this.lblIndiceVacio.Location = new System.Drawing.Point(208, 393);
            this.lblIndiceVacio.Name = "lblIndiceVacio";
            this.lblIndiceVacio.Size = new System.Drawing.Size(498, 23);
            this.lblIndiceVacio.TabIndex = 19;
            this.lblIndiceVacio.Text = "SE DEBE SELECCIONAR UN VUELO ANTES DE PROCEDER";
            // 
            // lblSalioOk
            // 
            this.lblSalioOk.AutoSize = true;
            this.lblSalioOk.BackColor = System.Drawing.Color.Black;
            this.lblSalioOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalioOk.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalioOk.ForeColor = System.Drawing.Color.Lime;
            this.lblSalioOk.Location = new System.Drawing.Point(391, 442);
            this.lblSalioOk.Name = "lblSalioOk";
            this.lblSalioOk.Size = new System.Drawing.Size(91, 23);
            this.lblSalioOk.TabIndex = 20;
            this.lblSalioOk.Text = "salioOK";
            // 
            // pnlConfirmacionFinalizar
            // 
            this.pnlConfirmacionFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlConfirmacionFinalizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfirmacionFinalizar.Controls.Add(this.btnCarcelarFinalizacion);
            this.pnlConfirmacionFinalizar.Controls.Add(this.btnConfirmarFinalizacion);
            this.pnlConfirmacionFinalizar.Controls.Add(this.label3);
            this.pnlConfirmacionFinalizar.Controls.Add(this.label2);
            this.pnlConfirmacionFinalizar.Controls.Add(this.label1);
            this.pnlConfirmacionFinalizar.Location = new System.Drawing.Point(22, 297);
            this.pnlConfirmacionFinalizar.Name = "pnlConfirmacionFinalizar";
            this.pnlConfirmacionFinalizar.Size = new System.Drawing.Size(258, 186);
            this.pnlConfirmacionFinalizar.TabIndex = 21;
            // 
            // btnCarcelarFinalizacion
            // 
            this.btnCarcelarFinalizacion.BackColor = System.Drawing.Color.Transparent;
            this.btnCarcelarFinalizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarcelarFinalizacion.FlatAppearance.BorderSize = 2;
            this.btnCarcelarFinalizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarcelarFinalizacion.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCarcelarFinalizacion.Location = new System.Drawing.Point(11, 121);
            this.btnCarcelarFinalizacion.Name = "btnCarcelarFinalizacion";
            this.btnCarcelarFinalizacion.Size = new System.Drawing.Size(97, 46);
            this.btnCarcelarFinalizacion.TabIndex = 4;
            this.btnCarcelarFinalizacion.Text = "CANCELAR";
            this.btnCarcelarFinalizacion.UseVisualStyleBackColor = false;
            this.btnCarcelarFinalizacion.Click += new System.EventHandler(this.btnCarcelarFinalizacion_Click);
            // 
            // btnConfirmarFinalizacion
            // 
            this.btnConfirmarFinalizacion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarFinalizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarFinalizacion.FlatAppearance.BorderSize = 2;
            this.btnConfirmarFinalizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarFinalizacion.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarFinalizacion.Location = new System.Drawing.Point(145, 121);
            this.btnConfirmarFinalizacion.Name = "btnConfirmarFinalizacion";
            this.btnConfirmarFinalizacion.Size = new System.Drawing.Size(97, 46);
            this.btnConfirmarFinalizacion.TabIndex = 3;
            this.btnConfirmarFinalizacion.Text = "CONFIRMAR";
            this.btnConfirmarFinalizacion.UseVisualStyleBackColor = false;
            this.btnConfirmarFinalizacion.Click += new System.EventHandler(this.btnConfirmarFinalizacion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(79, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "¿ESTAS SEGURO? ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(79, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "¡¡ATENCION!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTA ACCION ES INREVERSIBLE";
            // 
            // EditarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial_Laboratorio.Properties.Resources.fondoEdicion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 593);
            this.Controls.Add(this.pnlConfirmacionFinalizar);
            this.Controls.Add(this.lblSalioOk);
            this.Controls.Add(this.lblIndiceVacio);
            this.Controls.Add(this.lblNumeroDeVuelos);
            this.Controls.Add(this.lblCantidadVuelosActivos);
            this.Controls.Add(this.dtgVuelosActivos);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizarVuelo);
            this.Controls.Add(this.btnCerrarLista);
            this.Controls.Add(this.btnCambiarDuracion);
            this.Name = "EditarVuelo";
            this.Text = "EditarVuelo";
            this.Load += new System.EventHandler(this.EditarVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelosActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).EndInit();
            this.pnlConfirmacionFinalizar.ResumeLayout(false);
            this.pnlConfirmacionFinalizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCambiarDuracion;
        private System.Windows.Forms.Button btnCerrarLista;
        private System.Windows.Forms.Button btnFinalizarVuelo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgVuelosActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPartidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaPartidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientosLibresTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientosLibresPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeronaveAsigDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaArriboDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vueloBindingSource;
        private System.Windows.Forms.Label lblCantidadVuelosActivos;
        private System.Windows.Forms.Label lblNumeroDeVuelos;
        private System.Windows.Forms.Label lblIndiceVacio;
        private System.Windows.Forms.Label lblSalioOk;
        private System.Windows.Forms.Panel pnlConfirmacionFinalizar;
        private System.Windows.Forms.Button btnCarcelarFinalizacion;
        private System.Windows.Forms.Button btnConfirmarFinalizacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}