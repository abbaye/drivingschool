using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Barette.Library.UserControls {
	/// <summary>
	/// Description r�sum�e de DecimalTextBox.
	/// </summary>	
	public class CashTextBox : System.Windows.Forms.TextBox {
		/// <summary> 
		/// Variable n�cessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CashTextBox() {

			// Cet appel est requis par le Concepteur de formulaires Windows.Forms.
			InitializeComponent();
		}

		/// <summary> 
		/// Nettoyage des ressources utilis�es.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Code g�n�r� par le Concepteur de composants
		/// <summary> 
		/// M�thode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette m�thode avec l'�diteur de code.
		/// </summary>
		private void InitializeComponent() {
            // 
            // CashTextBox
            // 
            KeyPress += new System.Windows.Forms.KeyPressEventHandler(CashTextBox_KeyPress);
            TextChanged += new System.EventHandler(CashTextBox_TextChanged);
            Leave += new System.EventHandler(CashTextBox_Leave);
            Enter += new System.EventHandler(CashTextBox_Enter);

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
			} else if (key == '-') {
				int Position = -1;
				if (HaveMinus(out Position) == true) {
					e.Handled = true;
				} else if (SelectionStart == 0) {
					e.Handled = false;
				} else
					e.Handled = true;

			} else
				e.Handled = true;
		}

		/// <summary>
		/// se produit lorsque le focus survien
		/// </summary>
		private void CashTextBox_Enter(object sender, System.EventArgs e) {
            Text = Text.Replace(" $", "");

			if (Text.EndsWith(",00"))
                Text = Text.Replace(",00", "");
		}

		/// <summary>
		/// se produit lorsque le focus quite le controle
		/// </summary>
		private void CashTextBox_Leave(object sender, System.EventArgs e) {
			if (Text.Length > 0){			

				//Ajoute un 0 avant le virgule
				if (Text[0] == ',')
                    Text = "0" + Text;

				//si il na aucune virgule ajoute ,00
				if (!HaveComma())
					if (Text[Text.Length -1] != ',')
                        Text += ",00";

				//Ajoute les 00 apres la virgule si il ny a rien
				if (Text[Text.Length -1] == ',')
                    Text += "00";

                //Ajoute le signe de $ apres le montant
                Text = Text + " $";
			}
		}

		/// <summary>
		/// Recherche si une autre virgule existe
		/// </summary>
		/// <returns></returns>
		private bool HaveComma(){
			if (Text.Length > 0){
				for (int i=0; i < Text.Length; i++){
					if (Text[i] == ',')
						return true;
				}
			}

			//textbox vide
			return false;
		}

		/// <summary>
		/// Recherche s'il y a deja le signe moins
		/// </summary>
		/// <param name="Position"></param>
		/// <returns></returns>
		private bool HaveMinus(out int Position) {
			Position = -1;

			if (Text.Length > 0) {
				for (int i = 0; i < Text.Length; i++) {
					if (Text[i] == '-') {
						Position = i;
						return true;
					}
				}
			}

			//textbox vide
			return false;
		}


		private void CashTextBox_TextChanged(object sender, System.EventArgs e) {
			//ligne bidon servant a corriger un bug.. vive le patchage
			double temp = Value; 
		}

		/// <summary>
		/// Donne la valeur du textbox sans le $ (integer)
		/// </summary>
		public double Value{
			get{
				//if (this.Text == "") this.Text = "0 $";
				try{
                    //Corrige une bug lors de la rentrer d<une virgule
                    Text = Text.Replace(".", ",");
                    SelectionStart = Text.Length;

					return Convert.ToDouble(Text.Replace(" $", ""));
				}
				catch{
					return 0;
				}
			}			
		}

		/// <summary>
		/// Ajout d'un montant
		/// </summary>
		/// <param name="Amount">Montant � ajouter</param>
		public void Add(double Amount){
			double current = Value;
			current += Amount;

            Text = current.ToString() + " $"; 
		}

		/// <summary>
		/// Soustrais le montant
		/// </summary>
		/// <param name="Amount">Montant � soustraire</param>
		public void Soustract(double Amount){
			double current = Value;
			current -= Amount;

            Text = current.ToString() + " $"; 
		}
	}
}
