namespace Barette.IDE.Forms.GestionGroup {
    partial class FormAddStudent {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddStudent));
            this.listFindResult = new Barette.Library.Listview.ListViewEx();
            this.colheadContratNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadNumeroPermis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadPhone2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadNoGroupe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadTypeCours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbStudentsList = new System.Windows.Forms.ToolBar();
            this.tbbRefresh = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbAddCoursFinish = new System.Windows.Forms.ToolBarButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdAddClient = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdClearbox = new System.Windows.Forms.Button();
            this.txtFind = new UtilityLibrary.WinControls.NumericTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listFindResult
            // 
            this.listFindResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFindResult.CheckBoxes = true;
            this.listFindResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colheadContratNumber,
            this.colheadDate,
            this.colheadName,
            this.colHeadNumeroPermis,
            this.colHeadPhone,
            this.colHeadPhone2,
            this.colHeadNoGroupe,
            this.colHeadTypeCours});
            this.listFindResult.FullRowSelect = true;
            this.listFindResult.HideSelection = false;
            this.listFindResult.Location = new System.Drawing.Point(12, 102);
            this.listFindResult.MultiSelect = false;
            this.listFindResult.Name = "listFindResult";
            this.listFindResult.Size = new System.Drawing.Size(897, 332);
            this.listFindResult.SmallImageList = this.ImageListSmall;
            this.listFindResult.TabIndex = 4;
            this.listFindResult.UseCompatibleStateImageBehavior = false;
            this.listFindResult.View = System.Windows.Forms.View.Details;
            // 
            // colheadContratNumber
            // 
            this.colheadContratNumber.Text = "No. Contrat";
            this.colheadContratNumber.Width = 113;
            // 
            // colheadDate
            // 
            this.colheadDate.Text = "Date inscription";
            this.colheadDate.Width = 91;
            // 
            // colheadName
            // 
            this.colheadName.Text = "Nom du client";
            this.colheadName.Width = 175;
            // 
            // colHeadNumeroPermis
            // 
            this.colHeadNumeroPermis.Text = "No. Permis";
            this.colHeadNumeroPermis.Width = 165;
            // 
            // colHeadPhone
            // 
            this.colHeadPhone.Text = "Téléphone";
            this.colHeadPhone.Width = 91;
            // 
            // colHeadPhone2
            // 
            this.colHeadPhone2.Text = "Téléphone Autre";
            this.colHeadPhone2.Width = 101;
            // 
            // colHeadNoGroupe
            // 
            this.colHeadNoGroupe.Text = "No. Groupe";
            this.colHeadNoGroupe.Width = 73;
            // 
            // colHeadTypeCours
            // 
            this.colHeadTypeCours.Text = "États";
            // 
            // ImageListSmall
            // 
            this.ImageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListSmall.ImageStream")));
            this.ImageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListSmall.Images.SetKeyName(0, "Moto");
            this.ImageListSmall.Images.SetKeyName(1, "Auto");
            this.ImageListSmall.Images.SetKeyName(2, "Camion");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "close-icon.png");
            // 
            // tbStudentsList
            // 
            this.tbStudentsList.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbStudentsList.AutoSize = false;
            this.tbStudentsList.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbRefresh,
            this.tbbSeparator,
            this.tbbAddCoursFinish});
            this.tbStudentsList.Divider = false;
            this.tbStudentsList.Dock = System.Windows.Forms.DockStyle.None;
            this.tbStudentsList.DropDownArrows = true;
            this.tbStudentsList.ImageList = this.imageList1;
            this.tbStudentsList.Location = new System.Drawing.Point(12, 16);
            this.tbStudentsList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tbStudentsList.Name = "tbStudentsList";
            this.tbStudentsList.ShowToolTips = true;
            this.tbStudentsList.Size = new System.Drawing.Size(275, 42);
            this.tbStudentsList.TabIndex = 11;
            this.tbStudentsList.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.tbStudentsList.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbStudentsList_ButtonClick);
            // 
            // tbbRefresh
            // 
            this.tbbRefresh.ImageIndex = 0;
            this.tbbRefresh.Name = "tbbRefresh";
            this.tbbRefresh.Tag = "REFRESH";
            this.tbbRefresh.ToolTipText = "Rafraîchir la liste de clients";
            // 
            // tbbSeparator
            // 
            this.tbbSeparator.Name = "tbbSeparator";
            this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbAddCoursFinish
            // 
            this.tbbAddCoursFinish.ImageKey = "close-icon.png";
            this.tbbAddCoursFinish.Name = "tbbAddCoursFinish";
            this.tbbAddCoursFinish.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbAddCoursFinish.Tag = "COURSTERMINER";
            this.tbbAddCoursFinish.Text = "Afficher les cours terminés";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Barette.IDE.Properties.Resources.search_icon;
            this.pictureBox1.Location = new System.Drawing.Point(11, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Image = global::Barette.IDE.Properties.Resources.Cancel_2_icon;
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(821, 440);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(88, 43);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Annuler";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdAddClient
            // 
            this.cmdAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAddClient.Image = global::Barette.IDE.Properties.Resources.accept_icon;
            this.cmdAddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAddClient.Location = new System.Drawing.Point(731, 440);
            this.cmdAddClient.Name = "cmdAddClient";
            this.cmdAddClient.Size = new System.Drawing.Size(84, 43);
            this.cmdAddClient.TabIndex = 2;
            this.cmdAddClient.Text = "Ajouter";
            this.cmdAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAddClient.Click += new System.EventHandler(this.cmdAddClient_Click);
            // 
            // cmdClearbox
            // 
            this.cmdClearbox.Location = new System.Drawing.Point(164, 76);
            this.cmdClearbox.Name = "cmdClearbox";
            this.cmdClearbox.Size = new System.Drawing.Size(22, 20);
            this.cmdClearbox.TabIndex = 14;
            this.cmdClearbox.Text = "X";
            this.cmdClearbox.UseVisualStyleBackColor = true;
            this.cmdClearbox.Click += new System.EventHandler(this.cmdClearbox_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(42, 76);
            this.txtFind.Name = "txtFind";
            this.txtFind.SetRange = new System.Drawing.Size(0, 99999999);
            this.txtFind.ShortcutsEnabled = false;
            this.txtFind.Size = new System.Drawing.Size(116, 20);
            this.txtFind.TabIndex = 15;
            this.txtFind.Value = -1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // FormAddStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(921, 495);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.cmdClearbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbStudentsList);
            this.Controls.Add(this.listFindResult);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAddClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddStudent";
            this.Text = "Ajouter des élèves au groupe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdAddClient;
        private Library.Listview.ListViewEx listFindResult;
        private System.Windows.Forms.ColumnHeader colheadContratNumber;
        private System.Windows.Forms.ColumnHeader colheadDate;
        private System.Windows.Forms.ColumnHeader colheadName;
        private System.Windows.Forms.ColumnHeader colHeadNumeroPermis;
        private System.Windows.Forms.ColumnHeader colHeadPhone;
        private System.Windows.Forms.ColumnHeader colHeadPhone2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolBar tbStudentsList;
        private System.Windows.Forms.ToolBarButton tbbRefresh;
        private System.Windows.Forms.ToolBarButton tbbSeparator;
        private System.Windows.Forms.ToolBarButton tbbAddCoursFinish;
        private System.Windows.Forms.ColumnHeader colHeadNoGroupe;
        private System.Windows.Forms.ColumnHeader colHeadTypeCours;
        private System.Windows.Forms.ImageList ImageListSmall;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdClearbox;
        private UtilityLibrary.WinControls.NumericTextBox txtFind;
    }
}