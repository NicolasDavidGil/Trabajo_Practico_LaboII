namespace Vista.TP2
{
    partial class frmPartida
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
            this.ptbCartaEnMesa = new System.Windows.Forms.PictureBox();
            this.ptbManoJugadorDos = new System.Windows.Forms.PictureBox();
            this.ptbManoJugadorUno = new System.Windows.Forms.PictureBox();
            this.lblJugadorUno = new System.Windows.Forms.Label();
            this.lblJugadorDos = new System.Windows.Forms.Label();
            this.lblcartaMesa = new System.Windows.Forms.Label();
            this.lblCartasUno = new System.Windows.Forms.Label();
            this.lblCartasDos = new System.Windows.Forms.Label();
            this.tmrJugada = new System.Windows.Forms.Timer(this.components);
            this.pnlJuega2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlJuega1 = new System.Windows.Forms.Panel();
            this.ptbJugDosCantoUno = new System.Windows.Forms.PictureBox();
            this.ptbJugUnoCantoUno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaEnMesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbManoJugadorDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbManoJugadorUno)).BeginInit();
            this.pnlJuega2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJugDosCantoUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJugUnoCantoUno)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCartaEnMesa
            // 
            this.ptbCartaEnMesa.BackgroundImage = global::Vista.TP2.Properties.Resources.tapaCarta;
            this.ptbCartaEnMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbCartaEnMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbCartaEnMesa.Location = new System.Drawing.Point(299, 210);
            this.ptbCartaEnMesa.Name = "ptbCartaEnMesa";
            this.ptbCartaEnMesa.Size = new System.Drawing.Size(125, 165);
            this.ptbCartaEnMesa.TabIndex = 0;
            this.ptbCartaEnMesa.TabStop = false;
            // 
            // ptbManoJugadorDos
            // 
            this.ptbManoJugadorDos.BackgroundImage = global::Vista.TP2.Properties.Resources.tapaCarta;
            this.ptbManoJugadorDos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbManoJugadorDos.Location = new System.Drawing.Point(49, 220);
            this.ptbManoJugadorDos.Name = "ptbManoJugadorDos";
            this.ptbManoJugadorDos.Size = new System.Drawing.Size(89, 105);
            this.ptbManoJugadorDos.TabIndex = 1;
            this.ptbManoJugadorDos.TabStop = false;
            // 
            // ptbManoJugadorUno
            // 
            this.ptbManoJugadorUno.BackgroundImage = global::Vista.TP2.Properties.Resources.tapaCarta;
            this.ptbManoJugadorUno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbManoJugadorUno.Location = new System.Drawing.Point(602, 241);
            this.ptbManoJugadorUno.Name = "ptbManoJugadorUno";
            this.ptbManoJugadorUno.Size = new System.Drawing.Size(89, 106);
            this.ptbManoJugadorUno.TabIndex = 2;
            this.ptbManoJugadorUno.TabStop = false;
            // 
            // lblJugadorUno
            // 
            this.lblJugadorUno.AutoSize = true;
            this.lblJugadorUno.BackColor = System.Drawing.Color.Transparent;
            this.lblJugadorUno.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJugadorUno.Location = new System.Drawing.Point(324, 45);
            this.lblJugadorUno.Name = "lblJugadorUno";
            this.lblJugadorUno.Size = new System.Drawing.Size(90, 20);
            this.lblJugadorUno.TabIndex = 3;
            this.lblJugadorUno.Text = "Jugador1";
            // 
            // lblJugadorDos
            // 
            this.lblJugadorDos.AutoSize = true;
            this.lblJugadorDos.BackColor = System.Drawing.Color.Transparent;
            this.lblJugadorDos.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJugadorDos.Location = new System.Drawing.Point(313, 486);
            this.lblJugadorDos.Name = "lblJugadorDos";
            this.lblJugadorDos.Size = new System.Drawing.Size(90, 20);
            this.lblJugadorDos.TabIndex = 4;
            this.lblJugadorDos.Text = "Jugador2";
            // 
            // lblcartaMesa
            // 
            this.lblcartaMesa.AutoSize = true;
            this.lblcartaMesa.BackColor = System.Drawing.Color.Transparent;
            this.lblcartaMesa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcartaMesa.Location = new System.Drawing.Point(449, 265);
            this.lblcartaMesa.Name = "lblcartaMesa";
            this.lblcartaMesa.Size = new System.Drawing.Size(85, 21);
            this.lblcartaMesa.TabIndex = 5;
            this.lblcartaMesa.Text = "cartaMesa";
            // 
            // lblCartasUno
            // 
            this.lblCartasUno.AutoSize = true;
            this.lblCartasUno.BackColor = System.Drawing.Color.Transparent;
            this.lblCartasUno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCartasUno.Location = new System.Drawing.Point(266, 186);
            this.lblCartasUno.Name = "lblCartasUno";
            this.lblCartasUno.Size = new System.Drawing.Size(84, 21);
            this.lblCartasUno.TabIndex = 6;
            this.lblCartasUno.Text = "cartasJug1";
            // 
            // lblCartasDos
            // 
            this.lblCartasDos.AutoSize = true;
            this.lblCartasDos.BackColor = System.Drawing.Color.Transparent;
            this.lblCartasDos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCartasDos.Location = new System.Drawing.Point(264, 380);
            this.lblCartasDos.Name = "lblCartasDos";
            this.lblCartasDos.Size = new System.Drawing.Size(87, 21);
            this.lblCartasDos.TabIndex = 7;
            this.lblCartasDos.Text = "cartasJug2";
            // 
            // tmrJugada
            // 
            this.tmrJugada.Enabled = true;
            this.tmrJugada.Interval = 1000;
            this.tmrJugada.Tick += new System.EventHandler(this.tmrJugada_Tick);
            // 
            // pnlJuega2
            // 
            this.pnlJuega2.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlJuega2.Controls.Add(this.pictureBox2);
            this.pnlJuega2.Controls.Add(this.pictureBox1);
            this.pnlJuega2.Location = new System.Drawing.Point(409, 461);
            this.pnlJuega2.Name = "pnlJuega2";
            this.pnlJuega2.Size = new System.Drawing.Size(50, 45);
            this.pnlJuega2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlJuega1
            // 
            this.pnlJuega1.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlJuega1.Location = new System.Drawing.Point(420, 34);
            this.pnlJuega1.Name = "pnlJuega1";
            this.pnlJuega1.Size = new System.Drawing.Size(50, 38);
            this.pnlJuega1.TabIndex = 0;
            // 
            // ptbJugDosCantoUno
            // 
            this.ptbJugDosCantoUno.BackgroundImage = global::Vista.TP2.Properties.Resources.game;
            this.ptbJugDosCantoUno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbJugDosCantoUno.Location = new System.Drawing.Point(463, 405);
            this.ptbJugDosCantoUno.Name = "ptbJugDosCantoUno";
            this.ptbJugDosCantoUno.Size = new System.Drawing.Size(100, 50);
            this.ptbJugDosCantoUno.TabIndex = 9;
            this.ptbJugDosCantoUno.TabStop = false;
            // 
            // ptbJugUnoCantoUno
            // 
            this.ptbJugUnoCantoUno.BackgroundImage = global::Vista.TP2.Properties.Resources.game;
            this.ptbJugUnoCantoUno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbJugUnoCantoUno.Location = new System.Drawing.Point(463, 108);
            this.ptbJugUnoCantoUno.Name = "ptbJugUnoCantoUno";
            this.ptbJugUnoCantoUno.Size = new System.Drawing.Size(100, 50);
            this.ptbJugUnoCantoUno.TabIndex = 10;
            this.ptbJugUnoCantoUno.TabStop = false;
            // 
            // frmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.TP2.Properties.Resources.mesaOK;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 546);
            this.Controls.Add(this.ptbJugUnoCantoUno);
            this.Controls.Add(this.ptbJugDosCantoUno);
            this.Controls.Add(this.pnlJuega1);
            this.Controls.Add(this.pnlJuega2);
            this.Controls.Add(this.lblCartasDos);
            this.Controls.Add(this.lblCartasUno);
            this.Controls.Add(this.lblcartaMesa);
            this.Controls.Add(this.lblJugadorDos);
            this.Controls.Add(this.lblJugadorUno);
            this.Controls.Add(this.ptbManoJugadorUno);
            this.Controls.Add(this.ptbManoJugadorDos);
            this.Controls.Add(this.ptbCartaEnMesa);
            this.Name = "frmPartida";
            this.Text = "frmPartida";
            this.Load += new System.EventHandler(this.frmPartida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaEnMesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbManoJugadorDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbManoJugadorUno)).EndInit();
            this.pnlJuega2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJugDosCantoUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJugUnoCantoUno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ptbCartaEnMesa;
        private PictureBox ptbManoJugadorDos;
        private PictureBox ptbManoJugadorUno;
        private Label lblJugadorUno;
        private Label lblJugadorDos;
        private Label lblcartaMesa;
        private Label lblCartasUno;
        private Label lblCartasDos;
        private System.Windows.Forms.Timer tmrJugada;
        private Panel pnlJuega2;
        private Panel pnlJuega1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox ptbJugDosCantoUno;
        private PictureBox ptbJugUnoCantoUno;
    }
}