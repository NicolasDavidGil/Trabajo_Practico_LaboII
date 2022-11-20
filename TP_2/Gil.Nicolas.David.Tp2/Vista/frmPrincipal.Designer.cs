namespace Vista
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCrearPartida = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnJugarPartida = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReglas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlNuevaPartida = new System.Windows.Forms.Panel();
            this.btnSalirNuevaPartida = new System.Windows.Forms.Button();
            this.btnCrearNuevaPartida = new System.Windows.Forms.Button();
            this.lblErrores = new System.Windows.Forms.Label();
            this.cmbTipoPartida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbJugadorUno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbJugadorDos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObservar = new System.Windows.Forms.Button();
            this.dgvPartidasActivas = new System.Windows.Forms.DataGridView();
            this.jugadorUnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugadorDosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartaMesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtEscribirChat = new System.Windows.Forms.TextBox();
            this.rtbChatPrincipal = new System.Windows.Forms.RichTextBox();
            this.dgvJugadoresOnline = new System.Windows.Forms.DataGridView();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.victoriasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.derrotasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tmrPrincipal = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlNuevaPartida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidasActivas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadoresOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 728);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCrearPartida);
            this.panel4.Controls.Add(this.btnEstadisticas);
            this.panel4.Controls.Add(this.lblUsuario);
            this.panel4.Controls.Add(this.btnJugarPartida);
            this.panel4.Controls.Add(this.btnUsuarios);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 451);
            this.panel4.TabIndex = 0;
            // 
            // btnCrearPartida
            // 
            this.btnCrearPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPartida.FlatAppearance.BorderSize = 2;
            this.btnCrearPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPartida.ForeColor = System.Drawing.Color.Red;
            this.btnCrearPartida.Location = new System.Drawing.Point(12, 27);
            this.btnCrearPartida.Name = "btnCrearPartida";
            this.btnCrearPartida.Size = new System.Drawing.Size(139, 33);
            this.btnCrearPartida.TabIndex = 5;
            this.btnCrearPartida.Text = "CREAR SALA";
            this.btnCrearPartida.UseVisualStyleBackColor = false;
            this.btnCrearPartida.Click += new System.EventHandler(this.btnCrearPartida_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadisticas.FlatAppearance.BorderSize = 2;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.ForeColor = System.Drawing.Color.Red;
            this.btnEstadisticas.Location = new System.Drawing.Point(12, 174);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(136, 30);
            this.btnEstadisticas.TabIndex = 8;
            this.btnEstadisticas.Text = "ESTADISTICAS";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Location = new System.Drawing.Point(12, 276);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 17);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "usuario";
            // 
            // btnJugarPartida
            // 
            this.btnJugarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnJugarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJugarPartida.FlatAppearance.BorderSize = 2;
            this.btnJugarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugarPartida.ForeColor = System.Drawing.Color.Red;
            this.btnJugarPartida.Location = new System.Drawing.Point(12, 76);
            this.btnJugarPartida.Name = "btnJugarPartida";
            this.btnJugarPartida.Size = new System.Drawing.Size(139, 32);
            this.btnJugarPartida.TabIndex = 6;
            this.btnJugarPartida.Text = "JUGAR PARTIDA";
            this.btnJugarPartida.UseVisualStyleBackColor = false;
            this.btnJugarPartida.Click += new System.EventHandler(this.btnJugarPartida_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 2;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.Red;
            this.btnUsuarios.Location = new System.Drawing.Point(12, 125);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(136, 32);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "ADMINISTRAR USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReglas);
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.lblHora);
            this.panel3.Controls.Add(this.lblFecha);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 559);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 169);
            this.panel3.TabIndex = 0;
            // 
            // btnReglas
            // 
            this.btnReglas.BackColor = System.Drawing.Color.Transparent;
            this.btnReglas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReglas.FlatAppearance.BorderSize = 2;
            this.btnReglas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReglas.ForeColor = System.Drawing.Color.Red;
            this.btnReglas.Location = new System.Drawing.Point(12, 68);
            this.btnReglas.Name = "btnReglas";
            this.btnReglas.Size = new System.Drawing.Size(136, 35);
            this.btnReglas.TabIndex = 8;
            this.btnReglas.Text = "REGLAS DE JUEGO";
            this.btnReglas.UseVisualStyleBackColor = false;
            this.btnReglas.Click += new System.EventHandler(this.btnReglas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(13, 116);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 41);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHora.Location = new System.Drawing.Point(12, 3);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(45, 17);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFecha.Location = new System.Drawing.Point(12, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 17);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "fecha";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BackgroundImage = global::Vista.Properties.Resources.logoOK;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 108);
            this.panel2.TabIndex = 2;
            // 
            // pnlNuevaPartida
            // 
            this.pnlNuevaPartida.BackgroundImage = global::Vista.Properties.Resources.minimenu;
            this.pnlNuevaPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNuevaPartida.Controls.Add(this.btnSalirNuevaPartida);
            this.pnlNuevaPartida.Controls.Add(this.btnCrearNuevaPartida);
            this.pnlNuevaPartida.Controls.Add(this.lblErrores);
            this.pnlNuevaPartida.Controls.Add(this.cmbTipoPartida);
            this.pnlNuevaPartida.Controls.Add(this.label4);
            this.pnlNuevaPartida.Controls.Add(this.pictureBox1);
            this.pnlNuevaPartida.Controls.Add(this.label1);
            this.pnlNuevaPartida.Controls.Add(this.cmbJugadorUno);
            this.pnlNuevaPartida.Controls.Add(this.label3);
            this.pnlNuevaPartida.Controls.Add(this.cmbJugadorDos);
            this.pnlNuevaPartida.Controls.Add(this.label2);
            this.pnlNuevaPartida.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNuevaPartida.Location = new System.Drawing.Point(167, 0);
            this.pnlNuevaPartida.Name = "pnlNuevaPartida";
            this.pnlNuevaPartida.Size = new System.Drawing.Size(1139, 265);
            this.pnlNuevaPartida.TabIndex = 9;
            // 
            // btnSalirNuevaPartida
            // 
            this.btnSalirNuevaPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnSalirNuevaPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirNuevaPartida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalirNuevaPartida.Location = new System.Drawing.Point(591, 208);
            this.btnSalirNuevaPartida.Name = "btnSalirNuevaPartida";
            this.btnSalirNuevaPartida.Size = new System.Drawing.Size(75, 37);
            this.btnSalirNuevaPartida.TabIndex = 18;
            this.btnSalirNuevaPartida.Text = "SALIR";
            this.btnSalirNuevaPartida.UseVisualStyleBackColor = false;
            this.btnSalirNuevaPartida.Click += new System.EventHandler(this.btnSalirNuevaPartida_Click);
            // 
            // btnCrearNuevaPartida
            // 
            this.btnCrearNuevaPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearNuevaPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearNuevaPartida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrearNuevaPartida.Location = new System.Drawing.Point(476, 208);
            this.btnCrearNuevaPartida.Name = "btnCrearNuevaPartida";
            this.btnCrearNuevaPartida.Size = new System.Drawing.Size(75, 37);
            this.btnCrearNuevaPartida.TabIndex = 17;
            this.btnCrearNuevaPartida.Text = "CREAR";
            this.btnCrearNuevaPartida.UseVisualStyleBackColor = false;
            this.btnCrearNuevaPartida.Click += new System.EventHandler(this.btnCrearNuevaPartida_Click);
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.BackColor = System.Drawing.Color.Black;
            this.lblErrores.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrores.Location = new System.Drawing.Point(653, 67);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(104, 27);
            this.lblErrores.TabIndex = 15;
            this.lblErrores.Text = "Errores";
            // 
            // cmbTipoPartida
            // 
            this.cmbTipoPartida.FormattingEnabled = true;
            this.cmbTipoPartida.Location = new System.Drawing.Point(686, 134);
            this.cmbTipoPartida.Name = "cmbTipoPartida";
            this.cmbTipoPartida.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoPartida.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(653, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "TIPO DE PARTIDA:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = global::Vista.Properties.Resources.VSOK;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(511, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 74);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(476, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "NUEVO DESAFIO";
            // 
            // cmbJugadorUno
            // 
            this.cmbJugadorUno.FormattingEnabled = true;
            this.cmbJugadorUno.Location = new System.Drawing.Point(511, 67);
            this.cmbJugadorUno.Name = "cmbJugadorUno";
            this.cmbJugadorUno.Size = new System.Drawing.Size(121, 23);
            this.cmbJugadorUno.TabIndex = 9;
            this.cmbJugadorUno.SelectedIndexChanged += new System.EventHandler(this.cmbJugadorUno_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(365, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "JUGADOR 2:";
            // 
            // cmbJugadorDos
            // 
            this.cmbJugadorDos.FormattingEnabled = true;
            this.cmbJugadorDos.Location = new System.Drawing.Point(511, 176);
            this.cmbJugadorDos.Name = "cmbJugadorDos";
            this.cmbJugadorDos.Size = new System.Drawing.Size(121, 23);
            this.cmbJugadorDos.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(365, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "JUGADOR 1:";
            // 
            // btnObservar
            // 
            this.btnObservar.BackgroundImage = global::Vista.Properties.Resources.observar;
            this.btnObservar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObservar.Location = new System.Drawing.Point(31, 313);
            this.btnObservar.Name = "btnObservar";
            this.btnObservar.Size = new System.Drawing.Size(73, 43);
            this.btnObservar.TabIndex = 5;
            this.btnObservar.UseVisualStyleBackColor = true;
            this.btnObservar.Click += new System.EventHandler(this.btnObservar_Click);
            // 
            // dgvPartidasActivas
            // 
            this.dgvPartidasActivas.AutoGenerateColumns = false;
            this.dgvPartidasActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidasActivas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jugadorUnoDataGridViewTextBoxColumn,
            this.jugadorDosDataGridViewTextBoxColumn,
            this.cartaMesaDataGridViewTextBoxColumn,
            this.tipoPartidaDataGridViewTextBoxColumn});
            this.dgvPartidasActivas.DataSource = this.partidaBindingSource;
            this.dgvPartidasActivas.Location = new System.Drawing.Point(31, 184);
            this.dgvPartidasActivas.Name = "dgvPartidasActivas";
            this.dgvPartidasActivas.RowTemplate.Height = 25;
            this.dgvPartidasActivas.Size = new System.Drawing.Size(450, 108);
            this.dgvPartidasActivas.TabIndex = 4;
            this.dgvPartidasActivas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPartidasActivas_RowHeaderMouseClick);
            // 
            // jugadorUnoDataGridViewTextBoxColumn
            // 
            this.jugadorUnoDataGridViewTextBoxColumn.DataPropertyName = "JugadorUno";
            this.jugadorUnoDataGridViewTextBoxColumn.HeaderText = "JugadorUno";
            this.jugadorUnoDataGridViewTextBoxColumn.Name = "jugadorUnoDataGridViewTextBoxColumn";
            // 
            // jugadorDosDataGridViewTextBoxColumn
            // 
            this.jugadorDosDataGridViewTextBoxColumn.DataPropertyName = "JugadorDos";
            this.jugadorDosDataGridViewTextBoxColumn.HeaderText = "JugadorDos";
            this.jugadorDosDataGridViewTextBoxColumn.Name = "jugadorDosDataGridViewTextBoxColumn";
            // 
            // cartaMesaDataGridViewTextBoxColumn
            // 
            this.cartaMesaDataGridViewTextBoxColumn.DataPropertyName = "CartaMesa";
            this.cartaMesaDataGridViewTextBoxColumn.HeaderText = "CartaMesa";
            this.cartaMesaDataGridViewTextBoxColumn.Name = "cartaMesaDataGridViewTextBoxColumn";
            // 
            // tipoPartidaDataGridViewTextBoxColumn
            // 
            this.tipoPartidaDataGridViewTextBoxColumn.DataPropertyName = "TipoPartida";
            this.tipoPartidaDataGridViewTextBoxColumn.HeaderText = "TipoPartida";
            this.tipoPartidaDataGridViewTextBoxColumn.Name = "tipoPartidaDataGridViewTextBoxColumn";
            // 
            // partidaBindingSource
            // 
            this.partidaBindingSource.DataSource = typeof(Entidades.Modelos.Partida);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(425, 693);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(95, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtEscribirChat
            // 
            this.txtEscribirChat.Location = new System.Drawing.Point(26, 693);
            this.txtEscribirChat.Name = "txtEscribirChat";
            this.txtEscribirChat.Size = new System.Drawing.Size(376, 23);
            this.txtEscribirChat.TabIndex = 2;
            // 
            // rtbChatPrincipal
            // 
            this.rtbChatPrincipal.Location = new System.Drawing.Point(26, 529);
            this.rtbChatPrincipal.Name = "rtbChatPrincipal";
            this.rtbChatPrincipal.Size = new System.Drawing.Size(376, 141);
            this.rtbChatPrincipal.TabIndex = 1;
            this.rtbChatPrincipal.Text = "";
            // 
            // dgvJugadoresOnline
            // 
            this.dgvJugadoresOnline.AutoGenerateColumns = false;
            this.dgvJugadoresOnline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadoresOnline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.puntajeDataGridViewTextBoxColumn,
            this.victoriasDataGridViewTextBoxColumn,
            this.derrotasDataGridViewTextBoxColumn,
            this.nacionalidadDataGridViewTextBoxColumn,
            this.EstadoCuenta});
            this.dgvJugadoresOnline.DataSource = this.usuarioBindingSource;
            this.dgvJugadoresOnline.Location = new System.Drawing.Point(672, 184);
            this.dgvJugadoresOnline.Name = "dgvJugadoresOnline";
            this.dgvJugadoresOnline.RowTemplate.Height = 25;
            this.dgvJugadoresOnline.Size = new System.Drawing.Size(455, 532);
            this.dgvJugadoresOnline.TabIndex = 0;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.Width = 76;
            // 
            // puntajeDataGridViewTextBoxColumn
            // 
            this.puntajeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.puntajeDataGridViewTextBoxColumn.DataPropertyName = "Puntaje";
            this.puntajeDataGridViewTextBoxColumn.HeaderText = "Puntaje";
            this.puntajeDataGridViewTextBoxColumn.Name = "puntajeDataGridViewTextBoxColumn";
            this.puntajeDataGridViewTextBoxColumn.Width = 72;
            // 
            // victoriasDataGridViewTextBoxColumn
            // 
            this.victoriasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.victoriasDataGridViewTextBoxColumn.DataPropertyName = "Victorias";
            this.victoriasDataGridViewTextBoxColumn.HeaderText = "Victorias";
            this.victoriasDataGridViewTextBoxColumn.Name = "victoriasDataGridViewTextBoxColumn";
            this.victoriasDataGridViewTextBoxColumn.Width = 77;
            // 
            // derrotasDataGridViewTextBoxColumn
            // 
            this.derrotasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.derrotasDataGridViewTextBoxColumn.DataPropertyName = "Derrotas";
            this.derrotasDataGridViewTextBoxColumn.HeaderText = "Derrotas";
            this.derrotasDataGridViewTextBoxColumn.Name = "derrotasDataGridViewTextBoxColumn";
            this.derrotasDataGridViewTextBoxColumn.Width = 76;
            // 
            // nacionalidadDataGridViewTextBoxColumn
            // 
            this.nacionalidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nacionalidadDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidad";
            this.nacionalidadDataGridViewTextBoxColumn.HeaderText = "Nacionalidad";
            this.nacionalidadDataGridViewTextBoxColumn.Name = "nacionalidadDataGridViewTextBoxColumn";
            this.nacionalidadDataGridViewTextBoxColumn.Width = 102;
            // 
            // EstadoCuenta
            // 
            this.EstadoCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EstadoCuenta.DataPropertyName = "EstadoCuenta";
            this.EstadoCuenta.HeaderText = "Estado";
            this.EstadoCuenta.Name = "EstadoCuenta";
            this.EstadoCuenta.Width = 67;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Entidades.Modelos.Usuario);
            // 
            // tmrPrincipal
            // 
            this.tmrPrincipal.Enabled = true;
            this.tmrPrincipal.Tick += new System.EventHandler(this.tmrPrincipal_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = global::Vista.Properties.Resources.logo;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.btnObservar);
            this.pnlMain.Controls.Add(this.dgvPartidasActivas);
            this.pnlMain.Controls.Add(this.btnEnviar);
            this.pnlMain.Controls.Add(this.dgvJugadoresOnline);
            this.pnlMain.Controls.Add(this.rtbChatPrincipal);
            this.pnlMain.Controls.Add(this.txtEscribirChat);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(167, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1139, 728);
            this.pnlMain.TabIndex = 10;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1306, 728);
            this.ControlBox = false;
            this.Controls.Add(this.pnlNuevaPartida);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "UTN UNO MASTERS";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlNuevaPartida.ResumeLayout(false);
            this.pnlNuevaPartida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidasActivas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadoresOnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Button btnCrearPartida;
        private Button btnEstadisticas;
        private Label lblUsuario;
        private Button btnJugarPartida;
        private Button btnUsuarios;
        private Panel panel3;
        private Button btnReglas;
        private Button btnSalir;
        private Label lblHora;
        private Label lblFecha;
        private Panel panel2;
        private Panel pnlNuevaPartida;
        private Button btnSalirNuevaPartida;
        private Button btnCrearNuevaPartida;
        private Label lblErrores;
        private ComboBox cmbTipoPartida;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cmbJugadorUno;
        private Label label3;
        private ComboBox cmbJugadorDos;
        private Label label2;
        private DataGridView dgvJugadoresOnline;
        private Button btnObservar;
        private DataGridView dgvPartidasActivas;
        private Button btnEnviar;
        private TextBox txtEscribirChat;
        private RichTextBox rtbChatPrincipal;
        private System.Windows.Forms.Timer tmrPrincipal;
        private DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn puntajeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn victoriasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn derrotasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn EstadoCuenta;
        private BindingSource usuarioBindingSource;
        private DataGridViewTextBoxColumn jugadorUnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jugadorDosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cartaMesaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoPartidaDataGridViewTextBoxColumn;
        private BindingSource partidaBindingSource;
        private Panel pnlMain;
    }
}