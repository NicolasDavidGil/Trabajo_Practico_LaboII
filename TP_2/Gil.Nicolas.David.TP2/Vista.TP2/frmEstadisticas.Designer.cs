namespace Vista.TP2
{
    partial class frmEstadisticas
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
            this.dgvHistorialPartidas = new System.Windows.Forms.DataGridView();
            this.partidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCantPartidas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorialPartidas
            // 
            this.dgvHistorialPartidas.AutoGenerateColumns = false;
            this.dgvHistorialPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvHistorialPartidas.DataSource = this.partidaBindingSource;
            this.dgvHistorialPartidas.Location = new System.Drawing.Point(12, 12);
            this.dgvHistorialPartidas.Name = "dgvHistorialPartidas";
            this.dgvHistorialPartidas.RowTemplate.Height = 25;
            this.dgvHistorialPartidas.Size = new System.Drawing.Size(142, 492);
            this.dgvHistorialPartidas.TabIndex = 0;
            // 
            // partidaBindingSource
            // 
            this.partidaBindingSource.DataSource = typeof(Library.TP2.Partida);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FechaPartida";
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            // 
            // lblCantPartidas
            // 
            this.lblCantPartidas.AutoSize = true;
            this.lblCantPartidas.Location = new System.Drawing.Point(194, 28);
            this.lblCantPartidas.Name = "lblCantPartidas";
            this.lblCantPartidas.Size = new System.Drawing.Size(166, 15);
            this.lblCantPartidas.TabIndex = 1;
            this.lblCantPartidas.Text = "TOTAL DE PARTIDAS JUGADAS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "TOTAL DE JUGADORES REGISTRADOS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "TOTAL DE CUENTAS ACTIVAS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 516);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCantPartidas);
            this.Controls.Add(this.dgvHistorialPartidas);
            this.Name = "frmEstadisticas";
            this.Text = "frmEstadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvHistorialPartidas;
        private DataGridViewTextBoxColumn Column1;
        private BindingSource partidaBindingSource;
        private Label lblCantPartidas;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}