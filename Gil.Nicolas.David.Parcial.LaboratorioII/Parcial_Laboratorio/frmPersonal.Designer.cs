namespace Parcial_Laboratorio
{
    partial class frmPersonal
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditarDni = new System.Windows.Forms.Button();
            this.btnEditarNombre = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.ptbUsuario = new System.Windows.Forms.PictureBox();
            this.cobVendedores = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditarEdad = new System.Windows.Forms.Button();
            this.lblModificacion = new System.Windows.Forms.Label();
            this.txtModificacion = new System.Windows.Forms.TextBox();
            this.btnCancelarEdicion = new System.Windows.Forms.Button();
            this.btnConfirmarEdicion = new System.Windows.Forms.Button();
            this.pnlModificacion = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblClienteElegido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).BeginInit();
            this.pnlModificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(637, 497);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(134, 56);
            this.btnSalir.TabIndex = 39;
            this.btnSalir.Text = "SALIR";
            this.toolTip1.SetToolTip(this.btnSalir, "volver al menu principal");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditarDni
            // 
            this.btnEditarDni.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarDni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarDni.FlatAppearance.BorderSize = 3;
            this.btnEditarDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDni.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarDni.Location = new System.Drawing.Point(637, 326);
            this.btnEditarDni.Name = "btnEditarDni";
            this.btnEditarDni.Size = new System.Drawing.Size(134, 56);
            this.btnEditarDni.TabIndex = 38;
            this.btnEditarDni.Text = "EDITAR DNI VENDEDOR";
            this.toolTip1.SetToolTip(this.btnEditarDni, "Modificar dni persona");
            this.btnEditarDni.UseVisualStyleBackColor = false;
            this.btnEditarDni.Click += new System.EventHandler(this.btnEditarDni_Click);
            // 
            // btnEditarNombre
            // 
            this.btnEditarNombre.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarNombre.FlatAppearance.BorderSize = 3;
            this.btnEditarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarNombre.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarNombre.Location = new System.Drawing.Point(637, 166);
            this.btnEditarNombre.Name = "btnEditarNombre";
            this.btnEditarNombre.Size = new System.Drawing.Size(134, 56);
            this.btnEditarNombre.TabIndex = 37;
            this.btnEditarNombre.Text = "EDITAR NOMBRE VENDEDOR";
            this.toolTip1.SetToolTip(this.btnEditarNombre, "Editar nombre de persona");
            this.btnEditarNombre.UseVisualStyleBackColor = false;
            this.btnEditarNombre.Click += new System.EventHandler(this.btnEditarNombre_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarUsuario.FlatAppearance.BorderSize = 3;
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarUsuario.Location = new System.Drawing.Point(637, 245);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(134, 56);
            this.btnEditarUsuario.TabIndex = 36;
            this.btnEditarUsuario.Text = "EDITAR NOMBRE DE USUARIO";
            this.toolTip1.SetToolTip(this.btnEditarUsuario, "Cambiar usuario de logeo");
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // ptbUsuario
            // 
            this.ptbUsuario.BackColor = System.Drawing.Color.Black;
            this.ptbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbUsuario.Location = new System.Drawing.Point(308, 49);
            this.ptbUsuario.Name = "ptbUsuario";
            this.ptbUsuario.Size = new System.Drawing.Size(254, 298);
            this.ptbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbUsuario.TabIndex = 40;
            this.ptbUsuario.TabStop = false;
            // 
            // cobVendedores
            // 
            this.cobVendedores.FormattingEnabled = true;
            this.cobVendedores.Location = new System.Drawing.Point(26, 49);
            this.cobVendedores.Name = "cobVendedores";
            this.cobVendedores.Size = new System.Drawing.Size(193, 23);
            this.cobVendedores.TabIndex = 42;
            this.toolTip1.SetToolTip(this.cobVendedores, "Seleccione Vendedor");
            this.cobVendedores.SelectedIndexChanged += new System.EventHandler(this.cobVendedores_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(44, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "SELECCIONE VENDEDOR:";
            // 
            // btnEditarEdad
            // 
            this.btnEditarEdad.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarEdad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarEdad.FlatAppearance.BorderSize = 3;
            this.btnEditarEdad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEdad.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarEdad.Location = new System.Drawing.Point(637, 411);
            this.btnEditarEdad.Name = "btnEditarEdad";
            this.btnEditarEdad.Size = new System.Drawing.Size(134, 56);
            this.btnEditarEdad.TabIndex = 44;
            this.btnEditarEdad.Text = "EDITAR EDAD DE VENDEDOR";
            this.toolTip1.SetToolTip(this.btnEditarEdad, "Cambiar edad persona");
            this.btnEditarEdad.UseVisualStyleBackColor = false;
            this.btnEditarEdad.Click += new System.EventHandler(this.btnEditarEdad_Click);
            // 
            // lblModificacion
            // 
            this.lblModificacion.AutoSize = true;
            this.lblModificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblModificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModificacion.Location = new System.Drawing.Point(72, 47);
            this.lblModificacion.Name = "lblModificacion";
            this.lblModificacion.Size = new System.Drawing.Size(27, 15);
            this.lblModificacion.TabIndex = 45;
            this.lblModificacion.Text = "text";
            // 
            // txtModificacion
            // 
            this.txtModificacion.Location = new System.Drawing.Point(72, 102);
            this.txtModificacion.Name = "txtModificacion";
            this.txtModificacion.Size = new System.Drawing.Size(168, 23);
            this.txtModificacion.TabIndex = 46;
            this.txtModificacion.Text = " ";
            // 
            // btnCancelarEdicion
            // 
            this.btnCancelarEdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarEdicion.FlatAppearance.BorderSize = 3;
            this.btnCancelarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEdicion.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarEdicion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarEdicion.Location = new System.Drawing.Point(20, 165);
            this.btnCancelarEdicion.Name = "btnCancelarEdicion";
            this.btnCancelarEdicion.Size = new System.Drawing.Size(107, 42);
            this.btnCancelarEdicion.TabIndex = 47;
            this.btnCancelarEdicion.Text = "Cancelar Edición";
            this.btnCancelarEdicion.UseVisualStyleBackColor = true;
            this.btnCancelarEdicion.Click += new System.EventHandler(this.btnCancelarEdicion_Click);
            // 
            // btnConfirmarEdicion
            // 
            this.btnConfirmarEdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarEdicion.FlatAppearance.BorderSize = 3;
            this.btnConfirmarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarEdicion.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarEdicion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmarEdicion.Location = new System.Drawing.Point(188, 165);
            this.btnConfirmarEdicion.Name = "btnConfirmarEdicion";
            this.btnConfirmarEdicion.Size = new System.Drawing.Size(100, 42);
            this.btnConfirmarEdicion.TabIndex = 48;
            this.btnConfirmarEdicion.Text = "Confirmar Edición";
            this.toolTip1.SetToolTip(this.btnConfirmarEdicion, "Confirmar cambios");
            this.btnConfirmarEdicion.UseVisualStyleBackColor = true;
            this.btnConfirmarEdicion.Click += new System.EventHandler(this.btnConfirmarEdicion_Click);
            // 
            // pnlModificacion
            // 
            this.pnlModificacion.BackColor = System.Drawing.Color.Black;
            this.pnlModificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlModificacion.Controls.Add(this.btnConfirmarEdicion);
            this.pnlModificacion.Controls.Add(this.lblModificacion);
            this.pnlModificacion.Controls.Add(this.txtModificacion);
            this.pnlModificacion.Controls.Add(this.btnCancelarEdicion);
            this.pnlModificacion.Location = new System.Drawing.Point(12, 197);
            this.pnlModificacion.Name = "pnlModificacion";
            this.pnlModificacion.Size = new System.Drawing.Size(308, 228);
            this.pnlModificacion.TabIndex = 49;
            // 
            // lblClienteElegido
            // 
            this.lblClienteElegido.AutoSize = true;
            this.lblClienteElegido.BackColor = System.Drawing.Color.Transparent;
            this.lblClienteElegido.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClienteElegido.Location = new System.Drawing.Point(326, 363);
            this.lblClienteElegido.Name = "lblClienteElegido";
            this.lblClienteElegido.Size = new System.Drawing.Size(71, 17);
            this.lblClienteElegido.TabIndex = 21;
            this.lblClienteElegido.Text = "USUARIO:";
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 608);
            this.ControlBox = false;
            this.Controls.Add(this.pnlModificacion);
            this.Controls.Add(this.btnEditarEdad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cobVendedores);
            this.Controls.Add(this.ptbUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditarDni);
            this.Controls.Add(this.btnEditarNombre);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.lblClienteElegido);
            this.Name = "frmPersonal";
            this.Text = "frmPersonal";
            this.Load += new System.EventHandler(this.frmPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).EndInit();
            this.pnlModificacion.ResumeLayout(false);
            this.pnlModificacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditarDni;
        private System.Windows.Forms.Button btnEditarNombre;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.PictureBox ptbUsuario;
        private System.Windows.Forms.ComboBox cobVendedores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditarEdad;
        private System.Windows.Forms.Label lblModificacion;
        private System.Windows.Forms.TextBox txtModificacion;
        private System.Windows.Forms.Button btnCancelarEdicion;
        private System.Windows.Forms.Button btnConfirmarEdicion;
        private System.Windows.Forms.Panel pnlModificacion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblClienteElegido;
    }
}