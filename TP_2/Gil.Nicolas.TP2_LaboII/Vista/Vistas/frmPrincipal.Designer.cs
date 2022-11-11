namespace Vista.Vistas
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReglas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCrearPartida = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnJugarPartida = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.pnlImagen);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(223, 630);
            this.pnlMenu.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblUsuario);
            this.panel3.Controls.Add(this.lblHora);
            this.panel3.Controls.Add(this.lblFecha);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 430);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 100);
            this.panel3.TabIndex = 4;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Location = new System.Drawing.Point(12, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 17);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "usuario";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHora.Location = new System.Drawing.Point(12, 40);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(45, 17);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFecha.Location = new System.Drawing.Point(12, 66);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 17);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "fecha";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnReglas);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 100);
            this.panel2.TabIndex = 2;
            // 
            // btnReglas
            // 
            this.btnReglas.BackColor = System.Drawing.Color.Transparent;
            this.btnReglas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReglas.FlatAppearance.BorderSize = 2;
            this.btnReglas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReglas.ForeColor = System.Drawing.Color.Red;
            this.btnReglas.Location = new System.Drawing.Point(3, 22);
            this.btnReglas.Name = "btnReglas";
            this.btnReglas.Size = new System.Drawing.Size(208, 30);
            this.btnReglas.TabIndex = 6;
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
            this.btnSalir.Location = new System.Drawing.Point(3, 58);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(208, 30);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCrearPartida);
            this.panel1.Controls.Add(this.btnEstadisticas);
            this.panel1.Controls.Add(this.btnJugarPartida);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 212);
            this.panel1.TabIndex = 5;
            // 
            // btnCrearPartida
            // 
            this.btnCrearPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPartida.FlatAppearance.BorderSize = 2;
            this.btnCrearPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPartida.ForeColor = System.Drawing.Color.Red;
            this.btnCrearPartida.Location = new System.Drawing.Point(3, 16);
            this.btnCrearPartida.Name = "btnCrearPartida";
            this.btnCrearPartida.Size = new System.Drawing.Size(211, 33);
            this.btnCrearPartida.TabIndex = 1;
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
            this.btnEstadisticas.Location = new System.Drawing.Point(6, 131);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(208, 30);
            this.btnEstadisticas.TabIndex = 4;
            this.btnEstadisticas.Text = "ESTADISTICAS";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnJugarPartida
            // 
            this.btnJugarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnJugarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJugarPartida.FlatAppearance.BorderSize = 2;
            this.btnJugarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugarPartida.ForeColor = System.Drawing.Color.Red;
            this.btnJugarPartida.Location = new System.Drawing.Point(3, 55);
            this.btnJugarPartida.Name = "btnJugarPartida";
            this.btnJugarPartida.Size = new System.Drawing.Size(211, 32);
            this.btnJugarPartida.TabIndex = 2;
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
            this.btnUsuarios.Location = new System.Drawing.Point(6, 93);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(208, 32);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "ADMINISTRAR USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pnlImagen
            // 
            this.pnlImagen.BackgroundImage = global::Vista.Properties.Resources.logoOK;
            this.pnlImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImagen.Location = new System.Drawing.Point(0, 0);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Size = new System.Drawing.Size(223, 100);
            this.pnlImagen.TabIndex = 0;
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1223, 630);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMenu);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTN UNO MASTERS";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlImagen;
        private Button btnCrearPartida;
        private Button btnJugarPartida;
        private Button btnUsuarios;
        private Panel panel2;
        private Button btnSalir;
        private Panel panel1;
        private Button btnEstadisticas;
        private Panel panel3;
        private Label lblUsuario;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer tmrHora;
        private Button btnReglas;
    }
}