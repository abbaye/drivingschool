using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Text; 
using System.IO; 

namespace Barette.Library.Forms {
	/// <summary>
	/// Description résumée de FormScéanceCode.
	/// </summary>
	public class FormSeanceCode : System.Windows.Forms.Form {
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ListView lvCode;
		private System.Windows.Forms.Button cmdAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtDefinitions;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button cmdCancel;
		private ToolBar tbCode;
		private ToolBarButton tbbAddPaiment;
		private ToolBarButton tbbDelete;
		private ImageList imageListLarge;
		private Timer TimerButton;
		private IContainer components;

        private Config _AppConfig;

		public FormSeanceCode(Config appconfig) {
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

            this._AppConfig = appconfig;

			//Charge la liste de code
			LoadCode();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeanceCode));
            this.lvCode = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtDefinitions = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.tbCode = new System.Windows.Forms.ToolBar();
            this.tbbAddPaiment = new System.Windows.Forms.ToolBarButton();
            this.tbbDelete = new System.Windows.Forms.ToolBarButton();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.TimerButton = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCode
            // 
            this.lvCode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvCode.FullRowSelect = true;
            this.lvCode.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCode.Location = new System.Drawing.Point(12, 60);
            this.lvCode.Name = "lvCode";
            this.lvCode.Size = new System.Drawing.Size(272, 256);
            this.lvCode.TabIndex = 0;
            this.lvCode.UseCompatibleStateImageBehavior = false;
            this.lvCode.View = System.Windows.Forms.View.Details;
            this.lvCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvCode_KeyUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codes";
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Définitions";
            this.columnHeader2.Width = 182;
            // 
            // button1
            // 
            this.button1.Image = global::Barette.Library.Properties.Resources.accept_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(411, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Appliquer";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = global::Barette.Library.Properties.Resources.add_icon;
            this.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAdd.Location = new System.Drawing.Point(213, 94);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(91, 41);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Text = "Ajouter ";
            this.cmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.txtDefinitions);
            this.groupBox1.Controls.Add(this.cmdAdd);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(291, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 144);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un code";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Définitions";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCode
            // 
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Location = new System.Drawing.Point(120, 24);
            this.txtCode.MaxLength = 4;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 0;
            // 
            // txtDefinitions
            // 
            this.txtDefinitions.AcceptsReturn = true;
            this.txtDefinitions.Location = new System.Drawing.Point(120, 56);
            this.txtDefinitions.MaxLength = 50;
            this.txtDefinitions.Name = "txtDefinitions";
            this.txtDefinitions.Size = new System.Drawing.Size(184, 20);
            this.txtDefinitions.TabIndex = 1;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(515, 316);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(87, 42);
            this.cmdCancel.TabIndex = 6;
            this.cmdCancel.Text = "Annuler ";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // tbCode
            // 
            this.tbCode.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbCode.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbAddPaiment,
            this.tbbDelete});
            this.tbCode.Divider = false;
            this.tbCode.Dock = System.Windows.Forms.DockStyle.None;
            this.tbCode.DropDownArrows = true;
            this.tbCode.ImageList = this.imageListLarge;
            this.tbCode.Location = new System.Drawing.Point(10, 12);
            this.tbCode.Name = "tbCode";
            this.tbCode.ShowToolTips = true;
            this.tbCode.Size = new System.Drawing.Size(252, 42);
            this.tbCode.TabIndex = 27;
            this.tbCode.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.tbCode.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbCode_ButtonClick);
            // 
            // tbbAddPaiment
            // 
            this.tbbAddPaiment.ImageIndex = 1;
            this.tbbAddPaiment.Name = "tbbAddPaiment";
            this.tbbAddPaiment.Tag = "ADD";
            this.tbbAddPaiment.Text = "Nouveau";
            this.tbbAddPaiment.ToolTipText = "Nouveau Paiment";
            // 
            // tbbDelete
            // 
            this.tbbDelete.ImageIndex = 0;
            this.tbbDelete.Name = "tbbDelete";
            this.tbbDelete.Tag = "DELETE";
            this.tbbDelete.Text = "Supprimer";
            this.tbbDelete.ToolTipText = "Effacer un Paiment";
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "delete-icon.png");
            this.imageListLarge.Images.SetKeyName(1, "add-icon.png");
            // 
            // TimerButton
            // 
            this.TimerButton.Enabled = true;
            this.TimerButton.Interval = 250;
            this.TimerButton.Tick += new System.EventHandler(this.TimerButton_Tick);
            // 
            // FormSeanceCode
            // 
            this.AcceptButton = this.button1;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(612, 368);
            this.ControlBox = false;
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSeanceCode";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste de codes de séances";
            this.Load += new System.EventHandler(this.FormScéanceCode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void FormScéanceCode_Load(object sender, System.EventArgs e) {
		
		}

		private void button1_Click(object sender, System.EventArgs e) {
			this.SaveCode();
			this.Close(); //Fermer la dialog			
		}

		/// <summary>
		/// Effacer la sélection
		/// </summary>
		private void DeleteSelection() {
			if (lvCode.SelectedItems.Count > 0){
				DialogResult result = MessageBox.Show(this, "Voulez vous vraiment supprimer ce code?", _AppConfig.ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
					lvCode.SelectedItems[0].Remove();
			}
		}

		private void cmdAdd_Click(object sender, System.EventArgs e) {
			if (txtCode.Text != "" && txtDefinitions.Text != ""){
				string[] str= new string[2]{txtCode.Text, txtDefinitions.Text}; 
				ListViewItem itm = new ListViewItem(str);
				lvCode.Items.Add(itm); 
			}
			else
                MessageBox.Show(this, "Veuillez inscrire un code et une définition SVP.", _AppConfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void SaveCode() {
			try{
				XmlTextWriter myWriter = new XmlTextWriter(@"Data\code.xml", Encoding.Unicode);  
				myWriter.Formatting = Formatting.Indented;
			
				//Header avec la version
				myWriter.WriteStartElement("ECBCodeSeance");
				myWriter.WriteAttributeString("Version", "1.0");
					
				//Ecriture des code 
				myWriter.WriteStartElement("BarretteCode");
				myWriter.WriteAttributeString("Count", Convert.ToString(this.lvCode.Items.Count));
				if (this.lvCode.Items.Count > 0){
					for(int i=0; i<this.lvCode.Items.Count; i++){
						CodeSeance code = new CodeSeance(lvCode.Items[i].Text, lvCode.Items[i].SubItems[1].Text); 
						myWriter.WriteStartElement("Client");
						myWriter.WriteAttributeString("Code", code.code); 
						myWriter.WriteAttributeString("Definition", code.definition); 	
						myWriter.WriteEndElement();	
					}		
				}
				myWriter.WriteEndElement();
	
				//Fermeture du tag
				myWriter.WriteEndElement();

				//Fermeture du fichier
				myWriter.Close();	
							
			}
			catch{
			}
		}

		/// <summary>
		/// Chargement de la liste des clients
		/// </summary>
		private void LoadCode() {
			
			if (File.Exists(@"Data\code.xml")){
				//Creation du reader
				XmlDocument doc = new XmlDocument();
				XmlTextReader reader = new XmlTextReader(@"Data\code.xml");
			
				//Lecture du document
				doc.Load(reader);

				//Lecture des includes : TextFile
				XmlNodeList CodeNodes = doc.ChildNodes.Item(0).ChildNodes;
				XmlNodeList AllCode = doc.ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes;
					
				//Chargement de la liste de client
				XmlNode node = null;
				for (int i=0; i<AllCode.Count; i++){
					//client
					node = AllCode[i];
					
					string[] str= new string[2]{node.Attributes["Code"].Value,
												   node.Attributes["Definition"].Value}; 
					ListViewItem itm = new ListViewItem(str);
					
					//Ajout du code
					lvCode.Items.Add(itm); 
				}
			}
		}

		/// <summary>
		/// Nouveau code
		/// </summary>
		private void NewCodeSeance() {
			txtCode.Text = "";
			txtDefinitions.Text = "";
			txtCode.Focus();
		}

		private void cmdCancel_Click(object sender, System.EventArgs e) {
			this.Close();
		}

		private void tbCode_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
			switch (e.Button.Tag.ToString()) {
				case "ADD":
					NewCodeSeance();
					break;
				case "DELETE":
					DeleteSelection();
					break;
			}
		}

		private void TimerButton_Tick(object sender, EventArgs e) {
			if (lvCode.SelectedItems.Count > 0)
				tbbDelete.Enabled = true;
			else
				tbbDelete.Enabled = false;
		}

		private void lvCode_KeyUp(object sender, KeyEventArgs e) {
			switch (e.KeyCode) {
				case Keys.Delete:
					DeleteSelection();
					break;
			}
		}
	}
}
