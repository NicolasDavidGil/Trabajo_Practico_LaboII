namespace Parcial_Laboratorio
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.btn_autocompletar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.lbl_datosIncorrectos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(172, 310);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 23);
            this.txt_password.TabIndex = 2;
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(172, 281);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(100, 23);
            this.txt_userName.TabIndex = 3;
            // 
            // btn_autocompletar
            // 
            this.btn_autocompletar.Location = new System.Drawing.Point(154, 380);
            this.btn_autocompletar.Name = "btn_autocompletar";
            this.btn_autocompletar.Size = new System.Drawing.Size(143, 48);
            this.btn_autocompletar.TabIndex = 4;
            this.btn_autocompletar.Text = "AUTOCOMPLETAR";
            this.btn_autocompletar.UseVisualStyleBackColor = true;
            this.btn_autocompletar.Click += new System.EventHandler(this.btn_autocompletar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(131, 351);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(237, 351);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_Ingresar.TabIndex = 6;
            this.btn_Ingresar.Text = "INGRESAR";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // lbl_datosIncorrectos
            // 
            this.lbl_datosIncorrectos.AutoSize = true;
            this.lbl_datosIncorrectos.Location = new System.Drawing.Point(152, 254);
            this.lbl_datosIncorrectos.Name = "lbl_datosIncorrectos";
            this.lbl_datosIncorrectos.Size = new System.Drawing.Size(145, 15);
            this.lbl_datosIncorrectos.TabIndex = 7;
            this.lbl_datosIncorrectos.Text = "ERROR, DATOS INVALIDOS";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial_Laboratorio.Properties.Resources.FondoOK;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 505);
            this.Controls.Add(this.lbl_datosIncorrectos);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_autocompletar);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Button btn_autocompletar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Label lbl_datosIncorrectos;
    }
}
