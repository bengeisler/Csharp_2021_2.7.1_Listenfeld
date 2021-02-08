using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listenfeld
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lstAnzeige.Items.Add("Spaghetti");
			lstAnzeige.Items.Add("Grüne Nudeln");
			lstAnzeige.Items.Add("Tortellini");

			// Anzahl der Elemente in der ListBox
			lblAnzeige.Text =
				"Anzahl: " +
				lstAnzeige.Items.Count.ToString() +
				"\n";
		}

		private void lstAnzeige_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Anzeige des ausgewählten Elements
			lblAnzeige.Text +=
				"Ausgewähltes Element: " +
				lstAnzeige.SelectedItem +
				"\n";

			// Anzeige des ausgewählten Index
			lblAnzeige.Text +=
				"Ausgewählter Index: " +
				lstAnzeige.SelectedIndex +
				"\n";
		}

		private void btnErstesElementAusgeben_Click(object sender, EventArgs e)
		{
			// Erstes Element der Liste ausgeben
			// Zugriff auf Elemente über den Index
			if (lstAnzeige.Items.Count >= 1)
			{
				lblAnzeige.Text = lstAnzeige.Items[0].ToString();
			}

			// Viertes Element ausgeben
			if (lstAnzeige.Items.Count >= 4)
			{
				lblAnzeige.Text = lstAnzeige.Items[3].ToString();
			}

		}

		private void btnAktuellesElement_Click(object sender, EventArgs e)
		{
			// Anzeige des ausgewählten Elements
			// liefert null, wenn nichts ausgewählt wurde
			if (lstAnzeige.SelectedItem != null)
			{
				lblAnzeige.Text =
					"Element: " +
					lstAnzeige.SelectedItem +
					"\n";
			}
			else
			{
				lblAnzeige.Text = "Kein Element ausgewählt.\n";
			}


			// Anzeige des ausgewählten Index
			// liefert -1, wenn nichts ausgewählt wurde
			if (lstAnzeige.SelectedIndex != -1)
			{
				lblAnzeige.Text +=
					"Index: " +
					lstAnzeige.SelectedIndex;
			}
			else
			{
				lblAnzeige.Text += "Kein Index ausgewählt.";
			}

		}

		private void btnAlleElementeAusgeben_Click(object sender, EventArgs e)
		{
			lblAnzeige.Text = "Alle Elemente:\n";

			// Bisheriges Vorgehen:
			//for (int i = 0; i < lstAnzeige.Items.Count; i++)
			//{
			//	lblAnzeige.Text += lstAnzeige.Items[i] + "\n";
			//}

			foreach (string s in lstAnzeige.Items)
			{
				lblAnzeige.Text += s + "\n";
			}

		}

		private void btnIndex1Auswählen_Click(object sender, EventArgs e)
		{
			lstAnzeige.SelectedIndex = 1;
		}

		private void btnIndex3Auswählen_Click(object sender, EventArgs e)
		{
			lstAnzeige.SelectedIndex = 3;
		}

		private void btnLöschen_Click(object sender, EventArgs e)
		{
			// Löschen über den Index
			// lstAnzeige.Items.RemoveAt(lstAnzeige.SelectedIndex);

			// Empfehlung: Löschen über das Item
			 lstAnzeige.Items.Remove(lstAnzeige.SelectedItem);
		}

		private void btnAlleLöschen_Click(object sender, EventArgs e)
		{
			// Möglich:
			//foreach (string s in lstAnzeige.Items)
			//{
			//	lstAnzeige.Items.Remove(s);
			//}

			// Einfachste Möglichkeit:
			lstAnzeige.Items.Clear();
		}
	}
}
