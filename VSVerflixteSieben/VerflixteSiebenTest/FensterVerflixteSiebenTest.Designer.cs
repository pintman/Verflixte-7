namespace VerflixteSiebenTest
{
    partial class FensterVerflixteSiebenTest
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
            this.btnTestStarten = new System.Windows.Forms.Button();
            this.tbAusgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTestStarten
            // 
            this.btnTestStarten.Location = new System.Drawing.Point(13, 13);
            this.btnTestStarten.Name = "btnTestStarten";
            this.btnTestStarten.Size = new System.Drawing.Size(75, 23);
            this.btnTestStarten.TabIndex = 0;
            this.btnTestStarten.Text = "Test starten";
            this.btnTestStarten.UseVisualStyleBackColor = true;
            this.btnTestStarten.Click += new System.EventHandler(this.btnTestStarten_Click);
            // 
            // tbAusgabe
            // 
            this.tbAusgabe.Location = new System.Drawing.Point(13, 43);
            this.tbAusgabe.Multiline = true;
            this.tbAusgabe.Name = "tbAusgabe";
            this.tbAusgabe.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAusgabe.Size = new System.Drawing.Size(259, 310);
            this.tbAusgabe.TabIndex = 1;
            // 
            // FensterVerflixteSiebenTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 365);
            this.Controls.Add(this.tbAusgabe);
            this.Controls.Add(this.btnTestStarten);
            this.Name = "FensterVerflixteSiebenTest";
            this.Text = "Verflixte Sieben - Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestStarten;
        private System.Windows.Forms.TextBox tbAusgabe;
    }
}

