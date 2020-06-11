using System;

namespace Barette.Library.UserControls
{
    /// <summary>
    /// Description résumée de DecimalTextBox.
    /// </summary>	
    public class PourCentTextBox : System.Windows.Forms.TextBox {
		/// <summary> 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private readonly System.ComponentModel.Container components = null;

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
            KeyPress += new System.Windows.Forms.KeyPressEventHandler(CashTextBox_KeyPress);
            TextChanged += new EventHandler(CashTextBox_TextChanged);
            Leave += new EventHandler(CashTextBox_Leave);
            Enter += new EventHandler(CashTextBox_Enter);

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
				e.Handled = HaveComma() == true;
            }
			else
				e.Handled = true;
		}

		/// <summary>
		/// se produit lorsque le focus survien
		/// </summary>
		private void CashTextBox_Enter(object sender, EventArgs e) {
            Text = Text.Replace(" %", "");

			if (Text.EndsWith(",00"))
                Text = Text.Replace(",00", "");
		}

		/// <summary>
		/// se produit lorsque le focus quite le controle
		/// </summary>
		private void CashTextBox_Leave(object sender, EventArgs e) {
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

                //Ajoute le signe de % apres le montant
                Text = Text + " %";
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

		private void CashTextBox_TextChanged(object sender, EventArgs e) {
			//ligne bidon servant a corriger un bug.. vive le patchage
			double temp = Value; 
		}

		/// <summary>
		/// Donne la valeur du textbox sans le % (integer)
		/// </summary>
		public double Value{
			get{
				//if (this.Text == "") this.Text = "0 %";
				try{
                    //Corrige une bug lors de la rentrer d<une virgule
                    Text = Text.Replace(".", ",");
                    SelectionStart = Text.Length;

					return Convert.ToDouble(Text.Replace(" %", ""));
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
				
				rtn = Text.Replace(" %", "");
				rtn = rtn.Replace(".", ",");
				cmp = rtn.Replace(".", ",");
				rtn = rtn.Replace(",", "");

				rtn = Convert.ToDouble(cmp) >= 10 ? "0," + rtn : "0,0" + rtn;

                return Convert.ToDecimal(rtn);
			}			
		}

		/// <summary>
		/// Ajout d'un montant
		/// </summary>
		/// <param name="Amount">Montant à ajouter</param>
		public void Add(double Amount){
			double current = Value;
			current += Amount;

            Text = current.ToString() + " %"; 
		}

		/// <summary>
		/// Soustrais le montant
		/// </summary>
		/// <param name="Amount">Montant à soustraire</param>
		public void Soustract(double Amount){
			double current = Value;
			current -= Amount;

            Text = current.ToString() + " %"; 
		}
	}
}
