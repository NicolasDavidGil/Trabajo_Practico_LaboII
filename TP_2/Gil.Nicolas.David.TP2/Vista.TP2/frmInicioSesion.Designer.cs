namespace Vista.TP2
{
    partial class frmInicioSesion
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
            this.tmrClockLogin = new System.Windows.Forms.Timer(this.components);
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblErrores = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarPrograma = new System.Windows.Forms.Button();
            this.btnAutocompletar = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtUsuario.Location = new System.Drawing.Point(123, 180);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 23);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "Master01";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtContraseña.Location = new System.Drawing.Point(123, 252);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(100, 23);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.Text = "12345";
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblErrores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblErrores.Location = new System.Drawing.Point(146, 82);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(57, 21);
            this.lblErrores.TabIndex = 8;
            this.lblErrores.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(112, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre de usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(132, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contraseña:";
            // 
            // btnCerrarPrograma
            // 
            this.btnCerrarPrograma.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarPrograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarPrograma.FlatAppearance.BorderSize = 2;
            this.btnCerrarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPrograma.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarPrograma.ForeColor = System.Drawing.Color.White;
            this.btnCerrarPrograma.Location = new System.Drawing.Point(187, 281);
            this.btnCerrarPrograma.Name = "btnCerrarPrograma";
            this.btnCerrarPrograma.Size = new System.Drawing.Size(122, 42);
            this.btnCerrarPrograma.TabIndex = 3;
            this.btnCerrarPrograma.Text = "SALIR";
            this.btnCerrarPrograma.UseVisualStyleBackColor = false;
            this.btnCerrarPrograma.Click += new System.EventHandler(this.btnCerrarPrograma_Click);
            // 
            // btnAutocompletar
            // 
            this.btnAutocompletar.BackColor = System.Drawing.Color.Transparent;
            this.btnAutocompletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutocompletar.FlatAppearance.BorderSize = 2;
            this.btnAutocompletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutocompletar.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAutocompletar.ForeColor = System.Drawing.Color.White;
            this.btnAutocompletar.Location = new System.Drawing.Point(119, 335);
            this.btnAutocompletar.Name = "btnAutocompletar";
            this.btnAutocompletar.Size = new System.Drawing.Size(122, 32);
            this.btnAutocompletar.TabIndex = 4;
            this.btnAutocompletar.Text = "AUTOCOMPLETAR";
            this.btnAutocompletar.UseVisualStyleBackColor = false;
            this.btnAutocompletar.Click += new System.EventHandler(this.btnAutocompletar_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 2;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(52, 281);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(122, 42);
            this.btnIniciarSesion.TabIndex = 2;
            this.btnIniciarSesion.Text = "INGRESAR";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OrangeRed;
            this.panel4.BackgroundImage = global::Vista.TP2.Properties.Resources.logoOK1;
            this.panel4.Controls.Add(this.lblErrores);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtUsuario);
            this.panel4.Controls.Add(this.txtContraseña);
            this.panel4.Controls.Add(this.btnIniciarSesion);
            this.panel4.Controls.Add(this.btnAutocompletar);
            this.panel4.Controls.Add(this.btnCerrarPrograma);
            this.panel4.Location = new System.Drawing.Point(2, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(374, 457);
            this.panel4.TabIndex = 7;
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(377, 454);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Name = "frmInicioSesion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrClockLogin;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label2;
        private Label label1;
        private Label lblErrores;
        private Button btnCerrarPrograma;
        private Button btnAutocompletar;
        private Button btnIniciarSesion;
        private Panel panel4;
    }
}