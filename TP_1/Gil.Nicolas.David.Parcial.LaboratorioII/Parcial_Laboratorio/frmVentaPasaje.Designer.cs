namespace Parcial_Laboratorio
{
    partial class frmVentaPasaje
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
            this.dgvVuelosDisponibles = new System.Windows.Forms.DataGridView();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cobPesoTotal = new System.Windows.Forms.ComboBox();
            this.lbl_pesoTotal = new System.Windows.Forms.Label();
            this.numudCantidadMaletas = new System.Windows.Forms.NumericUpDown();
            this.cobClasePasajero = new System.Windows.Forms.ComboBox();
            this.chkEquipajeMano = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblPasajeroElegido = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudCantidadMaletas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVuelosDisponibles
            // 
            this.dgvVuelosDisponibles.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvVuelosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVuelosDisponibles.Location = new System.Drawing.Point(25, 35);
            this.dgvVuelosDisponibles.Name = "dgvVuelosDisponibles";
            this.dgvVuelosDisponibles.RowTemplate.Height = 25;
            this.dgvVuelosDisponibles.Size = new System.Drawing.Size(439, 150);
            this.dgvVuelosDisponibles.TabIndex = 0;
            this.dgvVuelosDisponibles.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVuelosDisponibles_RowHeaderMouseClick);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Transparent;
            this.btnContinuar.FlatAppearance.BorderSize = 3;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContinuar.ForeColor = System.Drawing.Color.Black;
            this.btnContinuar.Location = new System.Drawing.Point(253, 400);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(107, 39);
            this.btnContinuar.TabIndex = 1;
            this.btnContinuar.Text = "CONTINUAR";
            this.toolTip1.SetToolTip(this.btnContinuar, "Continuar con la venta");
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarVenta.FlatAppearance.BorderSize = 3;
            this.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarVenta.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarVenta.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarVenta.Location = new System.Drawing.Point(88, 400);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(96, 39);
            this.btnCancelarVenta.TabIndex = 2;
            this.btnCancelarVenta.Text = "CANCELAR VENTA";
            this.toolTip1.SetToolTip(this.btnCancelarVenta, "Volver al menu principal");
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECCIONE EL VUELO EN EL QUE DESEA VENDER";
            // 
            // cobPesoTotal
            // 
            this.cobPesoTotal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobPesoTotal.FormattingEnabled = true;
            this.cobPesoTotal.Location = new System.Drawing.Point(159, 339);
            this.cobPesoTotal.Name = "cobPesoTotal";
            this.cobPesoTotal.Size = new System.Drawing.Size(121, 23);
            this.cobPesoTotal.TabIndex = 39;
            this.toolTip1.SetToolTip(this.cobPesoTotal, "Peso total de las valijas");
            this.cobPesoTotal.SelectedIndexChanged += new System.EventHandler(this.cobPesoTotal_SelectedIndexChanged);
            // 
            // lbl_pesoTotal
            // 
            this.lbl_pesoTotal.AutoSize = true;
            this.lbl_pesoTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pesoTotal.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pesoTotal.ForeColor = System.Drawing.Color.Black;
            this.lbl_pesoTotal.Location = new System.Drawing.Point(62, 345);
            this.lbl_pesoTotal.Name = "lbl_pesoTotal";
            this.lbl_pesoTotal.Size = new System.Drawing.Size(91, 17);
            this.lbl_pesoTotal.TabIndex = 38;
            this.lbl_pesoTotal.Text = "PESO TOTAL:";
            // 
            // numudCantidadMaletas
            // 
            this.numudCantidadMaletas.Location = new System.Drawing.Point(161, 298);
            this.numudCantidadMaletas.Name = "numudCantidadMaletas";
            this.numudCantidadMaletas.Size = new System.Drawing.Size(55, 23);
            this.numudCantidadMaletas.TabIndex = 37;
            this.toolTip1.SetToolTip(this.numudCantidadMaletas, "Cantidad de valijas");
            this.numudCantidadMaletas.ValueChanged += new System.EventHandler(this.numudCantidadMaletas_ValueChanged);
            // 
            // cobClasePasajero
            // 
            this.cobClasePasajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobClasePasajero.FormattingEnabled = true;
            this.cobClasePasajero.Location = new System.Drawing.Point(161, 205);
            this.cobClasePasajero.Name = "cobClasePasajero";
            this.cobClasePasajero.Size = new System.Drawing.Size(121, 23);
            this.cobClasePasajero.TabIndex = 36;
            this.toolTip1.SetToolTip(this.cobClasePasajero, "Seleccione tipo de pasaje");
            this.cobClasePasajero.SelectedIndexChanged += new System.EventHandler(this.cobClasePasajero_SelectedIndexChanged);
            // 
            // chkEquipajeMano
            // 
            this.chkEquipajeMano.AutoSize = true;
            this.chkEquipajeMano.Location = new System.Drawing.Point(161, 258);
            this.chkEquipajeMano.Name = "chkEquipajeMano";
            this.chkEquipajeMano.Size = new System.Drawing.Size(15, 14);
            this.chkEquipajeMano.TabIndex = 35;
            this.chkEquipajeMano.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "EQUIPAJE BODEGA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(49, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "CLASE PASAJE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "EQUIPAJE MANO:";
            // 
            // lblPasajeroElegido
            // 
            this.lblPasajeroElegido.AutoSize = true;
            this.lblPasajeroElegido.BackColor = System.Drawing.Color.Transparent;
            this.lblPasajeroElegido.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasajeroElegido.ForeColor = System.Drawing.Color.Black;
            this.lblPasajeroElegido.Location = new System.Drawing.Point(288, 213);
            this.lblPasajeroElegido.Name = "lblPasajeroElegido";
            this.lblPasajeroElegido.Size = new System.Drawing.Size(72, 17);
            this.lblPasajeroElegido.TabIndex = 40;
            this.lblPasajeroElegido.Text = "PASAJERO";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(253, 383);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 41;
            // 
            // frmVentaPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial_Laboratorio.Properties.Resources._06;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 479);
            this.ControlBox = false;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblPasajeroElegido);
            this.Controls.Add(this.cobPesoTotal);
            this.Controls.Add(this.lbl_pesoTotal);
            this.Controls.Add(this.numudCantidadMaletas);
            this.Controls.Add(this.cobClasePasajero);
            this.Controls.Add(this.chkEquipajeMano);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.dgvVuelosDisponibles);
            this.Name = "frmVentaPasaje";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmVentaPasaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudCantidadMaletas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVuelosDisponibles;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobPesoTotal;
        private System.Windows.Forms.Label lbl_pesoTotal;
        private System.Windows.Forms.NumericUpDown numudCantidadMaletas;
        private System.Windows.Forms.ComboBox cobClasePasajero;
        private System.Windows.Forms.CheckBox chkEquipajeMano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblPasajeroElegido;
        private System.Windows.Forms.Label lblError;
    }
}