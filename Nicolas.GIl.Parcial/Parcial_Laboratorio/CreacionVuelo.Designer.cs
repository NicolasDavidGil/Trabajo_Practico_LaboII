namespace Parcial_Laboratorio
{
    partial class CreacionVuelo
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
            this.comboBox_origen = new System.Windows.Forms.ComboBox();
            this.comboBox_destino = new System.Windows.Forms.ComboBox();
            this.comboBox_aviones = new System.Windows.Forms.ComboBox();
            this.lbl_origen = new System.Windows.Forms.Label();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_crearVuelo = new System.Windows.Forms.Button();
            this.cmb_horaPartida = new System.Windows.Forms.ComboBox();
            this.lbl_horaPartida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_fechaSalida = new System.Windows.Forms.DateTimePicker();
            this.lbl_camposVacios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_origen
            // 
            this.comboBox_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_origen.FormattingEnabled = true;
            this.comboBox_origen.Location = new System.Drawing.Point(159, 61);
            this.comboBox_origen.Name = "comboBox_origen";
            this.comboBox_origen.Size = new System.Drawing.Size(121, 23);
            this.comboBox_origen.TabIndex = 0;
            this.comboBox_origen.SelectedIndexChanged += new System.EventHandler(this.comboBox_origen_SelectedIndexChanged);
            // 
            // comboBox_destino
            // 
            this.comboBox_destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_destino.FormattingEnabled = true;
            this.comboBox_destino.Location = new System.Drawing.Point(159, 99);
            this.comboBox_destino.Name = "comboBox_destino";
            this.comboBox_destino.Size = new System.Drawing.Size(121, 23);
            this.comboBox_destino.TabIndex = 1;
            // 
            // comboBox_aviones
            // 
            this.comboBox_aviones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_aviones.FormattingEnabled = true;
            this.comboBox_aviones.Location = new System.Drawing.Point(159, 211);
            this.comboBox_aviones.Name = "comboBox_aviones";
            this.comboBox_aviones.Size = new System.Drawing.Size(121, 23);
            this.comboBox_aviones.TabIndex = 2;
            this.comboBox_aviones.SelectedIndexChanged += new System.EventHandler(this.comboBox_aviones_SelectedIndexChanged);
            // 
            // lbl_origen
            // 
            this.lbl_origen.AutoSize = true;
            this.lbl_origen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_origen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_origen.Location = new System.Drawing.Point(90, 69);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(59, 17);
            this.lbl_origen.TabIndex = 3;
            this.lbl_origen.Text = "ORIGEN:";
            // 
            // lbl_destino
            // 
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.BackColor = System.Drawing.Color.Transparent;
            this.lbl_destino.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_destino.Location = new System.Drawing.Point(85, 107);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(65, 17);
            this.lbl_destino.TabIndex = 4;
            this.lbl_destino.Text = "DESTINO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "AVION DESIGNADA:";
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volver.FlatAppearance.BorderSize = 3;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.Location = new System.Drawing.Point(85, 275);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(94, 43);
            this.btn_volver.TabIndex = 6;
            this.btn_volver.Text = "VOLVER";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_crearVuelo
            // 
            this.btn_crearVuelo.BackColor = System.Drawing.Color.Transparent;
            this.btn_crearVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crearVuelo.FlatAppearance.BorderSize = 3;
            this.btn_crearVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crearVuelo.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_crearVuelo.Location = new System.Drawing.Point(210, 276);
            this.btn_crearVuelo.Name = "btn_crearVuelo";
            this.btn_crearVuelo.Size = new System.Drawing.Size(94, 42);
            this.btn_crearVuelo.TabIndex = 7;
            this.btn_crearVuelo.Text = "CREAR VUELO";
            this.btn_crearVuelo.UseVisualStyleBackColor = false;
            this.btn_crearVuelo.Click += new System.EventHandler(this.btn_crearVuelo_Click);
            // 
            // cmb_horaPartida
            // 
            this.cmb_horaPartida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_horaPartida.FormattingEnabled = true;
            this.cmb_horaPartida.Location = new System.Drawing.Point(159, 173);
            this.cmb_horaPartida.Name = "cmb_horaPartida";
            this.cmb_horaPartida.Size = new System.Drawing.Size(121, 23);
            this.cmb_horaPartida.TabIndex = 8;
            // 
            // lbl_horaPartida
            // 
            this.lbl_horaPartida.AutoSize = true;
            this.lbl_horaPartida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_horaPartida.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_horaPartida.Location = new System.Drawing.Point(34, 181);
            this.lbl_horaPartida.Name = "lbl_horaPartida";
            this.lbl_horaPartida.Size = new System.Drawing.Size(125, 17);
            this.lbl_horaPartida.TabIndex = 9;
            this.lbl_horaPartida.Text = "HORA DE PARTIDA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "FECHA DE PARTIDA:";
            // 
            // dtp_fechaSalida
            // 
            this.dtp_fechaSalida.Location = new System.Drawing.Point(159, 139);
            this.dtp_fechaSalida.Name = "dtp_fechaSalida";
            this.dtp_fechaSalida.Size = new System.Drawing.Size(121, 23);
            this.dtp_fechaSalida.TabIndex = 11;
            this.dtp_fechaSalida.ValueChanged += new System.EventHandler(this.dtm_horaSalida_ValueChanged);
            // 
            // lbl_camposVacios
            // 
            this.lbl_camposVacios.AutoSize = true;
            this.lbl_camposVacios.BackColor = System.Drawing.Color.Transparent;
            this.lbl_camposVacios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_camposVacios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_camposVacios.Location = new System.Drawing.Point(61, 246);
            this.lbl_camposVacios.Name = "lbl_camposVacios";
            this.lbl_camposVacios.Size = new System.Drawing.Size(283, 17);
            this.lbl_camposVacios.TabIndex = 12;
            this.lbl_camposVacios.Text = "SE DEBEN COMPLETAR TODOS LOS CAMPOS";
            // 
            // CreacionVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial_Laboratorio.Properties.Resources.FondoOK;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 384);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_camposVacios);
            this.Controls.Add(this.dtp_fechaSalida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_horaPartida);
            this.Controls.Add(this.cmb_horaPartida);
            this.Controls.Add(this.btn_crearVuelo);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_destino);
            this.Controls.Add(this.lbl_origen);
            this.Controls.Add(this.comboBox_aviones);
            this.Controls.Add(this.comboBox_destino);
            this.Controls.Add(this.comboBox_origen);
            this.Name = "CreacionVuelo";
            this.Text = "CreacionVuelo";
            this.Load += new System.EventHandler(this.CreacionVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_origen;
        private System.Windows.Forms.ComboBox comboBox_destino;
        private System.Windows.Forms.ComboBox comboBox_aviones;
        private System.Windows.Forms.Label lbl_origen;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_crearVuelo;
        private System.Windows.Forms.ComboBox cmb_horaPartida;
        private System.Windows.Forms.Label lbl_horaPartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_fechaSalida;
        private System.Windows.Forms.Label lbl_camposVacios;
    }
}