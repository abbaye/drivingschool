using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Barette.Library.UserControls {
	/// <summary>
	/// Description résumée de DecimalTextBox.
	/// </summary>	
	public class PourCentTextBox : System.Windows.Forms.TextBox {
		/// <summary> 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PourCentTextBox() {

			// Cet appel est requis par le Concepteur de formulaires Windows.Forms.
			InitializeComponent();
		}

		/// <summary> 
		/// Nettoyage des ressources utilisées.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Code généré par le Concepteur de composants
		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent() {
			// 
			// CashTextBox
			// 
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashTextBox_KeyPress);
			this.TextChanged += new System.EventHandler(this.CashTextBox_TextChanged);
			this.Leave += new System.EventHandler(this.CashTextBox_Leave);
			this.Enter += new System.EventHandler(this.CashTextBox_Enter);

		}
		#endregion

		private void CashTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e) {
			char key = e.KeyChar;
			
			if( key >= '0' && key <= '9')
				e.Handled = false;				
			else if( key == '\b') //Backspace
				e.Handled = false;
			else if( key == ',' || key == '.'){ //virgule
				//Recherche si une autre virgule existe
				if (HaveComma() == true)
					e.Handled = true;
				else
					e.Handled = false;	
			}
			else
				e.Handled = true;
		}

		/// <summary>
		/// se produit lorsque le focus survien
		/// </summary>
		private void CashTextBox_Enter(object sender, System.EventArgs e) {
			this.Text =  this.Text.Replace(" %", "");

			if (this.Text.EndsWith(",00"))
				this.Text =  this.Text.Replace(",00", "");
		}

		/// <summary>
		/// se produit lorsque le focus quite le controle
		/// </summary>
		private void CashTextBox_Leave(object sender, System.EventArgs e) {
			if (this.Text.Length > 0){			

				//Ajoute un 0 avant le virgule
				if (this.Text[0] == ',')
					this.Text = "0" + this.Text;

				//si il na aucune virgule ajoute ,00
				if (!HaveComma())
					if (this.Text[this.Text.Length -1] != ',')
						this.Text += ",00";

				//Ajoute les 00 apres la virgule si il ny a rien
				if (this.Text[this.Text.Length -1] == ',')
					this.Text += "00";			
			
				//Ajoute le signe de % apres le montant
				this.Text = this.Text + " %";
			}
		}

		/// <summary>
		/// Recherche si une autre virgule existe
		/// </summary>
		/// <returns></returns>
		private bool HaveComma(){
			if (this.Text.Length > 0){
				for (int i=0; i < this.Text.Length; i++){
					if (this.Text[i] == ',')
						return true;
				}
			}

			//textbox vide
			return false;
		}

		private void CashTextBox_TextChanged(object sender, System.EventArgs e) {
			//ligne bidon servant a corriger un bug.. vive le patchage
			double temp = this.Value; 
		}

		/// <summary>
		/// Donne la valeur du textbox sans le % (integer)
		/// </summary>
		public double Value{
			get{
				//if (this.Text == "") this.Text = "0 %";
				try{
					//Corrige une bug lors de la rentrer d<une virgule
					this.Text =  this.Text.Replace(".", ",");
					this.SelectionStart = this.Text.Length;

					return Convert.ToDouble(this.Text.Replace(" %", ""));
				}
				catch{
					return 0;
				}
			}			
		}

		/// <summary>
		/// Donne la valeur du textbox sans le % (integer)
		/// </summary>
		public decimal DecimalValue{
			get{
				string rtn = "";
				string cmp = "";
				
				rtn = this.Text.Replace(" %", "");
				rtn = rtn.Replace(".", ",");
				cmp = rtn.Replace(".", ",");
				rtn = rtn.Replace(",", "");

				if (Convert.ToDouble(cmp) >= 10)
					rtn = "0," + rtn;
				else 
					rtn = "0,0" + rtn;

				return Convert.ToDecimal(rtn);
			}			
		}

		/// <summary>
		/// Ajout d'un montant
		/// </summary>
		/// <param name="Amount">Montant à ajouter</param>
		public void Add(double Amount){
			double current = this.Value;
			current += Amount;

			this.Text = current.ToString() + " %"; 
		}

		/// <summary>
		/// Soustrais le montant
		/// </summary>
		/// <param name="Amount">Montant à soustraire</param>
		public void Soustract(double Amount){
			double current = this.Value;
			current -= Amount;

			this.Text = current.ToString() + " %"; 
		}
	}
}
