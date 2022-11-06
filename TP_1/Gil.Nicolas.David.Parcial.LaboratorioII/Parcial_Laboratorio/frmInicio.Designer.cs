namespace Parcial_Laboratorio
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDatosIncorrectos = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAutocompletar = new System.Windows.Forms.Button();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tmrFrmInicio = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(160, 131);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 23);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(160, 189);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblNombreUsuario.Location = new System.Drawing.Point(143, 111);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(129, 17);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblContraseña.Location = new System.Drawing.Point(171, 169);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(80, 17);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(70, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(267, 23);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "BIENVENIDO A UTN AIRLINES";
            // 
            // lblDatosIncorrectos
            // 
            this.lblDatosIncorrectos.AutoSize = true;
            this.lblDatosIncorrectos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosIncorrectos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatosIncorrectos.ForeColor = System.Drawing.Color.Red;
            this.lblDatosIncorrectos.Location = new System.Drawing.Point(134, 81);
            this.lblDatosIncorrectos.Name = "lblDatosIncorrectos";
            this.lblDatosIncorrectos.Size = new System.Drawing.Size(138, 17);
            this.lblDatosIncorrectos.TabIndex = 5;
            this.lblDatosIncorrectos.Text = "DATOS INCORRECTOS";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 3;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(210, 252);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(91, 33);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "INGRESAR";
            this.toolTip1.SetToolTip(this.btnIngresar, "Confirma usuario y contraseña");
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(117, 252);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 33);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.toolTip1.SetToolTip(this.btnSalir, "Cerrar el programa");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAutocompletar
            // 
            this.btnAutocompletar.BackColor = System.Drawing.Color.Transparent;
            this.btnAutocompletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutocompletar.FlatAppearance.BorderSize = 3;
            this.btnAutocompletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutocompletar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAutocompletar.Location = new System.Drawing.Point(143, 303);
            this.btnAutocompletar.Name = "btnAutocompletar";
            this.btnAutocompletar.Size = new System.Drawing.Size(129, 34);
            this.btnAutocompletar.TabIndex = 8;
            this.btnAutocompletar.Text = "AUTOCOMPLETAR";
            this.toolTip1.SetToolTip(this.btnAutocompletar, "Auto llenar datos");
            this.btnAutocompletar.UseVisualStyleBackColor = false;
            this.btnAutocompletar.Click += new System.EventHandler(this.btnAutocompletar_Click);
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarContraseña.FlatAppearance.BorderSize = 3;
            this.btnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCambiarContraseña.Location = new System.Drawing.Point(106, 354);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(195, 28);
            this.btnCambiarContraseña.TabIndex = 9;
            this.btnCambiarContraseña.Text = "¿Olvido su contraseña?";
            this.toolTip1.SetToolTip(this.btnCambiarContraseña, "Averiguar contraseña");
            this.btnCambiarContraseña.UseVisualStyleBackColor = false;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(334, 397);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 17);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(334, 424);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "date";
            // 
            // tmrFrmInicio
            // 
            this.tmrFrmInicio.Enabled = true;
            this.tmrFrmInicio.Tick += new System.EventHandler(this.tmrFrmInicio_Tick);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial_Laboratorio.Properties.Resources._01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.btnAutocompletar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblDatosIncorrectos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Name = "frmInicio";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDatosIncorrectos;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAutocompletar;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer tmrFrmInicio;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
