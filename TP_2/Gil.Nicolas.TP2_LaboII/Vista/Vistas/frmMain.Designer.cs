namespace Vista.Vistas
{
    partial class frmMain
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
            this.label2 = new System.Windows.Forms.Label();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvJugadoresOnline = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnObservar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPartidasEnJuego = new System.Windows.Forms.DataGridView();
            this.tmrChat = new System.Windows.Forms.Timer(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.partidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jugadorUnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugadorDosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartaMesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoJuegoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadManos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadoresOnline)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidasEnJuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "CHAT";
            // 
            // rtbChat
            // 
            this.rtbChat.BackColor = System.Drawing.Color.NavajoWhite;
            this.rtbChat.Location = new System.Drawing.Point(12, 3);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(566, 180);
            this.rtbChat.TabIndex = 12;
            this.rtbChat.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1413, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "JUGADORES ONLINE";
            // 
            // dgvJugadoresOnline
            // 
            this.dgvJugadoresOnline.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvJugadoresOnline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadoresOnline.Location = new System.Drawing.Point(21, 16);
            this.dgvJugadoresOnline.Name = "dgvJugadoresOnline";
            this.dgvJugadoresOnline.RowTemplate.Height = 25;
            this.dgvJugadoresOnline.Size = new System.Drawing.Size(333, 481);
            this.dgvJugadoresOnline.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 34);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(763, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "JUGADORES ONLINE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 509);
            this.panel2.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.dgvJugadoresOnline);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(629, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(366, 509);
            this.panel5.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.rtbChat);
            this.panel4.Controls.Add(this.txtChat);
            this.panel4.Location = new System.Drawing.Point(0, 280);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(628, 229);
            this.panel4.TabIndex = 17;
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(12, 189);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(566, 23);
            this.txtChat.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnObservar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dgvPartidasEnJuego);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(637, 274);
            this.panel3.TabIndex = 15;
            // 
            // btnObservar
            // 
            this.btnObservar.BackgroundImage = global::Vista.Properties.Resources.observar;
            this.btnObservar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObservar.Location = new System.Drawing.Point(12, 172);
            this.btnObservar.Name = "btnObservar";
            this.btnObservar.Size = new System.Drawing.Size(83, 47);
            this.btnObservar.TabIndex = 16;
            this.btnObservar.UseVisualStyleBackColor = true;
            this.btnObservar.Click += new System.EventHandler(this.btnObservar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(83, -37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "PARTIDAS ACTIVAS";
            // 
            // dgvPartidasEnJuego
            // 
            this.dgvPartidasEnJuego.AutoGenerateColumns = false;
            this.dgvPartidasEnJuego.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvPartidasEnJuego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidasEnJuego.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jugadorUnoDataGridViewTextBoxColumn,
            this.jugadorDosDataGridViewTextBoxColumn,
            this.cartaMesaDataGridViewTextBoxColumn,
            this.turnoJuegoDataGridViewTextBoxColumn,
            this.CantidadManos});
            this.dgvPartidasEnJuego.DataSource = this.partidaBindingSource;
            this.dgvPartidasEnJuego.Location = new System.Drawing.Point(12, 16);
            this.dgvPartidasEnJuego.Name = "dgvPartidasEnJuego";
            this.dgvPartidasEnJuego.RowTemplate.Height = 25;
            this.dgvPartidasEnJuego.Size = new System.Drawing.Size(544, 150);
            this.dgvPartidasEnJuego.TabIndex = 14;
            this.dgvPartidasEnJuego.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPartidasEnJuego_RowHeaderMouseClick);
            // 
            // tmrChat
            // 
            this.tmrChat.Enabled = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(875, 40);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // partidaBindingSource
            // 
            this.partidaBindingSource.DataSource = typeof(Entidades.Modelos.Partida);
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
            // cartaMesaDataGridViewTextBoxColumn
            // 
            this.cartaMesaDataGridViewTextBoxColumn.DataPropertyName = "CartaMesa";
            this.cartaMesaDataGridViewTextBoxColumn.HeaderText = "CartaMesa";
            this.cartaMesaDataGridViewTextBoxColumn.Name = "cartaMesaDataGridViewTextBoxColumn";
            // 
            // turnoJuegoDataGridViewTextBoxColumn
            // 
            this.turnoJuegoDataGridViewTextBoxColumn.DataPropertyName = "TurnoJuego";
            this.turnoJuegoDataGridViewTextBoxColumn.HeaderText = "TurnoJuego";
            this.turnoJuegoDataGridViewTextBoxColumn.Name = "turnoJuegoDataGridViewTextBoxColumn";
            // 
            // CantidadManos
            // 
            this.CantidadManos.DataPropertyName = "CantidadManos";
            this.CantidadManos.HeaderText = "CantidadManos";
            this.CantidadManos.Name = "CantidadManos";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 586);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadoresOnline)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidasEnJuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label2;
        private RichTextBox rtbChat;
        private Label label1;
        private DataGridView dgvJugadoresOnline;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private TextBox txtChat;
        private Button btnObservar;
        private Label label3;
        private DataGridView dgvPartidasEnJuego;
        private System.Windows.Forms.Timer tmrChat;
        private Panel panel5;
        private Panel panel4;
        private Button btnSalir;
        private DataGridViewTextBoxColumn jugadorUnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jugadorDosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cartaMesaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnoJuegoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CantidadManos;
        private BindingSource partidaBindingSource;
    }
}