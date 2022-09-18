namespace Parcial_Laboratorio
{
    partial class InfoVuelos
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
            this.dtgInfoVuelosTerminados = new System.Windows.Forms.DataGridView();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.dtgInfoVuelosActivos = new System.Windows.Forms.DataGridView();
            this.lbl_vuelosActivos = new System.Windows.Forms.Label();
            this.lblVuelosTerminados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfoVuelosTerminados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfoVuelosActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgInfoVuelosTerminados
            // 
            this.dtgInfoVuelosTerminados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtgInfoVuelosTerminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfoVuelosTerminados.Location = new System.Drawing.Point(12, 417);
            this.dtgInfoVuelosTerminados.Name = "dtgInfoVuelosTerminados";
            this.dtgInfoVuelosTerminados.RowTemplate.Height = 25;
            this.dtgInfoVuelosTerminados.Size = new System.Drawing.Size(873, 382);
            this.dtgInfoVuelosTerminados.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(366, 805);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(171, 64);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.Text = "CERRAR";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // dtgInfoVuelosActivos
            // 
            this.dtgInfoVuelosActivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtgInfoVuelosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfoVuelosActivos.Location = new System.Drawing.Point(12, 22);
            this.dtgInfoVuelosActivos.Name = "dtgInfoVuelosActivos";
            this.dtgInfoVuelosActivos.RowTemplate.Height = 25;
            this.dtgInfoVuelosActivos.Size = new System.Drawing.Size(873, 374);
            this.dtgInfoVuelosActivos.TabIndex = 2;
            // 
            // lbl_vuelosActivos
            // 
            this.lbl_vuelosActivos.AutoSize = true;
            this.lbl_vuelosActivos.ForeColor = System.Drawing.Color.White;
            this.lbl_vuelosActivos.Location = new System.Drawing.Point(397, 4);
            this.lbl_vuelosActivos.Name = "lbl_vuelosActivos";
            this.lbl_vuelosActivos.Size = new System.Drawing.Size(99, 15);
            this.lbl_vuelosActivos.TabIndex = 3;
            this.lbl_vuelosActivos.Text = "VUELOS ACTIVOS";
            // 
            // lblVuelosTerminados
            // 
            this.lblVuelosTerminados.AutoSize = true;
            this.lblVuelosTerminados.ForeColor = System.Drawing.Color.White;
            this.lblVuelosTerminados.Location = new System.Drawing.Point(371, 399);
            this.lblVuelosTerminados.Name = "lblVuelosTerminados";
            this.lblVuelosTerminados.Size = new System.Drawing.Size(125, 15);
            this.lblVuelosTerminados.TabIndex = 4;
            this.lblVuelosTerminados.Text = "VUELOS TERMINADOS";
            // 
            // InfoVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(897, 881);
            this.Controls.Add(this.lblVuelosTerminados);
            this.Controls.Add(this.lbl_vuelosActivos);
            this.Controls.Add(this.dtgInfoVuelosActivos);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.dtgInfoVuelosTerminados);
            this.Name = "InfoVuelos";
            this.Text = "InfoVuelos";
            this.Load += new System.EventHandler(this.InfoVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfoVuelosTerminados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfoVuelosActivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgInfoVuelosTerminados;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridView dtgInfoVuelosActivos;
        private System.Windows.Forms.Label lbl_vuelosActivos;
        private System.Windows.Forms.Label lblVuelosTerminados;
    }
}