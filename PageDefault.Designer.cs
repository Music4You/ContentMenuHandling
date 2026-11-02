namespace MultiWindowMenu
{
    partial class PageDefault
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPageDefault = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPageDefault
            // 
            this.lblPageDefault.AutoSize = true;
            this.lblPageDefault.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageDefault.Location = new System.Drawing.Point(3, 9);
            this.lblPageDefault.Name = "lblPageDefault";
            this.lblPageDefault.Size = new System.Drawing.Size(181, 19);
            this.lblPageDefault.TabIndex = 1;
            this.lblPageDefault.Text = "Page - Default";
            // 
            // PageDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPageDefault);
            this.Name = "PageDefault";
            this.Size = new System.Drawing.Size(487, 384);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageDefault;
    }
}
