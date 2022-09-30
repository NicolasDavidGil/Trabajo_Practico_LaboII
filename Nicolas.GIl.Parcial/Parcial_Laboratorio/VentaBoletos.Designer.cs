namespace Parcial_Laboratorio
{
    partial class VentaBoletos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_equipajeMano = new System.Windows.Forms.CheckBox();
            this.cmb_clasePasajero = new System.Windows.Forms.ComboBox();
            this.nud_cantidadMaletas = new System.Windows.Forms.NumericUpDown();
            this.lbl_pesoTotal = new System.Windows.Forms.Label();
            this.btn_cancelarVenta = new System.Windows.Forms.Button();
            this.btn_confirmarVenta = new System.Windows.Forms.Button();
            this.cmb_pesoTotal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_dniPasajero = new System.Windows.Forms.Label();
            this.lbl_nombrePasajero = new System.Windows.Forms.Label();
            this.lblNombrePasajero = new System.Windows.Forms.Label();
            this.lblDniPasajero = new System.Windows.Forms.Label();
            this.lblEdadPasajero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDestinoVuelo = new System.Windows.Forms.Label();
            this.lblOrigenVuelo = new System.Windows.Forms.Label();
            this.lblCodigoVuelo = new System.Windows.Forms.Label();
            this.lblTituloPrecioBruto = new System.Windows.Forms.Label();
            this.lblPrecioBruto = new System.Windows.Forms.Label();
            this.lblTituloPrecioNeto = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidadMaletas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "EQUIPAJE MANO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "CLASE PASAJE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "EQUIPAJE BODEGA:";
            // 
            // cb_equipajeMano
            // 
            this.cb_equipajeMano.AutoSize = true;
            this.cb_equipajeMano.Location = new System.Drawing.Point(171, 324);
            this.cb_equipajeMano.Name = "cb_equipajeMano";
            this.cb_equipajeMano.Size = new System.Drawing.Size(15, 14);
            this.cb_equipajeMano.TabIndex = 7;
            this.cb_equipajeMano.UseVisualStyleBackColor = true;
            // 
            // cmb_clasePasajero
            // 
            this.cmb_clasePasajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_clasePasajero.FormattingEnabled = true;
            this.cmb_clasePasajero.Location = new System.Drawing.Point(171, 287);
            this.cmb_clasePasajero.Name = "cmb_clasePasajero";
            this.cmb_clasePasajero.Size = new System.Drawing.Size(121, 23);
            this.cmb_clasePasajero.TabIndex = 11;
            this.cmb_clasePasajero.SelectedIndexChanged += new System.EventHandler(this.cb_clasePasajero_SelectedIndexChanged);
            // 
            // nud_cantidadMaletas
            // 
            this.nud_cantidadMaletas.Location = new System.Drawing.Point(171, 362);
            this.nud_cantidadMaletas.Name = "nud_cantidadMaletas";
            this.nud_cantidadMaletas.Size = new System.Drawing.Size(55, 23);
            this.nud_cantidadMaletas.TabIndex = 12;
            this.nud_cantidadMaletas.ValueChanged += new System.EventHandler(this.nud_cantidadMaletas_ValueChanged);
            // 
            // lbl_pesoTotal
            // 
            this.lbl_pesoTotal.AutoSize = true;
            this.lbl_pesoTotal.Location = new System.Drawing.Point(232, 371);
            this.lbl_pesoTotal.Name = "lbl_pesoTotal";
            this.lbl_pesoTotal.Size = new System.Drawing.Size(73, 15);
            this.lbl_pesoTotal.TabIndex = 14;
            this.lbl_pesoTotal.Text = "PESO TOTAL:";
            // 
            // btn_cancelarVenta
            // 
            this.btn_cancelarVenta.Location = new System.Drawing.Point(200, 445);
            this.btn_cancelarVenta.Name = "btn_cancelarVenta";
            this.btn_cancelarVenta.Size = new System.Drawing.Size(101, 50);
            this.btn_cancelarVenta.TabIndex = 16;
            this.btn_cancelarVenta.Text = "CANCELAR VENTA";
            this.btn_cancelarVenta.UseVisualStyleBackColor = true;
            this.btn_cancelarVenta.Click += new System.EventHandler(this.btn_cancelarVenta_Click);
            // 
            // btn_confirmarVenta
            // 
            this.btn_confirmarVenta.Location = new System.Drawing.Point(351, 445);
            this.btn_confirmarVenta.Name = "btn_confirmarVenta";
            this.btn_confirmarVenta.Size = new System.Drawing.Size(101, 50);
            this.btn_confirmarVenta.TabIndex = 17;
            this.btn_confirmarVenta.Text = "CONFIRMAR VENTA";
            this.btn_confirmarVenta.UseVisualStyleBackColor = true;
            this.btn_confirmarVenta.Click += new System.EventHandler(this.btn_confirmarVenta_Click);
            // 
            // cmb_pesoTotal
            // 
            this.cmb_pesoTotal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pesoTotal.FormattingEnabled = true;
            this.cmb_pesoTotal.Location = new System.Drawing.Point(311, 362);
            this.cmb_pesoTotal.Name = "cmb_pesoTotal";
            this.cmb_pesoTotal.Size = new System.Drawing.Size(121, 23);
            this.cmb_pesoTotal.TabIndex = 18;
            this.cmb_pesoTotal.SelectedIndexChanged += new System.EventHandler(this.cmb_pesoTotal_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "EDAD PASAJERO:";
            // 
            // lbl_dniPasajero
            // 
            this.lbl_dniPasajero.AutoSize = true;
            this.lbl_dniPasajero.Location = new System.Drawing.Point(58, 165);
            this.lbl_dniPasajero.Name = "lbl_dniPasajero";
            this.lbl_dniPasajero.Size = new System.Drawing.Size(97, 15);
            this.lbl_dniPasajero.TabIndex = 2;
            this.lbl_dniPasajero.Text = "D.N.I. PASAJERO:";
            // 
            // lbl_nombrePasajero
            // 
            this.lbl_nombrePasajero.AutoSize = true;
            this.lbl_nombrePasajero.Location = new System.Drawing.Point(38, 120);
            this.lbl_nombrePasajero.Name = "lbl_nombrePasajero";
            this.lbl_nombrePasajero.Size = new System.Drawing.Size(117, 15);
            this.lbl_nombrePasajero.TabIndex = 1;
            this.lbl_nombrePasajero.Text = "NOMBRE PASAJERO:";
            // 
            // lblNombrePasajero
            // 
            this.lblNombrePasajero.AutoSize = true;
            this.lblNombrePasajero.Location = new System.Drawing.Point(161, 120);
            this.lblNombrePasajero.Name = "lblNombrePasajero";
            this.lblNombrePasajero.Size = new System.Drawing.Size(93, 15);
            this.lblNombrePasajero.TabIndex = 19;
            this.lblNombrePasajero.Text = "nombrePasajero";
            // 
            // lblDniPasajero
            // 
            this.lblDniPasajero.AutoSize = true;
            this.lblDniPasajero.Location = new System.Drawing.Point(162, 165);
            this.lblDniPasajero.Name = "lblDniPasajero";
            this.lblDniPasajero.Size = new System.Drawing.Size(24, 15);
            this.lblDniPasajero.TabIndex = 20;
            this.lblDniPasajero.Text = "dni";
            // 
            // lblEdadPasajero
            // 
            this.lblEdadPasajero.AutoSize = true;
            this.lblEdadPasajero.Location = new System.Drawing.Point(162, 211);
            this.lblEdadPasajero.Name = "lblEdadPasajero";
            this.lblEdadPasajero.Size = new System.Drawing.Size(33, 15);
            this.lblEdadPasajero.TabIndex = 21;
            this.lblEdadPasajero.Text = "edad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "DESTINO VUELO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "ORIGEN DE VUELO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "CODIGO DE VUELO:";
            // 
            // lblDestinoVuelo
            // 
            this.lblDestinoVuelo.AutoSize = true;
            this.lblDestinoVuelo.Location = new System.Drawing.Point(417, 211);
            this.lblDestinoVuelo.Name = "lblDestinoVuelo";
            this.lblDestinoVuelo.Size = new System.Drawing.Size(76, 15);
            this.lblDestinoVuelo.TabIndex = 25;
            this.lblDestinoVuelo.Text = "destinoVuelo";
            // 
            // lblOrigenVuelo
            // 
            this.lblOrigenVuelo.AutoSize = true;
            this.lblOrigenVuelo.Location = new System.Drawing.Point(417, 165);
            this.lblOrigenVuelo.Name = "lblOrigenVuelo";
            this.lblOrigenVuelo.Size = new System.Drawing.Size(75, 15);
            this.lblOrigenVuelo.TabIndex = 26;
            this.lblOrigenVuelo.Text = "origemVuelo";
            // 
            // lblCodigoVuelo
            // 
            this.lblCodigoVuelo.AutoSize = true;
            this.lblCodigoVuelo.Location = new System.Drawing.Point(417, 120);
            this.lblCodigoVuelo.Name = "lblCodigoVuelo";
            this.lblCodigoVuelo.Size = new System.Drawing.Size(74, 15);
            this.lblCodigoVuelo.TabIndex = 27;
            this.lblCodigoVuelo.Text = "codigoVuelo";
            // 
            // lblTituloPrecioBruto
            // 
            this.lblTituloPrecioBruto.AutoSize = true;
            this.lblTituloPrecioBruto.Location = new System.Drawing.Point(471, 295);
            this.lblTituloPrecioBruto.Name = "lblTituloPrecioBruto";
            this.lblTituloPrecioBruto.Size = new System.Drawing.Size(89, 15);
            this.lblTituloPrecioBruto.TabIndex = 28;
            this.lblTituloPrecioBruto.Text = "PRECIO BRUTO:";
            // 
            // lblPrecioBruto
            // 
            this.lblPrecioBruto.AutoSize = true;
            this.lblPrecioBruto.Location = new System.Drawing.Point(600, 295);
            this.lblPrecioBruto.Name = "lblPrecioBruto";
            this.lblPrecioBruto.Size = new System.Drawing.Size(36, 15);
            this.lblPrecioBruto.TabIndex = 29;
            this.lblPrecioBruto.Text = "bruto";
            // 
            // lblTituloPrecioNeto
            // 
            this.lblTituloPrecioNeto.AutoSize = true;
            this.lblTituloPrecioNeto.Location = new System.Drawing.Point(478, 337);
            this.lblTituloPrecioNeto.Name = "lblTituloPrecioNeto";
            this.lblTituloPrecioNeto.Size = new System.Drawing.Size(82, 15);
            this.lblTituloPrecioNeto.TabIndex = 30;
            this.lblTituloPrecioNeto.Text = "PRECIO NETO:";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Location = new System.Drawing.Point(600, 337);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(31, 15);
            this.lblPrecioFinal.TabIndex = 31;
            this.lblPrecioFinal.Text = "neto";
            // 
            // VentaBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 530);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.lblTituloPrecioNeto);
            this.Controls.Add(this.lblPrecioBruto);
            this.Controls.Add(this.lblTituloPrecioBruto);
            this.Controls.Add(this.lblCodigoVuelo);
            this.Controls.Add(this.lblOrigenVuelo);
            this.Controls.Add(this.lblDestinoVuelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEdadPasajero);
            this.Controls.Add(this.lblDniPasajero);
            this.Controls.Add(this.lblNombrePasajero);
            this.Controls.Add(this.cmb_pesoTotal);
            this.Controls.Add(this.btn_confirmarVenta);
            this.Controls.Add(this.btn_cancelarVenta);
            this.Controls.Add(this.lbl_pesoTotal);
            this.Controls.Add(this.nud_cantidadMaletas);
            this.Controls.Add(this.cmb_clasePasajero);
            this.Controls.Add(this.cb_equipajeMano);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_dniPasajero);
            this.Controls.Add(this.lbl_nombrePasajero);
            this.Name = "VentaBoletos";
            this.Text = "VentaBoletos";
            this.Load += new System.EventHandler(this.VentaBoletos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidadMaletas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_equipajeMano;
        private System.Windows.Forms.ComboBox cmb_clasePasajero;
        private System.Windows.Forms.NumericUpDown nud_cantidadMaletas;
        private System.Windows.Forms.Label lbl_pesoTotal;
        private System.Windows.Forms.Button btn_cancelarVenta;
        private System.Windows.Forms.Button btn_confirmarVenta;
        private System.Windows.Forms.ComboBox cmb_pesoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_dniPasajero;
        private System.Windows.Forms.Label lbl_nombrePasajero;
        private System.Windows.Forms.Label lblNombrePasajero;
        private System.Windows.Forms.Label lblDniPasajero;
        private System.Windows.Forms.Label lblEdadPasajero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDestinoVuelo;
        private System.Windows.Forms.Label lblOrigenVuelo;
        private System.Windows.Forms.Label lblCodigoVuelo;
        private System.Windows.Forms.Label lblTituloPrecioBruto;
        private System.Windows.Forms.Label lblPrecioBruto;
        private System.Windows.Forms.Label lblTituloPrecioNeto;
        private System.Windows.Forms.Label lblPrecioFinal;
    }
}