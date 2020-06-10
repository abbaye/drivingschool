using System;
using System.Windows.Forms;

using Barette.Library.Collections;
using Barette.Library.Client;

namespace Barette.IDE.Forms.Finance
{
    /// <summary>
    /// Description résumée de FormFinanceEtatsGlobal.
    /// </summary>
    public class FormFinanceEtatsGlobal : Form
    {
		private Label label4;
		private Label lblTPS;
		private Label label3;
		private Label lblTVQ;
		private Label label2;
		private Label lblMontantExcluTaxe;
		private Label label1;
		private Label lblMontantIncluTaxe;
		private Button cmdOK;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private readonly System.ComponentModel.Container components = null;
		private GroupBox gbEtatsGlobal;
		private Label label5;
		private Label lblTotalPaiement;
		private ComboBox cbYear;
		private Label label6;
		private GroupBox groupBox1;
		private Label label7;
		private Label label8;
		private Label label10;
		private Label label12;
		private Label label14;
		private Label label16;
		private Label label18;
		private ComboBox cbYearMois;
		private ComboBox cbMonth;
		private Label lblTotalPaiementMonth;
		private Label lblTPSMonth;
		private Label lblTVQMonth;
		private Label lblMontantExcluTaxeMonth;
		private Label lblMontantIncluTaxeMonth;

		private readonly FormFinance _formFinance;

		public FormFinanceEtatsGlobal(FormFinance finance) {
			InitializeComponent();

            _formFinance = finance; 
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
            gbEtatsGlobal = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            lblTotalPaiement = new Label();
            label4 = new Label();
            lblTPS = new Label();
            label3 = new Label();
            lblTVQ = new Label();
            label2 = new Label();
            lblMontantExcluTaxe = new Label();
            label1 = new Label();
            lblMontantIncluTaxe = new Label();
            cbYear = new ComboBox();
            cmdOK = new Button();
            groupBox1 = new GroupBox();
            label18 = new Label();
            cbMonth = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            lblTotalPaiementMonth = new Label();
            label10 = new Label();
            lblTPSMonth = new Label();
            label12 = new Label();
            lblTVQMonth = new Label();
            label14 = new Label();
            lblMontantExcluTaxeMonth = new Label();
            label16 = new Label();
            lblMontantIncluTaxeMonth = new Label();
            cbYearMois = new ComboBox();
            gbEtatsGlobal.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbEtatsGlobal
            // 
            gbEtatsGlobal.Controls.Add(label6);
            gbEtatsGlobal.Controls.Add(label5);
            gbEtatsGlobal.Controls.Add(lblTotalPaiement);
            gbEtatsGlobal.Controls.Add(label4);
            gbEtatsGlobal.Controls.Add(lblTPS);
            gbEtatsGlobal.Controls.Add(label3);
            gbEtatsGlobal.Controls.Add(lblTVQ);
            gbEtatsGlobal.Controls.Add(label2);
            gbEtatsGlobal.Controls.Add(lblMontantExcluTaxe);
            gbEtatsGlobal.Controls.Add(label1);
            gbEtatsGlobal.Controls.Add(lblMontantIncluTaxe);
            gbEtatsGlobal.Controls.Add(cbYear);
            gbEtatsGlobal.Location = new System.Drawing.Point(16, 16);
            gbEtatsGlobal.Name = "gbEtatsGlobal";
            gbEtatsGlobal.Size = new System.Drawing.Size(232, 192);
            gbEtatsGlobal.TabIndex = 17;
            gbEtatsGlobal.TabStop = false;
            gbEtatsGlobal.Text = "Informations sur l\'anné en cours";
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(10, 32);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(110, 21);
            label6.TabIndex = 20;
            label6.Text = "Année :";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(10, 64);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(110, 16);
            label5.TabIndex = 9;
            label5.Text = "Nombre de paiment :";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPaiement
            // 
            lblTotalPaiement.Location = new System.Drawing.Point(127, 64);
            lblTotalPaiement.Name = "lblTotalPaiement";
            lblTotalPaiement.Size = new System.Drawing.Size(95, 16);
            lblTotalPaiement.TabIndex = 8;
            lblTotalPaiement.Text = "-";
            lblTotalPaiement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(10, 112);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(78, 16);
            label4.TabIndex = 7;
            label4.Text = "TPS :";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTPS
            // 
            lblTPS.Location = new System.Drawing.Point(127, 112);
            lblTPS.Name = "lblTPS";
            lblTPS.Size = new System.Drawing.Size(95, 16);
            lblTPS.TabIndex = 6;
            lblTPS.Text = "-";
            lblTPS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(10, 136);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 16);
            label3.TabIndex = 5;
            label3.Text = "TVQ :";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTVQ
            // 
            lblTVQ.Location = new System.Drawing.Point(127, 136);
            lblTVQ.Name = "lblTVQ";
            lblTVQ.Size = new System.Drawing.Size(95, 16);
            lblTVQ.TabIndex = 4;
            lblTVQ.Text = "-";
            lblTVQ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(10, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 16);
            label2.TabIndex = 3;
            label2.Text = "Total partiel :";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontantExcluTaxe
            // 
            lblMontantExcluTaxe.Location = new System.Drawing.Point(127, 88);
            lblMontantExcluTaxe.Name = "lblMontantExcluTaxe";
            lblMontantExcluTaxe.Size = new System.Drawing.Size(95, 16);
            lblMontantExcluTaxe.TabIndex = 2;
            lblMontantExcluTaxe.Text = "-";
            lblMontantExcluTaxe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(10, 160);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 16);
            label1.TabIndex = 1;
            label1.Text = "Total  :";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontantIncluTaxe
            // 
            lblMontantIncluTaxe.Location = new System.Drawing.Point(127, 160);
            lblMontantIncluTaxe.Name = "lblMontantIncluTaxe";
            lblMontantIncluTaxe.Size = new System.Drawing.Size(95, 16);
            lblMontantIncluTaxe.TabIndex = 0;
            lblMontantIncluTaxe.Text = "-";
            lblMontantIncluTaxe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbYear
            // 
            cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbYear.FormattingEnabled = true;
            cbYear.Items.AddRange(new object[] {
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
            cbYear.Location = new System.Drawing.Point(127, 32);
            cbYear.Name = "cbYear";
            cbYear.Size = new System.Drawing.Size(97, 21);
            cbYear.Sorted = true;
            cbYear.TabIndex = 19;
            cbYear.SelectedIndexChanged += new EventHandler(cbYear_SelectedIndexChanged);
            // 
            // cmdOK
            // 
            cmdOK.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdOK.Location = new System.Drawing.Point(421, 216);
            cmdOK.Name = "cmdOK";
            cmdOK.Size = new System.Drawing.Size(75, 23);
            cmdOK.TabIndex = 18;
            cmdOK.Text = "OK";
            cmdOK.Click += new EventHandler(cmdOK_Click);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(cbMonth);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lblTotalPaiementMonth);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lblTPSMonth);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(lblTVQMonth);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(lblMontantExcluTaxeMonth);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(lblMontantIncluTaxeMonth);
            groupBox1.Controls.Add(cbYearMois);
            groupBox1.Location = new System.Drawing.Point(256, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(240, 192);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informations sur le mois ";
            // 
            // label18
            // 
            label18.Location = new System.Drawing.Point(9, 40);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(110, 21);
            label18.TabIndex = 22;
            label18.Text = "Mois :";
            label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMonth
            // 
            cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbMonth.FormattingEnabled = true;
            cbMonth.Items.AddRange(new object[] {
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
            cbMonth.Location = new System.Drawing.Point(126, 40);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new System.Drawing.Size(106, 21);
            cbMonth.TabIndex = 21;
            cbMonth.SelectedIndexChanged += new EventHandler(cbYearMois_SelectedIndexChanged);
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(10, 18);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(110, 21);
            label7.TabIndex = 20;
            label7.Text = "Année :";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Location = new System.Drawing.Point(10, 72);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(110, 16);
            label8.TabIndex = 9;
            label8.Text = "Nombre de paiment :";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPaiementMonth
            // 
            lblTotalPaiementMonth.Location = new System.Drawing.Point(126, 72);
            lblTotalPaiementMonth.Name = "lblTotalPaiementMonth";
            lblTotalPaiementMonth.Size = new System.Drawing.Size(104, 16);
            lblTotalPaiementMonth.TabIndex = 8;
            lblTotalPaiementMonth.Text = "-";
            lblTotalPaiementMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Location = new System.Drawing.Point(10, 120);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(78, 16);
            label10.TabIndex = 7;
            label10.Text = "TPS :";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTPSMonth
            // 
            lblTPSMonth.Location = new System.Drawing.Point(126, 120);
            lblTPSMonth.Name = "lblTPSMonth";
            lblTPSMonth.Size = new System.Drawing.Size(104, 16);
            lblTPSMonth.TabIndex = 6;
            lblTPSMonth.Text = "-";
            lblTPSMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.Location = new System.Drawing.Point(10, 144);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(78, 16);
            label12.TabIndex = 5;
            label12.Text = "TVQ :";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTVQMonth
            // 
            lblTVQMonth.Location = new System.Drawing.Point(126, 144);
            lblTVQMonth.Name = "lblTVQMonth";
            lblTVQMonth.Size = new System.Drawing.Size(104, 16);
            lblTVQMonth.TabIndex = 4;
            lblTVQMonth.Text = "-";
            lblTVQMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.Location = new System.Drawing.Point(10, 96);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(78, 16);
            label14.TabIndex = 3;
            label14.Text = "Total partiel :";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontantExcluTaxeMonth
            // 
            lblMontantExcluTaxeMonth.Location = new System.Drawing.Point(126, 96);
            lblMontantExcluTaxeMonth.Name = "lblMontantExcluTaxeMonth";
            lblMontantExcluTaxeMonth.Size = new System.Drawing.Size(104, 16);
            lblMontantExcluTaxeMonth.TabIndex = 2;
            lblMontantExcluTaxeMonth.Text = "-";
            lblMontantExcluTaxeMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            label16.Location = new System.Drawing.Point(10, 168);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(78, 16);
            label16.TabIndex = 1;
            label16.Text = "Total  :";
            label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontantIncluTaxeMonth
            // 
            lblMontantIncluTaxeMonth.Location = new System.Drawing.Point(126, 168);
            lblMontantIncluTaxeMonth.Name = "lblMontantIncluTaxeMonth";
            lblMontantIncluTaxeMonth.Size = new System.Drawing.Size(104, 16);
            lblMontantIncluTaxeMonth.TabIndex = 0;
            lblMontantIncluTaxeMonth.Text = "-";
            lblMontantIncluTaxeMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbYearMois
            // 
            cbYearMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbYearMois.FormattingEnabled = true;
            cbYearMois.Items.AddRange(new object[] {
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
            cbYearMois.Location = new System.Drawing.Point(126, 16);
            cbYearMois.Name = "cbYearMois";
            cbYearMois.Size = new System.Drawing.Size(106, 21);
            cbYearMois.Sorted = true;
            cbYearMois.TabIndex = 19;
            cbYearMois.SelectedIndexChanged += new EventHandler(cbYearMois_SelectedIndexChanged);
            // 
            // FormFinanceEtatsGlobal
            // 
            ClientSize = new System.Drawing.Size(506, 246);
            Controls.Add(groupBox1);
            Controls.Add(cmdOK);
            Controls.Add(gbEtatsGlobal);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFinanceEtatsGlobal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "États Global";
            gbEtatsGlobal.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void cmdOK_Click(object sender, EventArgs e) {
            Close();
		}

		/// <summary>
		/// Recherche par date de recu
		/// </summary>
		private void CalculeInfos(){
			CustomerCollection ClientList = _formFinance._FormMain.ClientList;
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

			tps = TotalSansTaxe * _formFinance.txtTPS.DecimalValue;				
			tvq = (TotalSansTaxe + tps) * _formFinance.txtTVQ.DecimalValue;  
			
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
			CustomerCollection ClientList = _formFinance._FormMain.ClientList;
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

			tps = TotalSansTaxe * _formFinance.txtTPS.DecimalValue;				
			tvq = (TotalSansTaxe + tps) * _formFinance.txtTVQ.DecimalValue;  
			
			lblTPSMonth.Text = Decimal.Round(tps, 2).ToString() + " $";
			lblTVQMonth.Text = Decimal.Round(tvq, 2).ToString() + " $";
			lblMontantExcluTaxeMonth.Text = Decimal.Round(TotalSansTaxe, 2).ToString() + " $";
			lblMontantIncluTaxeMonth.Text = Decimal.Round(Total, 2).ToString() + " $";
			lblTotalPaiementMonth.Text = compteur.ToString();
		}

		private void cbYear_SelectedIndexChanged(object sender, EventArgs e) {
			CalculeInfos();
		}

		private void cbYearMois_SelectedIndexChanged(object sender, EventArgs e) {
			CalculeInfosMonth();
		}
	}
}
