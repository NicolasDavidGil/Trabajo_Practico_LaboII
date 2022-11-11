namespace Vista.Vistas
{
    partial class frmProbandoPartida
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblCartasJugDos = new System.Windows.Forms.Label();
            this.lblCartasJugUno = new System.Windows.Forms.Label();
            this.ptbCartaMesa = new System.Windows.Forms.PictureBox();
            this.ptbUnoJugDos = new System.Windows.Forms.PictureBox();
            this.ptbUnoJugUno = new System.Windows.Forms.PictureBox();
            this.lblJugadorUno = new System.Windows.Forms.Label();
            this.lblJugadorDos = new System.Windows.Forms.Label();
            this.tmrPrueba = new System.Windows.Forms.Timer(this.components);
            this.btnJugUno = new System.Windows.Forms.Button();
            this.btnJugDos = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblGanador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaMesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUnoJugDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUnoJugUno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cartas restantes jugador uno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cartas restantes jugador dos:";
            // 
            // lblCartasJugDos
            // 
            this.lblCartasJugDos.AutoSize = true;
            this.lblCartasJugDos.Location = new System.Drawing.Point(307, 372);
            this.lblCartasJugDos.Name = "lblCartasJugDos";
            this.lblCartasJugDos.Size = new System.Drawing.Size(38, 15);
            this.lblCartasJugDos.TabIndex = 2;
            this.lblCartasJugDos.Text = "label3";
            // 
            // lblCartasJugUno
            // 
            this.lblCartasJugUno.AutoSize = true;
            this.lblCartasJugUno.Location = new System.Drawing.Point(324, 131);
            this.lblCartasJugUno.Name = "lblCartasJugUno";
            this.lblCartasJugUno.Size = new System.Drawing.Size(38, 15);
            this.lblCartasJugUno.TabIndex = 3;
            this.lblCartasJugUno.Text = "label4";
            // 
            // ptbCartaMesa
            // 
            this.ptbCartaMesa.Location = new System.Drawing.Point(511, 172);
            this.ptbCartaMesa.Name = "ptbCartaMesa";
            this.ptbCartaMesa.Size = new System.Drawing.Size(100, 179);
            this.ptbCartaMesa.TabIndex = 4;
            this.ptbCartaMesa.TabStop = false;
            // 
            // ptbUnoJugDos
            // 
            this.ptbUnoJugDos.BackgroundImage = global::Vista.Properties.Resources.game;
            this.ptbUnoJugDos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbUnoJugDos.Location = new System.Drawing.Point(417, 386);
            this.ptbUnoJugDos.Name = "ptbUnoJugDos";
            this.ptbUnoJugDos.Size = new System.Drawing.Size(100, 50);
            this.ptbUnoJugDos.TabIndex = 5;
            this.ptbUnoJugDos.TabStop = false;
            // 
            // ptbUnoJugUno
            // 
            this.ptbUnoJugUno.BackgroundImage = global::Vista.Properties.Resources.game;
            this.ptbUnoJugUno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbUnoJugUno.Location = new System.Drawing.Point(430, 39);
            this.ptbUnoJugUno.Name = "ptbUnoJugUno";
            this.ptbUnoJugUno.Size = new System.Drawing.Size(100, 50);
            this.ptbUnoJugUno.TabIndex = 6;
            this.ptbUnoJugUno.TabStop = false;
            // 
            // lblJugadorUno
            // 
            this.lblJugadorUno.AutoSize = true;
            this.lblJugadorUno.Location = new System.Drawing.Point(457, 110);
            this.lblJugadorUno.Name = "lblJugadorUno";
            this.lblJugadorUno.Size = new System.Drawing.Size(48, 15);
            this.lblJugadorUno.TabIndex = 7;
            this.lblJugadorUno.Text = "jug uno";
            // 
            // lblJugadorDos
            // 
            this.lblJugadorDos.AutoSize = true;
            this.lblJugadorDos.Location = new System.Drawing.Point(441, 472);
            this.lblJugadorDos.Name = "lblJugadorDos";
            this.lblJugadorDos.Size = new System.Drawing.Size(46, 15);
            this.lblJugadorDos.TabIndex = 8;
            this.lblJugadorDos.Text = "jug dos";
            // 
            // tmrPrueba
            // 
            this.tmrPrueba.Enabled = true;
            this.tmrPrueba.Tick += new System.EventHandler(this.tmrPrueba_Tick);
            // 
            // btnJugUno
            // 
            this.btnJugUno.BackColor = System.Drawing.Color.Green;
            this.btnJugUno.FlatAppearance.BorderSize = 3;
            this.btnJugUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugUno.Location = new System.Drawing.Point(511, 95);
            this.btnJugUno.Name = "btnJugUno";
            this.btnJugUno.Size = new System.Drawing.Size(55, 45);
            this.btnJugUno.TabIndex = 9;
            this.btnJugUno.UseVisualStyleBackColor = false;
            // 
            // btnJugDos
            // 
            this.btnJugDos.BackColor = System.Drawing.Color.Green;
            this.btnJugDos.FlatAppearance.BorderSize = 3;
            this.btnJugDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugDos.Location = new System.Drawing.Point(511, 442);
            this.btnJugDos.Name = "btnJugDos";
            this.btnJugDos.Size = new System.Drawing.Size(55, 45);
            this.btnJugDos.TabIndex = 10;
            this.btnJugDos.UseVisualStyleBackColor = false;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(417, 213);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(38, 15);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "label3";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(417, 243);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(38, 15);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "label4";
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGanador.Location = new System.Drawing.Point(288, 559);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(57, 21);
            this.lblGanador.TabIndex = 13;
            this.lblGanador.Text = "label3";
            // 
            // frmProbandoPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 625);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnJugDos);
            this.Controls.Add(this.btnJugUno);
            this.Controls.Add(this.lblJugadorDos);
            this.Controls.Add(this.lblJugadorUno);
            this.Controls.Add(this.ptbUnoJugUno);
            this.Controls.Add(this.ptbUnoJugDos);
            this.Controls.Add(this.ptbCartaMesa);
            this.Controls.Add(this.lblCartasJugUno);
            this.Controls.Add(this.lblCartasJugDos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProbandoPartida";
            this.Text = "frmProbandoPartida";
            this.Load += new System.EventHandler(this.frmProbandoPartida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaMesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUnoJugDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUnoJugUno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblCartasJugDos;
        private Label lblCartasJugUno;
        private PictureBox ptbCartaMesa;
        private PictureBox ptbUnoJugDos;
        private PictureBox ptbUnoJugUno;
        private Label lblJugadorUno;
        private Label lblJugadorDos;
        private System.Windows.Forms.Timer tmrPrueba;
        private Button btnJugUno;
        private Button btnJugDos;
        private Label lblNumero;
        private Label lblColor;
        private Label lblGanador;
    }
}