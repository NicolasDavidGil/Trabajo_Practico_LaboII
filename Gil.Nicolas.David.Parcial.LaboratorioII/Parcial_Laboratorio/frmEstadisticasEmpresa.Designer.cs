namespace Parcial_Laboratorio
{
    partial class frmEstadisticasEmpresa
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPasajerosTotales = new System.Windows.Forms.Label();
            this.lblVuelosTotales = new System.Windows.Forms.Label();
            this.lblRecaudacionTotal = new System.Windows.Forms.Label();
            this.lblRecaudacionNacional = new System.Windows.Forms.Label();
            this.lblRecaudacionInternacional = new System.Windows.Forms.Label();
            this.dgvEstadisticas = new System.Windows.Forms.DataGridView();
            this.cobEstadisticas = new System.Windows.Forms.ComboBox();
            this.lblPasajerosT = new System.Windows.Forms.Label();
            this.lblPasajeroTurista = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPasajerosPrimera = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btnCerrarPanel = new System.Windows.Forms.Button();
            this.lblClienteElegido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).BeginInit();
            this.pnlCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(37, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "RECAUDACION TOTAL DE LA AEROLINEA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(77, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "TOTAL DE VUELOS REGISTRADOS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(63, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "TOTAL DE PASAJEROS REGISTRADOS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(241, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "ESTADISTICAS DE UTN AIRLINES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(108, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "RECAUDACION NACIONAL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(77, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "RECAUDACION INTERNACIONAL:";
            // 
            // lblPasajerosTotales
            // 
            this.lblPasajerosTotales.AutoSize = true;
            this.lblPasajerosTotales.BackColor = System.Drawing.Color.Transparent;
            this.lblPasajerosTotales.Location = new System.Drawing.Point(269, 59);
            this.lblPasajerosTotales.Name = "lblPasajerosTotales";
            this.lblPasajerosTotales.Size = new System.Drawing.Size(80, 15);
            this.lblPasajerosTotales.TabIndex = 16;
            this.lblPasajerosTotales.Text = "totalPasajeros";
            // 
            // lblVuelosTotales
            // 
            this.lblVuelosTotales.AutoSize = true;
            this.lblVuelosTotales.BackColor = System.Drawing.Color.Transparent;
            this.lblVuelosTotales.Location = new System.Drawing.Point(269, 288);
            this.lblVuelosTotales.Name = "lblVuelosTotales";
            this.lblVuelosTotales.Size = new System.Drawing.Size(77, 15);
            this.lblVuelosTotales.TabIndex = 17;
            this.lblVuelosTotales.Text = "vuelosTotales";
            // 
            // lblRecaudacionTotal
            // 
            this.lblRecaudacionTotal.AutoSize = true;
            this.lblRecaudacionTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblRecaudacionTotal.Location = new System.Drawing.Point(269, 250);
            this.lblRecaudacionTotal.Name = "lblRecaudacionTotal";
            this.lblRecaudacionTotal.Size = new System.Drawing.Size(97, 15);
            this.lblRecaudacionTotal.TabIndex = 18;
            this.lblRecaudacionTotal.Text = "recaudacionTotal";
            // 
            // lblRecaudacionNacional
            // 
            this.lblRecaudacionNacional.AutoSize = true;
            this.lblRecaudacionNacional.BackColor = System.Drawing.Color.Transparent;
            this.lblRecaudacionNacional.Location = new System.Drawing.Point(269, 172);
            this.lblRecaudacionNacional.Name = "lblRecaudacionNacional";
            this.lblRecaudacionNacional.Size = new System.Drawing.Size(119, 15);
            this.lblRecaudacionNacional.TabIndex = 19;
            this.lblRecaudacionNacional.Text = "recaudacionNacional";
            // 
            // lblRecaudacionInternacional
            // 
            this.lblRecaudacionInternacional.AutoSize = true;
            this.lblRecaudacionInternacional.BackColor = System.Drawing.Color.Transparent;
            this.lblRecaudacionInternacional.Location = new System.Drawing.Point(269, 211);
            this.lblRecaudacionInternacional.Name = "lblRecaudacionInternacional";
            this.lblRecaudacionInternacional.Size = new System.Drawing.Size(141, 15);
            this.lblRecaudacionInternacional.TabIndex = 20;
            this.lblRecaudacionInternacional.Text = "recaudacionInternacional";
            // 
            // dgvEstadisticas
            // 
            this.dgvEstadisticas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadisticas.Location = new System.Drawing.Point(430, 93);
            this.dgvEstadisticas.Name = "dgvEstadisticas";
            this.dgvEstadisticas.RowTemplate.Height = 25;
            this.dgvEstadisticas.Size = new System.Drawing.Size(358, 345);
            this.dgvEstadisticas.TabIndex = 21;
            this.dgvEstadisticas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEstadisticas_RowHeaderMouseClick);
            // 
            // cobEstadisticas
            // 
            this.cobEstadisticas.FormattingEnabled = true;
            this.cobEstadisticas.Location = new System.Drawing.Point(551, 59);
            this.cobEstadisticas.Name = "cobEstadisticas";
            this.cobEstadisticas.Size = new System.Drawing.Size(144, 23);
            this.cobEstadisticas.TabIndex = 22;
            this.cobEstadisticas.SelectedIndexChanged += new System.EventHandler(this.cobEstadisticas_SelectedIndexChanged);
            // 
            // lblPasajerosT
            // 
            this.lblPasajerosT.AutoSize = true;
            this.lblPasajerosT.BackColor = System.Drawing.Color.Transparent;
            this.lblPasajerosT.Location = new System.Drawing.Point(89, 93);
            this.lblPasajerosT.Name = "lblPasajerosT";
            this.lblPasajerosT.Size = new System.Drawing.Size(169, 15);
            this.lblPasajerosT.TabIndex = 23;
            this.lblPasajerosT.Text = "TOTAL DE PASAJEROS TURISTA:";
            // 
            // lblPasajeroTurista
            // 
            this.lblPasajeroTurista.AutoSize = true;
            this.lblPasajeroTurista.BackColor = System.Drawing.Color.Transparent;
            this.lblPasajeroTurista.Location = new System.Drawing.Point(269, 93);
            this.lblPasajeroTurista.Name = "lblPasajeroTurista";
            this.lblPasajeroTurista.Size = new System.Drawing.Size(91, 15);
            this.lblPasajeroTurista.TabIndex = 24;
            this.lblPasajeroTurista.Text = "pasajerosTurista";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(89, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "TOTAL DE PASAJEROS PRIMERA:";
            // 
            // lblPasajerosPrimera
            // 
            this.lblPasajerosPrimera.AutoSize = true;
            this.lblPasajerosPrimera.BackColor = System.Drawing.Color.Transparent;
            this.lblPasajerosPrimera.Location = new System.Drawing.Point(272, 132);
            this.lblPasajerosPrimera.Name = "lblPasajerosPrimera";
            this.lblPasajerosPrimera.Size = new System.Drawing.Size(97, 15);
            this.lblPasajerosPrimera.TabIndex = 26;
            this.lblPasajerosPrimera.Text = "pasajerosPrimera";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatAppearance.BorderSize = 3;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(126, 353);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 57);
            this.btnVolver.TabIndex = 27;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pnlCliente
            // 
            this.pnlCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlCliente.Controls.Add(this.btnCerrarPanel);
            this.pnlCliente.Controls.Add(this.lblClienteElegido);
            this.pnlCliente.Location = new System.Drawing.Point(264, 93);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(219, 345);
            this.pnlCliente.TabIndex = 28;
            // 
            // btnCerrarPanel
            // 
            this.btnCerrarPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarPanel.FlatAppearance.BorderSize = 3;
            this.btnCerrarPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPanel.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrarPanel.Location = new System.Drawing.Point(69, 300);
            this.btnCerrarPanel.Name = "btnCerrarPanel";
            this.btnCerrarPanel.Size = new System.Drawing.Size(86, 29);
            this.btnCerrarPanel.TabIndex = 1;
            this.btnCerrarPanel.Text = "CERRAR";
            this.btnCerrarPanel.UseVisualStyleBackColor = false;
            this.btnCerrarPanel.Click += new System.EventHandler(this.btnCerrarPanel_Click);
            // 
            // lblClienteElegido
            // 
            this.lblClienteElegido.AutoSize = true;
            this.lblClienteElegido.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblClienteElegido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClienteElegido.Location = new System.Drawing.Point(15, 15);
            this.lblClienteElegido.Name = "lblClienteElegido";
            this.lblClienteElegido.Size = new System.Drawing.Size(54, 17);
            this.lblClienteElegido.TabIndex = 0;
            this.lblClienteElegido.Text = "label8";
            // 
            // frmEstadisticasEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblPasajerosPrimera);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPasajeroTurista);
            this.Controls.Add(this.lblPasajerosT);
            this.Controls.Add(this.cobEstadisticas);
            this.Controls.Add(this.dgvEstadisticas);
            this.Controls.Add(this.lblRecaudacionInternacional);
            this.Controls.Add(this.lblRecaudacionNacional);
            this.Controls.Add(this.lblRecaudacionTotal);
            this.Controls.Add(this.lblVuelosTotales);
            this.Controls.Add(this.lblPasajerosTotales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEstadisticasEmpresa";
            this.Text = "frmEstadisticasEmpresa";
            this.Load += new System.EventHandler(this.frmEstadisticasEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).EndInit();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPasajerosTotales;
        private System.Windows.Forms.Label lblVuelosTotales;
        private System.Windows.Forms.Label lblRecaudacionTotal;
        private System.Windows.Forms.Label lblRecaudacionNacional;
        private System.Windows.Forms.Label lblRecaudacionInternacional;
        private System.Windows.Forms.DataGridView dgvEstadisticas;
        private System.Windows.Forms.ComboBox cobEstadisticas;
        private System.Windows.Forms.Label lblPasajerosT;
        private System.Windows.Forms.Label lblPasajeroTurista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPasajerosPrimera;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label lblClienteElegido;
        private System.Windows.Forms.Button btnCerrarPanel;
    }
}