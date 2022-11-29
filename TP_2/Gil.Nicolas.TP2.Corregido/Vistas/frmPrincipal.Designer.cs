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
            this.pnlMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnReadme = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCrearSala = new System.Windows.Forms.Button();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.btnReglasJuego = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlNuevaPartida = new System.Windows.Forms.Panel();
            this.btnSalirNuevaPartida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearNuevaPartida = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErroresPnlNueva = new System.Windows.Forms.Label();
            this.cmbJugadorDos = new System.Windows.Forms.ComboBox();
            this.cmbTipoPartida = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbJugadorUno = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnObservar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.dgvPartidasActivas = new System.Windows.Forms.DataGridView();
            this.NombreUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvJugadoresOnline = new System.Windows.Forms.DataGridView();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tmbPrincipal = new System.Windows.Forms.Timer(this.components);
            this.pnlMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNuevaPartida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidasActivas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadoresOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuPrincipal
            // 
            this.pnlMenuPrincipal.AutoSize = true;
            this.pnlMenuPrincipal.BackColor = System.Drawing.Color.Azure;
            this.pnlMenuPrincipal.Controls.Add(this.btnReadme);
            this.pnlMenuPrincipal.Controls.Add(this.pictureBox2);
            this.pnlMenuPrincipal.Controls.Add(this.lblUsuario);
            this.pnlMenuPrincipal.Controls.Add(this.btnCerrarSesion);
            this.pnlMenuPrincipal.Controls.Add(this.btnCrearSala);
            this.pnlMenuPrincipal.Controls.Add(this.btnAdministrar);
            this.pnlMenuPrincipal.Controls.Add(this.btnReglasJuego);
            this.pnlMenuPrincipal.Controls.Add(this.btnEstadisticas);
            this.pnlMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            this.pnlMenuPrincipal.Size = new System.Drawing.Size(225, 673);
            this.pnlMenuPrincipal.TabIndex = 0;
            // 
            // btnReadme
            // 
            this.btnReadme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadme.BackColor = System.Drawing.Color.Transparent;
            this.btnReadme.FlatAppearance.BorderSize = 0;
            this.btnReadme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReadme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadme.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReadme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReadme.Image = global::Vista.Properties.Resources.IconoReglas;
            this.btnReadme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadme.Location = new System.Drawing.Point(13, 459);
            this.btnReadme.Name = "btnReadme";
            this.btnReadme.Size = new System.Drawing.Size(170, 50);
            this.btnReadme.TabIndex = 9;
            this.btnReadme.Text = "README";
            this.btnReadme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReadme.UseVisualStyleBackColor = false;
            this.btnReadme.Click += new System.EventHandler(this.btnReadme_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Vista.Properties.Resources.LogoJuego;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(13, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 62);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuario.Location = new System.Drawing.Point(13, 364);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 17);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "usuario";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarSesion.Image = global::Vista.Properties.Resources.IconoCerrarSesion;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(13, 596);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(170, 49);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "CERRAR SESION";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnCrearSala
            // 
            this.btnCrearSala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearSala.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearSala.FlatAppearance.BorderSize = 0;
            this.btnCrearSala.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCrearSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearSala.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearSala.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCrearSala.Image = global::Vista.Properties.Resources.IconoJugar;
            this.btnCrearSala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearSala.Location = new System.Drawing.Point(12, 107);
            this.btnCrearSala.Name = "btnCrearSala";
            this.btnCrearSala.Size = new System.Drawing.Size(195, 50);
            this.btnCrearSala.TabIndex = 1;
            this.btnCrearSala.Text = "CREAR SALA";
            this.btnCrearSala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearSala.UseVisualStyleBackColor = false;
            this.btnCrearSala.Click += new System.EventHandler(this.btnCrearSala_Click);
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdministrar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdministrar.FlatAppearance.BorderSize = 0;
            this.btnAdministrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdministrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdministrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdministrar.Image = global::Vista.Properties.Resources.IconoAdministrar;
            this.btnAdministrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrar.Location = new System.Drawing.Point(12, 175);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(195, 50);
            this.btnAdministrar.TabIndex = 2;
            this.btnAdministrar.Text = "ADMINISTRAR";
            this.btnAdministrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdministrar.UseVisualStyleBackColor = false;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // btnReglasJuego
            // 
            this.btnReglasJuego.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReglasJuego.BackColor = System.Drawing.Color.Transparent;
            this.btnReglasJuego.FlatAppearance.BorderSize = 0;
            this.btnReglasJuego.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReglasJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReglasJuego.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReglasJuego.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReglasJuego.Image = global::Vista.Properties.Resources.IconoReglas;
            this.btnReglasJuego.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReglasJuego.Location = new System.Drawing.Point(13, 525);
            this.btnReglasJuego.Name = "btnReglasJuego";
            this.btnReglasJuego.Size = new System.Drawing.Size(170, 50);
            this.btnReglasJuego.TabIndex = 4;
            this.btnReglasJuego.Text = "REGLAS DE JUEGO";
            this.btnReglasJuego.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReglasJuego.UseVisualStyleBackColor = false;
            this.btnReglasJuego.Click += new System.EventHandler(this.btnReglasJuego_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEstadisticas.Image = global::Vista.Properties.Resources.IconoEstadisticasOK;
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.Location = new System.Drawing.Point(12, 240);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(195, 50);
            this.btnEstadisticas.TabIndex = 3;
            this.btnEstadisticas.Text = "VER ESTADISTICAS";
            this.btnEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Gold;
            this.lblError.Location = new System.Drawing.Point(466, 26);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(41, 16);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "error";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFecha.Location = new System.Drawing.Point(823, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 16);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "fecha";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHora.Location = new System.Drawing.Point(823, 40);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(37, 16);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "hora";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPrincipal.AutoSize = true;
            this.pnlPrincipal.BackColor = System.Drawing.Color.Azure;
            this.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPrincipal.Controls.Add(this.pnlNuevaPartida);
            this.pnlPrincipal.Controls.Add(this.btnCancelar);
            this.pnlPrincipal.Controls.Add(this.btnObservar);
            this.pnlPrincipal.Controls.Add(this.panel3);
            this.pnlPrincipal.Controls.Add(this.dgvPartidasActivas);
            this.pnlPrincipal.Controls.Add(this.btnEnviar);
            this.pnlPrincipal.Controls.Add(this.txtChat);
            this.pnlPrincipal.Controls.Add(this.rtbChat);
            this.pnlPrincipal.Controls.Add(this.button1);
            this.pnlPrincipal.Controls.Add(this.dgvJugadoresOnline);
            this.pnlPrincipal.ForeColor = System.Drawing.Color.Red;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1140, 673);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pnlNuevaPartida
            // 
            this.pnlNuevaPartida.BackColor = System.Drawing.Color.Black;
            this.pnlNuevaPartida.Controls.Add(this.btnSalirNuevaPartida);
            this.pnlNuevaPartida.Controls.Add(this.label1);
            this.pnlNuevaPartida.Controls.Add(this.btnCrearNuevaPartida);
            this.pnlNuevaPartida.Controls.Add(this.label2);
            this.pnlNuevaPartida.Controls.Add(this.lblErroresPnlNueva);
            this.pnlNuevaPartida.Controls.Add(this.cmbJugadorDos);
            this.pnlNuevaPartida.Controls.Add(this.cmbTipoPartida);
            this.pnlNuevaPartida.Controls.Add(this.label3);
            this.pnlNuevaPartida.Controls.Add(this.label4);
            this.pnlNuevaPartida.Controls.Add(this.cmbJugadorUno);
            this.pnlNuevaPartida.Controls.Add(this.pictureBox1);
            this.pnlNuevaPartida.Location = new System.Drawing.Point(374, 107);
            this.pnlNuevaPartida.Name = "pnlNuevaPartida";
            this.pnlNuevaPartida.Size = new System.Drawing.Size(704, 480);
            this.pnlNuevaPartida.TabIndex = 6;
            // 
            // btnSalirNuevaPartida
            // 
            this.btnSalirNuevaPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnSalirNuevaPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirNuevaPartida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalirNuevaPartida.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSalirNuevaPartida.Location = new System.Drawing.Point(377, 312);
            this.btnSalirNuevaPartida.Name = "btnSalirNuevaPartida";
            this.btnSalirNuevaPartida.Size = new System.Drawing.Size(100, 50);
            this.btnSalirNuevaPartida.TabIndex = 29;
            this.btnSalirNuevaPartida.Text = "SALIR";
            this.btnSalirNuevaPartida.UseVisualStyleBackColor = false;
            this.btnSalirNuevaPartida.Click += new System.EventHandler(this.btnSalirNuevaPartida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(241, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "NUEVO DESAFIO";
            // 
            // btnCrearNuevaPartida
            // 
            this.btnCrearNuevaPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearNuevaPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearNuevaPartida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrearNuevaPartida.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCrearNuevaPartida.Location = new System.Drawing.Point(250, 312);
            this.btnCrearNuevaPartida.Name = "btnCrearNuevaPartida";
            this.btnCrearNuevaPartida.Size = new System.Drawing.Size(100, 50);
            this.btnCrearNuevaPartida.TabIndex = 28;
            this.btnCrearNuevaPartida.Text = "CREAR";
            this.btnCrearNuevaPartida.UseVisualStyleBackColor = false;
            this.btnCrearNuevaPartida.Click += new System.EventHandler(this.btnCrearNuevaPartida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(161, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "JUGADOR 1:";
            // 
            // lblErroresPnlNueva
            // 
            this.lblErroresPnlNueva.AutoSize = true;
            this.lblErroresPnlNueva.BackColor = System.Drawing.Color.Black;
            this.lblErroresPnlNueva.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErroresPnlNueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErroresPnlNueva.Location = new System.Drawing.Point(174, 384);
            this.lblErroresPnlNueva.Name = "lblErroresPnlNueva";
            this.lblErroresPnlNueva.Size = new System.Drawing.Size(434, 27);
            this.lblErroresPnlNueva.TabIndex = 26;
            this.lblErroresPnlNueva.Text = "SE DEBEN COMPLETAR TODOS LOS CAMPOS";
            // 
            // cmbJugadorDos
            // 
            this.cmbJugadorDos.FormattingEnabled = true;
            this.cmbJugadorDos.Location = new System.Drawing.Point(307, 266);
            this.cmbJugadorDos.Name = "cmbJugadorDos";
            this.cmbJugadorDos.Size = new System.Drawing.Size(121, 23);
            this.cmbJugadorDos.TabIndex = 21;
            this.cmbJugadorDos.SelectedIndexChanged += new System.EventHandler(this.cmbJugadorDos_SelectedIndexChanged);
            // 
            // cmbTipoPartida
            // 
            this.cmbTipoPartida.FormattingEnabled = true;
            this.cmbTipoPartida.Location = new System.Drawing.Point(482, 224);
            this.cmbTipoPartida.Name = "cmbTipoPartida";
            this.cmbTipoPartida.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoPartida.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(161, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "JUGADOR 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(449, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "TIPO DE PARTIDA:";
            // 
            // cmbJugadorUno
            // 
            this.cmbJugadorUno.FormattingEnabled = true;
            this.cmbJugadorUno.Location = new System.Drawing.Point(307, 157);
            this.cmbJugadorUno.Name = "cmbJugadorUno";
            this.cmbJugadorUno.Size = new System.Drawing.Size(121, 23);
            this.cmbJugadorUno.TabIndex = 20;
            this.cmbJugadorUno.SelectedIndexChanged += new System.EventHandler(this.cmbJugadorUno_SelectedIndexChanged);
            this.cmbJugadorUno.SelectedValueChanged += new System.EventHandler(this.cmbJugadorUno_SelectedValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = global::Vista.Properties.Resources.VSOK;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(307, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 74);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(553, 349);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 49);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnObservar
            // 
            this.btnObservar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnObservar.BackgroundImage = global::Vista.Properties.Resources.observar;
            this.btnObservar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObservar.Location = new System.Drawing.Point(553, 404);
            this.btnObservar.Name = "btnObservar";
            this.btnObservar.Size = new System.Drawing.Size(113, 49);
            this.btnObservar.TabIndex = 5;
            this.btnObservar.UseVisualStyleBackColor = true;
            this.btnObservar.Click += new System.EventHandler(this.btnObservar_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Controls.Add(this.btnRestaurar);
            this.panel3.Controls.Add(this.btnMinimizar);
            this.panel3.Controls.Add(this.lblFecha);
            this.panel3.Controls.Add(this.lblError);
            this.panel3.Controls.Add(this.lblHora);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1140, 62);
            this.panel3.TabIndex = 0;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::Vista.Properties.Resources.iconoCerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Location = new System.Drawing.Point(1098, 19);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackgroundImage = global::Vista.Properties.Resources.IconoRestaurar;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.Location = new System.Drawing.Point(1048, 19);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(30, 30);
            this.btnRestaurar.TabIndex = 10;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::Vista.Properties.Resources.IconoMinimizarOK;
            this.btnMinimizar.Location = new System.Drawing.Point(1001, 19);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // dgvPartidasActivas
            // 
            this.dgvPartidasActivas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPartidasActivas.AutoGenerateColumns = false;
            this.dgvPartidasActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidasActivas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreUno,
            this.nombreDosDataGridViewTextBoxColumn,
            this.tipoPartidaDataGridViewTextBoxColumn});
            this.dgvPartidasActivas.DataSource = this.partidaBindingSource;
            this.dgvPartidasActivas.Location = new System.Drawing.Point(251, 263);
            this.dgvPartidasActivas.Name = "dgvPartidasActivas";
            this.dgvPartidasActivas.ReadOnly = true;
            this.dgvPartidasActivas.RowTemplate.Height = 25;
            this.dgvPartidasActivas.Size = new System.Drawing.Size(296, 190);
            this.dgvPartidasActivas.TabIndex = 1;
            this.dgvPartidasActivas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPartidasActivas_RowHeaderMouseClick);
            // 
            // NombreUno
            // 
            this.NombreUno.DataPropertyName = "NombreUno";
            this.NombreUno.HeaderText = "NombreUno";
            this.NombreUno.Name = "NombreUno";
            this.NombreUno.ReadOnly = true;
            // 
            // nombreDosDataGridViewTextBoxColumn
            // 
            this.nombreDosDataGridViewTextBoxColumn.DataPropertyName = "NombreDos";
            this.nombreDosDataGridViewTextBoxColumn.HeaderText = "NombreDos";
            this.nombreDosDataGridViewTextBoxColumn.Name = "nombreDosDataGridViewTextBoxColumn";
            this.nombreDosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoPartidaDataGridViewTextBoxColumn
            // 
            this.tipoPartidaDataGridViewTextBoxColumn.DataPropertyName = "TipoPartida";
            this.tipoPartidaDataGridViewTextBoxColumn.HeaderText = "TipoPartida";
            this.tipoPartidaDataGridViewTextBoxColumn.Name = "tipoPartidaDataGridViewTextBoxColumn";
            this.tipoPartidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partidaBindingSource
            // 
            this.partidaBindingSource.DataSource = typeof(Entidades.Modelos.Partida);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 2;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnviar.Location = new System.Drawing.Point(735, 615);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(117, 35);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // txtChat
            // 
            this.txtChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtChat.Location = new System.Drawing.Point(248, 622);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(481, 23);
            this.txtChat.TabIndex = 3;
            // 
            // rtbChat
            // 
            this.rtbChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbChat.BackColor = System.Drawing.Color.Gray;
            this.rtbChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbChat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbChat.Location = new System.Drawing.Point(248, 459);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.Size = new System.Drawing.Size(604, 150);
            this.rtbChat.TabIndex = 2;
            this.rtbChat.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(871, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "JUGADORES CONECTADOS";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvJugadoresOnline
            // 
            this.dgvJugadoresOnline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJugadoresOnline.AutoGenerateColumns = false;
            this.dgvJugadoresOnline.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvJugadoresOnline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadoresOnline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.puntajeDataGridViewTextBoxColumn,
            this.estadoCuentaDataGridViewTextBoxColumn});
            this.dgvJugadoresOnline.DataSource = this.usuarioBindingSource;
            this.dgvJugadoresOnline.Location = new System.Drawing.Point(871, 134);
            this.dgvJugadoresOnline.Name = "dgvJugadoresOnline";
            this.dgvJugadoresOnline.ReadOnly = true;
            this.dgvJugadoresOnline.RowTemplate.Height = 25;
            this.dgvJugadoresOnline.Size = new System.Drawing.Size(257, 507);
            this.dgvJugadoresOnline.TabIndex = 0;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Jugador";
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreUsuarioDataGridViewTextBoxColumn.Width = 74;
            // 
            // puntajeDataGridViewTextBoxColumn
            // 
            this.puntajeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.puntajeDataGridViewTextBoxColumn.DataPropertyName = "Puntaje";
            this.puntajeDataGridViewTextBoxColumn.HeaderText = "Puntaje";
            this.puntajeDataGridViewTextBoxColumn.Name = "puntajeDataGridViewTextBoxColumn";
            this.puntajeDataGridViewTextBoxColumn.ReadOnly = true;
            this.puntajeDataGridViewTextBoxColumn.Width = 72;
            // 
            // estadoCuentaDataGridViewTextBoxColumn
            // 
            this.estadoCuentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estadoCuentaDataGridViewTextBoxColumn.DataPropertyName = "EstadoCuenta";
            this.estadoCuentaDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoCuentaDataGridViewTextBoxColumn.Name = "estadoCuentaDataGridViewTextBoxColumn";
            this.estadoCuentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoCuentaDataGridViewTextBoxColumn.Width = 67;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Entidades.Modelos.Usuario);
            // 
            // tmbPrincipal
            // 
            this.tmbPrincipal.Enabled = true;
            this.tmbPrincipal.Tick += new System.EventHandler(this.tmbPrincipal_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1140, 673);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMenuPrincipal);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlMenuPrincipal.ResumeLayout(false);
            this.pnlMenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlNuevaPartida.ResumeLayout(false);
            this.pnlNuevaPartida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidasActivas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadoresOnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlMenuPrincipal;
        private Button btnCerrarSesion;
        private Button btnReglasJuego;
        private Button btnEstadisticas;
        private Button btnAdministrar;
        private Button btnCrearSala;
        private Panel pnlPrincipal;
        private Button btnEnviar;
        private TextBox txtChat;
        private RichTextBox rtbChat;
        private Button button1;
        private DataGridView dgvJugadoresOnline;
        private DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn puntajeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoCuentaDataGridViewTextBoxColumn;
        private BindingSource usuarioBindingSource;
        private Label lblFecha;
        private Label lblUsuario;
        private Label lblHora;
        private Label lblError;
        private System.Windows.Forms.Timer tmbPrincipal;
        private Button btnObservar;
        private DataGridView dgvPartidasActivas;
        private Panel pnlNuevaPartida;
        private Button btnSalirNuevaPartida;
        private Label label1;
        private Button btnCrearNuevaPartida;
        private Label label2;
        private Label lblErroresPnlNueva;
        private ComboBox cmbJugadorDos;
        private ComboBox cmbTipoPartida;
        private Label label3;
        private Label label4;
        private ComboBox cmbJugadorUno;
        private PictureBox pictureBox1;
        private BindingSource partidaBindingSource;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Button btnCancelar;
        private Button btnCerrar;
        private Button btnRestaurar;
        private Button btnMinimizar;
        private Button btnReadme;
        private DataGridViewTextBoxColumn NombreUno;
        private DataGridViewTextBoxColumn nombreDosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoPartidaDataGridViewTextBoxColumn;
    }
}