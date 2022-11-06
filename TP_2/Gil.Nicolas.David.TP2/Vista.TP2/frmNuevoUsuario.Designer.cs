namespace Vista.TP2
{
    partial class frmNuevoUsuario
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
            this.lblTittle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrearJugador = new System.Windows.Forms.Button();
            this.txtApodo = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cmbAcceso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblError.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(209, 226);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(51, 17);
            this.lblError.TabIndex = 25;
            this.lblError.Text = "errores";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTittle.Location = new System.Drawing.Point(49, 59);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(408, 27);
            this.lblTittle.TabIndex = 24;
            this.lblTittle.Text = "¡¡¡BIENVENIDO CONCURSANTE UNERO!!!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(81, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "NickName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(81, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(81, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Edad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 3;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(267, 375);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 79);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrearJugador
            // 
            this.btnCrearJugador.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearJugador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearJugador.FlatAppearance.BorderSize = 3;
            this.btnCrearJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearJugador.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearJugador.Location = new System.Drawing.Point(130, 375);
            this.btnCrearJugador.Name = "btnCrearJugador";
            this.btnCrearJugador.Size = new System.Drawing.Size(100, 79);
            this.btnCrearJugador.TabIndex = 18;
            this.btnCrearJugador.Text = "CREAR JUGADOR";
            this.btnCrearJugador.UseVisualStyleBackColor = false;
            this.btnCrearJugador.Click += new System.EventHandler(this.btnCrearJugador_Click);
            // 
            // txtApodo
            // 
            this.txtApodo.Location = new System.Drawing.Point(193, 245);
            this.txtApodo.Name = "txtApodo";
            this.txtApodo.Size = new System.Drawing.Size(100, 23);
            this.txtApodo.TabIndex = 17;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(193, 200);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 23);
            this.txtDocumento.TabIndex = 16;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(193, 156);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 23);
            this.txtEdad.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(193, 111);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(79, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nivel de Acceso:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContraseña.Location = new System.Drawing.Point(79, 283);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(81, 17);
            this.lblContraseña.TabIndex = 27;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(192, 287);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(100, 23);
            this.txtContraseña.TabIndex = 28;
            // 
            // cmbAcceso
            // 
            this.cmbAcceso.FormattingEnabled = true;
            this.cmbAcceso.Location = new System.Drawing.Point(192, 324);
            this.cmbAcceso.Name = "cmbAcceso";
            this.cmbAcceso.Size = new System.Drawing.Size(101, 23);
            this.cmbAcceso.TabIndex = 29;
            // 
            // frmNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.TP2.Properties.Resources.minimenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 556);
            this.ControlBox = false;
            this.Controls.Add(this.cmbAcceso);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrearJugador);
            this.Controls.Add(this.txtApodo);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmNuevoUsuario";
            this.Text = "frmNuevoUsuario";
            this.Load += new System.EventHandler(this.frmNuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblError;
        private Label lblTittle;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnCrearJugador;
        private TextBox txtApodo;
        private TextBox txtDocumento;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label label5;
        private Label lblContraseña;
        private TextBox txtContraseña;
        private ComboBox cmbAcceso;
    }
}