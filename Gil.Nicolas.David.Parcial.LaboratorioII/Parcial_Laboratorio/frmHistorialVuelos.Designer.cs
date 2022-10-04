namespace Parcial_Laboratorio
{
    partial class frmHistorialVuelos
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
            this.lblVuelosFinalizados = new System.Windows.Forms.Label();
            this.lblVuelosActivos = new System.Windows.Forms.Label();
            this.lblVuelosTotales = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblFinalizados = new System.Windows.Forms.Label();
            this.lblTotales = new System.Windows.Forms.Label();
            this.lblActivos = new System.Windows.Forms.Label();
            this.lblNombreUsuarioTittle = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.dgvHistorialVuelos = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaPartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaArriboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientosLibresTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientosLibresPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeronaveMatriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblVuelosTerminados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVuelosFinalizados
            // 
            this.lblVuelosFinalizados.AutoSize = true;
            this.lblVuelosFinalizados.BackColor = System.Drawing.Color.Transparent;
            this.lblVuelosFinalizados.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVuelosFinalizados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVuelosFinalizados.Location = new System.Drawing.Point(197, 119);
            this.lblVuelosFinalizados.Name = "lblVuelosFinalizados";
            this.lblVuelosFinalizados.Size = new System.Drawing.Size(123, 20);
            this.lblVuelosFinalizados.TabIndex = 21;
            this.lblVuelosFinalizados.Text = "finalizados";
            // 
            // lblVuelosActivos
            // 
            this.lblVuelosActivos.AutoSize = true;
            this.lblVuelosActivos.BackColor = System.Drawing.Color.Transparent;
            this.lblVuelosActivos.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVuelosActivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVuelosActivos.Location = new System.Drawing.Point(197, 82);
            this.lblVuelosActivos.Name = "lblVuelosActivos";
            this.lblVuelosActivos.Size = new System.Drawing.Size(84, 20);
            this.lblVuelosActivos.TabIndex = 20;
            this.lblVuelosActivos.Text = "activos";
            // 
            // lblVuelosTotales
            // 
            this.lblVuelosTotales.AutoSize = true;
            this.lblVuelosTotales.BackColor = System.Drawing.Color.Transparent;
            this.lblVuelosTotales.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVuelosTotales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVuelosTotales.Location = new System.Drawing.Point(197, 42);
            this.lblVuelosTotales.Name = "lblVuelosTotales";
            this.lblVuelosTotales.Size = new System.Drawing.Size(84, 20);
            this.lblVuelosTotales.TabIndex = 19;
            this.lblVuelosTotales.Text = "totales";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreUsuario.Location = new System.Drawing.Point(197, 8);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(92, 20);
            this.lblNombreUsuario.TabIndex = 18;
            this.lblNombreUsuario.Text = "usrName";
            // 
            // lblFinalizados
            // 
            this.lblFinalizados.AutoSize = true;
            this.lblFinalizados.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalizados.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinalizados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFinalizados.Location = new System.Drawing.Point(3, 119);
            this.lblFinalizados.Name = "lblFinalizados";
            this.lblFinalizados.Size = new System.Drawing.Size(199, 20);
            this.lblFinalizados.TabIndex = 17;
            this.lblFinalizados.Text = "VUELOS FINALIZADOS:";
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.BackColor = System.Drawing.Color.Transparent;
            this.lblTotales.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotales.Location = new System.Drawing.Point(41, 42);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(160, 20);
            this.lblTotales.TabIndex = 16;
            this.lblTotales.Text = "VUELOS TOTALES:";
            // 
            // lblActivos
            // 
            this.lblActivos.AutoSize = true;
            this.lblActivos.BackColor = System.Drawing.Color.Transparent;
            this.lblActivos.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblActivos.Location = new System.Drawing.Point(38, 82);
            this.lblActivos.Name = "lblActivos";
            this.lblActivos.Size = new System.Drawing.Size(160, 20);
            this.lblActivos.TabIndex = 15;
            this.lblActivos.Text = "VUELOS ACTIVOS:";
            // 
            // lblNombreUsuarioTittle
            // 
            this.lblNombreUsuarioTittle.AutoSize = true;
            this.lblNombreUsuarioTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuarioTittle.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreUsuarioTittle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreUsuarioTittle.Location = new System.Drawing.Point(26, 8);
            this.lblNombreUsuarioTittle.Name = "lblNombreUsuarioTittle";
            this.lblNombreUsuarioTittle.Size = new System.Drawing.Size(171, 20);
            this.lblNombreUsuarioTittle.TabIndex = 14;
            this.lblNombreUsuarioTittle.Text = "NOMBRE USUARIO:";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.FlatAppearance.BorderSize = 3;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cerrar.Location = new System.Drawing.Point(690, 42);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(171, 64);
            this.btn_cerrar.TabIndex = 13;
            this.btn_cerrar.Text = "CERRAR";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // dgvHistorialVuelos
            // 
            this.dgvHistorialVuelos.AutoGenerateColumns = false;
            this.dgvHistorialVuelos.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvHistorialVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialVuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.origenDataGridViewTextBoxColumn,
            this.destinosDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.horaPartidaDataGridViewTextBoxColumn,
            this.horaArriboDataGridViewTextBoxColumn,
            this.fechaPartidaDataGridViewTextBoxColumn,
            this.asientosLibresTDataGridViewTextBoxColumn,
            this.asientosLibresPDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.aeronaveMatriculaDataGridViewTextBoxColumn});
            this.dgvHistorialVuelos.DataSource = this.vueloBindingSource;
            this.dgvHistorialVuelos.Location = new System.Drawing.Point(12, 224);
            this.dgvHistorialVuelos.Name = "dgvHistorialVuelos";
            this.dgvHistorialVuelos.RowTemplate.Height = 25;
            this.dgvHistorialVuelos.Size = new System.Drawing.Size(867, 402);
            this.dgvHistorialVuelos.TabIndex = 22;
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
            this.origenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinosDataGridViewTextBoxColumn
            // 
            this.destinosDataGridViewTextBoxColumn.DataPropertyName = "Destinos";
            this.destinosDataGridViewTextBoxColumn.HeaderText = "Destinos";
            this.destinosDataGridViewTextBoxColumn.Name = "destinosDataGridViewTextBoxColumn";
            this.destinosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            this.duracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion";
            this.duracionDataGridViewTextBoxColumn.HeaderText = "Duracion";
            this.duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            // 
            // horaPartidaDataGridViewTextBoxColumn
            // 
            this.horaPartidaDataGridViewTextBoxColumn.DataPropertyName = "HoraPartida";
            this.horaPartidaDataGridViewTextBoxColumn.HeaderText = "Hora Partida";
            this.horaPartidaDataGridViewTextBoxColumn.Name = "horaPartidaDataGridViewTextBoxColumn";
            this.horaPartidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaArriboDataGridViewTextBoxColumn
            // 
            this.horaArriboDataGridViewTextBoxColumn.DataPropertyName = "HoraArribo";
            this.horaArriboDataGridViewTextBoxColumn.HeaderText = "HoraArribo";
            this.horaArriboDataGridViewTextBoxColumn.Name = "horaArriboDataGridViewTextBoxColumn";
            // 
            // fechaPartidaDataGridViewTextBoxColumn
            // 
            this.fechaPartidaDataGridViewTextBoxColumn.DataPropertyName = "FechaPartida";
            this.fechaPartidaDataGridViewTextBoxColumn.HeaderText = "Fecha Partida";
            this.fechaPartidaDataGridViewTextBoxColumn.Name = "fechaPartidaDataGridViewTextBoxColumn";
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
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // aeronaveMatriculaDataGridViewTextBoxColumn
            // 
            this.aeronaveMatriculaDataGridViewTextBoxColumn.DataPropertyName = "AeronaveMatricula";
            this.aeronaveMatriculaDataGridViewTextBoxColumn.HeaderText = "AeronaveMatricula";
            this.aeronaveMatriculaDataGridViewTextBoxColumn.Name = "aeronaveMatriculaDataGridViewTextBoxColumn";
            this.aeronaveMatriculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vueloBindingSource
            // 
            this.vueloBindingSource.DataSource = typeof(Parcial.Library.Vuelo);
            // 
            // lblVuelosTerminados
            // 
            this.lblVuelosTerminados.AutoSize = true;
            this.lblVuelosTerminados.BackColor = System.Drawing.Color.Transparent;
            this.lblVuelosTerminados.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVuelosTerminados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVuelosTerminados.Location = new System.Drawing.Point(309, 188);
            this.lblVuelosTerminados.Name = "lblVuelosTerminados";
            this.lblVuelosTerminados.Size = new System.Drawing.Size(214, 23);
            this.lblVuelosTerminados.TabIndex = 23;
            this.lblVuelosTerminados.Text = "HISTORIAL DE VUELOS";
            // 
            // frmHistorialVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 626);
            this.ControlBox = false;
            this.Controls.Add(this.lblVuelosTerminados);
            this.Controls.Add(this.dgvHistorialVuelos);
            this.Controls.Add(this.lblVuelosFinalizados);
            this.Controls.Add(this.lblVuelosActivos);
            this.Controls.Add(this.lblVuelosTotales);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblFinalizados);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.lblActivos);
            this.Controls.Add(this.lblNombreUsuarioTittle);
            this.Controls.Add(this.btn_cerrar);
            this.Name = "frmHistorialVuelos";
            this.Text = "frmHistorialVuelos";
            this.Load += new System.EventHandler(this.frmHistorialVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVuelosFinalizados;
        private System.Windows.Forms.Label lblVuelosActivos;
        private System.Windows.Forms.Label lblVuelosTotales;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblFinalizados;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.Label lblActivos;
        private System.Windows.Forms.Label lblNombreUsuarioTittle;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridView dgvHistorialVuelos;
        private System.Windows.Forms.Label lblVuelosTerminados;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaPartidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaArriboDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPartidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientosLibresTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientosLibresPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeronaveMatriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVueloDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vueloBindingSource;
    }
}