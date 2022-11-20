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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticas));
            this.btnSalirEstadisticas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbEstadisticas = new System.Windows.Forms.RichTextBox();
            this.dgvEstadisticas = new System.Windows.Forms.DataGridView();
            this.fechaPartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugadorUnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugadorDosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPartidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTopTres = new System.Windows.Forms.Label();
            this.lblTopDos = new System.Windows.Forms.Label();
            this.lblTopUno = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirEstadisticas
            // 
            this.btnSalirEstadisticas.BackgroundImage = global::Vista.Properties.Resources.Cerrar;
            this.btnSalirEstadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalirEstadisticas.Location = new System.Drawing.Point(825, 500);
            this.btnSalirEstadisticas.Name = "btnSalirEstadisticas";
            this.btnSalirEstadisticas.Size = new System.Drawing.Size(79, 61);
            this.btnSalirEstadisticas.TabIndex = 0;
            this.btnSalirEstadisticas.UseVisualStyleBackColor = true;
            this.btnSalirEstadisticas.Click += new System.EventHandler(this.btnSalirEstadisticas_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "HISTORIAL PARTIDAS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rtbEstadisticas
            // 
            this.rtbEstadisticas.Location = new System.Drawing.Point(318, 168);
            this.rtbEstadisticas.Name = "rtbEstadisticas";
            this.rtbEstadisticas.Size = new System.Drawing.Size(211, 393);
            this.rtbEstadisticas.TabIndex = 2;
            this.rtbEstadisticas.Text = "";
            // 
            // dgvEstadisticas
            // 
            this.dgvEstadisticas.AutoGenerateColumns = false;
            this.dgvEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadisticas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaPartidaDataGridViewTextBoxColumn,
            this.jugadorUnoDataGridViewTextBoxColumn,
            this.jugadorDosDataGridViewTextBoxColumn,
            this.ganadorDataGridViewTextBoxColumn,
            this.tipoPartidaDataGridViewTextBoxColumn});
            this.dgvEstadisticas.DataSource = this.partidaBindingSource;
            this.dgvEstadisticas.Location = new System.Drawing.Point(3, 168);
            this.dgvEstadisticas.Name = "dgvEstadisticas";
            this.dgvEstadisticas.RowTemplate.Height = 25;
            this.dgvEstadisticas.Size = new System.Drawing.Size(309, 393);
            this.dgvEstadisticas.TabIndex = 0;
            this.dgvEstadisticas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEstadisticas_RowHeaderMouseClick);
            // 
            // fechaPartidaDataGridViewTextBoxColumn
            // 
            this.fechaPartidaDataGridViewTextBoxColumn.DataPropertyName = "FechaPartida";
            this.fechaPartidaDataGridViewTextBoxColumn.HeaderText = "FechaPartida";
            this.fechaPartidaDataGridViewTextBoxColumn.Name = "fechaPartidaDataGridViewTextBoxColumn";
            // 
            // jugadorUnoDataGridViewTextBoxColumn
            // 
            this.jugadorUnoDataGridViewTextBoxColumn.DataPropertyName = "JugadorUno";
            this.jugadorUnoDataGridViewTextBoxColumn.HeaderText = "JugadorUno";
            this.jugadorUnoDataGridViewTextBoxColumn.Name = "jugadorUnoDataGridViewTextBoxColumn";
            // 
            // jugadorDosDataGridViewTextBoxColumn
            // 
            this.jugadorDosDataGridViewTextBoxColumn.DataPropertyName = "JugadorDos";
            this.jugadorDosDataGridViewTextBoxColumn.HeaderText = "JugadorDos";
            this.jugadorDosDataGridViewTextBoxColumn.Name = "jugadorDosDataGridViewTextBoxColumn";
            // 
            // ganadorDataGridViewTextBoxColumn
            // 
            this.ganadorDataGridViewTextBoxColumn.DataPropertyName = "Ganador";
            this.ganadorDataGridViewTextBoxColumn.HeaderText = "Ganador";
            this.ganadorDataGridViewTextBoxColumn.Name = "ganadorDataGridViewTextBoxColumn";
            // 
            // tipoPartidaDataGridViewTextBoxColumn
            // 
            this.tipoPartidaDataGridViewTextBoxColumn.DataPropertyName = "TipoPartida";
            this.tipoPartidaDataGridViewTextBoxColumn.HeaderText = "TipoPartida";
            this.tipoPartidaDataGridViewTextBoxColumn.Name = "tipoPartidaDataGridViewTextBoxColumn";
            // 
            // partidaBindingSource
            // 
            this.partidaBindingSource.DataSource = typeof(Entidades.Modelos.Partida);
            // 
            // lblTopTres
            // 
            this.lblTopTres.AutoSize = true;
            this.lblTopTres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTopTres.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblTopTres.Location = new System.Drawing.Point(799, 324);
            this.lblTopTres.Name = "lblTopTres";
            this.lblTopTres.Size = new System.Drawing.Size(36, 17);
            this.lblTopTres.TabIndex = 2;
            this.lblTopTres.Text = "top3";
            // 
            // lblTopDos
            // 
            this.lblTopDos.AutoSize = true;
            this.lblTopDos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTopDos.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblTopDos.Location = new System.Drawing.Point(610, 303);
            this.lblTopDos.Name = "lblTopDos";
            this.lblTopDos.Size = new System.Drawing.Size(36, 17);
            this.lblTopDos.TabIndex = 1;
            this.lblTopDos.Text = "top2";
            // 
            // lblTopUno
            // 
            this.lblTopUno.AutoSize = true;
            this.lblTopUno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTopUno.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblTopUno.Location = new System.Drawing.Point(710, 267);
            this.lblTopUno.Name = "lblTopUno";
            this.lblTopUno.Size = new System.Drawing.Size(36, 17);
            this.lblTopUno.TabIndex = 0;
            this.lblTopUno.Text = "top1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Vista.Properties.Resources.game1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 100);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Vista.Properties.Resources.podioOk;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(568, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 241);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmEstadisticas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(916, 573);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvEstadisticas);
            this.Controls.Add(this.rtbEstadisticas);
            this.Controls.Add(this.lblTopTres);
            this.Controls.Add(this.btnSalirEstadisticas);
            this.Controls.Add(this.lblTopDos);
            this.Controls.Add(this.lblTopUno);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstadisticas";
            this.Load += new System.EventHandler(this.frmEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalirEstadisticas;
        private RichTextBox rtbEstadisticas;
        private DataGridView dgvEstadisticas;
        private Label lblTopTres;
        private Label lblTopDos;
        private Label lblTopUno;
        private Button button1;
        private DataGridViewTextBoxColumn fechaPartidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jugadorUnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jugadorDosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ganadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoPartidaDataGridViewTextBoxColumn;
        private BindingSource partidaBindingSource;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}