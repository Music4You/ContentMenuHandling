namespace MultiWindowMenu
{
    partial class PageOne
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
            this.lblPageOne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPageOne
            // 
            this.lblPageOne.AutoSize = true;
            this.lblPageOne.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageOne.Location = new System.Drawing.Point(3, 0);
            this.lblPageOne.Name = "lblPageOne";
            this.lblPageOne.Size = new System.Drawing.Size(128, 19);
            this.lblPageOne.TabIndex = 0;
            this.lblPageOne.Text = "Page - One";
            // 
            // PageOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPageOne);
            this.Name = "PageOne";
            this.Size = new System.Drawing.Size(537, 403);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageOne;
    }
}
