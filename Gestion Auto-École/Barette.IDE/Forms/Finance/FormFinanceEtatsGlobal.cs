using System;
using Barette.Library.Client;
using Barette.Library.Collections;

namespace Barette.IDE.Forms.Finance {
	/// <summary>
	/// Description résumée de FormFinanceEtatsGlobal.
	/// </summary>
	public class FormFinanceEtatsGlobal : System.Windows.Forms.Form {
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblTPS;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTVQ;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblMontantExcluTaxe;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblMontantIncluTaxe;
		private System.Windows.Forms.Button cmdOK;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.GroupBox gbEtatsGlobal;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblTotalPaiement;
		private System.Windows.Forms.ComboBox cbYear;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox cbYearMois;
		private System.Windows.Forms.ComboBox cbMonth;
		private System.Windows.Forms.Label lblTotalPaiementMonth;
		private System.Windows.Forms.Label lblTPSMonth;
		private System.Windows.Forms.Label lblTVQMonth;
		private System.Windows.Forms.Label lblMontantExcluTaxeMonth;
		private System.Windows.Forms.Label lblMontantIncluTaxeMonth;

		private FormFinance _formFinance;

		public FormFinanceEtatsGlobal(FormFinance finance) {
			InitializeComponent();

			this._formFinance = finance; 
			cbYearMois.Text = cbYear.Text = DateTime.Now.Year.ToString();
			cbMonth.SelectedIndex =  DateTime.Now.Month - 1; 
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

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinanceEtatsGlobal));
            this.gbEtatsGlobal = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalPaiement = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTPS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTVQ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMontantExcluTaxe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMontantIncluTaxe = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalPaiementMonth = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTPSMonth = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTVQMonth = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblMontantExcluTaxeMonth = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblMontantIncluTaxeMonth = new System.Windows.Forms.Label();
            this.cbYearMois = new System.Windows.Forms.ComboBox();
            this.gbEtatsGlobal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEtatsGlobal
            // 
            this.gbEtatsGlobal.Controls.Add(this.label6);
            this.gbEtatsGlobal.Controls.Add(this.label5);
            this.gbEtatsGlobal.Controls.Add(this.lblTotalPaiement);
            this.gbEtatsGlobal.Controls.Add(this.label4);
            this.gbEtatsGlobal.Controls.Add(this.lblTPS);
            this.gbEtatsGlobal.Controls.Add(this.label3);
            this.gbEtatsGlobal.Controls.Add(this.lblTVQ);
            this.gbEtatsGlobal.Controls.Add(this.label2);
            this.gbEtatsGlobal.Controls.Add(this.lblMontantExcluTaxe);
            this.gbEtatsGlobal.Controls.Add(this.label1);
            this.gbEtatsGlobal.Controls.Add(this.lblMontantIncluTaxe);
            this.gbEtatsGlobal.Controls.Add(this.cbYear);
            this.gbEtatsGlobal.Location = new System.Drawing.Point(16, 16);
            this.gbEtatsGlobal.Name = "gbEtatsGlobal";
            this.gbEtatsGlobal.Size = new System.Drawing.Size(232, 192);
            this.gbEtatsGlobal.TabIndex = 17;
            this.gbEtatsGlobal.TabStop = false;
            this.gbEtatsGlobal.Text = "Informations sur l\'anné en cours";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Année :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre de paiment :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPaiement
            // 
            this.lblTotalPaiement.Location = new System.Drawing.Point(127, 64);
            this.lblTotalPaiement.Name = "lblTotalPaiement";
            this.lblTotalPaiement.Size = new System.Drawing.Size(95, 16);
            this.lblTotalPaiement.TabIndex = 8;
            this.lblTotalPaiement.Text = "-";
            this.lblTotalPaiement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "TPS :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTPS
            // 
            this.lblTPS.Location = new System.Drawing.Point(127, 112);
            this.lblTPS.Name = "lblTPS";
            this.lblTPS.Size = new System.Drawing.Size(95, 16);
            this.lblTPS.TabIndex = 6;
            this.lblTPS.Text = "-";
            this.lblTPS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "TVQ :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTVQ
            // 
            this.lblTVQ.Location = new System.Drawing.Point(127, 136);
            this.lblTVQ.Name = "lblTVQ";
            this.lblTVQ.Size = new System.Drawing.Size(95, 16);
            this.lblTVQ.TabIndex = 4;
            this.lblTVQ.Text = "-";
            this.lblTVQ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total partiel :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontantExcluTaxe
            // 
            this.lblMontantExcluTaxe.Location = new System.Drawing.Point(127, 88);
            this.lblMontantExcluTaxe.Name = "lblMontantExcluTaxe";
            this.lblMontantExcluTaxe.Size = new System.Drawing.Size(95, 16);
            this.lblMontantExcluTaxe.TabIndex = 2;
            this.lblMontantExcluTaxe.Text = "-";
            this.lblMontantExcluTaxe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total  :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontantIncluTaxe
            // 
            this.lblMontantIncluTaxe.Location = new System.Drawing.Point(127, 160);
            this.lblMontantIncluTaxe.Name = "lblMontantIncluTaxe";
            this.lblMontantIncluTaxe.Size = new System.Drawing.Size(95, 16);
            this.lblMontantIncluTaxe.TabIndex = 0;
            this.lblMontantIncluTaxe.Text = "-";
            this.lblMontantIncluTaxe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbYear.Location = new System.Drawing.Point(127, 32);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(97, 21);
            this.cbYear.Sorted = true;
            this.cbYear.TabIndex = 19;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdOK.Location = new System.Drawing.Point(421, 216);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 18;
            this.cmdOK.Text = "OK";
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cbMonth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblTotalPaiementMonth);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblTPSMonth);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblTVQMonth);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblMontantExcluTaxeMonth);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lblMontantIncluTaxeMonth);
            this.groupBox1.Controls.Add(this.cbYearMois);
            this.groupBox1.Location = new System.Drawing.Point(256, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 192);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations sur le mois ";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(9, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 21);
            this.label18.TabIndex = 22;
            this.label18.Text = "Mois :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Août",
            "Septembre",
            "Octobre",
            "Novembre",
            "Décembre"});
            this.cbMonth.Location = new System.Drawing.Point(126, 40);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(106, 21);
            this.cbMonth.TabIndex = 21;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbYearMois_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Année :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(10, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nombre de paiment :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPaiementMonth
            // 
            this.lblTotalPaiementMonth.Location = new System.Drawing.Point(126, 72);
            this.lblTotalPaiementMonth.Name = "lblTotalPaiementMonth";
            this.lblTotalPaiementMonth.Size = new System.Drawing.Size(104, 16);
            this.lblTotalPaiementMonth.TabIndex = 8;
            this.lblTotalPaiementMonth.Text = "-";
            this.lblTotalPaiementMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(10, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "TPS :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTPSMonth
            // 
            this.lblTPSMonth.Location = new System.Drawing.Point(126, 120);
            this.lblTPSMonth.Name = "lblTPSMonth";
            this.lblTPSMonth.Size = new System.Drawing.Size(104, 16);
            this.lblTPSMonth.TabIndex = 6;
            this.lblTPSMonth.Text = "-";
            this.lblTPSMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(10, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "TVQ :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTVQMonth
            // 
            this.lblTVQMonth.Location = new System.Drawing.Point(126, 144);
            this.lblTVQMonth.Name = "lblTVQMonth";
            this.lblTVQMonth.Size = new System.Drawing.Size(104, 16);
            this.lblTVQMonth.TabIndex = 4;
            this.lblTVQMonth.Text = "-";
            this.lblTVQMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(10, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Total partiel :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontantExcluTaxeMonth
            // 
            this.lblMontantExcluTaxeMonth.Location = new System.Drawing.Point(126, 96);
            this.lblMontantExcluTaxeMonth.Name = "lblMontantExcluTaxeMonth";
            this.lblMontantExcluTaxeMonth.Size = new System.Drawing.Size(104, 16);
            this.lblMontantExcluTaxeMonth.TabIndex = 2;
            this.lblMontantExcluTaxeMonth.Text = "-";
            this.lblMontantExcluTaxeMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(10, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "Total  :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontantIncluTaxeMonth
            // 
            this.lblMontantIncluTaxeMonth.Location = new System.Drawing.Point(126, 168);
            this.lblMontantIncluTaxeMonth.Name = "lblMontantIncluTaxeMonth";
            this.lblMontantIncluTaxeMonth.Size = new System.Drawing.Size(104, 16);
            this.lblMontantIncluTaxeMonth.TabIndex = 0;
            this.lblMontantIncluTaxeMonth.Text = "-";
            this.lblMontantIncluTaxeMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbYearMois
            // 
            this.cbYearMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYearMois.FormattingEnabled = true;
            this.cbYearMois.Items.AddRange(new object[] {
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbYearMois.Location = new System.Drawing.Point(126, 16);
            this.cbYearMois.Name = "cbYearMois";
            this.cbYearMois.Size = new System.Drawing.Size(106, 21);
            this.cbYearMois.Sorted = true;
            this.cbYearMois.TabIndex = 19;
            this.cbYearMois.SelectedIndexChanged += new System.EventHandler(this.cbYearMois_SelectedIndexChanged);
            // 
            // FormFinanceEtatsGlobal
            // 
            this.ClientSize = new System.Drawing.Size(506, 246);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.gbEtatsGlobal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFinanceEtatsGlobal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "États Global";
            this.gbEtatsGlobal.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void cmdOK_Click(object sender, System.EventArgs e) {
			this.Close();
		}

		/// <summary>
		/// Recherche par date de recu
		/// </summary>
		private void CalculeInfos(){
			CustomerCollection ClientList = this._formFinance._FormMain.ClientList;
			Paiement paiment = null; 
			decimal tps = 0;
			decimal tvq = 0;
			decimal montant = 0;
			decimal Total = 0;
			decimal TotalSansTaxe = 0;
			const decimal VariableTaxe = 115.025M;
			int compteur = 0;
			
			lblTPS.Text = "0,00 $";
			lblTVQ.Text = "0,00 $";
			lblMontantExcluTaxe.Text = "0,00 $";
			lblMontantIncluTaxe.Text = "0,00 $";

			for(int i=0; i < ClientList.Count; i++){ 
				for(int j=0; j < ClientList[i].Paiment.Count; j++){ 
					paiment = ClientList[i].Paiment[j]; 

					if (paiment.DatePaiment.Date.Year.ToString() == cbYear.Text){
						montant = Convert.ToDecimal(paiment.Montant.Replace(" $", ""));
						TotalSansTaxe += (montant / VariableTaxe) * 100;				
						Total += montant;
						compteur++;
					}
				}
			}

			tps = TotalSansTaxe * this._formFinance.txtTPS.DecimalValue;				
			tvq = (TotalSansTaxe + tps) * this._formFinance.txtTVQ.DecimalValue;  
			
			lblTPS.Text = Decimal.Round(tps, 2).ToString() + " $";
			lblTVQ.Text = Decimal.Round(tvq, 2).ToString() + " $";
			lblMontantExcluTaxe.Text = Decimal.Round(TotalSansTaxe, 2).ToString() + " $";
			lblMontantIncluTaxe.Text = Decimal.Round(Total, 2).ToString() + " $";
			lblTotalPaiement.Text = compteur.ToString();
		}

		/// <summary>
		/// Recherche par date de recu
		/// </summary>
		private void CalculeInfosMonth(){
			CustomerCollection ClientList = this._formFinance._FormMain.ClientList;
			Paiement paiment = null; 
			decimal tps = 0;
			decimal tvq = 0;
			decimal montant = 0;
			decimal Total = 0;
			decimal TotalSansTaxe = 0;
			const decimal VariableTaxe = 115.025M;
			int compteur = 0;
			
			lblTPSMonth.Text = "0,00 $";
			lblTVQMonth.Text = "0,00 $";
			lblMontantExcluTaxeMonth.Text = "0,00 $";
			lblMontantIncluTaxeMonth.Text = "0,00 $";

			for(int i=0; i < ClientList.Count; i++){ 
				for(int j=0; j < ClientList[i].Paiment.Count; j++){ 
					paiment = ClientList[i].Paiment[j]; 

					if (paiment.DatePaiment.Date.Year.ToString() == cbYearMois.Text && 
						paiment.DatePaiment.Date.Month == cbMonth.SelectedIndex + 1){
						montant = Convert.ToDecimal(paiment.Montant.Replace(" $", ""));
						TotalSansTaxe += (montant / VariableTaxe) * 100;				
						Total += montant;
						compteur++;
					}
				}
			}

			tps = TotalSansTaxe * this._formFinance.txtTPS.DecimalValue;				
			tvq = (TotalSansTaxe + tps) * this._formFinance.txtTVQ.DecimalValue;  
			
			lblTPSMonth.Text = Decimal.Round(tps, 2).ToString() + " $";
			lblTVQMonth.Text = Decimal.Round(tvq, 2).ToString() + " $";
			lblMontantExcluTaxeMonth.Text = Decimal.Round(TotalSansTaxe, 2).ToString() + " $";
			lblMontantIncluTaxeMonth.Text = Decimal.Round(Total, 2).ToString() + " $";
			lblTotalPaiementMonth.Text = compteur.ToString();
		}

		private void cbYear_SelectedIndexChanged(object sender, System.EventArgs e) {
			CalculeInfos();
		}

		private void cbYearMois_SelectedIndexChanged(object sender, System.EventArgs e) {
			CalculeInfosMonth();
		}
	}
}
