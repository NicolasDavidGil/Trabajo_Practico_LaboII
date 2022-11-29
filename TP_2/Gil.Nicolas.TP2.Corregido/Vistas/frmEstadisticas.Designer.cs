namespace Vista
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
            this.dgvPartidas = new System.Windows.Forms.DataGridView();
            this.fechaPartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rtbEstadisticas = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarEstadisticas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblActivos = new System.Windows.Forms.Label();
            this.lblPartidasExpress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPartidasCompletas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblJugadoresTotales = new System.Windows.Forms.Label();
            this.lblPartidasTotales = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPartidas
            // 
            this.dgvPartidas.AutoGenerateColumns = false;
            this.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaPartidaDataGridViewTextBoxColumn,
            this.NombreUno,
            this.NombreDos,
            this.ganadorDataGridViewTextBoxColumn});
            this.dgvPartidas.DataSource = this.partidaBindingSource;
            this.dgvPartidas.Location = new System.Drawing.Point(12, 60);
            this.dgvPartidas.Name = "dgvPartidas";
            this.dgvPartidas.RowTemplate.Height = 25;
            this.dgvPartidas.Size = new System.Drawing.Size(299, 281);
            this.dgvPartidas.TabIndex = 0;
            this.dgvPartidas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPartidas_RowHeaderMouseClick);
            // 
            // fechaPartidaDataGridViewTextBoxColumn
            // 
            this.fechaPartidaDataGridViewTextBoxColumn.DataPropertyName = "FechaPartida";
            this.fechaPartidaDataGridViewTextBoxColumn.HeaderText = "FechaPartida";
            this.fechaPartidaDataGridViewTextBoxColumn.Name = "fechaPartidaDataGridViewTextBoxColumn";
            // 
            // NombreUno
            // 
            this.NombreUno.DataPropertyName = "NombreUno";
            this.NombreUno.HeaderText = "NombreUno";
            this.NombreUno.Name = "NombreUno";
            this.NombreUno.ReadOnly = true;
            // 
            // NombreDos
            // 
            this.NombreDos.DataPropertyName = "NombreDos";
            this.NombreDos.HeaderText = "NombreDos";
            this.NombreDos.Name = "NombreDos";
            this.NombreDos.ReadOnly = true;
            // 
            // ganadorDataGridViewTextBoxColumn
            // 
            this.ganadorDataGridViewTextBoxColumn.DataPropertyName = "Ganador";
            this.ganadorDataGridViewTextBoxColumn.HeaderText = "Ganador";
            this.ganadorDataGridViewTextBoxColumn.Name = "ganadorDataGridViewTextBoxColumn";
            // 
            // partidaBindingSource
            // 
            this.partidaBindingSource.DataSource = typeof(Entidades.Modelos.Partida);
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.AutoGenerateColumns = false;
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.nacionalidadDataGridViewTextBoxColumn,
            this.puntajeDataGridViewTextBoxColumn});
            this.dgvJugadores.DataSource = this.usuarioBindingSource;
            this.dgvJugadores.Location = new System.Drawing.Point(602, 60);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.RowTemplate.Height = 25;
            this.dgvJugadores.Size = new System.Drawing.Size(307, 281);
            this.dgvJugadores.TabIndex = 1;
            this.dgvJugadores.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvJugadores_RowHeaderMouseClick);
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "NombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            // 
            // nacionalidadDataGridViewTextBoxColumn
            // 
            this.nacionalidadDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidad";
            this.nacionalidadDataGridViewTextBoxColumn.HeaderText = "Nacionalidad";
            this.nacionalidadDataGridViewTextBoxColumn.Name = "nacionalidadDataGridViewTextBoxColumn";
            // 
            // puntajeDataGridViewTextBoxColumn
            // 
            this.puntajeDataGridViewTextBoxColumn.DataPropertyName = "Puntaje";
            this.puntajeDataGridViewTextBoxColumn.HeaderText = "Puntaje";
            this.puntajeDataGridViewTextBoxColumn.Name = "puntajeDataGridViewTextBoxColumn";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Entidades.Modelos.Usuario);
            // 
            // rtbEstadisticas
            // 
            this.rtbEstadisticas.Location = new System.Drawing.Point(321, 60);
            this.rtbEstadisticas.Name = "rtbEstadisticas";
            this.rtbEstadisticas.Size = new System.Drawing.Size(263, 281);
            this.rtbEstadisticas.TabIndex = 2;
            this.rtbEstadisticas.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "HISTORIAL PARTIDAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(687, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "CALIFICACION JUGADORES";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Vista.Properties.Resources.game;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnCerrarEstadisticas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 94);
            this.panel1.TabIndex = 5;
            // 
            // btnCerrarEstadisticas
            // 
            this.btnCerrarEstadisticas.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrarEstadisticas.BackgroundImage = global::Vista.Properties.Resources.Cerrar;
            this.btnCerrarEstadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarEstadisticas.Location = new System.Drawing.Point(811, 12);
            this.btnCerrarEstadisticas.Name = "btnCerrarEstadisticas";
            this.btnCerrarEstadisticas.Size = new System.Drawing.Size(81, 72);
            this.btnCerrarEstadisticas.TabIndex = 0;
            this.btnCerrarEstadisticas.UseVisualStyleBackColor = false;
            this.btnCerrarEstadisticas.Click += new System.EventHandler(this.btnCerrarEstadisticas_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblActivos);
            this.panel2.Controls.Add(this.lblPartidasExpress);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblPartidasCompletas);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblJugadoresTotales);
            this.panel2.Controls.Add(this.lblPartidasTotales);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 181);
            this.panel2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(513, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "CANTIDAD DE JUGADORES ACTIVOS:";
            // 
            // lblActivos
            // 
            this.lblActivos.AutoSize = true;
            this.lblActivos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivos.Location = new System.Drawing.Point(762, 68);
            this.lblActivos.Name = "lblActivos";
            this.lblActivos.Size = new System.Drawing.Size(116, 19);
            this.lblActivos.TabIndex = 7;
            this.lblActivos.Text = "activos.count";
            // 
            // lblPartidasExpress
            // 
            this.lblPartidasExpress.AutoSize = true;
            this.lblPartidasExpress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPartidasExpress.Location = new System.Drawing.Point(317, 107);
            this.lblPartidasExpress.Name = "lblPartidasExpress";
            this.lblPartidasExpress.Size = new System.Drawing.Size(122, 19);
            this.lblPartidasExpress.TabIndex = 7;
            this.lblPartidasExpress.Text = "express.count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(60, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "CANTIDAD DE PARTIDAS EXPRESS:";
            // 
            // lblPartidasCompletas
            // 
            this.lblPartidasCompletas.AutoSize = true;
            this.lblPartidasCompletas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPartidasCompletas.Location = new System.Drawing.Point(317, 68);
            this.lblPartidasCompletas.Name = "lblPartidasCompletas";
            this.lblPartidasCompletas.Size = new System.Drawing.Size(142, 19);
            this.lblPartidasCompletas.TabIndex = 5;
            this.lblPartidasCompletas.Text = "completas.count";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(65, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "CANTIDAD DE PARTIDAS COMPLETAS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(513, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "CANTIDAD DE JUGADORES TOTALES:";
            // 
            // lblJugadoresTotales
            // 
            this.lblJugadoresTotales.AutoSize = true;
            this.lblJugadoresTotales.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJugadoresTotales.Location = new System.Drawing.Point(762, 30);
            this.lblJugadoresTotales.Name = "lblJugadoresTotales";
            this.lblJugadoresTotales.Size = new System.Drawing.Size(85, 19);
            this.lblJugadoresTotales.TabIndex = 2;
            this.lblJugadoresTotales.Text = "jug.count";
            // 
            // lblPartidasTotales
            // 
            this.lblPartidasTotales.AutoSize = true;
            this.lblPartidasTotales.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPartidasTotales.Location = new System.Drawing.Point(321, 30);
            this.lblPartidasTotales.Name = "lblPartidasTotales";
            this.lblPartidasTotales.Size = new System.Drawing.Size(126, 19);
            this.lblPartidasTotales.TabIndex = 1;
            this.lblPartidasTotales.Text = "partidas.count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(65, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "CANTIDAD DE PARTIDAS JUGADAS:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.rtbEstadisticas);
            this.panel3.Controls.Add(this.dgvJugadores);
            this.panel3.Controls.Add(this.dgvPartidas);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(912, 359);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(423, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "DETALLES";
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 634);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEstadisticas";
            this.Load += new System.EventHandler(this.frmEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvPartidas;
        private DataGridView dgvJugadores;
        private RichTextBox rtbEstadisticas;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Button btnCerrarEstadisticas;
        private DataGridViewTextBoxColumn fechaPartidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn NombreUno;
        private DataGridViewTextBoxColumn NombreDos;
        private DataGridViewTextBoxColumn ganadorDataGridViewTextBoxColumn;
        private BindingSource partidaBindingSource;
        private DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn puntajeDataGridViewTextBoxColumn;
        private BindingSource usuarioBindingSource;
        private Label lblPartidasExpress;
        private Label label5;
        private Label lblPartidasCompletas;
        private Label label8;
        private Label label7;
        private Label lblJugadoresTotales;
        private Label lblPartidasTotales;
        private Label label4;
        private Label label6;
        private Label lblActivos;
    }
}