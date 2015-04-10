namespace Barette.IDE.Forms.Notes {
	partial class FormPostIt {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPostIt));
        this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
        this.toolBar1 = new System.Windows.Forms.ToolBar();
        this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
        this.tbbDelete = new System.Windows.Forms.ToolBarButton();
        this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
        this.tbbEdit = new System.Windows.Forms.ToolBarButton();
        this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
        this.imageListTB = new System.Windows.Forms.ImageList(this.components);
        this.SelectionTimer = new System.Windows.Forms.Timer(this.components);
        this.lvNote = new Barette.Library.Listview.ListViewEx();
        this.SuspendLayout();
        // 
        // imageListLarge
        // 
        this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
        this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
        this.imageListLarge.Images.SetKeyName(0, "Notes");
        this.imageListLarge.Images.SetKeyName(1, "NotesClock");
        // 
        // toolBar1
        // 
        this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
        this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.tbbDelete,
            this.tbbSeparator,
            this.tbbEdit,
            this.toolBarButton2});
        this.toolBar1.Divider = false;
        this.toolBar1.Dock = System.Windows.Forms.DockStyle.None;
        this.toolBar1.DropDownArrows = true;
        this.toolBar1.ImageList = this.imageListTB;
        this.toolBar1.Location = new System.Drawing.Point(11, 6);
        this.toolBar1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
        this.toolBar1.Name = "toolBar1";
        this.toolBar1.ShowToolTips = true;
        this.toolBar1.Size = new System.Drawing.Size(166, 42);
        this.toolBar1.TabIndex = 10;
        this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
        this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
        // 
        // toolBarButton1
        // 
        this.toolBarButton1.ImageIndex = 0;
        this.toolBarButton1.Name = "toolBarButton1";
        this.toolBarButton1.Tag = "ADD";
        this.toolBarButton1.ToolTipText = "Ajouter une notes";
        // 
        // tbbDelete
        // 
        this.tbbDelete.ImageIndex = 1;
        this.tbbDelete.Name = "tbbDelete";
        this.tbbDelete.Tag = "DELETE";
        this.tbbDelete.ToolTipText = "Supprimer la note sélectionné";
        // 
        // tbbSeparator
        // 
        this.tbbSeparator.Name = "tbbSeparator";
        this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
        // 
        // tbbEdit
        // 
        this.tbbEdit.ImageIndex = 2;
        this.tbbEdit.Name = "tbbEdit";
        this.tbbEdit.Tag = "EDIT";
        this.tbbEdit.ToolTipText = "Modifier une notes";
        // 
        // toolBarButton2
        // 
        this.toolBarButton2.Enabled = false;
        this.toolBarButton2.Name = "toolBarButton2";
        // 
        // imageListTB
        // 
        this.imageListTB.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTB.ImageStream")));
        this.imageListTB.TransparentColor = System.Drawing.Color.Transparent;
        this.imageListTB.Images.SetKeyName(0, "Add");
        this.imageListTB.Images.SetKeyName(1, "Edit");
        this.imageListTB.Images.SetKeyName(2, "Edit");
        // 
        // SelectionTimer
        // 
        this.SelectionTimer.Enabled = true;
        this.SelectionTimer.Interval = 200;
        this.SelectionTimer.Tick += new System.EventHandler(this.SelectionTimer_Tick);
        // 
        // lvNote
        // 
        this.lvNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.lvNote.BackColor = System.Drawing.SystemColors.Window;
        this.lvNote.LabelEdit = true;
        this.lvNote.LargeImageList = this.imageListLarge;
        this.lvNote.Location = new System.Drawing.Point(11, 44);
        this.lvNote.MultiSelect = false;
        this.lvNote.Name = "lvNote";
        this.lvNote.ShowItemToolTips = true;
        this.lvNote.Size = new System.Drawing.Size(611, 300);
        this.lvNote.TabIndex = 0;
        this.lvNote.TileSize = new System.Drawing.Size(240, 80);
        this.lvNote.UseCompatibleStateImageBehavior = false;
        this.lvNote.View = System.Windows.Forms.View.Tile;
        this.lvNote.DoubleClick += new System.EventHandler(this.lvNote_DoubleClick);
        this.lvNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvNote_KeyDown);
        // 
        // FormPostIt
        // 
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(634, 356);
        this.Controls.Add(this.lvNote);
        this.Controls.Add(this.toolBar1);
        this.Name = "FormPostIt";
        this.ResumeLayout(false);
        this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ImageList imageListLarge;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton tbbEdit;
		private System.Windows.Forms.ToolBarButton tbbDelete;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.Timer SelectionTimer;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ImageList imageListTB;
		private Barette.Library.Listview.ListViewEx lvNote;





	}
}