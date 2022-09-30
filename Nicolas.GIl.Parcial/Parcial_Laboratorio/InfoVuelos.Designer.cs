namespace Parcial_Laboratorio
{
    partial class InfoVuelos
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
            this.dtgInfoVuelosTerminados = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinosDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPartidaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaPartidaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaArriboDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vueloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.dtgInfoVuelosActivos = new System.Windows.Forms.DataGridView();
            this.vueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_vuelosActivos = new System.Windows.Forms.Label();
            this.lblVuelosTerminados = new System.Windows.Forms.Label();
            this.lblNombreUsuarioTittle = new System.Windows.Forms.Label();
            this.lblActivos = new System.Windows.Forms.Label();
            this.lblTotales = new System.Windows.Forms.Label();
            this.lblFinalizados = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblVuelosTotales = new System.Windows.Forms.Label();
            this.lblVuelosActivos = new System.Windows.Forms.Label();
            this.lblVuelosFinalizados = new System.Windows.Forms.Label();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaPartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaArriboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AeronaveMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfoVuelosTerminados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfoVuelosActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgInfoVuelosTerminados
            // 
            this.dtgInfoVuelosTerminados.AutoGenerateColumns = false;
            this.dtgInfoVuelosTerminados.BackgroundColor = System.Drawing.Color.White;
            this.dtgInfoVuelosTerminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfoVuelosTerminados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn1,
            this.origenDataGridViewTextBoxColumn1,
            this.destinosDataGridViewTextBoxColumn1,
            this.fechaPartidaDataGridViewTextBoxColumn1,
            this.horaPartidaDataGridViewTextBoxColumn1,
            this.duracionDataGridViewTextBoxColumn1,
            this.horaArriboDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.estadoDataGridViewTextBoxColumn1});
            this.dtgInfoVuelosTerminados.DataSource = this.vueloBindingSource1;
            this.dtgInfoVuelosTerminados.Location = new System.Drawing.Point(95, 419);
            this.dtgInfoVuelosTerminados.Name = "dtgInfoVuelosTerminados";
            this.dtgInfoVuelosTerminados.RowTemplate.Height = 25;
            this.dtgInfoVuelosTerminados.Size = new System.Drawing.Size(948, 382);
            this.dtgInfoVuelosTerminados.TabIndex = 0;
            // 
            // codigoDataGridViewTextBoxColumn1
            // 
            this.codigoDataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.Name = "codigoDataGridViewTextBoxColumn1";
            this.codigoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // origenDataGridViewTextBoxColumn1
            // 
            this.origenDataGridViewTextBoxColumn1.DataPropertyName = "Origen";
            this.origenDataGridViewTextBoxColumn1.HeaderText = "Origen";
            this.origenDataGridViewTextBoxColumn1.Name = "origenDataGridViewTextBoxColumn1";
            // 
            // destinosDataGridViewTextBoxColumn1
            // 
            this.destinosDataGridViewTextBoxColumn1.DataPropertyName = "Destinos";
            this.destinosDataGridViewTextBoxColumn1.HeaderText = "Destinos";
            this.destinosDataGridViewTextBoxColumn1.Name = "destinosDataGridViewTextBoxColumn1";
            // 
            // fechaPartidaDataGridViewTextBoxColumn1
            // 
            this.fechaPartidaDataGridViewTextBoxColumn1.DataPropertyName = "FechaPartida";
            this.fechaPartidaDataGridViewTextBoxColumn1.HeaderText = "Fecha Partida";
            this.fechaPartidaDataGridViewTextBoxColumn1.Name = "fechaPartidaDataGridViewTextBoxColumn1";
            // 
            // horaPartidaDataGridViewTextBoxColumn1
            // 
            this.horaPartidaDataGridViewTextBoxColumn1.DataPropertyName = "HoraPartida";
            this.horaPartidaDataGridViewTextBoxColumn1.HeaderText = "Hora Partida";
            this.horaPartidaDataGridViewTextBoxColumn1.Name = "horaPartidaDataGridViewTextBoxColumn1";
            this.horaPartidaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // duracionDataGridViewTextBoxColumn1
            // 
            this.duracionDataGridViewTextBoxColumn1.DataPropertyName = "Duracion";
            this.duracionDataGridViewTextBoxColumn1.HeaderText = "Duracion";
            this.duracionDataGridViewTextBoxColumn1.Name = "duracionDataGridViewTextBoxColumn1";
            // 
            // horaArriboDataGridViewTextBoxColumn1
            // 
            this.horaArriboDataGridViewTextBoxColumn1.DataPropertyName = "HoraArribo";
            this.horaArriboDataGridViewTextBoxColumn1.HeaderText = "Hora Arribo";
            this.horaArriboDataGridViewTextBoxColumn1.Name = "horaArriboDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AeronaveMatricula";
            this.dataGridViewTextBoxColumn1.HeaderText = "Matrícula Avión";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // estadoDataGridViewTextBoxColumn1
            // 
            this.estadoDataGridViewTextBoxColumn1.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn1.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn1.Name = "estadoDataGridViewTextBoxColumn1";
            // 
            // vueloBindingSource1
            // 
            this.vueloBindingSource1.DataSource = typeof(Parcial_Library.Vuelo);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.FlatAppearance.BorderSize = 3;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cerrar.Location = new System.Drawing.Point(935, 59);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(171, 64);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.Text = "CERRAR";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // dtgInfoVuelosActivos
            // 
            this.dtgInfoVuelosActivos.AutoGenerateColumns = false;
            this.dtgInfoVuelosActivos.BackgroundColor = System.Drawing.Color.White;
            this.dtgInfoVuelosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfoVuelosActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.origenDataGridViewTextBoxColumn,
            this.destinosDataGridViewTextBoxColumn,
            this.fechaPartidaDataGridViewTextBoxColumn,
            this.horaPartidaDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.horaArriboDataGridViewTextBoxColumn,
            this.AeronaveMatricula,
            this.estadoDataGridViewTextBoxColumn});
            this.dtgInfoVuelosActivos.DataSource = this.vueloBindingSource1;
            this.dtgInfoVuelosActivos.Location = new System.Drawing.Point(95, 183);
            this.dtgInfoVuelosActivos.Name = "dtgInfoVuelosActivos";
            this.dtgInfoVuelosActivos.RowTemplate.Height = 25;
            this.dtgInfoVuelosActivos.Size = new System.Drawing.Size(948, 210);
            this.dtgInfoVuelosActivos.TabIndex = 2;
            this.dtgInfoVuelosActivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInfoVuelosActivos_CellContentClick);
            // 
            // vueloBindingSource
            // 
            this.vueloBindingSource.DataSource = typeof(Parcial_Library.Vuelo);
            // 
            // lbl_vuelosActivos
            // 
            this.lbl_vuelosActivos.AutoSize = true;
            this.lbl_vuelosActivos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vuelosActivos.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_vuelosActivos.ForeColor = System.Drawing.Color.Black;
            this.lbl_vuelosActivos.Location = new System.Drawing.Point(477, 160);
            this.lbl_vuelosActivos.Name = "lbl_vuelosActivos";
            this.lbl_vuelosActivos.Size = new System.Drawing.Size(140, 20);
            this.lbl_vuelosActivos.TabIndex = 3;
            this.lbl_vuelosActivos.Text = "VUELOS ACTIVOS";
            // 
            // lblVuelosTerminados
            // 
            this.lblVuelosTerminados.AutoSize = true;
            this.lblVuelosTerminados.BackColor = System.Drawing.Color.Transparent;
            this.lblVuelosTerminados.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVuelosTerminados.ForeColor = System.Drawing.Color.Black;
            this.lblVuelosTerminados.Location = new System.Drawing.Point(461, 396);
            this.lblVuelosTerminados.Name = "lblVuelosTerminados";
            this.lblVuelosTerminados.Size = new System.Drawing.Size(177, 20);
            this.lblVuelosTerminados.TabIndex = 4;
            this.lblVuelosTerminados.Text = "VUELOS TERMINADOS";
            // 
            // lblNombreUsuarioTittle
            // 
            this.lblNombreUsuarioTittle.AutoSize = true;
            this.lblNombreUsuarioTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuarioTittle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreUsuarioTittle.Location = new System.Drawing.Point(35, 25);
            this.lblNombreUsuarioTittle.Name = "lblNombreUsuarioTittle";
            this.lblNombreUsuarioTittle.Size = new System.Drawing.Size(154, 21);
            this.lblNombreUsuarioTittle.TabIndex = 5;
            this.lblNombreUsuarioTittle.Text = "NOMBRE USUARIO:";
            // 
            // lblActivos
            // 
            this.lblActivos.AutoSize = true;
            this.lblActivos.BackColor = System.Drawing.Color.Transparent;
            this.lblActivos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivos.Location = new System.Drawing.Point(47, 99);
            this.lblActivos.Name = "lblActivos";
            this.lblActivos.Size = new System.Drawing.Size(142, 21);
            this.lblActivos.TabIndex = 6;
            this.lblActivos.Text = "VUELOS ACTIVOS:";
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.BackColor = System.Drawing.Color.Transparent;
            this.lblTotales.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotales.Location = new System.Drawing.Point(50, 59);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(139, 21);
            this.lblTotales.TabIndex = 7;
            this.lblTotales.Text = "VUELOS TOTALES:";
            // 
            // lblFinalizados
            // 
            this.lblFinalizados.AutoSize = true;
            this.lblFinalizados.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalizados.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinalizados.Location = new System.Drawing.Point(12, 136);
            this.lblFinalizados.Name = "lblFinalizados";
            this.lblFinalizados.Size = new System.Drawing.Size(177, 21);
            this.lblFinalizados.TabIndex = 8;
            this.lblFinalizados.Text = "VUELOS FINALIZADOS:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreUsuario.Location = new System.Drawing.Point(206, 25);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(75, 21);
            this.lblNombreUsuario.TabIndex = 9;
            this.lblNombreUsuario.Text = "usrName";
            // 
            // lblVuelosTotales
            // 
            this.lblVuelosTotales.AutoSize = true;
            this.lblVuelosTotales.BackColor = System.Drawing.Color.Transparent;
            this.lblVuelosTotales.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVuelosTotales.Location = new System.Drawing.Point(206, 59);
            this.lblVuelosTotales.Name = "lblVuelosTotales";
            this.lblVuelosTotales.Size = new System.Drawing.Size(60, 21);
            this.lblVuelosTotales.TabIndex = 10;
            this.lblVuelosTotales.Text = "totales";
            // 
            // lblVuelosActivos
            // 
            this.lblVuelosActivos.AutoSize = true;
            this.lblVuelosActivos.BackColor = System.Drawing.Color.Transparent;
            this.lblVuelosActivos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVuelosActivos.Location = new System.Drawing.Point(206, 99);
            this.lblVuelosActivos.Name = "lblVuelosActivos";
            this.lblVuelosActivos.Size = new System.Drawing.Size(61, 21);
            this.lblVuelosActivos.TabIndex = 11;
            this.lblVuelosActivos.Text = "activos";
            // 
            // lblVuelosFinalizados
            // 
            this.lblVuelosFinalizados.AutoSize = true;
            this.lblVuelosFinalizados.BackColor = System.Drawing.Color.Transparent;
            this.lblVuelosFinalizados.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVuelosFinalizados.Location = new System.Drawing.Point(206, 136);
            this.lblVuelosFinalizados.Name = "lblVuelosFinalizados";
            this.lblVuelosFinalizados.Size = new System.Drawing.Size(87, 21);
            this.lblVuelosFinalizados.TabIndex = 12;
            this.lblVuelosFinalizados.Text = "finalizados";
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
            // horaArriboDataGridViewTextBoxColumn
            // 
            this.horaArriboDataGridViewTextBoxColumn.DataPropertyName = "HoraArribo";
            this.horaArriboDataGridViewTextBoxColumn.HeaderText = "Hora Arribo";
            this.horaArriboDataGridViewTextBoxColumn.Name = "horaArriboDataGridViewTextBoxColumn";
            // 
            // AeronaveMatricula
            // 
            this.AeronaveMatricula.DataPropertyName = "AeronaveMatricula";
            this.AeronaveMatricula.HeaderText = "Matricula Avión";
            this.AeronaveMatricula.Name = "AeronaveMatricula";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // InfoVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Parcial_Laboratorio.Properties.Resources.estela_aviones;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1127, 822);
            this.Controls.Add(this.lblVuelosFinalizados);
            this.Controls.Add(this.lblVuelosActivos);
            this.Controls.Add(this.lblVuelosTotales);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblFinalizados);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.lblActivos);
            this.Controls.Add(this.lblNombreUsuarioTittle);
            this.Controls.Add(this.lblVuelosTerminados);
            this.Controls.Add(this.lbl_vuelosActivos);
            this.Controls.Add(this.dtgInfoVuelosActivos);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.dtgInfoVuelosTerminados);
            this.Name = "InfoVuelos";
            this.Text = "InfoVuelos";
            this.Load += new System.EventHandler(this.InfoVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfoVuelosTerminados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfoVuelosActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgInfoVuelosTerminados;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridView dtgInfoVuelosActivos;
        private System.Windows.Forms.Label lbl_vuelosActivos;
        private System.Windows.Forms.Label lblVuelosTerminados;
        private System.Windows.Forms.Label lblNombreUsuarioTittle;
        private System.Windows.Forms.Label lblActivos;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.Label lblFinalizados;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblVuelosTotales;
        private System.Windows.Forms.Label lblVuelosActivos;
        private System.Windows.Forms.Label lblVuelosFinalizados;
        private System.Windows.Forms.BindingSource vueloBindingSource;
        private System.Windows.Forms.BindingSource vueloBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn origenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinosDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPartidaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaPartidaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaArriboDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPartidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaPartidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaArriboDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AeronaveMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}