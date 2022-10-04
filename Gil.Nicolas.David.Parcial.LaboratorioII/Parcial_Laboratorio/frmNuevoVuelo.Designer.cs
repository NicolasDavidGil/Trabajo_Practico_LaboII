namespace Parcial_Laboratorio
{
    partial class frmNuevoVuelo
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
            this.lblCamposVacios = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_horaPartida = new System.Windows.Forms.Label();
            this.cobHoraSalida = new System.Windows.Forms.ComboBox();
            this.btnCrearVuelo = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.lbl_origen = new System.Windows.Forms.Label();
            this.cobAviones = new System.Windows.Forms.ComboBox();
            this.cobDestino = new System.Windows.Forms.ComboBox();
            this.cobOrigen = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblCamposVacios
            // 
            this.lblCamposVacios.AutoSize = true;
            this.lblCamposVacios.BackColor = System.Drawing.Color.Black;
            this.lblCamposVacios.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCamposVacios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCamposVacios.Location = new System.Drawing.Point(29, 256);
            this.lblCamposVacios.Name = "lblCamposVacios";
            this.lblCamposVacios.Size = new System.Drawing.Size(315, 17);
            this.lblCamposVacios.TabIndex = 25;
            this.lblCamposVacios.Text = "SE DEBEN COMPLETAR TODOS LOS CAMPOS";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(172, 122);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(121, 23);
            this.dtpFechaSalida.TabIndex = 24;
            this.toolTip1.SetToolTip(this.dtpFechaSalida, "Seleccione fecha");
            this.dtpFechaSalida.ValueChanged += new System.EventHandler(this.dtpFechaSalida_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "FECHA DE PARTIDA:";
            // 
            // lbl_horaPartida
            // 
            this.lbl_horaPartida.AutoSize = true;
            this.lbl_horaPartida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_horaPartida.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_horaPartida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_horaPartida.Location = new System.Drawing.Point(16, 162);
            this.lbl_horaPartida.Name = "lbl_horaPartida";
            this.lbl_horaPartida.Size = new System.Drawing.Size(146, 17);
            this.lbl_horaPartida.TabIndex = 22;
            this.lbl_horaPartida.Text = "HORA DE PARTIDA:";
            // 
            // cobHoraSalida
            // 
            this.cobHoraSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobHoraSalida.FormattingEnabled = true;
            this.cobHoraSalida.Location = new System.Drawing.Point(172, 156);
            this.cobHoraSalida.Name = "cobHoraSalida";
            this.cobHoraSalida.Size = new System.Drawing.Size(121, 23);
            this.cobHoraSalida.TabIndex = 21;
            this.toolTip1.SetToolTip(this.cobHoraSalida, "Seleccione Hora");
            // 
            // btnCrearVuelo
            // 
            this.btnCrearVuelo.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearVuelo.FlatAppearance.BorderSize = 3;
            this.btnCrearVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearVuelo.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearVuelo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearVuelo.Location = new System.Drawing.Point(189, 290);
            this.btnCrearVuelo.Name = "btnCrearVuelo";
            this.btnCrearVuelo.Size = new System.Drawing.Size(94, 55);
            this.btnCrearVuelo.TabIndex = 20;
            this.btnCrearVuelo.Text = "CREAR VUELO";
            this.toolTip1.SetToolTip(this.btnCrearVuelo, "Crear Vuelo");
            this.btnCrearVuelo.UseVisualStyleBackColor = false;
            this.btnCrearVuelo.Click += new System.EventHandler(this.btnCrearVuelo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 3;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolver.Location = new System.Drawing.Point(46, 289);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 56);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "VOLVER";
            this.toolTip1.SetToolTip(this.btnVolver, "Cancelar creacion");
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "AVION DESIGNADA:";
            // 
            // lbl_destino
            // 
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.BackColor = System.Drawing.Color.Transparent;
            this.lbl_destino.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_destino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_destino.Location = new System.Drawing.Point(67, 88);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(77, 17);
            this.lbl_destino.TabIndex = 17;
            this.lbl_destino.Text = "DESTINO:";
            // 
            // lbl_origen
            // 
            this.lbl_origen.AutoSize = true;
            this.lbl_origen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_origen.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_origen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_origen.Location = new System.Drawing.Point(72, 50);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(68, 17);
            this.lbl_origen.TabIndex = 16;
            this.lbl_origen.Text = "ORIGEN:";
            // 
            // cobAviones
            // 
            this.cobAviones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobAviones.FormattingEnabled = true;
            this.cobAviones.Location = new System.Drawing.Point(172, 194);
            this.cobAviones.Name = "cobAviones";
            this.cobAviones.Size = new System.Drawing.Size(121, 23);
            this.cobAviones.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cobAviones, "Seleccione avión");
            // 
            // cobDestino
            // 
            this.cobDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobDestino.FormattingEnabled = true;
            this.cobDestino.Location = new System.Drawing.Point(172, 82);
            this.cobDestino.Name = "cobDestino";
            this.cobDestino.Size = new System.Drawing.Size(121, 23);
            this.cobDestino.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cobDestino, "Seleccione destino");
            // 
            // cobOrigen
            // 
            this.cobOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobOrigen.FormattingEnabled = true;
            this.cobOrigen.Location = new System.Drawing.Point(172, 44);
            this.cobOrigen.Name = "cobOrigen";
            this.cobOrigen.Size = new System.Drawing.Size(121, 23);
            this.cobOrigen.TabIndex = 13;
            this.toolTip1.SetToolTip(this.cobOrigen, "Seleccione el origen");
            this.cobOrigen.SelectedIndexChanged += new System.EventHandler(this.cobOrigen_SelectedIndexChanged);
            // 
            // frmNuevoVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial_Laboratorio.Properties.Resources._10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblCamposVacios);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_horaPartida);
            this.Controls.Add(this.cobHoraSalida);
            this.Controls.Add(this.btnCrearVuelo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_destino);
            this.Controls.Add(this.lbl_origen);
            this.Controls.Add(this.cobAviones);
            this.Controls.Add(this.cobDestino);
            this.Controls.Add(this.cobOrigen);
            this.Name = "frmNuevoVuelo";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmNuevoVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCamposVacios;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_horaPartida;
        private System.Windows.Forms.ComboBox cobHoraSalida;
        private System.Windows.Forms.Button btnCrearVuelo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.Label lbl_origen;
        private System.Windows.Forms.ComboBox cobAviones;
        private System.Windows.Forms.ComboBox cobDestino;
        private System.Windows.Forms.ComboBox cobOrigen;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}