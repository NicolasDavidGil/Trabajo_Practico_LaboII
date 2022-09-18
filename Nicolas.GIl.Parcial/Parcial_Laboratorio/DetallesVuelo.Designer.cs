namespace Parcial_Laboratorio
{
    partial class DetallesVuelo
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
            this.dgv_listaPasajeros = new System.Windows.Forms.DataGridView();
            this.lbl_codigoVuelo = new System.Windows.Forms.Label();
            this.lbl_origenVuelo = new System.Windows.Forms.Label();
            this.lbl_destinoVuelo = new System.Windows.Forms.Label();
            this.lbl_fechaPartida = new System.Windows.Forms.Label();
            this.lbl_horaPartida = new System.Windows.Forms.Label();
            this.lbl_horaLlegada = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lbl_pasajerosCargados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listaPasajeros
            // 
            this.dgv_listaPasajeros.BackgroundColor = System.Drawing.Color.Blue;
            this.dgv_listaPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaPasajeros.Location = new System.Drawing.Point(12, 140);
            this.dgv_listaPasajeros.Name = "dgv_listaPasajeros";
            this.dgv_listaPasajeros.RowTemplate.Height = 25;
            this.dgv_listaPasajeros.Size = new System.Drawing.Size(776, 608);
            this.dgv_listaPasajeros.TabIndex = 0;
            // 
            // lbl_codigoVuelo
            // 
            this.lbl_codigoVuelo.AutoSize = true;
            this.lbl_codigoVuelo.Location = new System.Drawing.Point(12, 22);
            this.lbl_codigoVuelo.Name = "lbl_codigoVuelo";
            this.lbl_codigoVuelo.Size = new System.Drawing.Size(74, 15);
            this.lbl_codigoVuelo.TabIndex = 1;
            this.lbl_codigoVuelo.Text = "codigoVuelo";
            // 
            // lbl_origenVuelo
            // 
            this.lbl_origenVuelo.AutoSize = true;
            this.lbl_origenVuelo.Location = new System.Drawing.Point(12, 64);
            this.lbl_origenVuelo.Name = "lbl_origenVuelo";
            this.lbl_origenVuelo.Size = new System.Drawing.Size(71, 15);
            this.lbl_origenVuelo.TabIndex = 2;
            this.lbl_origenVuelo.Text = "origenVuelo";
            // 
            // lbl_destinoVuelo
            // 
            this.lbl_destinoVuelo.AutoSize = true;
            this.lbl_destinoVuelo.Location = new System.Drawing.Point(12, 100);
            this.lbl_destinoVuelo.Name = "lbl_destinoVuelo";
            this.lbl_destinoVuelo.Size = new System.Drawing.Size(76, 15);
            this.lbl_destinoVuelo.TabIndex = 3;
            this.lbl_destinoVuelo.Text = "destinoVuelo";
            // 
            // lbl_fechaPartida
            // 
            this.lbl_fechaPartida.AutoSize = true;
            this.lbl_fechaPartida.Location = new System.Drawing.Point(408, 22);
            this.lbl_fechaPartida.Name = "lbl_fechaPartida";
            this.lbl_fechaPartida.Size = new System.Drawing.Size(73, 15);
            this.lbl_fechaPartida.TabIndex = 4;
            this.lbl_fechaPartida.Text = "fechaPartida";
            // 
            // lbl_horaPartida
            // 
            this.lbl_horaPartida.AutoSize = true;
            this.lbl_horaPartida.Location = new System.Drawing.Point(408, 64);
            this.lbl_horaPartida.Name = "lbl_horaPartida";
            this.lbl_horaPartida.Size = new System.Drawing.Size(68, 15);
            this.lbl_horaPartida.TabIndex = 5;
            this.lbl_horaPartida.Text = "horaPartida";
            // 
            // lbl_horaLlegada
            // 
            this.lbl_horaLlegada.AutoSize = true;
            this.lbl_horaLlegada.Location = new System.Drawing.Point(408, 100);
            this.lbl_horaLlegada.Name = "lbl_horaLlegada";
            this.lbl_horaLlegada.Size = new System.Drawing.Size(72, 15);
            this.lbl_horaLlegada.TabIndex = 6;
            this.lbl_horaLlegada.Text = "horaLlegada";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(676, 44);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(93, 35);
            this.btn_cerrar.TabIndex = 7;
            this.btn_cerrar.Text = "CERRAR";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // lbl_pasajerosCargados
            // 
            this.lbl_pasajerosCargados.AutoSize = true;
            this.lbl_pasajerosCargados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_pasajerosCargados.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pasajerosCargados.ForeColor = System.Drawing.Color.Black;
            this.lbl_pasajerosCargados.Location = new System.Drawing.Point(128, 252);
            this.lbl_pasajerosCargados.Name = "lbl_pasajerosCargados";
            this.lbl_pasajerosCargados.Size = new System.Drawing.Size(550, 32);
            this.lbl_pasajerosCargados.TabIndex = 8;
            this.lbl_pasajerosCargados.Text = "ESTE VUELO NO POSEE PASAJEROS CARGADOS";
            // 
            // DetallesVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 750);
            this.Controls.Add(this.lbl_pasajerosCargados);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.lbl_horaLlegada);
            this.Controls.Add(this.lbl_horaPartida);
            this.Controls.Add(this.lbl_fechaPartida);
            this.Controls.Add(this.lbl_destinoVuelo);
            this.Controls.Add(this.lbl_origenVuelo);
            this.Controls.Add(this.lbl_codigoVuelo);
            this.Controls.Add(this.dgv_listaPasajeros);
            this.Name = "DetallesVuelo";
            this.Text = "DetallesVuelo";
            this.Load += new System.EventHandler(this.DetallesVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listaPasajeros;
        private System.Windows.Forms.Label lbl_codigoVuelo;
        private System.Windows.Forms.Label lbl_origenVuelo;
        private System.Windows.Forms.Label lbl_destinoVuelo;
        private System.Windows.Forms.Label lbl_fechaPartida;
        private System.Windows.Forms.Label lbl_horaPartida;
        private System.Windows.Forms.Label lbl_horaLlegada;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lbl_pasajerosCargados;
    }
}