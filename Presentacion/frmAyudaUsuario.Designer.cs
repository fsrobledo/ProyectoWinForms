namespace Presentacion
{
    partial class frmAyudaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyudaUsuario));
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbTexto
            // 
            this.rtbTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTexto.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTexto.Location = new System.Drawing.Point(12, 12);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.ReadOnly = true;
            this.rtbTexto.Size = new System.Drawing.Size(550, 621);
            this.rtbTexto.TabIndex = 0;
            this.rtbTexto.Text = resources.GetString("rtbTexto.Text");
            // 
            // frmAyudaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 645);
            this.Controls.Add(this.rtbTexto);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(380, 520);
            this.Name = "frmAyudaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual de Usuario";
            this.Load += new System.EventHandler(this.frmAyudaUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTexto;
    }
}