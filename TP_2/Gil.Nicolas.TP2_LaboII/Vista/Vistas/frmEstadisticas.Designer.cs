namespace Vista.Vistas
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvEstadisticas = new System.Windows.Forms.DataGridView();
            this.cmbEstadisticas = new System.Windows.Forms.ComboBox();
            this.lblPrimero = new System.Windows.Forms.Label();
            this.lblTercero = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.ptbPodio = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPodio)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTADISTICAS UTN UNO MASTERS";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(555, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvEstadisticas
            // 
            this.dgvEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadisticas.Location = new System.Drawing.Point(12, 198);
            this.dgvEstadisticas.Name = "dgvEstadisticas";
            this.dgvEstadisticas.RowTemplate.Height = 25;
            this.dgvEstadisticas.Size = new System.Drawing.Size(147, 240);
            this.dgvEstadisticas.TabIndex = 2;
            this.dgvEstadisticas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEstadisticas_RowHeaderMouseClick);
            // 
            // cmbEstadisticas
            // 
            this.cmbEstadisticas.FormattingEnabled = true;
            this.cmbEstadisticas.Location = new System.Drawing.Point(12, 169);
            this.cmbEstadisticas.Name = "cmbEstadisticas";
            this.cmbEstadisticas.Size = new System.Drawing.Size(147, 23);
            this.cmbEstadisticas.TabIndex = 3;
            // 
            // lblPrimero
            // 
            this.lblPrimero.AutoSize = true;
            this.lblPrimero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrimero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrimero.Location = new System.Drawing.Point(365, 135);
            this.lblPrimero.Name = "lblPrimero";
            this.lblPrimero.Size = new System.Drawing.Size(57, 17);
            this.lblPrimero.TabIndex = 4;
            this.lblPrimero.Text = "primero";
            // 
            // lblTercero
            // 
            this.lblTercero.AutoSize = true;
            this.lblTercero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTercero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTercero.Location = new System.Drawing.Point(468, 197);
            this.lblTercero.Name = "lblTercero";
            this.lblTercero.Size = new System.Drawing.Size(51, 17);
            this.lblTercero.TabIndex = 5;
            this.lblTercero.Text = "tercero";
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegundo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSegundo.Location = new System.Drawing.Point(265, 173);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(61, 17);
            this.lblSegundo.TabIndex = 6;
            this.lblSegundo.Text = "segundo";
            // 
            // ptbPodio
            // 
            this.ptbPodio.BackgroundImage = global::Vista.Properties.Resources.podioOk;
            this.ptbPodio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbPodio.Location = new System.Drawing.Point(218, 104);
            this.ptbPodio.Name = "ptbPodio";
            this.ptbPodio.Size = new System.Drawing.Size(370, 261);
            this.ptbPodio.TabIndex = 7;
            this.ptbPodio.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.dgvEstadisticas);
            this.panel1.Controls.Add(this.cmbEstadisticas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Vista.Properties.Resources.logo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 123);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 73);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.lblInformacion);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.lblPrimero);
            this.panel4.Controls.Add(this.lblTercero);
            this.panel4.Controls.Add(this.lblSegundo);
            this.panel4.Controls.Add(this.ptbPodio);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 377);
            this.panel4.TabIndex = 8;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInformacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInformacion.Location = new System.Drawing.Point(6, 173);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(38, 17);
            this.lblInformacion.TabIndex = 8;
            this.lblInformacion.Text = "toStr";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Entidades.Modelos.Usuario);
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEstadisticas";
            this.Load += new System.EventHandler(this.frmEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPodio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView dgvEstadisticas;
        private ComboBox cmbEstadisticas;
        private Label lblPrimero;
        private Label lblTercero;
        private Label lblSegundo;
        private PictureBox ptbPodio;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblInformacion;
        private BindingSource usuarioBindingSource;
    }
}