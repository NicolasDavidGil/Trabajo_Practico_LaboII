namespace Parcial_Laboratorio
{
    partial class NuevoCliente
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEdadCliente = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.txtEdadCliente = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccesoUser = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnVentaNuevoCLiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 3;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(206, 442);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(130, 80);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "VOLVER SIN GUARDAR";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearCliente.FlatAppearance.BorderSize = 3;
            this.btnCrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCliente.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearCliente.Location = new System.Drawing.Point(368, 442);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(154, 80);
            this.btnCrearCliente.TabIndex = 1;
            this.btnCrearCliente.Text = "AGREGAR NUEVO CLIENTE";
            this.btnCrearCliente.UseVisualStyleBackColor = false;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblDniCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDniCliente.Location = new System.Drawing.Point(240, 133);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(43, 17);
            this.lblDniCliente.TabIndex = 3;
            this.lblDniCliente.Text = "D.N.I :";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCliente.Location = new System.Drawing.Point(220, 99);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(66, 17);
            this.lblNombreCliente.TabIndex = 4;
            this.lblNombreCliente.Text = "NOMBRE:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(295, 96);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(158, 23);
            this.txtNombreCliente.TabIndex = 5;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(295, 130);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(158, 23);
            this.txtDniCliente.TabIndex = 6;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.BackColor = System.Drawing.Color.Transparent;
            this.lblCiudad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCiudad.Location = new System.Drawing.Point(227, 236);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(59, 17);
            this.lblCiudad.TabIndex = 7;
            this.lblCiudad.Text = "CIUDAD:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(206, 202);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(79, 17);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "DIRECCION:";
            // 
            // lblEdadCliente
            // 
            this.lblEdadCliente.AutoSize = true;
            this.lblEdadCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblEdadCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEdadCliente.Location = new System.Drawing.Point(237, 169);
            this.lblEdadCliente.Name = "lblEdadCliente";
            this.lblEdadCliente.Size = new System.Drawing.Size(45, 17);
            this.lblEdadCliente.TabIndex = 9;
            this.lblEdadCliente.Text = "EDAD:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLocalidad.Location = new System.Drawing.Point(206, 272);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(81, 17);
            this.lblLocalidad.TabIndex = 10;
            this.lblLocalidad.Text = "LOCALIDAD:";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblNacionalidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNacionalidad.Location = new System.Drawing.Point(180, 315);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(108, 17);
            this.lblNacionalidad.TabIndex = 11;
            this.lblNacionalidad.Text = "NACIONALIDAD:";
            // 
            // txtEdadCliente
            // 
            this.txtEdadCliente.Location = new System.Drawing.Point(295, 166);
            this.txtEdadCliente.Name = "txtEdadCliente";
            this.txtEdadCliente.Size = new System.Drawing.Size(158, 23);
            this.txtEdadCliente.TabIndex = 12;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(295, 269);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(158, 23);
            this.txtLocalidad.TabIndex = 13;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(295, 233);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(158, 23);
            this.txtCiudad.TabIndex = 14;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(295, 199);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(158, 23);
            this.txtDireccion.TabIndex = 15;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(295, 312);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(158, 23);
            this.txtNacionalidad.TabIndex = 16;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(323, 400);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(195, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "ESTADO CIVIL:";
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(295, 351);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(158, 23);
            this.cboEstadoCivil.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(514, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Usuario Activo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(514, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nivel de acceso:";
            // 
            // lblAccesoUser
            // 
            this.lblAccesoUser.AutoSize = true;
            this.lblAccesoUser.BackColor = System.Drawing.Color.Transparent;
            this.lblAccesoUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccesoUser.Location = new System.Drawing.Point(619, 57);
            this.lblAccesoUser.Name = "lblAccesoUser";
            this.lblAccesoUser.Size = new System.Drawing.Size(46, 17);
            this.lblAccesoUser.TabIndex = 22;
            this.lblAccesoUser.Text = "access";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(619, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(34, 17);
            this.lblUsuario.TabIndex = 23;
            this.lblUsuario.Text = "user";
            // 
            // btnVentaNuevoCLiente
            // 
            this.btnVentaNuevoCLiente.BackColor = System.Drawing.Color.Transparent;
            this.btnVentaNuevoCLiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentaNuevoCLiente.FlatAppearance.BorderSize = 3;
            this.btnVentaNuevoCLiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaNuevoCLiente.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVentaNuevoCLiente.Location = new System.Drawing.Point(528, 442);
            this.btnVentaNuevoCLiente.Name = "btnVentaNuevoCLiente";
            this.btnVentaNuevoCLiente.Size = new System.Drawing.Size(154, 80);
            this.btnVentaNuevoCLiente.TabIndex = 24;
            this.btnVentaNuevoCLiente.Text = "AGREGAR Y PROCEDER A VENTA";
            this.btnVentaNuevoCLiente.UseVisualStyleBackColor = false;
            this.btnVentaNuevoCLiente.Click += new System.EventHandler(this.btnVentaNuevoCLiente_Click);
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial_Laboratorio.Properties.Resources.avion_2_750x530;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 626);
            this.Controls.Add(this.btnVentaNuevoCLiente);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblAccesoUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEstadoCivil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtEdadCliente);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblEdadCliente);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.btnCrearCliente);
            this.Controls.Add(this.btnVolver);
            this.Name = "NuevoCliente";
            this.Text = "NuevoCliente";
            this.Load += new System.EventHandler(this.NuevoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEdadCliente;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.TextBox txtEdadCliente;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAccesoUser;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnVentaNuevoCLiente;
    }
}