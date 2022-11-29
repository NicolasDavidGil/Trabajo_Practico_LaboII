namespace Vista
{
    partial class frmCargando
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
            this.ptbCargando = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCargando)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCargando
            // 
            this.ptbCargando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbCargando.Location = new System.Drawing.Point(68, 60);
            this.ptbCargando.Name = "ptbCargando";
            this.ptbCargando.Size = new System.Drawing.Size(392, 255);
            this.ptbCargando.TabIndex = 0;
            this.ptbCargando.TabStop = false;
            // 
            // frmCargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(535, 373);
            this.ControlBox = false;
            this.Controls.Add(this.ptbCargando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCargando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCargando_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCargando)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ptbCargando;
    }
}