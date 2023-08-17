using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Text;
using System.IO;

namespace Barette.Library.Forms
{
    /// <summary>
    /// Description résumée de FormScéanceCode.
    /// </summary>
    public class FormSeanceCode : Form
    {
		private Button button1;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ListView lvCode;
		private Button cmdAdd;
		private GroupBox groupBox1;
		private TextBox txtDefinitions;
		private TextBox txtCode;
		private Label label1;
		private Label label2;
		private Button cmdCancel;
		private ToolBar tbCode;
		private ToolBarButton tbbAddPaiment;
		private ToolBarButton tbbDelete;
		private ImageList imageListLarge;
		private Timer TimerButton;
		private IContainer components;

        private readonly Config _AppConfig;

		public FormSeanceCode(Config appconfig) {
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

            _AppConfig = appconfig;

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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormSeanceCode));
            lvCode = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button1 = new Button();
            cmdAdd = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtCode = new TextBox();
            txtDefinitions = new TextBox();
            cmdCancel = new Button();
            tbCode = new ToolBar();
            tbbAddPaiment = new ToolBarButton();
            tbbDelete = new ToolBarButton();
            imageListLarge = new ImageList(components);
            TimerButton = new Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lvCode
            // 
            lvCode.Columns.AddRange(new ColumnHeader[] {
            columnHeader1,
            columnHeader2});
            lvCode.FullRowSelect = true;
            lvCode.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            lvCode.Location = new System.Drawing.Point(12, 60);
            lvCode.Name = "lvCode";
            lvCode.Size = new System.Drawing.Size(272, 256);
            lvCode.TabIndex = 0;
            lvCode.UseCompatibleStateImageBehavior = false;
            lvCode.View = System.Windows.Forms.View.Details;
            lvCode.KeyUp += new KeyEventHandler(lvCode_KeyUp);
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Codes";
            columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Définitions";
            columnHeader2.Width = 182;
            // 
            // button1
            // 
            button1.Image = global::Barette.Library.Properties.Resources.accept_icon;
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Location = new System.Drawing.Point(411, 316);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(100, 42);
            button1.TabIndex = 5;
            button1.Text = "Appliquer";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button1.Click += new EventHandler(button1_Click);
            // 
            // cmdAdd
            // 
            cmdAdd.Image = global::Barette.Library.Properties.Resources.add_icon;
            cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdAdd.Location = new System.Drawing.Point(213, 94);
            cmdAdd.Name = "cmdAdd";
            cmdAdd.Size = new System.Drawing.Size(91, 41);
            cmdAdd.TabIndex = 2;
            cmdAdd.Text = "Ajouter ";
            cmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdAdd.Click += new EventHandler(cmdAdd_Click);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(txtDefinitions);
            groupBox1.Controls.Add(cmdAdd);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox1.Location = new System.Drawing.Point(291, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(311, 144);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ajouter un code";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(16, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 23);
            label2.TabIndex = 7;
            label2.Text = "Définitions";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(16, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 23);
            label1.TabIndex = 6;
            label1.Text = "Code";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCode
            // 
            txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            txtCode.Location = new System.Drawing.Point(120, 24);
            txtCode.MaxLength = 4;
            txtCode.Name = "txtCode";
            txtCode.Size = new System.Drawing.Size(100, 20);
            txtCode.TabIndex = 0;
            // 
            // txtDefinitions
            // 
            txtDefinitions.AcceptsReturn = true;
            txtDefinitions.Location = new System.Drawing.Point(120, 56);
            txtDefinitions.MaxLength = 50;
            txtDefinitions.Name = "txtDefinitions";
            txtDefinitions.Size = new System.Drawing.Size(184, 20);
            txtDefinitions.TabIndex = 1;
            // 
            // cmdCancel
            // 
            cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmdCancel.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdCancel.Location = new System.Drawing.Point(515, 316);
            cmdCancel.Name = "cmdCancel";
            cmdCancel.Size = new System.Drawing.Size(87, 42);
            cmdCancel.TabIndex = 6;
            cmdCancel.Text = "Annuler ";
            cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdCancel.Click += new EventHandler(cmdCancel_Click);
            // 
            // tbCode
            // 
            tbCode.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            tbCode.Buttons.AddRange(new ToolBarButton[] {
            tbbAddPaiment,
            tbbDelete});
            tbCode.Divider = false;
            tbCode.Dock = System.Windows.Forms.DockStyle.None;
            tbCode.DropDownArrows = true;
            tbCode.ImageList = imageListLarge;
            tbCode.Location = new System.Drawing.Point(10, 12);
            tbCode.Name = "tbCode";
            tbCode.ShowToolTips = true;
            tbCode.Size = new System.Drawing.Size(252, 42);
            tbCode.TabIndex = 27;
            tbCode.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            tbCode.ButtonClick += new ToolBarButtonClickEventHandler(tbCode_ButtonClick);
            // 
            // tbbAddPaiment
            // 
            tbbAddPaiment.ImageIndex = 1;
            tbbAddPaiment.Name = "tbbAddPaiment";
            tbbAddPaiment.Tag = "ADD";
            tbbAddPaiment.Text = "Nouveau";
            tbbAddPaiment.ToolTipText = "Nouveau Paiment";
            // 
            // tbbDelete
            // 
            tbbDelete.ImageIndex = 0;
            tbbDelete.Name = "tbbDelete";
            tbbDelete.Tag = "DELETE";
            tbbDelete.Text = "Supprimer";
            tbbDelete.ToolTipText = "Effacer un Paiment";
            // 
            // imageListLarge
            // 
            imageListLarge.ImageStream = (ImageListStreamer)resources.GetObject("imageListLarge.ImageStream");
            imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            imageListLarge.Images.SetKeyName(0, "delete-icon.png");
            imageListLarge.Images.SetKeyName(1, "add-icon.png");
            // 
            // TimerButton
            // 
            TimerButton.Enabled = true;
            TimerButton.Interval = 250;
            TimerButton.Tick += new EventHandler(TimerButton_Tick);
            // 
            // FormSeanceCode
            // 
            AcceptButton = button1;
            CancelButton = cmdCancel;
            ClientSize = new System.Drawing.Size(612, 368);
            ControlBox = false;
            Controls.Add(tbCode);
            Controls.Add(cmdCancel);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(lvCode);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSeanceCode";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Liste de codes de séances";
            Load += new EventHandler(FormScéanceCode_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

		}
		#endregion

		private void FormScéanceCode_Load(object sender, EventArgs e) {
		
		}

		private void button1_Click(object sender, EventArgs e) {
            SaveCode();
            Close(); //Fermer la dialog			
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

		private void cmdAdd_Click(object sender, EventArgs e) {
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
                XmlTextWriter myWriter = new XmlTextWriter(@"Data\code.xml", Encoding.Unicode)
                {
                    Formatting = Formatting.Indented
                };

                //Header avec la version
                myWriter.WriteStartElement("ECBCodeSeance");
				myWriter.WriteAttributeString("Version", "1.0");
					
				//Ecriture des code 
				myWriter.WriteStartElement("BarretteCode");
				myWriter.WriteAttributeString("Count", Convert.ToString(lvCode.Items.Count));
				if (lvCode.Items.Count > 0){
					for(int i=0; i< lvCode.Items.Count; i++){
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

        private void cmdCancel_Click(object sender, EventArgs e) => Close();

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

        private void TimerButton_Tick(object sender, EventArgs e) => tbbDelete.Enabled = lvCode.SelectedItems.Count > 0;

        private void lvCode_KeyUp(object sender, KeyEventArgs e) {
			switch (e.KeyCode) {
				case Keys.Delete:
					DeleteSelection();
					break;
			}
		}
	}
}
