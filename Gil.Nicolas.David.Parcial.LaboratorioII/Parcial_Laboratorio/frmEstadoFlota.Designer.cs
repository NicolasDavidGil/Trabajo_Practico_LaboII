namespace Parcial_Laboratorio
{
    partial class frmEstadoFlota
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
            this.lblPromedioVuelo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAvionMasTiempoVolado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAvionesLibres = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAvionesVolando = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAviones = new System.Windows.Forms.DataGridView();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeronaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblAvionElegido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAviones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPromedioVuelo
            // 
            this.lblPromedioVuelo.AutoSize = true;
            this.lblPromedioVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lblPromedioVuelo.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPromedioVuelo.Location = new System.Drawing.Point(405, 104);
            this.lblPromedioVuelo.Name = "lblPromedioVuelo";
            this.lblPromedioVuelo.Size = new System.Drawing.Size(47, 17);
            this.lblPromedioVuelo.TabIndex = 18;
            this.lblPromedioVuelo.Text = "prom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(260, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "PROMEDIO DE VUELO:";
            // 
            // lblAvionMasTiempoVolado
            // 
            this.lblAvionMasTiempoVolado.AutoSize = true;
            this.lblAvionMasTiempoVolado.BackColor = System.Drawing.Color.Transparent;
            this.lblAvionMasTiempoVolado.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvionMasTiempoVolado.Location = new System.Drawing.Point(405, 70);
            this.lblAvionMasTiempoVolado.Name = "lblAvionMasTiempoVolado";
            this.lblAvionMasTiempoVolado.Size = new System.Drawing.Size(69, 17);
            this.lblAvionMasTiempoVolado.TabIndex = 16;
            this.lblAvionMasTiempoVolado.Text = "masVolo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(212, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "AVION CON MAS HS DE VUELO:";
            // 
            // lblAvionesLibres
            // 
            this.lblAvionesLibres.AutoSize = true;
            this.lblAvionesLibres.BackColor = System.Drawing.Color.Transparent;
            this.lblAvionesLibres.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvionesLibres.Location = new System.Drawing.Point(136, 104);
            this.lblAvionesLibres.Name = "lblAvionesLibres";
            this.lblAvionesLibres.Size = new System.Drawing.Size(52, 17);
            this.lblAvionesLibres.TabIndex = 14;
            this.lblAvionesLibres.Text = "libres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "AVIONES LIBRES:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvionesVolando
            // 
            this.lblAvionesVolando.AutoSize = true;
            this.lblAvionesVolando.BackColor = System.Drawing.Color.Transparent;
            this.lblAvionesVolando.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvionesVolando.Location = new System.Drawing.Point(136, 70);
            this.lblAvionesVolando.Name = "lblAvionesVolando";
            this.lblAvionesVolando.Size = new System.Drawing.Size(78, 17);
            this.lblAvionesVolando.TabIndex = 12;
            this.lblAvionesVolando.Text = "ocupadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-1, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "AVIONES VOLANDO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "ESTADO FLOTA";
            // 
            // dgvAviones
            // 
            this.dgvAviones.AutoGenerateColumns = false;
            this.dgvAviones.BackgroundColor = System.Drawing.Color.Firebrick;
            this.dgvAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAviones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn});
            this.dgvAviones.DataSource = this.aeronaveBindingSource;
            this.dgvAviones.Location = new System.Drawing.Point(14, 164);
            this.dgvAviones.Name = "dgvAviones";
            this.dgvAviones.RowTemplate.Height = 25;
            this.dgvAviones.Size = new System.Drawing.Size(144, 187);
            this.dgvAviones.TabIndex = 19;
            this.dgvAviones.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAviones_RowHeaderMouseClick);
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aeronaveBindingSource
            // 
            this.aeronaveBindingSource.DataSource = typeof(Parcial.Library.Aeronave);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.BorderSize = 3;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(164, 385);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 35);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblAvionElegido
            // 
            this.lblAvionElegido.AutoSize = true;
            this.lblAvionElegido.BackColor = System.Drawing.Color.Transparent;
            this.lblAvionElegido.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvionElegido.Location = new System.Drawing.Point(188, 164);
            this.lblAvionElegido.Name = "lblAvionElegido";
            this.lblAvionElegido.Size = new System.Drawing.Size(59, 20);
            this.lblAvionElegido.TabIndex = 21;
            this.lblAvionElegido.Text = "avion";
            // 
            // frmEstadoFlota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblAvionElegido);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvAviones);
            this.Controls.Add(this.lblPromedioVuelo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAvionMasTiempoVolado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAvionesLibres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAvionesVolando);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEstadoFlota";
            this.Text = "frmEstadoFlota";
            this.Load += new System.EventHandler(this.frmEstadoFlota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAviones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronaveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPromedioVuelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAvionMasTiempoVolado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAvionesLibres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAvionesVolando;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAviones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.BindingSource aeronaveBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoAvionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblAvionElegido;
    }
}