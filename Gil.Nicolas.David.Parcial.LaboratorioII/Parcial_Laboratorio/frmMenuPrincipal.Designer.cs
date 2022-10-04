namespace Parcial_Laboratorio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuCrearCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuBaseDatosCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVentaPasajes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVentaClienteNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVentaClienteExistente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.vUELOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCrearVuelo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVuelosProgramados = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditarVuelo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHistorialVuelo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPRESAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPersonalEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEstadisticasEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSitioWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFlota = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEstadoFlota = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrMenuPrincipal = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.OrangeRed;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.cLIENTESToolStripMenuItem,
            this.toolStripMenuItem2,
            this.btnVentaPasajes,
            this.toolStripMenuItem3,
            this.vUELOSToolStripMenuItem,
            this.toolStripMenuItem4,
            this.eMPRESAToolStripMenuItem,
            this.toolStripMenuItem5,
            this.btnFlota,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem16,
            this.btnCerrarSesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(124, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.OrangeRed;
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(111, 21);
            this.toolStripMenuItem1.Text = "  ";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuCrearCliente,
            this.btnMenuBaseDatosCliente});
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(111, 21);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            // 
            // btnMenuCrearCliente
            // 
            this.btnMenuCrearCliente.Name = "btnMenuCrearCliente";
            this.btnMenuCrearCliente.Size = new System.Drawing.Size(240, 22);
            this.btnMenuCrearCliente.Text = "AGREGAR CLIENTE NUEVO";
            this.btnMenuCrearCliente.Click += new System.EventHandler(this.btnMenuCrearCliente_Click);
            // 
            // btnMenuBaseDatosCliente
            // 
            this.btnMenuBaseDatosCliente.Name = "btnMenuBaseDatosCliente";
            this.btnMenuBaseDatosCliente.Size = new System.Drawing.Size(240, 22);
            this.btnMenuBaseDatosCliente.Text = "BASE DE DATOS: CLIENTES";
            this.btnMenuBaseDatosCliente.Click += new System.EventHandler(this.btnMenuBaseDatosCliente_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(111, 21);
            this.toolStripMenuItem2.Text = " ";
            // 
            // btnVentaPasajes
            // 
            this.btnVentaPasajes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVentaClienteNuevo,
            this.btnVentaClienteExistente});
            this.btnVentaPasajes.Name = "btnVentaPasajes";
            this.btnVentaPasajes.Size = new System.Drawing.Size(111, 21);
            this.btnVentaPasajes.Text = "VENTA PASAJES";
            // 
            // btnVentaClienteNuevo
            // 
            this.btnVentaClienteNuevo.Name = "btnVentaClienteNuevo";
            this.btnVentaClienteNuevo.Size = new System.Drawing.Size(201, 22);
            this.btnVentaClienteNuevo.Text = "NUEVO CLIENTE";
            this.btnVentaClienteNuevo.Click += new System.EventHandler(this.btnVentaClienteNuevo_Click);
            // 
            // btnVentaClienteExistente
            // 
            this.btnVentaClienteExistente.Name = "btnVentaClienteExistente";
            this.btnVentaClienteExistente.Size = new System.Drawing.Size(201, 22);
            this.btnVentaClienteExistente.Text = "CLIENTE EXISTENTE";
            this.btnVentaClienteExistente.Click += new System.EventHandler(this.btnVentaClienteExistente_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(111, 21);
            this.toolStripMenuItem3.Text = " ";
            // 
            // vUELOSToolStripMenuItem
            // 
            this.vUELOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCrearVuelo,
            this.btnVuelosProgramados,
            this.btnEditarVuelo,
            this.btnHistorialVuelo});
            this.vUELOSToolStripMenuItem.Name = "vUELOSToolStripMenuItem";
            this.vUELOSToolStripMenuItem.Size = new System.Drawing.Size(111, 21);
            this.vUELOSToolStripMenuItem.Text = "VUELOS";
            // 
            // btnCrearVuelo
            // 
            this.btnCrearVuelo.Name = "btnCrearVuelo";
            this.btnCrearVuelo.Size = new System.Drawing.Size(255, 22);
            this.btnCrearVuelo.Text = "CREAR NUEVO VUELO";
            this.btnCrearVuelo.Click += new System.EventHandler(this.btnCrearVuelo_Click);
            // 
            // btnVuelosProgramados
            // 
            this.btnVuelosProgramados.Name = "btnVuelosProgramados";
            this.btnVuelosProgramados.Size = new System.Drawing.Size(255, 22);
            this.btnVuelosProgramados.Text = "VER VUELOS PROGRAMADOS";
            this.btnVuelosProgramados.Click += new System.EventHandler(this.btnVuelosProgramados_Click);
            // 
            // btnEditarVuelo
            // 
            this.btnEditarVuelo.Name = "btnEditarVuelo";
            this.btnEditarVuelo.Size = new System.Drawing.Size(255, 22);
            this.btnEditarVuelo.Text = "EDITAR VUELO";
            this.btnEditarVuelo.Click += new System.EventHandler(this.btnEditarVuelo_Click);
            // 
            // btnHistorialVuelo
            // 
            this.btnHistorialVuelo.Name = "btnHistorialVuelo";
            this.btnHistorialVuelo.Size = new System.Drawing.Size(255, 22);
            this.btnHistorialVuelo.Text = "HISTORIAL VUELOS";
            this.btnHistorialVuelo.Click += new System.EventHandler(this.btnHistorialVuelo_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Enabled = false;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(111, 21);
            this.toolStripMenuItem4.Text = " ";
            // 
            // eMPRESAToolStripMenuItem
            // 
            this.eMPRESAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPersonalEmpresa,
            this.btnEstadisticasEmpresa,
            this.btnSitioWeb});
            this.eMPRESAToolStripMenuItem.Name = "eMPRESAToolStripMenuItem";
            this.eMPRESAToolStripMenuItem.Size = new System.Drawing.Size(111, 21);
            this.eMPRESAToolStripMenuItem.Text = "EMPRESA";
            // 
            // btnPersonalEmpresa
            // 
            this.btnPersonalEmpresa.Name = "btnPersonalEmpresa";
            this.btnPersonalEmpresa.Size = new System.Drawing.Size(227, 22);
            this.btnPersonalEmpresa.Text = "PERSONAL";
            this.btnPersonalEmpresa.Click += new System.EventHandler(this.btnPersonalEmpresa_Click);
            // 
            // btnEstadisticasEmpresa
            // 
            this.btnEstadisticasEmpresa.Name = "btnEstadisticasEmpresa";
            this.btnEstadisticasEmpresa.Size = new System.Drawing.Size(227, 22);
            this.btnEstadisticasEmpresa.Text = "ESTADISTICAS EMPRESA";
            this.btnEstadisticasEmpresa.Click += new System.EventHandler(this.btnEstadisticasEmpresa_Click);
            // 
            // btnSitioWeb
            // 
            this.btnSitioWeb.Name = "btnSitioWeb";
            this.btnSitioWeb.Size = new System.Drawing.Size(227, 22);
            this.btnSitioWeb.Text = "SITIO WEB";
            this.btnSitioWeb.Click += new System.EventHandler(this.btnSitioWeb_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Enabled = false;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(111, 21);
            this.toolStripMenuItem5.Text = " ";
            // 
            // btnFlota
            // 
            this.btnFlota.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEstadoFlota});
            this.btnFlota.Name = "btnFlota";
            this.btnFlota.Size = new System.Drawing.Size(111, 21);
            this.btnFlota.Text = "FLOTA";
            // 
            // btnEstadoFlota
            // 
            this.btnEstadoFlota.Name = "btnEstadoFlota";
            this.btnEstadoFlota.Size = new System.Drawing.Size(198, 22);
            this.btnEstadoFlota.Text = "VER ESTADO FLOTA";
            this.btnEstadoFlota.Click += new System.EventHandler(this.btnEstadoFlota_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Enabled = false;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(111, 21);
            this.toolStripMenuItem6.Text = " ";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Enabled = false;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(111, 21);
            this.toolStripMenuItem7.Text = " ";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Enabled = false;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(111, 21);
            this.toolStripMenuItem8.Text = " ";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Enabled = false;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(111, 21);
            this.toolStripMenuItem9.Text = " ";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Enabled = false;
            this.toolStripMenuItem10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(111, 21);
            this.toolStripMenuItem10.Text = "  ";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Enabled = false;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(111, 21);
            this.toolStripMenuItem11.Text = " ";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Enabled = false;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(111, 21);
            this.toolStripMenuItem12.Text = " ";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Enabled = false;
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(111, 21);
            this.toolStripMenuItem13.Text = " ";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Enabled = false;
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(111, 21);
            this.toolStripMenuItem14.Text = " ";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Enabled = false;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(111, 21);
            this.toolStripMenuItem16.Text = " ";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(111, 21);
            this.btnCerrarSesion.Text = "CERRAR SESION";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario conectado:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(396, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(95, 17);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "userOnName";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(463, 424);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(463, 390);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 17);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "time";
            // 
            // tmrMenuPrincipal
            // 
            this.tmrMenuPrincipal.Enabled = true;
            this.tmrMenuPrincipal.Tick += new System.EventHandler(this.tmrMenuPrincipal_Tick);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuCrearCliente;
        private System.Windows.Forms.ToolStripMenuItem btnMenuBaseDatosCliente;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btnVentaPasajes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem vUELOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCrearVuelo;
        private System.Windows.Forms.ToolStripMenuItem btnVuelosProgramados;
        private System.Windows.Forms.ToolStripMenuItem btnEditarVuelo;
        private System.Windows.Forms.ToolStripMenuItem btnHistorialVuelo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem eMPRESAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnPersonalEmpresa;
        private System.Windows.Forms.ToolStripMenuItem btnEstadisticasEmpresa;
        private System.Windows.Forms.ToolStripMenuItem btnSitioWeb;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem btnFlota;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem btnCerrarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem btnEstadoFlota;
        private System.Windows.Forms.ToolStripMenuItem btnVentaClienteNuevo;
        private System.Windows.Forms.ToolStripMenuItem btnVentaClienteExistente;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}