namespace Vista
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageListado = new System.Windows.Forms.TabPage();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelAccesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.victoriasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.derrotasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pageNuevo = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnErrorNuevo = new System.Windows.Forms.Button();
            this.btnConfirmarNuevo = new System.Windows.Forms.Button();
            this.btnCancelarNuevo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApodoNuevo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNacionNuevo = new System.Windows.Forms.ComboBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEdadNuevo = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtDocumentoNuevo = new System.Windows.Forms.TextBox();
            this.cmbAccesoNuevo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseñaNuevo = new System.Windows.Forms.TextBox();
            this.pageEditar = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfirmarEdicion = new System.Windows.Forms.Button();
            this.btnCancelarEdicion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserEditar = new System.Windows.Forms.TextBox();
            this.cmbNacionEditar = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbAccesoEditar = new System.Windows.Forms.ComboBox();
            this.pageBorrar = new System.Windows.Forms.TabPage();
            this.btnConfirmarDelete = new System.Windows.Forms.Button();
            this.btnCancelarDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUserBorrar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreBorrar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEdadBorrar = new System.Windows.Forms.TextBox();
            this.txtDniBorrar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblPuntajeBorrar = new System.Windows.Forms.Label();
            this.lblEliminacion = new System.Windows.Forms.Label();
            this.cmbRazonEliminacion = new System.Windows.Forms.ComboBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnBorrarUsuario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDatosModificados = new System.Windows.Forms.Button();
            this.tmrUsuarios = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.pageListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.pageNuevo.SuspendLayout();
            this.pageEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pageBorrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageListado);
            this.tabControl1.Controls.Add(this.pageNuevo);
            this.tabControl1.Controls.Add(this.pageEditar);
            this.tabControl1.Controls.Add(this.pageBorrar);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // pageListado
            // 
            this.pageListado.BackColor = System.Drawing.Color.DarkRed;
            this.pageListado.Controls.Add(this.txtBusqueda);
            this.pageListado.Controls.Add(this.dgvListado);
            this.pageListado.Controls.Add(this.lblBusqueda);
            this.pageListado.Controls.Add(this.btnBuscar);
            this.pageListado.Location = new System.Drawing.Point(4, 24);
            this.pageListado.Name = "pageListado";
            this.pageListado.Padding = new System.Windows.Forms.Padding(3);
            this.pageListado.Size = new System.Drawing.Size(646, 420);
            this.pageListado.TabIndex = 0;
            this.pageListado.Text = "USUARIOS";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(8, 34);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(434, 23);
            this.txtBusqueda.TabIndex = 20;
            // 
            // dgvListado
            // 
            this.dgvListado.AutoGenerateColumns = false;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.nivelAccesoDataGridViewTextBoxColumn,
            this.puntajeDataGridViewTextBoxColumn,
            this.victoriasDataGridViewTextBoxColumn,
            this.derrotasDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.nacionalidadDataGridViewTextBoxColumn});
            this.dgvListado.DataSource = this.usuarioBindingSource;
            this.dgvListado.Location = new System.Drawing.Point(8, 75);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowTemplate.Height = 25;
            this.dgvListado.Size = new System.Drawing.Size(571, 325);
            this.dgvListado.TabIndex = 19;
            this.dgvListado.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListado_RowHeaderMouseClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "NombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            // 
            // nivelAccesoDataGridViewTextBoxColumn
            // 
            this.nivelAccesoDataGridViewTextBoxColumn.DataPropertyName = "NivelAcceso";
            this.nivelAccesoDataGridViewTextBoxColumn.HeaderText = "NivelAcceso";
            this.nivelAccesoDataGridViewTextBoxColumn.Name = "nivelAccesoDataGridViewTextBoxColumn";
            // 
            // puntajeDataGridViewTextBoxColumn
            // 
            this.puntajeDataGridViewTextBoxColumn.DataPropertyName = "Puntaje";
            this.puntajeDataGridViewTextBoxColumn.HeaderText = "Puntaje";
            this.puntajeDataGridViewTextBoxColumn.Name = "puntajeDataGridViewTextBoxColumn";
            // 
            // victoriasDataGridViewTextBoxColumn
            // 
            this.victoriasDataGridViewTextBoxColumn.DataPropertyName = "Victorias";
            this.victoriasDataGridViewTextBoxColumn.HeaderText = "Victorias";
            this.victoriasDataGridViewTextBoxColumn.Name = "victoriasDataGridViewTextBoxColumn";
            // 
            // derrotasDataGridViewTextBoxColumn
            // 
            this.derrotasDataGridViewTextBoxColumn.DataPropertyName = "Derrotas";
            this.derrotasDataGridViewTextBoxColumn.HeaderText = "Derrotas";
            this.derrotasDataGridViewTextBoxColumn.Name = "derrotasDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // nacionalidadDataGridViewTextBoxColumn
            // 
            this.nacionalidadDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidad";
            this.nacionalidadDataGridViewTextBoxColumn.HeaderText = "Nacionalidad";
            this.nacionalidadDataGridViewTextBoxColumn.Name = "nacionalidadDataGridViewTextBoxColumn";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Entidades.Modelos.Usuario);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(6, 16);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(85, 15);
            this.lblBusqueda.TabIndex = 18;
            this.lblBusqueda.Text = "Buscar Usuario";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(488, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 35);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // pageNuevo
            // 
            this.pageNuevo.BackColor = System.Drawing.Color.Khaki;
            this.pageNuevo.Controls.Add(this.panel1);
            this.pageNuevo.Controls.Add(this.btnErrorNuevo);
            this.pageNuevo.Controls.Add(this.btnConfirmarNuevo);
            this.pageNuevo.Controls.Add(this.btnCancelarNuevo);
            this.pageNuevo.Controls.Add(this.label4);
            this.pageNuevo.Controls.Add(this.txtApodoNuevo);
            this.pageNuevo.Controls.Add(this.label1);
            this.pageNuevo.Controls.Add(this.cmbNacionNuevo);
            this.pageNuevo.Controls.Add(this.txtNombreNuevo);
            this.pageNuevo.Controls.Add(this.label5);
            this.pageNuevo.Controls.Add(this.label3);
            this.pageNuevo.Controls.Add(this.label6);
            this.pageNuevo.Controls.Add(this.txtEdadNuevo);
            this.pageNuevo.Controls.Add(this.lblContraseña);
            this.pageNuevo.Controls.Add(this.txtDocumentoNuevo);
            this.pageNuevo.Controls.Add(this.cmbAccesoNuevo);
            this.pageNuevo.Controls.Add(this.label2);
            this.pageNuevo.Controls.Add(this.txtContraseñaNuevo);
            this.pageNuevo.Location = new System.Drawing.Point(4, 24);
            this.pageNuevo.Name = "pageNuevo";
            this.pageNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.pageNuevo.Size = new System.Drawing.Size(646, 420);
            this.pageNuevo.TabIndex = 1;
            this.pageNuevo.Text = "AGREGAR";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Vista.Properties.Resources.BIENVENIDOBARRAOK;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 73);
            this.panel1.TabIndex = 96;
            // 
            // btnErrorNuevo
            // 
            this.btnErrorNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnErrorNuevo.FlatAppearance.BorderSize = 2;
            this.btnErrorNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErrorNuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnErrorNuevo.ForeColor = System.Drawing.Color.Red;
            this.btnErrorNuevo.Location = new System.Drawing.Point(480, 205);
            this.btnErrorNuevo.Name = "btnErrorNuevo";
            this.btnErrorNuevo.Size = new System.Drawing.Size(132, 89);
            this.btnErrorNuevo.TabIndex = 95;
            this.btnErrorNuevo.Text = "ERROR AL AGREGAR NUEVO USUARIO";
            this.btnErrorNuevo.UseVisualStyleBackColor = false;
            // 
            // btnConfirmarNuevo
            // 
            this.btnConfirmarNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarNuevo.FlatAppearance.BorderSize = 3;
            this.btnConfirmarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarNuevo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarNuevo.Location = new System.Drawing.Point(175, 341);
            this.btnConfirmarNuevo.Name = "btnConfirmarNuevo";
            this.btnConfirmarNuevo.Size = new System.Drawing.Size(139, 55);
            this.btnConfirmarNuevo.TabIndex = 93;
            this.btnConfirmarNuevo.Text = "CONFIRMAR";
            this.btnConfirmarNuevo.UseVisualStyleBackColor = false;
            this.btnConfirmarNuevo.Click += new System.EventHandler(this.btnConfirmarNuevo_Click);
            // 
            // btnCancelarNuevo
            // 
            this.btnCancelarNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarNuevo.FlatAppearance.BorderSize = 3;
            this.btnCancelarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarNuevo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarNuevo.Location = new System.Drawing.Point(392, 341);
            this.btnCancelarNuevo.Name = "btnCancelarNuevo";
            this.btnCancelarNuevo.Size = new System.Drawing.Size(139, 55);
            this.btnCancelarNuevo.TabIndex = 94;
            this.btnCancelarNuevo.Text = "CANCELAR";
            this.btnCancelarNuevo.UseVisualStyleBackColor = false;
            this.btnCancelarNuevo.Click += new System.EventHandler(this.btnCancelarNuevo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(187, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 86;
            this.label4.Text = "NickName:";
            // 
            // txtApodoNuevo
            // 
            this.txtApodoNuevo.BackColor = System.Drawing.Color.Khaki;
            this.txtApodoNuevo.Location = new System.Drawing.Point(304, 184);
            this.txtApodoNuevo.Name = "txtApodoNuevo";
            this.txtApodoNuevo.Size = new System.Drawing.Size(127, 23);
            this.txtApodoNuevo.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(187, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "Nombre:";
            // 
            // cmbNacionNuevo
            // 
            this.cmbNacionNuevo.BackColor = System.Drawing.Color.Khaki;
            this.cmbNacionNuevo.FormattingEnabled = true;
            this.cmbNacionNuevo.Location = new System.Drawing.Point(303, 284);
            this.cmbNacionNuevo.Name = "cmbNacionNuevo";
            this.cmbNacionNuevo.Size = new System.Drawing.Size(128, 23);
            this.cmbNacionNuevo.TabIndex = 92;
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.BackColor = System.Drawing.Color.Khaki;
            this.txtNombreNuevo.Location = new System.Drawing.Point(303, 93);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(127, 23);
            this.txtNombreNuevo.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(183, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 87;
            this.label5.Text = "Nivel de Acceso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(187, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "Documento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(187, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 91;
            this.label6.Text = "Nacionalidad:";
            // 
            // txtEdadNuevo
            // 
            this.txtEdadNuevo.BackColor = System.Drawing.Color.Khaki;
            this.txtEdadNuevo.Location = new System.Drawing.Point(303, 122);
            this.txtEdadNuevo.Name = "txtEdadNuevo";
            this.txtEdadNuevo.Size = new System.Drawing.Size(127, 23);
            this.txtEdadNuevo.TabIndex = 80;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblContraseña.Location = new System.Drawing.Point(187, 214);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(82, 17);
            this.lblContraseña.TabIndex = 88;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtDocumentoNuevo
            // 
            this.txtDocumentoNuevo.BackColor = System.Drawing.Color.Khaki;
            this.txtDocumentoNuevo.Location = new System.Drawing.Point(303, 155);
            this.txtDocumentoNuevo.Name = "txtDocumentoNuevo";
            this.txtDocumentoNuevo.Size = new System.Drawing.Size(127, 23);
            this.txtDocumentoNuevo.TabIndex = 81;
            // 
            // cmbAccesoNuevo
            // 
            this.cmbAccesoNuevo.BackColor = System.Drawing.Color.Khaki;
            this.cmbAccesoNuevo.FormattingEnabled = true;
            this.cmbAccesoNuevo.Location = new System.Drawing.Point(303, 242);
            this.cmbAccesoNuevo.Name = "cmbAccesoNuevo";
            this.cmbAccesoNuevo.Size = new System.Drawing.Size(128, 23);
            this.cmbAccesoNuevo.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(187, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 84;
            this.label2.Text = "Edad:";
            // 
            // txtContraseñaNuevo
            // 
            this.txtContraseñaNuevo.BackColor = System.Drawing.Color.Khaki;
            this.txtContraseñaNuevo.Location = new System.Drawing.Point(303, 213);
            this.txtContraseñaNuevo.Name = "txtContraseñaNuevo";
            this.txtContraseñaNuevo.PasswordChar = '*';
            this.txtContraseñaNuevo.Size = new System.Drawing.Size(127, 23);
            this.txtContraseñaNuevo.TabIndex = 89;
            // 
            // pageEditar
            // 
            this.pageEditar.BackColor = System.Drawing.Color.IndianRed;
            this.pageEditar.Controls.Add(this.pictureBox1);
            this.pageEditar.Controls.Add(this.btnConfirmarEdicion);
            this.pageEditar.Controls.Add(this.btnCancelarEdicion);
            this.pageEditar.Controls.Add(this.label8);
            this.pageEditar.Controls.Add(this.txtUserEditar);
            this.pageEditar.Controls.Add(this.cmbNacionEditar);
            this.pageEditar.Controls.Add(this.label10);
            this.pageEditar.Controls.Add(this.label12);
            this.pageEditar.Controls.Add(this.cmbAccesoEditar);
            this.pageEditar.Location = new System.Drawing.Point(4, 24);
            this.pageEditar.Name = "pageEditar";
            this.pageEditar.Size = new System.Drawing.Size(646, 420);
            this.pageEditar.TabIndex = 2;
            this.pageEditar.Text = "EDITAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Vista.Properties.Resources.edicion;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 231);
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfirmarEdicion
            // 
            this.btnConfirmarEdicion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarEdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarEdicion.FlatAppearance.BorderSize = 3;
            this.btnConfirmarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarEdicion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarEdicion.Location = new System.Drawing.Point(145, 293);
            this.btnConfirmarEdicion.Name = "btnConfirmarEdicion";
            this.btnConfirmarEdicion.Size = new System.Drawing.Size(139, 55);
            this.btnConfirmarEdicion.TabIndex = 103;
            this.btnConfirmarEdicion.Text = "CONFIRMAR";
            this.btnConfirmarEdicion.UseVisualStyleBackColor = false;
            this.btnConfirmarEdicion.Click += new System.EventHandler(this.btnConfirmarEdicion_Click);
            // 
            // btnCancelarEdicion
            // 
            this.btnCancelarEdicion.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarEdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarEdicion.FlatAppearance.BorderSize = 3;
            this.btnCancelarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEdicion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarEdicion.Location = new System.Drawing.Point(362, 293);
            this.btnCancelarEdicion.Name = "btnCancelarEdicion";
            this.btnCancelarEdicion.Size = new System.Drawing.Size(139, 55);
            this.btnCancelarEdicion.TabIndex = 104;
            this.btnCancelarEdicion.Text = "CANCELAR";
            this.btnCancelarEdicion.UseVisualStyleBackColor = false;
            this.btnCancelarEdicion.Click += new System.EventHandler(this.btnCancelarEdicion_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(152, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 98;
            this.label8.Text = "NickName:";
            // 
            // txtUserEditar
            // 
            this.txtUserEditar.BackColor = System.Drawing.Color.IndianRed;
            this.txtUserEditar.Location = new System.Drawing.Point(267, 137);
            this.txtUserEditar.Name = "txtUserEditar";
            this.txtUserEditar.Size = new System.Drawing.Size(127, 23);
            this.txtUserEditar.TabIndex = 97;
            // 
            // cmbNacionEditar
            // 
            this.cmbNacionEditar.BackColor = System.Drawing.Color.IndianRed;
            this.cmbNacionEditar.FormattingEnabled = true;
            this.cmbNacionEditar.Location = new System.Drawing.Point(268, 218);
            this.cmbNacionEditar.Name = "cmbNacionEditar";
            this.cmbNacionEditar.Size = new System.Drawing.Size(128, 23);
            this.cmbNacionEditar.TabIndex = 102;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(152, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 99;
            this.label10.Text = "Nivel de Acceso:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(152, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 17);
            this.label12.TabIndex = 101;
            this.label12.Text = "Nacionalidad:";
            // 
            // cmbAccesoEditar
            // 
            this.cmbAccesoEditar.BackColor = System.Drawing.Color.IndianRed;
            this.cmbAccesoEditar.FormattingEnabled = true;
            this.cmbAccesoEditar.Location = new System.Drawing.Point(268, 176);
            this.cmbAccesoEditar.Name = "cmbAccesoEditar";
            this.cmbAccesoEditar.Size = new System.Drawing.Size(128, 23);
            this.cmbAccesoEditar.TabIndex = 100;
            // 
            // pageBorrar
            // 
            this.pageBorrar.BackColor = System.Drawing.Color.Orange;
            this.pageBorrar.BackgroundImage = global::Vista.Properties.Resources.bomba;
            this.pageBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pageBorrar.Controls.Add(this.btnConfirmarDelete);
            this.pageBorrar.Controls.Add(this.btnCancelarDelete);
            this.pageBorrar.Controls.Add(this.label11);
            this.pageBorrar.Controls.Add(this.txtUserBorrar);
            this.pageBorrar.Controls.Add(this.label13);
            this.pageBorrar.Controls.Add(this.txtNombreBorrar);
            this.pageBorrar.Controls.Add(this.label14);
            this.pageBorrar.Controls.Add(this.txtEdadBorrar);
            this.pageBorrar.Controls.Add(this.txtDniBorrar);
            this.pageBorrar.Controls.Add(this.label15);
            this.pageBorrar.Controls.Add(this.lblPuntajeBorrar);
            this.pageBorrar.Controls.Add(this.lblEliminacion);
            this.pageBorrar.Controls.Add(this.cmbRazonEliminacion);
            this.pageBorrar.Location = new System.Drawing.Point(4, 24);
            this.pageBorrar.Name = "pageBorrar";
            this.pageBorrar.Size = new System.Drawing.Size(646, 420);
            this.pageBorrar.TabIndex = 3;
            this.pageBorrar.Text = "BORRAR";
            // 
            // btnConfirmarDelete
            // 
            this.btnConfirmarDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarDelete.FlatAppearance.BorderSize = 3;
            this.btnConfirmarDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmarDelete.Location = new System.Drawing.Point(173, 289);
            this.btnConfirmarDelete.Name = "btnConfirmarDelete";
            this.btnConfirmarDelete.Size = new System.Drawing.Size(139, 55);
            this.btnConfirmarDelete.TabIndex = 108;
            this.btnConfirmarDelete.Text = "CONFIRMAR";
            this.btnConfirmarDelete.UseVisualStyleBackColor = false;
            this.btnConfirmarDelete.Click += new System.EventHandler(this.btnConfirmarDelete_Click);
            // 
            // btnCancelarDelete
            // 
            this.btnCancelarDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarDelete.FlatAppearance.BorderSize = 3;
            this.btnCancelarDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelarDelete.Location = new System.Drawing.Point(390, 289);
            this.btnCancelarDelete.Name = "btnCancelarDelete";
            this.btnCancelarDelete.Size = new System.Drawing.Size(139, 55);
            this.btnCancelarDelete.TabIndex = 109;
            this.btnCancelarDelete.Text = "CANCELAR";
            this.btnCancelarDelete.UseVisualStyleBackColor = false;
            this.btnCancelarDelete.Click += new System.EventHandler(this.btnCancelarDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(63, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 107;
            this.label11.Text = "NickName:";
            // 
            // txtUserBorrar
            // 
            this.txtUserBorrar.Location = new System.Drawing.Point(178, 243);
            this.txtUserBorrar.Name = "txtUserBorrar";
            this.txtUserBorrar.Size = new System.Drawing.Size(127, 23);
            this.txtUserBorrar.TabIndex = 103;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(63, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 104;
            this.label13.Text = "Nombre:";
            // 
            // txtNombreBorrar
            // 
            this.txtNombreBorrar.Location = new System.Drawing.Point(178, 113);
            this.txtNombreBorrar.Name = "txtNombreBorrar";
            this.txtNombreBorrar.Size = new System.Drawing.Size(127, 23);
            this.txtNombreBorrar.TabIndex = 100;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(63, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 17);
            this.label14.TabIndex = 106;
            this.label14.Text = "Documento:";
            // 
            // txtEdadBorrar
            // 
            this.txtEdadBorrar.Location = new System.Drawing.Point(178, 158);
            this.txtEdadBorrar.Name = "txtEdadBorrar";
            this.txtEdadBorrar.Size = new System.Drawing.Size(127, 23);
            this.txtEdadBorrar.TabIndex = 101;
            // 
            // txtDniBorrar
            // 
            this.txtDniBorrar.Location = new System.Drawing.Point(178, 202);
            this.txtDniBorrar.Name = "txtDniBorrar";
            this.txtDniBorrar.Size = new System.Drawing.Size(127, 23);
            this.txtDniBorrar.TabIndex = 102;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(63, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 105;
            this.label15.Text = "Edad:";
            // 
            // lblPuntajeBorrar
            // 
            this.lblPuntajeBorrar.AutoSize = true;
            this.lblPuntajeBorrar.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntajeBorrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPuntajeBorrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPuntajeBorrar.Location = new System.Drawing.Point(355, 112);
            this.lblPuntajeBorrar.Name = "lblPuntajeBorrar";
            this.lblPuntajeBorrar.Size = new System.Drawing.Size(80, 25);
            this.lblPuntajeBorrar.TabIndex = 98;
            this.lblPuntajeBorrar.Text = "puntaje";
            // 
            // lblEliminacion
            // 
            this.lblEliminacion.AutoSize = true;
            this.lblEliminacion.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminacion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEliminacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEliminacion.Location = new System.Drawing.Point(355, 153);
            this.lblEliminacion.Name = "lblEliminacion";
            this.lblEliminacion.Size = new System.Drawing.Size(206, 25);
            this.lblEliminacion.TabIndex = 97;
            this.lblEliminacion.Text = "Razon de Eliminación:";
            // 
            // cmbRazonEliminacion
            // 
            this.cmbRazonEliminacion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbRazonEliminacion.FormattingEnabled = true;
            this.cmbRazonEliminacion.Location = new System.Drawing.Point(355, 187);
            this.cmbRazonEliminacion.Name = "cmbRazonEliminacion";
            this.cmbRazonEliminacion.Size = new System.Drawing.Size(201, 33);
            this.cmbRazonEliminacion.TabIndex = 99;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 2;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarUsuario.Location = new System.Drawing.Point(681, 62);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(91, 50);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.Text = "AGREGAR USUARIO";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarUsuario.FlatAppearance.BorderSize = 2;
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarUsuario.Location = new System.Drawing.Point(681, 128);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(91, 50);
            this.btnEditarUsuario.TabIndex = 2;
            this.btnEditarUsuario.Text = "EDITAR USUARIO";
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnBorrarUsuario
            // 
            this.btnBorrarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarUsuario.FlatAppearance.BorderSize = 2;
            this.btnBorrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrarUsuario.Location = new System.Drawing.Point(681, 197);
            this.btnBorrarUsuario.Name = "btnBorrarUsuario";
            this.btnBorrarUsuario.Size = new System.Drawing.Size(91, 50);
            this.btnBorrarUsuario.TabIndex = 3;
            this.btnBorrarUsuario.Text = "BORRAR USUARIO";
            this.btnBorrarUsuario.UseVisualStyleBackColor = false;
            this.btnBorrarUsuario.Click += new System.EventHandler(this.btnBorrarUsuario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Vista.Properties.Resources.Cerrar;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(681, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 53);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDatosModificados
            // 
            this.btnDatosModificados.BackColor = System.Drawing.Color.Black;
            this.btnDatosModificados.FlatAppearance.BorderSize = 2;
            this.btnDatosModificados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosModificados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDatosModificados.ForeColor = System.Drawing.Color.Green;
            this.btnDatosModificados.Location = new System.Drawing.Point(660, 273);
            this.btnDatosModificados.Name = "btnDatosModificados";
            this.btnDatosModificados.Size = new System.Drawing.Size(132, 89);
            this.btnDatosModificados.TabIndex = 5;
            this.btnDatosModificados.Text = "DATOS MODIFICADOS CORRECTAMENTE";
            this.btnDatosModificados.UseVisualStyleBackColor = false;
            // 
            // tmrUsuarios
            // 
            this.tmrUsuarios.Enabled = true;
            this.tmrUsuarios.Tick += new System.EventHandler(this.tmrUsuarios_Tick);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnDatosModificados);
            this.Controls.Add(this.btnBorrarUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.pageListado.ResumeLayout(false);
            this.pageListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.pageNuevo.ResumeLayout(false);
            this.pageNuevo.PerformLayout();
            this.pageEditar.ResumeLayout(false);
            this.pageEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pageBorrar.ResumeLayout(false);
            this.pageBorrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage pageListado;
        private TabPage pageNuevo;
        private Button btnAgregarUsuario;
        private Button btnEditarUsuario;
        private Button btnBorrarUsuario;
        private Button btnSalir;
        private TabPage pageEditar;
        private TabPage pageBorrar;
        private Label lblBusqueda;
        private Button btnBuscar;
        private DataGridView dgvListado;
        private TextBox txtBusqueda;
        private Label label4;
        private TextBox txtApodoNuevo;
        private Label label1;
        private ComboBox cmbNacionNuevo;
        private TextBox txtNombreNuevo;
        private Label label5;
        private Label label3;
        private Label label6;
        private TextBox txtEdadNuevo;
        private Label lblContraseña;
        private TextBox txtDocumentoNuevo;
        private ComboBox cmbAccesoNuevo;
        private Label label2;
        private TextBox txtContraseñaNuevo;
        private Button btnConfirmarNuevo;
        private Button btnCancelarNuevo;
        private PictureBox pictureBox1;
        private Button btnConfirmarEdicion;
        private Button btnCancelarEdicion;
        private Label label8;
        private TextBox txtUserEditar;
        private ComboBox cmbNacionEditar;
        private Label label10;
        private Label label12;
        private ComboBox cmbAccesoEditar;
        private Button btnConfirmarDelete;
        private Button btnCancelarDelete;
        private Label label11;
        private TextBox txtUserBorrar;
        private Label label13;
        private TextBox txtNombreBorrar;
        private Label label14;
        private TextBox txtEdadBorrar;
        private TextBox txtDniBorrar;
        private Label label15;
        private Label lblPuntajeBorrar;
        private Label lblEliminacion;
        private ComboBox cmbRazonEliminacion;
        private Button btnDatosModificados;
        private System.Windows.Forms.Timer tmrUsuarios;
        private Button btnErrorNuevo;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nivelAccesoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn puntajeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn victoriasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn derrotasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadDataGridViewTextBoxColumn;
        private BindingSource usuarioBindingSource;
        private Panel panel1;
    }
}