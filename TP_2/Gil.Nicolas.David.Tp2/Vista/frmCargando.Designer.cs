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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargando));
            this.ptbCargando = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCargando)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCargando
            // 
            this.ptbCargando.Location = new System.Drawing.Point(72, 75);
            this.ptbCargando.Name = "ptbCargando";
            this.ptbCargando.Size = new System.Drawing.Size(311, 242);
            this.ptbCargando.TabIndex = 0;
            this.ptbCargando.TabStop = false;
            // 
            // frmCargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(464, 398);
            this.ControlBox = false;
            this.Controls.Add(this.ptbCargando);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCargardo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCargando)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ptbCargando;
    }
}