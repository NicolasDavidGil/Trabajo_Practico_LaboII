namespace Parcial_Laboratorio
{
    partial class UserMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nombreVendedor = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_acceso = new System.Windows.Forms.Label();
            this.btn_ventaPasajes = new System.Windows.Forms.Button();
            this.btn_estadisticas = new System.Windows.Forms.Button();
            this.btn_hardCodeo = new System.Windows.Forms.Button();
            this.btn_nuevoVuelo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_detalles = new System.Windows.Forms.Button();
            this.lbl_vuelosActivos = new System.Windows.Forms.Label();
            this.lbl_datosYaCargados = new System.Windows.Forms.Label();
            this.lbl_primeraCarga = new System.Windows.Forms.Label();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.btn_informacionVuelos = new System.Windows.Forms.Button();
            this.lbl_vueloLleno = new System.Windows.Forms.Label();
            this.btnEditarVuelo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nivel de acceso:";
            // 
            // lbl_nombreVendedor
            // 
            this.lbl_nombreVendedor.AutoSize = true;
            this.lbl_nombreVendedor.Location = new System.Drawing.Point(149, 68);
            this.lbl_nombreVendedor.Name = "lbl_nombreVendedor";
            this.lbl_nombreVendedor.Size = new System.Drawing.Size(102, 15);
            this.lbl_nombreVendedor.TabIndex = 3;
            this.lbl_nombreVendedor.Text = "nombreCompleto";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(149, 102);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(61, 15);
            this.lbl_userName.TabIndex = 4;
            this.lbl_userName.Text = "userName";
            // 
            // lbl_acceso
            // 
            this.lbl_acceso.AutoSize = true;
            this.lbl_acceso.Location = new System.Drawing.Point(149, 130);
            this.lbl_acceso.Name = "lbl_acceso";
            this.lbl_acceso.Size = new System.Drawing.Size(70, 15);
            this.lbl_acceso.TabIndex = 5;
            this.lbl_acceso.Text = "nivelAcceso";
            // 
            // btn_ventaPasajes
            // 
            this.btn_ventaPasajes.Enabled = false;
            this.btn_ventaPasajes.Location = new System.Drawing.Point(263, 223);
            this.btn_ventaPasajes.Name = "btn_ventaPasajes";
            this.btn_ventaPasajes.Size = new System.Drawing.Size(97, 84);
            this.btn_ventaPasajes.TabIndex = 6;
            this.btn_ventaPasajes.Text = "VENDER PASAJES";
            this.btn_ventaPasajes.UseVisualStyleBackColor = true;
            this.btn_ventaPasajes.Click += new System.EventHandler(this.btn_ventaPasajes_Click);
            // 
            // btn_estadisticas
            // 
            this.btn_estadisticas.Location = new System.Drawing.Point(131, 322);
            this.btn_estadisticas.Name = "btn_estadisticas";
            this.btn_estadisticas.Size = new System.Drawing.Size(94, 84);
            this.btn_estadisticas.TabIndex = 7;
            this.btn_estadisticas.Text = "ESTADISTICAS EMPRESA";
            this.btn_estadisticas.UseVisualStyleBackColor = true;
            this.btn_estadisticas.Click += new System.EventHandler(this.btn_estadisticas_Click);
            // 
            // btn_hardCodeo
            // 
            this.btn_hardCodeo.Location = new System.Drawing.Point(366, 12);
            this.btn_hardCodeo.Name = "btn_hardCodeo";
            this.btn_hardCodeo.Size = new System.Drawing.Size(209, 84);
            this.btn_hardCodeo.TabIndex = 8;
            this.btn_hardCodeo.Text = "CARGAR DATOS EN BASE";
            this.btn_hardCodeo.UseVisualStyleBackColor = true;
            this.btn_hardCodeo.Click += new System.EventHandler(this.btn_hardCodeo_Click);
            // 
            // btn_nuevoVuelo
            // 
            this.btn_nuevoVuelo.Location = new System.Drawing.Point(131, 223);
            this.btn_nuevoVuelo.Name = "btn_nuevoVuelo";
            this.btn_nuevoVuelo.Size = new System.Drawing.Size(94, 84);
            this.btn_nuevoVuelo.TabIndex = 9;
            this.btn_nuevoVuelo.Text = "CREAR NUEVO VUELO";
            this.btn_nuevoVuelo.UseVisualStyleBackColor = true;
            this.btn_nuevoVuelo.Click += new System.EventHandler(this.btn_nuevoVuelo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 412);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 178);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btn_detalles
            // 
            this.btn_detalles.Enabled = false;
            this.btn_detalles.Location = new System.Drawing.Point(946, 223);
            this.btn_detalles.Name = "btn_detalles";
            this.btn_detalles.Size = new System.Drawing.Size(97, 84);
            this.btn_detalles.TabIndex = 11;
            this.btn_detalles.Text = "DETALLES VUELO";
            this.btn_detalles.UseVisualStyleBackColor = true;
            this.btn_detalles.Click += new System.EventHandler(this.btn_detalles_Click);
            // 
            // lbl_vuelosActivos
            // 
            this.lbl_vuelosActivos.AutoSize = true;
            this.lbl_vuelosActivos.BackColor = System.Drawing.Color.Black;
            this.lbl_vuelosActivos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_vuelosActivos.Font = new System.Drawing.Font("Book Antiqua", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_vuelosActivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_vuelosActivos.Location = new System.Drawing.Point(79, 467);
            this.lbl_vuelosActivos.Name = "lbl_vuelosActivos";
            this.lbl_vuelosActivos.Size = new System.Drawing.Size(909, 78);
            this.lbl_vuelosActivos.TabIndex = 12;
            this.lbl_vuelosActivos.Text = "NO HAY VUELOS ACTIVOS";
            // 
            // lbl_datosYaCargados
            // 
            this.lbl_datosYaCargados.AutoSize = true;
            this.lbl_datosYaCargados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_datosYaCargados.Location = new System.Drawing.Point(581, 68);
            this.lbl_datosYaCargados.Name = "lbl_datosYaCargados";
            this.lbl_datosYaCargados.Size = new System.Drawing.Size(174, 15);
            this.lbl_datosYaCargados.TabIndex = 13;
            this.lbl_datosYaCargados.Text = "YA SE HA USADO ESTA OPCION";
            // 
            // lbl_primeraCarga
            // 
            this.lbl_primeraCarga.AutoSize = true;
            this.lbl_primeraCarga.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_primeraCarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_primeraCarga.Location = new System.Drawing.Point(581, 23);
            this.lbl_primeraCarga.Name = "lbl_primeraCarga";
            this.lbl_primeraCarga.Size = new System.Drawing.Size(121, 17);
            this.lbl_primeraCarga.TabIndex = 14;
            this.lbl_primeraCarga.Text = "DATOS CARGADOS";
            // 
            // btn_cerrarSesion
            // 
            this.btn_cerrarSesion.Location = new System.Drawing.Point(962, 33);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.Size = new System.Drawing.Size(97, 84);
            this.btn_cerrarSesion.TabIndex = 15;
            this.btn_cerrarSesion.Text = "CERRAR SESION";
            this.btn_cerrarSesion.UseVisualStyleBackColor = true;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            // 
            // btn_informacionVuelos
            // 
            this.btn_informacionVuelos.Location = new System.Drawing.Point(263, 322);
            this.btn_informacionVuelos.Name = "btn_informacionVuelos";
            this.btn_informacionVuelos.Size = new System.Drawing.Size(97, 84);
            this.btn_informacionVuelos.TabIndex = 16;
            this.btn_informacionVuelos.Text = "INFORMACION VUELOS";
            this.btn_informacionVuelos.UseVisualStyleBackColor = true;
            this.btn_informacionVuelos.Click += new System.EventHandler(this.btn_informacionVuelos_Click);
            // 
            // lbl_vueloLleno
            // 
            this.lbl_vueloLleno.AutoSize = true;
            this.lbl_vueloLleno.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_vueloLleno.ForeColor = System.Drawing.Color.Red;
            this.lbl_vueloLleno.Location = new System.Drawing.Point(378, 256);
            this.lbl_vueloLleno.Name = "lbl_vueloLleno";
            this.lbl_vueloLleno.Size = new System.Drawing.Size(286, 17);
            this.lbl_vueloLleno.TabIndex = 17;
            this.lbl_vueloLleno.Text = "NO QUEDAN LUGARES LIBRES EN ESTE VUELO";
            // 
            // btnEditarVuelo
            // 
            this.btnEditarVuelo.Enabled = false;
            this.btnEditarVuelo.Location = new System.Drawing.Point(946, 322);
            this.btnEditarVuelo.Name = "btnEditarVuelo";
            this.btnEditarVuelo.Size = new System.Drawing.Size(97, 84);
            this.btnEditarVuelo.TabIndex = 18;
            this.btnEditarVuelo.Text = "EDITAR VUELO";
            this.btnEditarVuelo.UseVisualStyleBackColor = true;
            this.btnEditarVuelo.Click += new System.EventHandler(this.btnEditarVuelo_Click);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 602);
            this.Controls.Add(this.btnEditarVuelo);
            this.Controls.Add(this.lbl_vueloLleno);
            this.Controls.Add(this.btn_informacionVuelos);
            this.Controls.Add(this.btn_cerrarSesion);
            this.Controls.Add(this.lbl_primeraCarga);
            this.Controls.Add(this.lbl_datosYaCargados);
            this.Controls.Add(this.lbl_vuelosActivos);
            this.Controls.Add(this.btn_detalles);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_nuevoVuelo);
            this.Controls.Add(this.btn_hardCodeo);
            this.Controls.Add(this.btn_estadisticas);
            this.Controls.Add(this.btn_ventaPasajes);
            this.Controls.Add(this.lbl_acceso);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.lbl_nombreVendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.Load += new System.EventHandler(this.UserMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_nombreVendedor;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_acceso;
        private System.Windows.Forms.Button btn_ventaPasajes;
        private System.Windows.Forms.Button btn_estadisticas;
        private System.Windows.Forms.Button btn_hardCodeo;
        private System.Windows.Forms.Button btn_nuevoVuelo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_detalles;
        private System.Windows.Forms.Label lbl_vuelosActivos;
        private System.Windows.Forms.Label lbl_datosYaCargados;
        private System.Windows.Forms.Label lbl_primeraCarga;
        private System.Windows.Forms.Button btn_cerrarSesion;
        private System.Windows.Forms.Button btn_informacionVuelos;
        private System.Windows.Forms.Label lbl_vueloLleno;
        private System.Windows.Forms.Button btnEditarVuelo;
    }
}