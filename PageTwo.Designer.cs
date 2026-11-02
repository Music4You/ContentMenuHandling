namespace MultiWindowMenu
{
    partial class PageTwo
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
            this.lblPageTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPageTwo
            // 
            this.lblPageTwo.AutoSize = true;
            this.lblPageTwo.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTwo.Location = new System.Drawing.Point(3, 0);
            this.lblPageTwo.Name = "lblPageTwo";
            this.lblPageTwo.Size = new System.Drawing.Size(130, 19);
            this.lblPageTwo.TabIndex = 1;
            this.lblPageTwo.Text = "Page - Two";
            // 
            // PageTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPageTwo);
            this.Name = "PageTwo";
            this.Size = new System.Drawing.Size(405, 303);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTwo;
    }
}
