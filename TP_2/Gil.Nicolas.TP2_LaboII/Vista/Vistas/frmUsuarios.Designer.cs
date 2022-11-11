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
            this.pageDetalles = new System.Windows.Forms.TabPage();
            this.cmbRazonEliminacion = new System.Windows.Forms.ComboBox();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblEliminacion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cmbNacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAcceso = new System.Windows.Forms.ComboBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApodo = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabListado.SuspendLayout();
            this.pageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoJugadores)).BeginInit();
            this.pageDetalles.SuspendLayout();
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
            this.tabListado.Controls.Add(this.pageDetalles);
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
            this.pageLista.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.lblBusqueda.Size = new System.Drawing.Size(99, 17);
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
            this.txtBusqueda.Size = new System.Drawing.Size(663, 25);
            this.txtBusqueda.TabIndex = 8;
            // 
            // pageDetalles
            // 
            this.pageDetalles.BackColor = System.Drawing.Color.Red;
            this.pageDetalles.Controls.Add(this.cmbRazonEliminacion);
            this.pageDetalles.Controls.Add(this.lblPuntaje);
            this.pageDetalles.Controls.Add(this.lblEliminacion);
            this.pageDetalles.Controls.Add(this.btnCancelar);
            this.pageDetalles.Controls.Add(this.btnConfirmar);
            this.pageDetalles.Controls.Add(this.cmbNacion);
            this.pageDetalles.Controls.Add(this.label6);
            this.pageDetalles.Controls.Add(this.cmbAcceso);
            this.pageDetalles.Controls.Add(this.txtContraseña);
            this.pageDetalles.Controls.Add(this.lblContraseña);
            this.pageDetalles.Controls.Add(this.label5);
            this.pageDetalles.Controls.Add(this.label4);
            this.pageDetalles.Controls.Add(this.label3);
            this.pageDetalles.Controls.Add(this.label2);
            this.pageDetalles.Controls.Add(this.label1);
            this.pageDetalles.Controls.Add(this.txtApodo);
            this.pageDetalles.Controls.Add(this.txtDocumento);
            this.pageDetalles.Controls.Add(this.txtEdad);
            this.pageDetalles.Controls.Add(this.txtNombre);
            this.pageDetalles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageDetalles.Location = new System.Drawing.Point(4, 24);
            this.pageDetalles.Name = "pageDetalles";
            this.pageDetalles.Padding = new System.Windows.Forms.Padding(3);
            this.pageDetalles.Size = new System.Drawing.Size(1055, 558);
            this.pageDetalles.TabIndex = 1;
            this.pageDetalles.Text = "Detalles";
            // 
            // cmbRazonEliminacion
            // 
            this.cmbRazonEliminacion.FormattingEnabled = true;
            this.cmbRazonEliminacion.Location = new System.Drawing.Point(608, 260);
            this.cmbRazonEliminacion.Name = "cmbRazonEliminacion";
            this.cmbRazonEliminacion.Size = new System.Drawing.Size(121, 25);
            this.cmbRazonEliminacion.TabIndex = 83;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(544, 135);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(55, 17);
            this.lblPuntaje.TabIndex = 82;
            this.lblPuntaje.Text = "puntaje";
            // 
            // lblEliminacion
            // 
            this.lblEliminacion.AutoSize = true;
            this.lblEliminacion.Location = new System.Drawing.Point(594, 226);
            this.lblEliminacion.Name = "lblEliminacion";
            this.lblEliminacion.Size = new System.Drawing.Size(144, 17);
            this.lblEliminacion.TabIndex = 81;
            this.lblEliminacion.Text = "Razon de Eliminación:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 3;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(483, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 37);
            this.btnCancelar.TabIndex = 80;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderSize = 3;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(321, 369);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(99, 37);
            this.btnConfirmar.TabIndex = 79;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cmbNacion
            // 
            this.cmbNacion.FormattingEnabled = true;
            this.cmbNacion.Location = new System.Drawing.Point(381, 297);
            this.cmbNacion.Name = "cmbNacion";
            this.cmbNacion.Size = new System.Drawing.Size(101, 25);
            this.cmbNacion.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(265, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 77;
            this.label6.Text = "Nacionalidad:";
            // 
            // cmbAcceso
            // 
            this.cmbAcceso.FormattingEnabled = true;
            this.cmbAcceso.Location = new System.Drawing.Point(381, 255);
            this.cmbAcceso.Name = "cmbAcceso";
            this.cmbAcceso.Size = new System.Drawing.Size(101, 25);
            this.cmbAcceso.TabIndex = 76;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(381, 218);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(100, 25);
            this.txtContraseña.TabIndex = 75;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblContraseña.Location = new System.Drawing.Point(265, 218);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(81, 17);
            this.lblContraseña.TabIndex = 74;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(265, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Nivel de Acceso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(267, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "NickName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(267, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(267, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Edad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(267, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "Nombre:";
            // 
            // txtApodo
            // 
            this.txtApodo.Location = new System.Drawing.Point(382, 176);
            this.txtApodo.Name = "txtApodo";
            this.txtApodo.Size = new System.Drawing.Size(100, 25);
            this.txtApodo.TabIndex = 68;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(382, 131);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 25);
            this.txtDocumento.TabIndex = 67;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(382, 87);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 25);
            this.txtEdad.TabIndex = 66;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(382, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 25);
            this.txtNombre.TabIndex = 65;
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
            this.pageDetalles.ResumeLayout(false);
            this.pageDetalles.PerformLayout();
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
        private TabPage pageDetalles;
        private ComboBox cmbRazonEliminacion;
        private Label lblPuntaje;
        private Label lblEliminacion;
        private Button btnCancelar;
        private Button btnConfirmar;
        private ComboBox cmbNacion;
        private Label label6;
        private ComboBox cmbAcceso;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtApodo;
        private TextBox txtDocumento;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label lblCambios;
        private BindingSource usuarioBindingSource;
        private BindingSource usuarioBindingSource1;
    }
}