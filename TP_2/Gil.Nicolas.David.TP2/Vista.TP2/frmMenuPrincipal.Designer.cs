namespace Vista.TP2
{
    partial class frmMenuPrincipal
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
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntajeJugadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnEliminarJugador = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnNuevoJugador = new System.Windows.Forms.Button();
            this.btnNuevaPartida = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnObservar = new System.Windows.Forms.Button();
            this.dgvPartidas = new System.Windows.Forms.DataGridView();
            this.fechaPartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugadorUnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugadorDosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartaMesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoJuegoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPartidas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNuevaPartida = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbJugadorDos = new System.Windows.Forms.ComboBox();
            this.cmbJugadorUno = new System.Windows.Forms.ComboBox();
            this.btnPanelCancelar = new System.Windows.Forms.Button();
            this.btnPanelIniciar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).BeginInit();
            this.pnlNuevaPartida.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.AutoGenerateColumns = false;
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.puntajeJugadorDataGridViewTextBoxColumn,
            this.Clase});
            this.dgvJugadores.DataSource = this.usuarioBindingSource;
            this.dgvJugadores.Location = new System.Drawing.Point(972, 55);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.RowTemplate.Height = 25;
            this.dgvJugadores.Size = new System.Drawing.Size(220, 561);
            this.dgvJugadores.TabIndex = 0;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "User";
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.Width = 55;
            // 
            // puntajeJugadorDataGridViewTextBoxColumn
            // 
            this.puntajeJugadorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.puntajeJugadorDataGridViewTextBoxColumn.DataPropertyName = "PuntajeJugador";
            this.puntajeJugadorDataGridViewTextBoxColumn.HeaderText = "Score";
            this.puntajeJugadorDataGridViewTextBoxColumn.Name = "puntajeJugadorDataGridViewTextBoxColumn";
            this.puntajeJugadorDataGridViewTextBoxColumn.Width = 61;
            // 
            // Clase
            // 
            this.Clase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Clase.HeaderText = "Clase";
            this.Clase.Name = "Clase";
            this.Clase.Width = 60;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Library.TP2.Usuario);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Gray;
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.btnEliminarJugador);
            this.pnlMenu.Controls.Add(this.btnEstadisticas);
            this.pnlMenu.Controls.Add(this.btnNuevoJugador);
            this.pnlMenu.Controls.Add(this.btnNuevaPartida);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(158, 628);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 2;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Brown;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 574);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(158, 51);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "CERRAR SESION";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnEliminarJugador
            // 
            this.btnEliminarJugador.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarJugador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarJugador.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnEliminarJugador.FlatAppearance.BorderSize = 2;
            this.btnEliminarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarJugador.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarJugador.ForeColor = System.Drawing.Color.Brown;
            this.btnEliminarJugador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarJugador.Location = new System.Drawing.Point(0, 236);
            this.btnEliminarJugador.Name = "btnEliminarJugador";
            this.btnEliminarJugador.Size = new System.Drawing.Size(158, 51);
            this.btnEliminarJugador.TabIndex = 5;
            this.btnEliminarJugador.Text = "ELIMINAR JUGADOR";
            this.btnEliminarJugador.UseVisualStyleBackColor = false;
            this.btnEliminarJugador.Click += new System.EventHandler(this.btnEliminarJugador_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadisticas.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnEstadisticas.FlatAppearance.BorderSize = 2;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticas.ForeColor = System.Drawing.Color.Brown;
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEstadisticas.Location = new System.Drawing.Point(0, 293);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(158, 51);
            this.btnEstadisticas.TabIndex = 4;
            this.btnEstadisticas.Text = "ESTADISTICAS";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnNuevoJugador
            // 
            this.btnNuevoJugador.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoJugador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoJugador.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnNuevoJugador.FlatAppearance.BorderSize = 2;
            this.btnNuevoJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoJugador.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoJugador.ForeColor = System.Drawing.Color.Brown;
            this.btnNuevoJugador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoJugador.Location = new System.Drawing.Point(0, 179);
            this.btnNuevoJugador.Name = "btnNuevoJugador";
            this.btnNuevoJugador.Size = new System.Drawing.Size(158, 51);
            this.btnNuevoJugador.TabIndex = 3;
            this.btnNuevoJugador.Text = "NUEVO JUGADOR";
            this.btnNuevoJugador.UseVisualStyleBackColor = false;
            this.btnNuevoJugador.Click += new System.EventHandler(this.btnNuevoJugador_Click);
            // 
            // btnNuevaPartida
            // 
            this.btnNuevaPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevaPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaPartida.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnNuevaPartida.FlatAppearance.BorderSize = 2;
            this.btnNuevaPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaPartida.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevaPartida.ForeColor = System.Drawing.Color.Brown;
            this.btnNuevaPartida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevaPartida.Location = new System.Drawing.Point(0, 122);
            this.btnNuevaPartida.Name = "btnNuevaPartida";
            this.btnNuevaPartida.Size = new System.Drawing.Size(158, 51);
            this.btnNuevaPartida.TabIndex = 2;
            this.btnNuevaPartida.Text = "NUEVA PARTIDA";
            this.btnNuevaPartida.UseVisualStyleBackColor = false;
            this.btnNuevaPartida.Click += new System.EventHandler(this.btnNuevaPartida_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BackgroundImage = global::Vista.TP2.Properties.Resources.logoOK;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 104);
            this.panel1.TabIndex = 0;
            // 
            // btnObservar
            // 
            this.btnObservar.BackColor = System.Drawing.Color.Gray;
            this.btnObservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObservar.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnObservar.FlatAppearance.BorderSize = 2;
            this.btnObservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObservar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnObservar.ForeColor = System.Drawing.Color.Brown;
            this.btnObservar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnObservar.Location = new System.Drawing.Point(735, 231);
            this.btnObservar.Name = "btnObservar";
            this.btnObservar.Size = new System.Drawing.Size(162, 41);
            this.btnObservar.TabIndex = 7;
            this.btnObservar.Text = "observar";
            this.btnObservar.UseVisualStyleBackColor = false;
            this.btnObservar.Click += new System.EventHandler(this.btnObservar_Click);
            // 
            // dgvPartidas
            // 
            this.dgvPartidas.AutoGenerateColumns = false;
            this.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaPartidaDataGridViewTextBoxColumn,
            this.jugadorUnoDataGridViewTextBoxColumn,
            this.jugadorDosDataGridViewTextBoxColumn,
            this.cartaMesaDataGridViewTextBoxColumn,
            this.ganadorDataGridViewTextBoxColumn,
            this.turnoJuegoDataGridViewTextBoxColumn});
            this.dgvPartidas.DataSource = this.partidaBindingSource;
            this.dgvPartidas.Location = new System.Drawing.Point(642, 55);
            this.dgvPartidas.Name = "dgvPartidas";
            this.dgvPartidas.RowTemplate.Height = 25;
            this.dgvPartidas.Size = new System.Drawing.Size(324, 170);
            this.dgvPartidas.TabIndex = 2;
            this.dgvPartidas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPartidas_RowHeaderMouseClick);
            // 
            // fechaPartidaDataGridViewTextBoxColumn
            // 
            this.fechaPartidaDataGridViewTextBoxColumn.DataPropertyName = "FechaPartida";
            this.fechaPartidaDataGridViewTextBoxColumn.HeaderText = "FechaPartida";
            this.fechaPartidaDataGridViewTextBoxColumn.Name = "fechaPartidaDataGridViewTextBoxColumn";
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
            // ganadorDataGridViewTextBoxColumn
            // 
            this.ganadorDataGridViewTextBoxColumn.DataPropertyName = "Ganador";
            this.ganadorDataGridViewTextBoxColumn.HeaderText = "Ganador";
            this.ganadorDataGridViewTextBoxColumn.Name = "ganadorDataGridViewTextBoxColumn";
            // 
            // turnoJuegoDataGridViewTextBoxColumn
            // 
            this.turnoJuegoDataGridViewTextBoxColumn.DataPropertyName = "TurnoJuego";
            this.turnoJuegoDataGridViewTextBoxColumn.HeaderText = "TurnoJuego";
            this.turnoJuegoDataGridViewTextBoxColumn.Name = "turnoJuegoDataGridViewTextBoxColumn";
            this.turnoJuegoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partidaBindingSource
            // 
            this.partidaBindingSource.DataSource = typeof(Library.TP2.Partida);
            // 
            // lblPartidas
            // 
            this.lblPartidas.AutoSize = true;
            this.lblPartidas.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPartidas.ForeColor = System.Drawing.Color.Red;
            this.lblPartidas.Location = new System.Drawing.Point(760, 26);
            this.lblPartidas.Name = "lblPartidas";
            this.lblPartidas.Size = new System.Drawing.Size(129, 17);
            this.lblPartidas.TabIndex = 3;
            this.lblPartidas.Text = "PARTIDAS ACTIVAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1022, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "JUGADORES ONLINE";
            // 
            // pnlNuevaPartida
            // 
            this.pnlNuevaPartida.BackColor = System.Drawing.Color.Gray;
            this.pnlNuevaPartida.Controls.Add(this.label4);
            this.pnlNuevaPartida.Controls.Add(this.label3);
            this.pnlNuevaPartida.Controls.Add(this.cmbJugadorDos);
            this.pnlNuevaPartida.Controls.Add(this.cmbJugadorUno);
            this.pnlNuevaPartida.Controls.Add(this.btnPanelCancelar);
            this.pnlNuevaPartida.Controls.Add(this.btnPanelIniciar);
            this.pnlNuevaPartida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pnlNuevaPartida.Location = new System.Drawing.Point(182, 122);
            this.pnlNuevaPartida.Name = "pnlNuevaPartida";
            this.pnlNuevaPartida.Size = new System.Drawing.Size(259, 246);
            this.pnlNuevaPartida.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(94, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jugador Dos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(94, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jugador Uno:";
            // 
            // cmbJugadorDos
            // 
            this.cmbJugadorDos.FormattingEnabled = true;
            this.cmbJugadorDos.Location = new System.Drawing.Point(69, 139);
            this.cmbJugadorDos.Name = "cmbJugadorDos";
            this.cmbJugadorDos.Size = new System.Drawing.Size(121, 25);
            this.cmbJugadorDos.TabIndex = 3;
            // 
            // cmbJugadorUno
            // 
            this.cmbJugadorUno.FormattingEnabled = true;
            this.cmbJugadorUno.Location = new System.Drawing.Point(69, 66);
            this.cmbJugadorUno.Name = "cmbJugadorUno";
            this.cmbJugadorUno.Size = new System.Drawing.Size(121, 25);
            this.cmbJugadorUno.TabIndex = 2;
            // 
            // btnPanelCancelar
            // 
            this.btnPanelCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPanelCancelar.FlatAppearance.BorderSize = 2;
            this.btnPanelCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelCancelar.ForeColor = System.Drawing.Color.Brown;
            this.btnPanelCancelar.Location = new System.Drawing.Point(135, 176);
            this.btnPanelCancelar.Name = "btnPanelCancelar";
            this.btnPanelCancelar.Size = new System.Drawing.Size(88, 56);
            this.btnPanelCancelar.TabIndex = 1;
            this.btnPanelCancelar.Text = "CANCELAR";
            this.btnPanelCancelar.UseVisualStyleBackColor = true;
            this.btnPanelCancelar.Click += new System.EventHandler(this.btnPanelCancelar_Click);
            // 
            // btnPanelIniciar
            // 
            this.btnPanelIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPanelIniciar.FlatAppearance.BorderSize = 2;
            this.btnPanelIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelIniciar.ForeColor = System.Drawing.Color.Brown;
            this.btnPanelIniciar.Location = new System.Drawing.Point(41, 176);
            this.btnPanelIniciar.Name = "btnPanelIniciar";
            this.btnPanelIniciar.Size = new System.Drawing.Size(88, 56);
            this.btnPanelIniciar.TabIndex = 0;
            this.btnPanelIniciar.Text = "INICIAR PARTIDA";
            this.btnPanelIniciar.UseVisualStyleBackColor = true;
            this.btnPanelIniciar.Click += new System.EventHandler(this.btnPanelIniciar_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(182, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(45, 17);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(182, 39);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 17);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "fecha";
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Vista.TP2.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1204, 628);
            this.ControlBox = false;
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.pnlNuevaPartida);
            this.Controls.Add(this.btnObservar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPartidas);
            this.Controls.Add(this.dgvPartidas);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.dgvJugadores);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).EndInit();
            this.pnlNuevaPartida.ResumeLayout(false);
            this.pnlNuevaPartida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvJugadores;
        private Panel pnlMenu;
        private Button btnCerrarSesion;
        private Button btnObservar;
        private Button btnEliminarJugador;
        private Button btnEstadisticas;
        private Button btnNuevoJugador;
        private Button btnNuevaPartida;
        private Panel panel1;
        private DataGridView dgvPartidas;
        private Label lblPartidas;
        private Label label2;
        private Panel pnlNuevaPartida;
        private Label label4;
        private Label label3;
        private ComboBox cmbJugadorDos;
        private ComboBox cmbJugadorUno;
        private Button btnPanelCancelar;
        private Button btnPanelIniciar;
        private BindingSource usuarioBindingSource;
        private DataGridViewTextBoxColumn jugadorUnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jugadorDosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cartaMesaDataGridViewTextBoxColumn;
        private BindingSource partidaBindingSource;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer tmrHora;
        private DataGridViewTextBoxColumn fechaPartidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ganadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnoJuegoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn puntajeJugadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Clase;
    }
}