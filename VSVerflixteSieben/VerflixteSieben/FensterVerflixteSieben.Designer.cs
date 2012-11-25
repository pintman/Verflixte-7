namespace VerflixteSieben
{
    partial class FensterVerflixteSieben
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGuiErstellen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGuiErstellen
            // 
            this.lblGuiErstellen.AutoSize = true;
            this.lblGuiErstellen.Location = new System.Drawing.Point(61, 113);
            this.lblGuiErstellen.Name = "lblGuiErstellen";
            this.lblGuiErstellen.Size = new System.Drawing.Size(152, 13);
            this.lblGuiErstellen.TabIndex = 0;
            this.lblGuiErstellen.Text = "Hier musst du die GUI erstellen";
            // 
            // FensterVerflixteSieben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.lblGuiErstellen);
            this.Name = "FensterVerflixteSieben";
            this.Text = "Die verflixte 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuiErstellen;
    }
}

