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
            this.btnSp1Wuerfeln = new System.Windows.Forms.Button();
            this.lblPunkteSp1 = new System.Windows.Forms.Label();
            this.lblAnzahlWurfeSp1 = new System.Windows.Forms.Label();
            this.lblAnzahlWurfeSp2 = new System.Windows.Forms.Label();
            this.lblWuerfelergebnisse = new System.Windows.Forms.Label();
            this.lblPunkteSp2 = new System.Windows.Forms.Label();
            this.btnSp2Wuerfeln = new System.Windows.Forms.Button();
            this.nudEinsatzSpieler1 = new System.Windows.Forms.NumericUpDown();
            this.nudEinsatzSpieler2 = new System.Windows.Forms.NumericUpDown();
            this.btnEinsaetzeSetzen = new System.Windows.Forms.Button();
            this.lblTopf = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSpieler1TopfLeeren = new System.Windows.Forms.Button();
            this.btnSpieler2TopfLeeren = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEinsatzSpieler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEinsatzSpieler2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSp1Wuerfeln
            // 
            this.btnSp1Wuerfeln.Location = new System.Drawing.Point(6, 19);
            this.btnSp1Wuerfeln.Name = "btnSp1Wuerfeln";
            this.btnSp1Wuerfeln.Size = new System.Drawing.Size(75, 23);
            this.btnSp1Wuerfeln.TabIndex = 1;
            this.btnSp1Wuerfeln.Text = "würfeln";
            this.btnSp1Wuerfeln.UseVisualStyleBackColor = true;
            this.btnSp1Wuerfeln.Click += new System.EventHandler(this.btnSp1Wuerfeln_Click);
            // 
            // lblPunkteSp1
            // 
            this.lblPunkteSp1.AutoSize = true;
            this.lblPunkteSp1.Location = new System.Drawing.Point(87, 19);
            this.lblPunkteSp1.Name = "lblPunkteSp1";
            this.lblPunkteSp1.Size = new System.Drawing.Size(44, 13);
            this.lblPunkteSp1.TabIndex = 2;
            this.lblPunkteSp1.Text = "Punkte:";
            // 
            // lblAnzahlWurfeSp1
            // 
            this.lblAnzahlWurfeSp1.AutoSize = true;
            this.lblAnzahlWurfeSp1.Location = new System.Drawing.Point(87, 46);
            this.lblAnzahlWurfeSp1.Name = "lblAnzahlWurfeSp1";
            this.lblAnzahlWurfeSp1.Size = new System.Drawing.Size(39, 13);
            this.lblAnzahlWurfeSp1.TabIndex = 4;
            this.lblAnzahlWurfeSp1.Text = "Würfe:";
            // 
            // lblAnzahlWurfeSp2
            // 
            this.lblAnzahlWurfeSp2.AutoSize = true;
            this.lblAnzahlWurfeSp2.Location = new System.Drawing.Point(92, 43);
            this.lblAnzahlWurfeSp2.Name = "lblAnzahlWurfeSp2";
            this.lblAnzahlWurfeSp2.Size = new System.Drawing.Size(39, 13);
            this.lblAnzahlWurfeSp2.TabIndex = 8;
            this.lblAnzahlWurfeSp2.Text = "Würfe:";
            // 
            // lblWuerfelergebnisse
            // 
            this.lblWuerfelergebnisse.AutoSize = true;
            this.lblWuerfelergebnisse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWuerfelergebnisse.Location = new System.Drawing.Point(18, 198);
            this.lblWuerfelergebnisse.Name = "lblWuerfelergebnisse";
            this.lblWuerfelergebnisse.Size = new System.Drawing.Size(59, 20);
            this.lblWuerfelergebnisse.TabIndex = 7;
            this.lblWuerfelergebnisse.Text = "Würfel:";
            // 
            // lblPunkteSp2
            // 
            this.lblPunkteSp2.AutoSize = true;
            this.lblPunkteSp2.Location = new System.Drawing.Point(92, 19);
            this.lblPunkteSp2.Name = "lblPunkteSp2";
            this.lblPunkteSp2.Size = new System.Drawing.Size(44, 13);
            this.lblPunkteSp2.TabIndex = 6;
            this.lblPunkteSp2.Text = "Punkte:";
            // 
            // btnSp2Wuerfeln
            // 
            this.btnSp2Wuerfeln.Location = new System.Drawing.Point(6, 19);
            this.btnSp2Wuerfeln.Name = "btnSp2Wuerfeln";
            this.btnSp2Wuerfeln.Size = new System.Drawing.Size(75, 23);
            this.btnSp2Wuerfeln.TabIndex = 5;
            this.btnSp2Wuerfeln.Text = "würfeln";
            this.btnSp2Wuerfeln.UseVisualStyleBackColor = true;
            this.btnSp2Wuerfeln.Click += new System.EventHandler(this.btnSp2Wuerfeln_Click);
            // 
            // nudEinsatzSpieler1
            // 
            this.nudEinsatzSpieler1.Location = new System.Drawing.Point(17, 35);
            this.nudEinsatzSpieler1.Name = "nudEinsatzSpieler1";
            this.nudEinsatzSpieler1.Size = new System.Drawing.Size(120, 20);
            this.nudEinsatzSpieler1.TabIndex = 9;
            // 
            // nudEinsatzSpieler2
            // 
            this.nudEinsatzSpieler2.Location = new System.Drawing.Point(17, 91);
            this.nudEinsatzSpieler2.Name = "nudEinsatzSpieler2";
            this.nudEinsatzSpieler2.Size = new System.Drawing.Size(120, 20);
            this.nudEinsatzSpieler2.TabIndex = 11;
            // 
            // btnEinsaetzeSetzen
            // 
            this.btnEinsaetzeSetzen.Location = new System.Drawing.Point(17, 130);
            this.btnEinsaetzeSetzen.Name = "btnEinsaetzeSetzen";
            this.btnEinsaetzeSetzen.Size = new System.Drawing.Size(101, 23);
            this.btnEinsaetzeSetzen.TabIndex = 12;
            this.btnEinsaetzeSetzen.Text = "Einsätze setzen";
            this.btnEinsaetzeSetzen.UseVisualStyleBackColor = true;
            this.btnEinsaetzeSetzen.Click += new System.EventHandler(this.btnEinsaetzeSetzen_Click);
            // 
            // lblTopf
            // 
            this.lblTopf.AutoSize = true;
            this.lblTopf.Location = new System.Drawing.Point(14, 167);
            this.lblTopf.Name = "lblTopf";
            this.lblTopf.Size = new System.Drawing.Size(41, 13);
            this.lblTopf.TabIndex = 13;
            this.lblTopf.Text = "Topf: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.nudEinsatzSpieler1);
            this.groupBox1.Controls.Add(this.lblTopf);
            this.groupBox1.Controls.Add(this.nudEinsatzSpieler2);
            this.groupBox1.Controls.Add(this.btnEinsaetzeSetzen);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(200, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 192);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Einsätze";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.btnSpieler1TopfLeeren);
            this.groupBox2.Controls.Add(this.btnSp1Wuerfeln);
            this.groupBox2.Controls.Add(this.lblPunkteSp1);
            this.groupBox2.Controls.Add(this.lblAnzahlWurfeSp1);
            this.groupBox2.Location = new System.Drawing.Point(16, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 79);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spieler 1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.btnSpieler2TopfLeeren);
            this.groupBox3.Controls.Add(this.btnSp2Wuerfeln);
            this.groupBox3.Controls.Add(this.lblPunkteSp2);
            this.groupBox3.Controls.Add(this.lblAnzahlWurfeSp2);
            this.groupBox3.Location = new System.Drawing.Point(16, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 79);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Spieler 2";
            // 
            // btnSpieler1TopfLeeren
            // 
            this.btnSpieler1TopfLeeren.Location = new System.Drawing.Point(6, 46);
            this.btnSpieler1TopfLeeren.Name = "btnSpieler1TopfLeeren";
            this.btnSpieler1TopfLeeren.Size = new System.Drawing.Size(75, 23);
            this.btnSpieler1TopfLeeren.TabIndex = 5;
            this.btnSpieler1TopfLeeren.Text = "Topf leeren";
            this.btnSpieler1TopfLeeren.UseVisualStyleBackColor = true;
            this.btnSpieler1TopfLeeren.Click += new System.EventHandler(this.btnSpieler1TopfLeeren_Click);
            // 
            // btnSpieler2TopfLeeren
            // 
            this.btnSpieler2TopfLeeren.Location = new System.Drawing.Point(6, 50);
            this.btnSpieler2TopfLeeren.Name = "btnSpieler2TopfLeeren";
            this.btnSpieler2TopfLeeren.Size = new System.Drawing.Size(75, 23);
            this.btnSpieler2TopfLeeren.TabIndex = 6;
            this.btnSpieler2TopfLeeren.Text = "Topf leeren";
            this.btnSpieler2TopfLeeren.UseVisualStyleBackColor = true;
            this.btnSpieler2TopfLeeren.Click += new System.EventHandler(this.btnSpieler2TopfLeeren_Click);
            // 
            // FensterVerflixteSieben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 244);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWuerfelergebnisse);
            this.Name = "FensterVerflixteSieben";
            this.Text = "Die verflixte 7";
            ((System.ComponentModel.ISupportInitialize)(this.nudEinsatzSpieler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEinsatzSpieler2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSp1Wuerfeln;
        private System.Windows.Forms.Label lblPunkteSp1;
        private System.Windows.Forms.Label lblAnzahlWurfeSp1;
        private System.Windows.Forms.Label lblAnzahlWurfeSp2;
        private System.Windows.Forms.Label lblWuerfelergebnisse;
        private System.Windows.Forms.Label lblPunkteSp2;
        private System.Windows.Forms.Button btnSp2Wuerfeln;
        private System.Windows.Forms.NumericUpDown nudEinsatzSpieler1;
        private System.Windows.Forms.NumericUpDown nudEinsatzSpieler2;
        private System.Windows.Forms.Button btnEinsaetzeSetzen;
        private System.Windows.Forms.Label lblTopf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSpieler1TopfLeeren;
        private System.Windows.Forms.Button btnSpieler2TopfLeeren;

    }
}

