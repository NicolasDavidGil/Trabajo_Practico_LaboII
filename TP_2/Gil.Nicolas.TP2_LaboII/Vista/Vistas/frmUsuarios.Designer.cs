namespace Vista.Vistas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabListado = new System.Windows.Forms.TabControl();
            this.pageLista = new System.Windows.Forms.TabPage();
            this.lblCambios = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.dgvListadoJugadores = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.pageCrear = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pageEditar = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnConfirmarEdicion = new System.Windows.Forms.Button();
            this.btnCancelarEdicion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserEditar = new System.Windows.Forms.TextBox();
            this.cmbNacionEditar = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbAccesoEditar = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pageBorrar = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabListado.SuspendLayout();
            this.pageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoJugadores)).BeginInit();
            this.pageCrear.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pageEditar.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pageBorrar.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImage = global::Vista.Properties.Resources.game;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 102);
            this.panel1.TabIndex = 0;
            // 
            // tabListado
            // 
            this.tabListado.Controls.Add(this.pageLista);
            this.tabListado.Controls.Add(this.pageCrear);
            this.tabListado.Controls.Add(this.pageEditar);
            this.tabListado.Controls.Add(this.pageBorrar);
            this.tabListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabListado.Location = new System.Drawing.Point(0, 102);
            this.tabListado.Name = "tabListado";
            this.tabListado.SelectedIndex = 0;
            this.tabListado.Size = new System.Drawing.Size(1063, 586);
            this.tabListado.TabIndex = 0;
            // 
            // pageLista
            // 
            this.pageLista.BackColor = System.Drawing.Color.Red;
            this.pageLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageLista.Controls.Add(this.lblCambios);
            this.pageLista.Controls.Add(this.lblBusqueda);
            this.pageLista.Controls.Add(this.dgvListadoJugadores);
            this.pageLista.Controls.Add(this.btnSalir);
            this.pageLista.Controls.Add(this.btnBorrar);
            this.pageLista.Controls.Add(this.btnEditar);
            this.pageLista.Controls.Add(this.btnAgregarNuevo);
            this.pageLista.Controls.Add(this.btnBuscar);
            this.pageLista.Controls.Add(this.txtBusqueda);
            this.pageLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageLista.Location = new System.Drawing.Point(4, 24);
            this.pageLista.Name = "pageLista";
            this.pageLista.Padding = new System.Windows.Forms.Padding(3);
            this.pageLista.Size = new System.Drawing.Size(1055, 558);
            this.pageLista.TabIndex = 0;
            this.pageLista.Text = "Listado";
            // 
            // lblCambios
            // 
            this.lblCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCambios.AutoSize = true;
            this.lblCambios.BackColor = System.Drawing.Color.Transparent;
            this.lblCambios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCambios.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCambios.Location = new System.Drawing.Point(780, 263);
            this.lblCambios.Name = "lblCambios";
            this.lblCambios.Size = new System.Drawing.Size(242, 25);
            this.lblCambios.TabIndex = 16;
            this.lblCambios.Text = "CAMBIOS CONFIRMADOS";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(17, 12);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(113, 16);
            this.lblBusqueda.TabIndex = 15;
            this.lblBusqueda.Text = "Buscar Usuario";
            // 
            // dgvListadoJugadores
            // 
            this.dgvListadoJugadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoJugadores.BackgroundColor = System.Drawing.Color.Red;
            this.dgvListadoJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoJugadores.Location = new System.Drawing.Point(17, 63);
            this.dgvListadoJugadores.Name = "dgvListadoJugadores";
            this.dgvListadoJugadores.RowTemplate.Height = 25;
            this.dgvListadoJugadores.Size = new System.Drawing.Size(757, 473);
            this.dgvListadoJugadores.TabIndex = 14;
            this.dgvListadoJugadores.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListadoJugadores_RowHeaderMouseClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(811, 367);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(142, 47);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderSize = 3;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Location = new System.Drawing.Point(811, 195);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(142, 47);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 3;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(811, 138);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(142, 47);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarNuevo.FlatAppearance.BorderSize = 3;
            this.btnAgregarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevo.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarNuevo.Location = new System.Drawing.Point(811, 81);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(142, 47);
            this.btnAgregarNuevo.TabIndex = 10;
            this.btnAgregarNuevo.Text = "NUEVO";
            this.btnAgregarNuevo.UseVisualStyleBackColor = false;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(686, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 35);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Location = new System.Drawing.Point(17, 32);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(663, 22);
            this.txtBusqueda.TabIndex = 8;
            // 
            // pageCrear
            // 
            this.pageCrear.BackColor = System.Drawing.Color.Red;
            this.pageCrear.Controls.Add(this.panel4);
            this.pageCrear.Controls.Add(this.panel3);
            this.pageCrear.Controls.Add(this.panel2);
            this.pageCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageCrear.Location = new System.Drawing.Point(4, 24);
            this.pageCrear.Name = "pageCrear";
            this.pageCrear.Padding = new System.Windows.Forms.Padding(3);
            this.pageCrear.Size = new System.Drawing.Size(1055, 558);
            this.pageCrear.TabIndex = 1;
            this.pageCrear.Text = "Nuevo Usuario";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnConfirmarNuevo);
            this.panel4.Controls.Add(this.btnCancelarNuevo);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtApodoNuevo);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cmbNacionNuevo);
            this.panel4.Controls.Add(this.txtNombreNuevo);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtEdadNuevo);
            this.panel4.Controls.Add(this.lblContraseña);
            this.panel4.Controls.Add(this.txtDocumentoNuevo);
            this.panel4.Controls.Add(this.cmbAccesoNuevo);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtContraseñaNuevo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(292, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(479, 552);
            this.panel4.TabIndex = 79;
            // 
            // btnConfirmarNuevo
            // 
            this.btnConfirmarNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarNuevo.FlatAppearance.BorderSize = 3;
            this.btnConfirmarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarNuevo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarNuevo.Location = new System.Drawing.Point(72, 431);
            this.btnConfirmarNuevo.Name = "btnConfirmarNuevo";
            this.btnConfirmarNuevo.Size = new System.Drawing.Size(139, 55);
            this.btnConfirmarNuevo.TabIndex = 79;
            this.btnConfirmarNuevo.Text = "CONFIRMAR";
            this.btnConfirmarNuevo.UseVisualStyleBackColor = false;
            // 
            // btnCancelarNuevo
            // 
            this.btnCancelarNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarNuevo.FlatAppearance.BorderSize = 3;
            this.btnCancelarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarNuevo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarNuevo.Location = new System.Drawing.Point(289, 431);
            this.btnCancelarNuevo.Name = "btnCancelarNuevo";
            this.btnCancelarNuevo.Size = new System.Drawing.Size(139, 55);
            this.btnCancelarNuevo.TabIndex = 80;
            this.btnCancelarNuevo.Text = "CANCELAR";
            this.btnCancelarNuevo.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(92, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "NickName:";
            // 
            // txtApodoNuevo
            // 
            this.txtApodoNuevo.Location = new System.Drawing.Point(207, 211);
            this.txtApodoNuevo.Name = "txtApodoNuevo";
            this.txtApodoNuevo.Size = new System.Drawing.Size(127, 22);
            this.txtApodoNuevo.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(92, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "Nombre:";
            // 
            // cmbNacionNuevo
            // 
            this.cmbNacionNuevo.FormattingEnabled = true;
            this.cmbNacionNuevo.Location = new System.Drawing.Point(206, 332);
            this.cmbNacionNuevo.Name = "cmbNacionNuevo";
            this.cmbNacionNuevo.Size = new System.Drawing.Size(128, 24);
            this.cmbNacionNuevo.TabIndex = 78;
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Location = new System.Drawing.Point(207, 81);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(127, 22);
            this.txtNombreNuevo.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(90, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Nivel de Acceso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(92, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "Documento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(90, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 77;
            this.label6.Text = "Nacionalidad:";
            // 
            // txtEdadNuevo
            // 
            this.txtEdadNuevo.Location = new System.Drawing.Point(207, 126);
            this.txtEdadNuevo.Name = "txtEdadNuevo";
            this.txtEdadNuevo.Size = new System.Drawing.Size(127, 22);
            this.txtEdadNuevo.TabIndex = 66;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblContraseña.Location = new System.Drawing.Point(90, 253);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(82, 17);
            this.lblContraseña.TabIndex = 74;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtDocumentoNuevo
            // 
            this.txtDocumentoNuevo.Location = new System.Drawing.Point(207, 170);
            this.txtDocumentoNuevo.Name = "txtDocumentoNuevo";
            this.txtDocumentoNuevo.Size = new System.Drawing.Size(127, 22);
            this.txtDocumentoNuevo.TabIndex = 67;
            // 
            // cmbAccesoNuevo
            // 
            this.cmbAccesoNuevo.FormattingEnabled = true;
            this.cmbAccesoNuevo.Location = new System.Drawing.Point(206, 290);
            this.cmbAccesoNuevo.Name = "cmbAccesoNuevo";
            this.cmbAccesoNuevo.Size = new System.Drawing.Size(128, 24);
            this.cmbAccesoNuevo.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(92, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Edad:";
            // 
            // txtContraseñaNuevo
            // 
            this.txtContraseñaNuevo.Location = new System.Drawing.Point(206, 253);
            this.txtContraseñaNuevo.Name = "txtContraseñaNuevo";
            this.txtContraseñaNuevo.PasswordChar = '*';
            this.txtContraseñaNuevo.Size = new System.Drawing.Size(127, 22);
            this.txtContraseñaNuevo.TabIndex = 75;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Vista.Properties.Resources.bienvenidook;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(771, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 552);
            this.panel3.TabIndex = 82;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Vista.Properties.Resources.WELCOME;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 133);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Vista.Properties.Resources.IconoUnoSinFondo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 552);
            this.panel2.TabIndex = 81;
            // 
            // pageEditar
            // 
            this.pageEditar.BackColor = System.Drawing.Color.Red;
            this.pageEditar.Controls.Add(this.panel7);
            this.pageEditar.Controls.Add(this.panel6);
            this.pageEditar.Controls.Add(this.panel5);
            this.pageEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageEditar.Location = new System.Drawing.Point(4, 24);
            this.pageEditar.Name = "pageEditar";
            this.pageEditar.Size = new System.Drawing.Size(1055, 558);
            this.pageEditar.TabIndex = 2;
            this.pageEditar.Text = "Editar Usuario";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnConfirmarEdicion);
            this.panel7.Controls.Add(this.btnCancelarEdicion);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.txtUserEditar);
            this.panel7.Controls.Add(this.cmbNacionEditar);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.cmbAccesoEditar);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 100);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(787, 458);
            this.panel7.TabIndex = 0;
            // 
            // btnConfirmarEdicion
            // 
            this.btnConfirmarEdicion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarEdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarEdicion.FlatAppearance.BorderSize = 3;
            this.btnConfirmarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarEdicion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarEdicion.Location = new System.Drawing.Point(266, 378);
            this.btnConfirmarEdicion.Name = "btnConfirmarEdicion";
            this.btnConfirmarEdicion.Size = new System.Drawing.Size(139, 55);
            this.btnConfirmarEdicion.TabIndex = 95;
            this.btnConfirmarEdicion.Text = "CONFIRMAR";
            this.btnConfirmarEdicion.UseVisualStyleBackColor = false;
            // 
            // btnCancelarEdicion
            // 
            this.btnCancelarEdicion.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarEdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarEdicion.FlatAppearance.BorderSize = 3;
            this.btnCancelarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEdicion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarEdicion.Location = new System.Drawing.Point(483, 378);
            this.btnCancelarEdicion.Name = "btnCancelarEdicion";
            this.btnCancelarEdicion.Size = new System.Drawing.Size(139, 55);
            this.btnCancelarEdicion.TabIndex = 96;
            this.btnCancelarEdicion.Text = "CANCELAR";
            this.btnCancelarEdicion.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(286, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 88;
            this.label8.Text = "NickName:";
            // 
            // txtUserEditar
            // 
            this.txtUserEditar.Location = new System.Drawing.Point(401, 158);
            this.txtUserEditar.Name = "txtUserEditar";
            this.txtUserEditar.Size = new System.Drawing.Size(127, 22);
            this.txtUserEditar.TabIndex = 84;
            // 
            // cmbNacionEditar
            // 
            this.cmbNacionEditar.FormattingEnabled = true;
            this.cmbNacionEditar.Location = new System.Drawing.Point(402, 239);
            this.cmbNacionEditar.Name = "cmbNacionEditar";
            this.cmbNacionEditar.Size = new System.Drawing.Size(128, 24);
            this.cmbNacionEditar.TabIndex = 94;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(286, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 89;
            this.label10.Text = "Nivel de Acceso:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(286, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 17);
            this.label12.TabIndex = 93;
            this.label12.Text = "Nacionalidad:";
            // 
            // cmbAccesoEditar
            // 
            this.cmbAccesoEditar.FormattingEnabled = true;
            this.cmbAccesoEditar.Location = new System.Drawing.Point(402, 197);
            this.cmbAccesoEditar.Name = "cmbAccesoEditar";
            this.cmbAccesoEditar.Size = new System.Drawing.Size(128, 24);
            this.cmbAccesoEditar.TabIndex = 92;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::Vista.Properties.Resources.edicion;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(787, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(268, 458);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1055, 100);
            this.panel5.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(319, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(318, 46);
            this.label7.TabIndex = 0;
            this.label7.Text = "EDITAR USUARIO";
            // 
            // pageBorrar
            // 
            this.pageBorrar.BackColor = System.Drawing.Color.Red;
            this.pageBorrar.Controls.Add(this.panel11);
            this.pageBorrar.Controls.Add(this.panel10);
            this.pageBorrar.Controls.Add(this.panel9);
            this.pageBorrar.Controls.Add(this.panel8);
            this.pageBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageBorrar.Location = new System.Drawing.Point(4, 24);
            this.pageBorrar.Name = "pageBorrar";
            this.pageBorrar.Size = new System.Drawing.Size(1055, 558);
            this.pageBorrar.TabIndex = 3;
            this.pageBorrar.Text = "Borrar Usuario";
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = global::Vista.Properties.Resources.bomba;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(662, 100);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(393, 299);
            this.panel11.TabIndex = 89;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnConfirmarDelete);
            this.panel10.Controls.Add(this.btnCancelarDelete);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Controls.Add(this.txtUserBorrar);
            this.panel10.Controls.Add(this.label13);
            this.panel10.Controls.Add(this.txtNombreBorrar);
            this.panel10.Controls.Add(this.label14);
            this.panel10.Controls.Add(this.txtEdadBorrar);
            this.panel10.Controls.Add(this.txtDniBorrar);
            this.panel10.Controls.Add(this.label15);
            this.panel10.Controls.Add(this.lblPuntajeBorrar);
            this.panel10.Controls.Add(this.lblEliminacion);
            this.panel10.Controls.Add(this.cmbRazonEliminacion);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 100);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(662, 299);
            this.panel10.TabIndex = 0;
            // 
            // btnConfirmarDelete
            // 
            this.btnConfirmarDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarDelete.FlatAppearance.BorderSize = 3;
            this.btnConfirmarDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarDelete.Location = new System.Drawing.Point(152, 226);
            this.btnConfirmarDelete.Name = "btnConfirmarDelete";
            this.btnConfirmarDelete.Size = new System.Drawing.Size(139, 55);
            this.btnConfirmarDelete.TabIndex = 95;
            this.btnConfirmarDelete.Text = "CONFIRMAR";
            this.btnConfirmarDelete.UseVisualStyleBackColor = false;
            // 
            // btnCancelarDelete
            // 
            this.btnCancelarDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarDelete.FlatAppearance.BorderSize = 3;
            this.btnCancelarDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarDelete.Location = new System.Drawing.Point(369, 226);
            this.btnCancelarDelete.Name = "btnCancelarDelete";
            this.btnCancelarDelete.Size = new System.Drawing.Size(139, 55);
            this.btnCancelarDelete.TabIndex = 96;
            this.btnCancelarDelete.Text = "CANCELAR";
            this.btnCancelarDelete.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(42, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 94;
            this.label11.Text = "NickName:";
            // 
            // txtUserBorrar
            // 
            this.txtUserBorrar.Location = new System.Drawing.Point(157, 180);
            this.txtUserBorrar.Name = "txtUserBorrar";
            this.txtUserBorrar.Size = new System.Drawing.Size(127, 22);
            this.txtUserBorrar.TabIndex = 90;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(42, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 91;
            this.label13.Text = "Nombre:";
            // 
            // txtNombreBorrar
            // 
            this.txtNombreBorrar.Location = new System.Drawing.Point(157, 50);
            this.txtNombreBorrar.Name = "txtNombreBorrar";
            this.txtNombreBorrar.Size = new System.Drawing.Size(127, 22);
            this.txtNombreBorrar.TabIndex = 87;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(42, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 17);
            this.label14.TabIndex = 93;
            this.label14.Text = "Documento:";
            // 
            // txtEdadBorrar
            // 
            this.txtEdadBorrar.Location = new System.Drawing.Point(157, 95);
            this.txtEdadBorrar.Name = "txtEdadBorrar";
            this.txtEdadBorrar.Size = new System.Drawing.Size(127, 22);
            this.txtEdadBorrar.TabIndex = 88;
            // 
            // txtDniBorrar
            // 
            this.txtDniBorrar.Location = new System.Drawing.Point(157, 139);
            this.txtDniBorrar.Name = "txtDniBorrar";
            this.txtDniBorrar.Size = new System.Drawing.Size(127, 22);
            this.txtDniBorrar.TabIndex = 89;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(42, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 92;
            this.label15.Text = "Edad:";
            // 
            // lblPuntajeBorrar
            // 
            this.lblPuntajeBorrar.AutoSize = true;
            this.lblPuntajeBorrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPuntajeBorrar.Location = new System.Drawing.Point(334, 49);
            this.lblPuntajeBorrar.Name = "lblPuntajeBorrar";
            this.lblPuntajeBorrar.Size = new System.Drawing.Size(80, 25);
            this.lblPuntajeBorrar.TabIndex = 85;
            this.lblPuntajeBorrar.Text = "puntaje";
            // 
            // lblEliminacion
            // 
            this.lblEliminacion.AutoSize = true;
            this.lblEliminacion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEliminacion.Location = new System.Drawing.Point(334, 90);
            this.lblEliminacion.Name = "lblEliminacion";
            this.lblEliminacion.Size = new System.Drawing.Size(206, 25);
            this.lblEliminacion.TabIndex = 84;
            this.lblEliminacion.Text = "Razon de Eliminación:";
            // 
            // cmbRazonEliminacion
            // 
            this.cmbRazonEliminacion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbRazonEliminacion.FormattingEnabled = true;
            this.cmbRazonEliminacion.Location = new System.Drawing.Point(334, 124);
            this.cmbRazonEliminacion.Name = "cmbRazonEliminacion";
            this.cmbRazonEliminacion.Size = new System.Drawing.Size(201, 33);
            this.cmbRazonEliminacion.TabIndex = 86;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::Vista.Properties.Resources.logoOK;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 399);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1055, 159);
            this.panel9.TabIndex = 88;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1055, 100);
            this.panel8.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(182, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(622, 44);
            this.label9.TabIndex = 0;
            this.label9.Text = "PIERDE TURNO NO... PIERDE CUENTA";
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataSource = typeof(Entidades.Modelos.Usuario);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Entidades.Modelos.Usuario);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1063, 688);
            this.ControlBox = false;
            this.Controls.Add(this.tabListado);
            this.Controls.Add(this.panel1);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.tabListado.ResumeLayout(false);
            this.pageLista.ResumeLayout(false);
            this.pageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoJugadores)).EndInit();
            this.pageCrear.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pageEditar.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pageBorrar.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TabControl tabListado;
        private TabPage pageLista;
        private Label lblBusqueda;
        private DataGridView dgvListadoJugadores;
        private Button btnSalir;
        private Button btnBorrar;
        private Button btnEditar;
        private Button btnAgregarNuevo;
        private Button btnBuscar;
        private TextBox txtBusqueda;
        private TabPage pageCrear;
        private Button btnCancelarNuevo;
        private Button btnConfirmarNuevo;
        private ComboBox cmbNacionNuevo;
        private Label label6;
        private ComboBox cmbAccesoNuevo;
        private TextBox txtContraseñaNuevo;
        private Label lblContraseña;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtApodoNuevo;
        private TextBox txtDocumentoNuevo;
        private TextBox txtEdadNuevo;
        private TextBox txtNombreNuevo;
        private Label lblCambios;
        private BindingSource usuarioBindingSource;
        private BindingSource usuarioBindingSource1;
        private TabPage pageEditar;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private TabPage pageBorrar;
        private ComboBox cmbRazonEliminacion;
        private Label lblPuntajeBorrar;
        private Label lblEliminacion;
        private Panel panel7;
        private Button btnConfirmarEdicion;
        private Button btnCancelarEdicion;
        private Label label8;
        private TextBox txtUserEditar;
        private ComboBox cmbNacionEditar;
        private Label label10;
        private Label label12;
        private ComboBox cmbAccesoEditar;
        private Panel panel6;
        private Panel panel5;
        private Label label7;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private PictureBox pictureBox1;
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
        private Label label9;
    }
}