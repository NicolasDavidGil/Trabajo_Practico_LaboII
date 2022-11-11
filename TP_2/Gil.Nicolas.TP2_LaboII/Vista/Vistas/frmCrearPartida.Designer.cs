namespace Vista.Vistas
{
    partial class frmCrearPartida
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbJugadorUno = new System.Windows.Forms.ComboBox();
            this.cmbJugadorDos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblErrores = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(290, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUEVO DESAFIO";
            // 
            // cmbJugadorUno
            // 
            this.cmbJugadorUno.FormattingEnabled = true;
            this.cmbJugadorUno.Location = new System.Drawing.Point(338, 113);
            this.cmbJugadorUno.Name = "cmbJugadorUno";
            this.cmbJugadorUno.Size = new System.Drawing.Size(121, 23);
            this.cmbJugadorUno.TabIndex = 1;
            // 
            // cmbJugadorDos
            // 
            this.cmbJugadorDos.FormattingEnabled = true;
            this.cmbJugadorDos.Location = new System.Drawing.Point(338, 222);
            this.cmbJugadorDos.Name = "cmbJugadorDos";
            this.cmbJugadorDos.Size = new System.Drawing.Size(121, 23);
            this.cmbJugadorDos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(192, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "JUGADOR 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(192, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "JUGADOR 2:";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.Black;
            this.btnIniciarPartida.BackgroundImage = global::Vista.Properties.Resources.BotonEmpezar;
            this.btnIniciarPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarPartida.Location = new System.Drawing.Point(192, 6);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(173, 115);
            this.btnIniciarPartida.TabIndex = 5;
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.BackgroundImage = global::Vista.Properties.Resources.BotonSalir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(391, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(173, 115);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnIniciarPartida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 147);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblErrores);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbJugadorUno);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbJugadorDos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 303);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = global::Vista.Properties.Resources.VSOK;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(338, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 74);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(597, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "TIPO DE PARTIDA:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(630, 244);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.BackColor = System.Drawing.Color.Black;
            this.lblErrores.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrores.Location = new System.Drawing.Point(480, 113);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(104, 27);
            this.lblErrores.TabIndex = 7;
            this.lblErrores.Text = "Errores";
            // 
            // frmCrearPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.minimenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCrearPartida";
            this.Load += new System.EventHandler(this.frmCrearPartida_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private ComboBox cmbJugadorUno;
        private ComboBox cmbJugadorDos;
        private Label label2;
        private Label label3;
        private Button btnIniciarPartida;
        private Button btnSalir;
        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBox1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label lblErrores;
    }
}