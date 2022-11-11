namespace Vista.Vistas
{
    partial class frmLogin
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
            this.lblError = new System.Windows.Forms.Label();
            this.btnAutocompletar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(107, 120);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(134, 17);
            this.lblError.TabIndex = 15;
            this.lblError.Text = "DATOS NO VÁLIDOS";
            // 
            // btnAutocompletar
            // 
            this.btnAutocompletar.BackColor = System.Drawing.Color.Transparent;
            this.btnAutocompletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutocompletar.FlatAppearance.BorderSize = 3;
            this.btnAutocompletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutocompletar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAutocompletar.Location = new System.Drawing.Point(95, 260);
            this.btnAutocompletar.Name = "btnAutocompletar";
            this.btnAutocompletar.Size = new System.Drawing.Size(127, 32);
            this.btnAutocompletar.TabIndex = 14;
            this.btnAutocompletar.Text = "AUTOCOMPLETAR";
            this.btnAutocompletar.UseVisualStyleBackColor = false;
            this.btnAutocompletar.Click += new System.EventHandler(this.btnAutocompletar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(178, 207);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 36);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 3;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresar.Location = new System.Drawing.Point(69, 207);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(83, 36);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPassword.Location = new System.Drawing.Point(122, 158);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 11;
            // 
            // txtUserName
            // 
            this.txtUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUserName.Location = new System.Drawing.Point(122, 70);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 23);
            this.txtUserName.TabIndex = 10;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblContraseña.Location = new System.Drawing.Point(46, 161);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(70, 15);
            this.lblContraseña.TabIndex = 9;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Location = new System.Drawing.Point(69, 73);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 15);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Vista.Properties.Resources.logoOK;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 92);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Controls.Add(this.lblContraseña);
            this.panel2.Controls.Add(this.btnAutocompletar);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnIngresar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 352);
            this.panel2.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(55, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(51, 17);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "label1";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 444);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblError;
        private Button btnAutocompletar;
        private Button btnSalir;
        private Button btnIngresar;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label lblContraseña;
        private Label lblUsuario;
        private Panel panel1;
        private Panel panel2;
        private Label lblTitulo;
    }
}