
namespace Listenfeld
{
	partial class Form1
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
			this.lstAnzeige = new System.Windows.Forms.ListBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.lblAnzeige = new System.Windows.Forms.Label();
			this.btnErstesElementAusgeben = new System.Windows.Forms.Button();
			this.btnAktuellesElement = new System.Windows.Forms.Button();
			this.btnAlleElementeAusgeben = new System.Windows.Forms.Button();
			this.btnIndex1Auswählen = new System.Windows.Forms.Button();
			this.btnIndex3Auswählen = new System.Windows.Forms.Button();
			this.btnLöschen = new System.Windows.Forms.Button();
			this.btnAlleLöschen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstAnzeige
			// 
			this.lstAnzeige.FormattingEnabled = true;
			this.lstAnzeige.Location = new System.Drawing.Point(12, 12);
			this.lstAnzeige.Name = "lstAnzeige";
			this.lstAnzeige.Size = new System.Drawing.Size(120, 95);
			this.lstAnzeige.TabIndex = 0;
			this.lstAnzeige.SelectedIndexChanged += new System.EventHandler(this.lstAnzeige_SelectedIndexChanged);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(56, 50);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(8, 4);
			this.listBox1.TabIndex = 1;
			// 
			// lblAnzeige
			// 
			this.lblAnzeige.AutoSize = true;
			this.lblAnzeige.Location = new System.Drawing.Point(178, 13);
			this.lblAnzeige.Name = "lblAnzeige";
			this.lblAnzeige.Size = new System.Drawing.Size(35, 13);
			this.lblAnzeige.TabIndex = 2;
			this.lblAnzeige.Text = "label1";
			// 
			// btnErstesElementAusgeben
			// 
			this.btnErstesElementAusgeben.Location = new System.Drawing.Point(13, 123);
			this.btnErstesElementAusgeben.Name = "btnErstesElementAusgeben";
			this.btnErstesElementAusgeben.Size = new System.Drawing.Size(119, 37);
			this.btnErstesElementAusgeben.TabIndex = 3;
			this.btnErstesElementAusgeben.Text = "Erstes Element ausgeben";
			this.btnErstesElementAusgeben.UseVisualStyleBackColor = true;
			this.btnErstesElementAusgeben.Click += new System.EventHandler(this.btnErstesElementAusgeben_Click);
			// 
			// btnAktuellesElement
			// 
			this.btnAktuellesElement.Location = new System.Drawing.Point(12, 166);
			this.btnAktuellesElement.Name = "btnAktuellesElement";
			this.btnAktuellesElement.Size = new System.Drawing.Size(120, 44);
			this.btnAktuellesElement.TabIndex = 4;
			this.btnAktuellesElement.Text = "Aktuelles Element und Index ausgeben";
			this.btnAktuellesElement.UseVisualStyleBackColor = true;
			this.btnAktuellesElement.Click += new System.EventHandler(this.btnAktuellesElement_Click);
			// 
			// btnAlleElementeAusgeben
			// 
			this.btnAlleElementeAusgeben.Location = new System.Drawing.Point(13, 217);
			this.btnAlleElementeAusgeben.Name = "btnAlleElementeAusgeben";
			this.btnAlleElementeAusgeben.Size = new System.Drawing.Size(119, 37);
			this.btnAlleElementeAusgeben.TabIndex = 5;
			this.btnAlleElementeAusgeben.Text = "Alle Elemente ausgeben";
			this.btnAlleElementeAusgeben.UseVisualStyleBackColor = true;
			this.btnAlleElementeAusgeben.Click += new System.EventHandler(this.btnAlleElementeAusgeben_Click);
			// 
			// btnIndex1Auswählen
			// 
			this.btnIndex1Auswählen.Location = new System.Drawing.Point(13, 260);
			this.btnIndex1Auswählen.Name = "btnIndex1Auswählen";
			this.btnIndex1Auswählen.Size = new System.Drawing.Size(119, 37);
			this.btnIndex1Auswählen.TabIndex = 6;
			this.btnIndex1Auswählen.Text = "Index 1 auswählen";
			this.btnIndex1Auswählen.UseVisualStyleBackColor = true;
			this.btnIndex1Auswählen.Click += new System.EventHandler(this.btnIndex1Auswählen_Click);
			// 
			// btnIndex3Auswählen
			// 
			this.btnIndex3Auswählen.Location = new System.Drawing.Point(13, 303);
			this.btnIndex3Auswählen.Name = "btnIndex3Auswählen";
			this.btnIndex3Auswählen.Size = new System.Drawing.Size(119, 34);
			this.btnIndex3Auswählen.TabIndex = 7;
			this.btnIndex3Auswählen.Text = "Index 3 auswählen";
			this.btnIndex3Auswählen.UseVisualStyleBackColor = true;
			this.btnIndex3Auswählen.Click += new System.EventHandler(this.btnIndex3Auswählen_Click);
			// 
			// btnLöschen
			// 
			this.btnLöschen.Location = new System.Drawing.Point(13, 344);
			this.btnLöschen.Name = "btnLöschen";
			this.btnLöschen.Size = new System.Drawing.Size(119, 40);
			this.btnLöschen.TabIndex = 8;
			this.btnLöschen.Text = "Ausgewähltes Element löschen";
			this.btnLöschen.UseVisualStyleBackColor = true;
			this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
			// 
			// btnAlleLöschen
			// 
			this.btnAlleLöschen.Location = new System.Drawing.Point(13, 391);
			this.btnAlleLöschen.Name = "btnAlleLöschen";
			this.btnAlleLöschen.Size = new System.Drawing.Size(119, 38);
			this.btnAlleLöschen.TabIndex = 9;
			this.btnAlleLöschen.Text = "Alle löschen";
			this.btnAlleLöschen.UseVisualStyleBackColor = true;
			this.btnAlleLöschen.Click += new System.EventHandler(this.btnAlleLöschen_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAlleLöschen);
			this.Controls.Add(this.btnLöschen);
			this.Controls.Add(this.btnIndex3Auswählen);
			this.Controls.Add(this.btnIndex1Auswählen);
			this.Controls.Add(this.btnAlleElementeAusgeben);
			this.Controls.Add(this.btnAktuellesElement);
			this.Controls.Add(this.btnErstesElementAusgeben);
			this.Controls.Add(this.lblAnzeige);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.lstAnzeige);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstAnzeige;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label lblAnzeige;
		private System.Windows.Forms.Button btnErstesElementAusgeben;
		private System.Windows.Forms.Button btnAktuellesElement;
		private System.Windows.Forms.Button btnAlleElementeAusgeben;
		private System.Windows.Forms.Button btnIndex1Auswählen;
		private System.Windows.Forms.Button btnIndex3Auswählen;
		private System.Windows.Forms.Button btnLöschen;
		private System.Windows.Forms.Button btnAlleLöschen;
	}
}

