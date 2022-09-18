namespace Parcial_Laboratorio
{
    partial class Estadisticas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_totalRecaudacion = new System.Windows.Forms.TextBox();
            this.txt_totalVuelos = new System.Windows.Forms.TextBox();
            this.txt_totalPasajeros = new System.Windows.Forms.TextBox();
            this.btn_cerrarPestaña = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOTAL DE PASAJEROS REGISTRADOS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "TOTAL DE VUELOS REGISTRADOS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "RECAUDACION TOTAL DE LA AEROLINEA:";
            // 
            // txt_totalRecaudacion
            // 
            this.txt_totalRecaudacion.Location = new System.Drawing.Point(302, 272);
            this.txt_totalRecaudacion.Name = "txt_totalRecaudacion";
            this.txt_totalRecaudacion.Size = new System.Drawing.Size(100, 23);
            this.txt_totalRecaudacion.TabIndex = 4;
            // 
            // txt_totalVuelos
            // 
            this.txt_totalVuelos.Location = new System.Drawing.Point(302, 205);
            this.txt_totalVuelos.Name = "txt_totalVuelos";
            this.txt_totalVuelos.Size = new System.Drawing.Size(100, 23);
            this.txt_totalVuelos.TabIndex = 5;
            // 
            // txt_totalPasajeros
            // 
            this.txt_totalPasajeros.Location = new System.Drawing.Point(302, 157);
            this.txt_totalPasajeros.Name = "txt_totalPasajeros";
            this.txt_totalPasajeros.Size = new System.Drawing.Size(100, 23);
            this.txt_totalPasajeros.TabIndex = 6;
            // 
            // btn_cerrarPestaña
            // 
            this.btn_cerrarPestaña.Location = new System.Drawing.Point(529, 209);
            this.btn_cerrarPestaña.Name = "btn_cerrarPestaña";
            this.btn_cerrarPestaña.Size = new System.Drawing.Size(127, 68);
            this.btn_cerrarPestaña.TabIndex = 7;
            this.btn_cerrarPestaña.Text = "CERRAR";
            this.btn_cerrarPestaña.UseVisualStyleBackColor = true;
            this.btn_cerrarPestaña.Click += new System.EventHandler(this.btn_cerrarPestaña_Click);
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cerrarPestaña);
            this.Controls.Add(this.txt_totalPasajeros);
            this.Controls.Add(this.txt_totalVuelos);
            this.Controls.Add(this.txt_totalRecaudacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_totalRecaudacion;
        private System.Windows.Forms.TextBox txt_totalVuelos;
        private System.Windows.Forms.TextBox txt_totalPasajeros;
        private System.Windows.Forms.Button btn_cerrarPestaña;
    }
}