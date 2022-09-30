namespace Parcial_Laboratorio
{
    partial class DetallesVuelo
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
            this.dtgListaPasajeros = new System.Windows.Forms.DataGridView();
            this.ClienteNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipajeBodegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipajeManoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cantidadMaletasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasajeroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pasajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPasajerosPrimera = new System.Windows.Forms.Label();
            this.lblOrigenVuelo = new System.Windows.Forms.Label();
            this.lblDestinoVuelo = new System.Windows.Forms.Label();
            this.lblFechaPartida = new System.Windows.Forms.Label();
            this.lblHoraPartida = new System.Windows.Forms.Label();
            this.lblHoraLlegada = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lblVueloVacio = new System.Windows.Forms.Label();
            this.dtgCodigoVuelos = new System.Windows.Forms.DataGridView();
            this.lblTittle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalPasajeros = new System.Windows.Forms.Label();
            this.lblPasajerosTurista = new System.Windows.Forms.Label();
            this.lblTotalMaletas = new System.Windows.Forms.Label();
            this.lblPesoTotal = new System.Windows.Forms.Label();
            this.lblAvionDesignada = new System.Windows.Forms.Label();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vuelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaPasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCodigoVuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListaPasajeros
            // 
            this.dtgListaPasajeros.AllowUserToOrderColumns = true;
            this.dtgListaPasajeros.AutoGenerateColumns = false;
            this.dtgListaPasajeros.BackgroundColor = System.Drawing.Color.Navy;
            this.dtgListaPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteNombre,
            this.ClienteDocumento,
            this.ClienteEdad,
            this.equipajeBodegaDataGridViewTextBoxColumn,
            this.equipajeManoDataGridViewCheckBoxColumn,
            this.cantidadMaletasDataGridViewTextBoxColumn});
            this.dtgListaPasajeros.DataSource = this.pasajeroBindingSource1;
            this.dtgListaPasajeros.Location = new System.Drawing.Point(350, 311);
            this.dtgListaPasajeros.Name = "dtgListaPasajeros";
            this.dtgListaPasajeros.RowTemplate.Height = 25;
            this.dtgListaPasajeros.Size = new System.Drawing.Size(644, 440);
            this.dtgListaPasajeros.TabIndex = 0;
            // 
            // ClienteNombre
            // 
            this.ClienteNombre.DataPropertyName = "ClienteNombre";
            this.ClienteNombre.HeaderText = "Nombre";
            this.ClienteNombre.Name = "ClienteNombre";
            // 
            // ClienteDocumento
            // 
            this.ClienteDocumento.DataPropertyName = "ClienteDocumento";
            this.ClienteDocumento.HeaderText = "Documento";
            this.ClienteDocumento.Name = "ClienteDocumento";
            this.ClienteDocumento.ReadOnly = true;
            // 
            // ClienteEdad
            // 
            this.ClienteEdad.DataPropertyName = "ClienteEdad";
            this.ClienteEdad.HeaderText = "Edad";
            this.ClienteEdad.Name = "ClienteEdad";
            this.ClienteEdad.ReadOnly = true;
            // 
            // equipajeBodegaDataGridViewTextBoxColumn
            // 
            this.equipajeBodegaDataGridViewTextBoxColumn.DataPropertyName = "EquipajeBodega";
            this.equipajeBodegaDataGridViewTextBoxColumn.HeaderText = "EquipajeBodega";
            this.equipajeBodegaDataGridViewTextBoxColumn.Name = "equipajeBodegaDataGridViewTextBoxColumn";
            // 
            // equipajeManoDataGridViewCheckBoxColumn
            // 
            this.equipajeManoDataGridViewCheckBoxColumn.DataPropertyName = "EquipajeMano";
            this.equipajeManoDataGridViewCheckBoxColumn.HeaderText = "EquipajeMano";
            this.equipajeManoDataGridViewCheckBoxColumn.Name = "equipajeManoDataGridViewCheckBoxColumn";
            this.equipajeManoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // cantidadMaletasDataGridViewTextBoxColumn
            // 
            this.cantidadMaletasDataGridViewTextBoxColumn.DataPropertyName = "CantidadMaletas";
            this.cantidadMaletasDataGridViewTextBoxColumn.HeaderText = "CantidadMaletas";
            this.cantidadMaletasDataGridViewTextBoxColumn.Name = "cantidadMaletasDataGridViewTextBoxColumn";
            // 
            // pasajeroBindingSource1
            // 
            this.pasajeroBindingSource1.DataSource = typeof(Parcial_Library.Pasajero);
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataSource = typeof(Parcial_Library.Cliente);
            // 
            // pasajeroBindingSource
            // 
            this.pasajeroBindingSource.DataSource = typeof(Parcial_Library.Pasajero);
            // 
            // lblPasajerosPrimera
            // 
            this.lblPasajerosPrimera.AutoSize = true;
            this.lblPasajerosPrimera.BackColor = System.Drawing.Color.Transparent;
            this.lblPasajerosPrimera.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasajerosPrimera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPasajerosPrimera.Location = new System.Drawing.Point(563, 113);
            this.lblPasajerosPrimera.Name = "lblPasajerosPrimera";
            this.lblPasajerosPrimera.Size = new System.Drawing.Size(0, 21);
            this.lblPasajerosPrimera.TabIndex = 1;
            // 
            // lblOrigenVuelo
            // 
            this.lblOrigenVuelo.AutoSize = true;
            this.lblOrigenVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigenVuelo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrigenVuelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOrigenVuelo.Location = new System.Drawing.Point(135, 76);
            this.lblOrigenVuelo.Name = "lblOrigenVuelo";
            this.lblOrigenVuelo.Size = new System.Drawing.Size(0, 21);
            this.lblOrigenVuelo.TabIndex = 2;
            // 
            // lblDestinoVuelo
            // 
            this.lblDestinoVuelo.AutoSize = true;
            this.lblDestinoVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lblDestinoVuelo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestinoVuelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDestinoVuelo.Location = new System.Drawing.Point(135, 113);
            this.lblDestinoVuelo.Name = "lblDestinoVuelo";
            this.lblDestinoVuelo.Size = new System.Drawing.Size(0, 21);
            this.lblDestinoVuelo.TabIndex = 3;
            // 
            // lblFechaPartida
            // 
            this.lblFechaPartida.AutoSize = true;
            this.lblFechaPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaPartida.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaPartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFechaPartida.Location = new System.Drawing.Point(140, 149);
            this.lblFechaPartida.Name = "lblFechaPartida";
            this.lblFechaPartida.Size = new System.Drawing.Size(0, 21);
            this.lblFechaPartida.TabIndex = 4;
            // 
            // lblHoraPartida
            // 
            this.lblHoraPartida.AutoSize = true;
            this.lblHoraPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraPartida.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHoraPartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblHoraPartida.Location = new System.Drawing.Point(140, 183);
            this.lblHoraPartida.Name = "lblHoraPartida";
            this.lblHoraPartida.Size = new System.Drawing.Size(0, 21);
            this.lblHoraPartida.TabIndex = 5;
            // 
            // lblHoraLlegada
            // 
            this.lblHoraLlegada.AutoSize = true;
            this.lblHoraLlegada.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraLlegada.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHoraLlegada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblHoraLlegada.Location = new System.Drawing.Point(140, 212);
            this.lblHoraLlegada.Name = "lblHoraLlegada";
            this.lblHoraLlegada.Size = new System.Drawing.Size(0, 21);
            this.lblHoraLlegada.TabIndex = 6;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.FlatAppearance.BorderSize = 3;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cerrar.ForeColor = System.Drawing.Color.Black;
            this.btn_cerrar.Location = new System.Drawing.Point(981, 159);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(131, 74);
            this.btn_cerrar.TabIndex = 7;
            this.btn_cerrar.Text = "CERRAR";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // lblVueloVacio
            // 
            this.lblVueloVacio.AutoSize = true;
            this.lblVueloVacio.BackColor = System.Drawing.Color.Navy;
            this.lblVueloVacio.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVueloVacio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblVueloVacio.Location = new System.Drawing.Point(416, 535);
            this.lblVueloVacio.Name = "lblVueloVacio";
            this.lblVueloVacio.Size = new System.Drawing.Size(497, 27);
            this.lblVueloVacio.TabIndex = 8;
            this.lblVueloVacio.Text = "ESTE VUELO NO POSEE PASAJEROS CARGADOS";
            // 
            // dtgCodigoVuelos
            // 
            this.dtgCodigoVuelos.BackgroundColor = System.Drawing.Color.Navy;
            this.dtgCodigoVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCodigoVuelos.Location = new System.Drawing.Point(121, 389);
            this.dtgCodigoVuelos.Name = "dtgCodigoVuelos";
            this.dtgCodigoVuelos.RowTemplate.Height = 25;
            this.dtgCodigoVuelos.Size = new System.Drawing.Size(143, 234);
            this.dtgCodigoVuelos.TabIndex = 9;
            this.dtgCodigoVuelos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgCodigoVuelos_RowHeaderMouseClick);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTittle.Location = new System.Drawing.Point(416, 12);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(301, 30);
            this.lblTittle.TabIndex = 10;
            this.lblTittle.Text = "INFORMACION DEL VUELO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(57, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "ORIGEN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(49, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "DESTINO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "FECHA SALIDA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(16, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "HORA SALIDA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(14, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "HORA ARRIBO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(305, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "TOTAL PASAJEROS A BORDO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(332, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "PASAJEROS EN PRIMERA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(338, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "PASAJEROS EN TURISTA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(269, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "CANTIDAD MALETAS EN BODEGA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(345, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "PESO TOTAL EN CARGA:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(633, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "AERONAVE DESIGNADA:";
            // 
            // lblTotalPasajeros
            // 
            this.lblTotalPasajeros.AutoSize = true;
            this.lblTotalPasajeros.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPasajeros.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPasajeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTotalPasajeros.Location = new System.Drawing.Point(563, 76);
            this.lblTotalPasajeros.Name = "lblTotalPasajeros";
            this.lblTotalPasajeros.Size = new System.Drawing.Size(0, 21);
            this.lblTotalPasajeros.TabIndex = 22;
            // 
            // lblPasajerosTurista
            // 
            this.lblPasajerosTurista.AutoSize = true;
            this.lblPasajerosTurista.BackColor = System.Drawing.Color.Transparent;
            this.lblPasajerosTurista.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasajerosTurista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPasajerosTurista.Location = new System.Drawing.Point(563, 149);
            this.lblPasajerosTurista.Name = "lblPasajerosTurista";
            this.lblPasajerosTurista.Size = new System.Drawing.Size(0, 21);
            this.lblPasajerosTurista.TabIndex = 23;
            // 
            // lblTotalMaletas
            // 
            this.lblTotalMaletas.AutoSize = true;
            this.lblTotalMaletas.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMaletas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalMaletas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTotalMaletas.Location = new System.Drawing.Point(563, 183);
            this.lblTotalMaletas.Name = "lblTotalMaletas";
            this.lblTotalMaletas.Size = new System.Drawing.Size(0, 21);
            this.lblTotalMaletas.TabIndex = 24;
            // 
            // lblPesoTotal
            // 
            this.lblPesoTotal.AutoSize = true;
            this.lblPesoTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPesoTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPesoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPesoTotal.Location = new System.Drawing.Point(563, 221);
            this.lblPesoTotal.Name = "lblPesoTotal";
            this.lblPesoTotal.Size = new System.Drawing.Size(0, 21);
            this.lblPesoTotal.TabIndex = 25;
            // 
            // lblAvionDesignada
            // 
            this.lblAvionDesignada.AutoSize = true;
            this.lblAvionDesignada.BackColor = System.Drawing.Color.Transparent;
            this.lblAvionDesignada.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvionDesignada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAvionDesignada.Location = new System.Drawing.Point(827, 76);
            this.lblAvionDesignada.Name = "lblAvionDesignada";
            this.lblAvionDesignada.Size = new System.Drawing.Size(0, 21);
            this.lblAvionDesignada.TabIndex = 26;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Parcial_Library.Cliente);
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(Parcial_Library.Persona);
            // 
            // vuelosBindingSource
            // 
            this.vuelosBindingSource.DataMember = "Vuelos";
            this.vuelosBindingSource.DataSource = this.clienteBindingSource1;
            // 
            // DetallesVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial_Laboratorio.Properties.Resources.Img1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 750);
            this.Controls.Add(this.lblAvionDesignada);
            this.Controls.Add(this.lblPesoTotal);
            this.Controls.Add(this.lblTotalMaletas);
            this.Controls.Add(this.lblPasajerosTurista);
            this.Controls.Add(this.lblTotalPasajeros);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.dtgCodigoVuelos);
            this.Controls.Add(this.lblVueloVacio);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.lblHoraLlegada);
            this.Controls.Add(this.lblHoraPartida);
            this.Controls.Add(this.lblFechaPartida);
            this.Controls.Add(this.lblDestinoVuelo);
            this.Controls.Add(this.lblOrigenVuelo);
            this.Controls.Add(this.lblPasajerosPrimera);
            this.Controls.Add(this.dtgListaPasajeros);
            this.DoubleBuffered = true;
            this.Name = "DetallesVuelo";
            this.Text = "DetallesVuelo";
            this.Load += new System.EventHandler(this.DetallesVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaPasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCodigoVuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListaPasajeros;
        private System.Windows.Forms.Label lblPasajerosPrimera;
        private System.Windows.Forms.Label lblOrigenVuelo;
        private System.Windows.Forms.Label lblDestinoVuelo;
        private System.Windows.Forms.Label lblFechaPartida;
        private System.Windows.Forms.Label lblHoraPartida;
        private System.Windows.Forms.Label lblHoraLlegada;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lblVueloVacio;
        private System.Windows.Forms.BindingSource pasajeroBindingSource;
        private System.Windows.Forms.DataGridView dtgCodigoVuelos;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalPasajeros;
        private System.Windows.Forms.Label lblPasajerosTurista;
        private System.Windows.Forms.Label lblTotalMaletas;
        private System.Windows.Forms.Label lblPesoTotal;
        private System.Windows.Forms.Label lblAvionDesignada;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private System.Windows.Forms.BindingSource pasajeroBindingSource1;
        private System.Windows.Forms.BindingSource vuelosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipajeBodegaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn equipajeManoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadMaletasDataGridViewTextBoxColumn;
    }
}