namespace Vista.Vistas
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
            this.ptbLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLoading
            // 
            this.ptbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbLoading.Location = new System.Drawing.Point(50, 50);
            this.ptbLoading.Name = "ptbLoading";
            this.ptbLoading.Size = new System.Drawing.Size(348, 208);
            this.ptbLoading.TabIndex = 0;
            this.ptbLoading.TabStop = false;
            // 
            // frmCargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(479, 311);
            this.ControlBox = false;
            this.Controls.Add(this.ptbLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCargando";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCargando";
            this.Load += new System.EventHandler(this.frmCargando_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ptbLoading;
    }
}