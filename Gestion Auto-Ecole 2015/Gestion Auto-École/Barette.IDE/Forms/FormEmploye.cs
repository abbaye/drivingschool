using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Text; 
using System.IO; 

using Barette.Library.Employer;
using Barette.Library.Listview;

namespace Barette.IDE.Forms {
	/// <summary>
	/// Description résumée de FormScéanceCode.
	/// </summary>
	public class FormEmploye : System.Windows.Forms.Form {
		private ImageList ImageListTB;
		private ToolBar tbEmploye;
		private ToolBarButton tbbSeparator;
		private ToolBarButton tbbRefresh;
		private Barette.Library.UserControls.EmployeControl employeControl1;
		private ListViewEx lvEmploye;
		private ColumnHeader colHeadNumeroEmploye;
		private ColumnHeader colHeadName;
		private IContainer components;
		private ToolBarButton toolBarButton1;
		private ToolBarButton toolBarButton2;
		private ImageList ImageListLV;
		private Timer AutoUpdateTimer;
		private Timer TimerEnableDisable;

		private FormMain _FormMain = null;

		public FormEmploye(FormMain formMain) {
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			this._FormMain = formMain;

			RefreshEmployeList();
		}

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmploye));
            Barette.Library.Employer.Employe employe1 = new Barette.Library.Employer.Employe();
            this.ImageListTB = new System.Windows.Forms.ImageList(this.components);
            this.tbEmploye = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbRefresh = new System.Windows.Forms.ToolBarButton();
            this.ImageListLV = new System.Windows.Forms.ImageList(this.components);
            this.AutoUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.employeControl1 = new Barette.Library.UserControls.EmployeControl();
            this.lvEmploye = new Barette.Library.Listview.ListViewEx();
            this.colHeadName = new System.Windows.Forms.ColumnHeader();
            this.colHeadNumeroEmploye = new System.Windows.Forms.ColumnHeader();
            this.TimerEnableDisable = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ImageListTB
            // 
            this.ImageListTB.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListTB.ImageStream")));
            this.ImageListTB.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListTB.Images.SetKeyName(0, "add-icon.png");
            this.ImageListTB.Images.SetKeyName(1, "delete-icon.png");
            this.ImageListTB.Images.SetKeyName(2, "");
            this.ImageListTB.Images.SetKeyName(3, "");
            this.ImageListTB.Images.SetKeyName(4, "");
            // 
            // tbEmploye
            // 
            this.tbEmploye.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbEmploye.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.tbbSeparator,
            this.tbbRefresh});
            this.tbEmploye.Divider = false;
            this.tbEmploye.Dock = System.Windows.Forms.DockStyle.None;
            this.tbEmploye.DropDownArrows = true;
            this.tbEmploye.ImageList = this.ImageListTB;
            this.tbEmploye.Location = new System.Drawing.Point(4, 6);
            this.tbEmploye.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tbEmploye.Name = "tbEmploye";
            this.tbEmploye.ShowToolTips = true;
            this.tbEmploye.Size = new System.Drawing.Size(233, 42);
            this.tbEmploye.TabIndex = 16;
            this.tbEmploye.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.tbEmploye.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbEmploye_ButtonClick);
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 0;
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Tag = "ADD";
            this.toolBarButton1.ToolTipText = "Ajouter un client";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 1;
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Tag = "DELETE";
            this.toolBarButton2.ToolTipText = "Effacer un client";
            // 
            // tbbSeparator
            // 
            this.tbbSeparator.Name = "tbbSeparator";
            this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbRefresh
            // 
            this.tbbRefresh.ImageIndex = 4;
            this.tbbRefresh.Name = "tbbRefresh";
            this.tbbRefresh.Tag = "REFRESH";
            this.tbbRefresh.ToolTipText = "Rafraîchir la liste de clients";
            // 
            // ImageListLV
            // 
            this.ImageListLV.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListLV.ImageStream")));
            this.ImageListLV.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListLV.Images.SetKeyName(0, "employe");
            // 
            // AutoUpdateTimer
            // 
            this.AutoUpdateTimer.Enabled = true;
            this.AutoUpdateTimer.Interval = 250;
            this.AutoUpdateTimer.Tick += new System.EventHandler(this.AutoUpdateTimer_Tick);
            // 
            // employeControl1
            // 
            this.employeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.employeControl1.Employer = employe1;
            this.employeControl1.Location = new System.Drawing.Point(255, 6);
            this.employeControl1.Name = "employeControl1";
            this.employeControl1.Size = new System.Drawing.Size(634, 524);
            this.employeControl1.TabIndex = 17;
            // 
            // lvEmploye
            // 
            this.lvEmploye.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lvEmploye.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadName,
            this.colHeadNumeroEmploye});
            this.lvEmploye.FullRowSelect = true;
            this.lvEmploye.Location = new System.Drawing.Point(5, 51);
            this.lvEmploye.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.lvEmploye.MultiSelect = false;
            this.lvEmploye.Name = "lvEmploye";
            this.lvEmploye.Size = new System.Drawing.Size(233, 479);
            this.lvEmploye.SmallImageList = this.ImageListLV;
            this.lvEmploye.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvEmploye.TabIndex = 0;
            this.lvEmploye.UseCompatibleStateImageBehavior = false;
            this.lvEmploye.View = System.Windows.Forms.View.Details;
            this.lvEmploye.SelectedIndexChanged += new System.EventHandler(this.lvEmploye_SelectedIndexChanged);
            this.lvEmploye.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvEmploye_KeyDown);
            // 
            // colHeadName
            // 
            this.colHeadName.Text = "Nom";
            this.colHeadName.Width = 142;
            // 
            // colHeadNumeroEmploye
            // 
            this.colHeadNumeroEmploye.Text = "#Emp.";
            this.colHeadNumeroEmploye.Width = 63;
            // 
            // TimerEnableDisable
            // 
            this.TimerEnableDisable.Enabled = true;
            this.TimerEnableDisable.Interval = 250;
            this.TimerEnableDisable.Tick += new System.EventHandler(this.TimerEnableDisable_Tick);
            // 
            // FormEmploye
            // 
            this.ClientSize = new System.Drawing.Size(893, 536);
            this.Controls.Add(this.employeControl1);
            this.Controls.Add(this.tbEmploye);
            this.Controls.Add(this.lvEmploye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmploye";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des employés";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void tbEmploye_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
			switch (e.Button.Tag.ToString()) {
				case "ADD":
					new FormAjoutEmploye(this._FormMain, this).ShowDialog(this);
					break;
				case "DELETE":
					DeleteSelectedEmploye();
					break;
				case "REFRESH":
					break;
			}
		}

		/// <summary>
		/// Supprime l'e employé sélectionné
		/// </summary>
		private DialogResult DeleteSelectedEmploye() {
			if (lvEmploye.SelectedItems.Count > 0)
				if (MessageBox.Show(this, "Voulez vous vraiment effacer : " +
					((Employe)lvEmploye.SelectedItems[0].Tag).Prenom + " " +
					((Employe)lvEmploye.SelectedItems[0].Tag).Nom,
                    this._FormMain.AppConfig.ApplicationName,
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question) == DialogResult.Yes) {
					lvEmploye.Items.RemoveAt(lvEmploye.SelectedItems[0].Index);
					ReloadEmployeList();
					return DialogResult.Yes;
				}

			return DialogResult.No;
		}

		/// <summary>
		/// Ajouter un employer
		/// </summary>
		/// <param name="emp">Objet contenant l'employer</param>
		public void AddEmploye(Employe emp) {
			ListViewItem itm = new ListViewItem();
			RichTextBox rich = new RichTextBox();

			itm.Text = emp.Prenom + " " + emp.Nom;

			itm.ImageIndex = 0;
			itm.Tag = emp;
			itm.SubItems.Add(emp.NumeroEmploye);
			
			lvEmploye.Items.Add(itm);			
		}

		/// <summary>
		/// Rafraichir la liste des employer
		/// </summary>
		public void RefreshEmployeList() {
			lvEmploye.Items.Clear();

			Cursor.Current = Cursors.WaitCursor;

			for (int i = 0; i < this._FormMain.EmployeList.Count; i++) {
				this.AddEmploye(this._FormMain.EmployeList[i]);
			}

			Cursor.Current = Cursors.Default;
		}

		/// <summary>
		/// Transfere la liste d'employé dans la FormMain
		/// </summary>
		private void ReloadEmployeList() {
			//Efface la liste des clients
			this._FormMain.EmployeList.Clear();

			//reload la liste des client
			for (int i = 0; i < lvEmploye.Items.Count; i++) {
				this._FormMain.EmployeList.Add((Employe)lvEmploye.Items[i].Tag);
			}
		}

		private void AutoUpdateTimer_Tick(object sender, EventArgs e) {

			//Mise a jour de la liste et de l'employe sélectioné
			if (lvEmploye.SelectedItems.Count > 0) {
				lvEmploye.SelectedItems[0].Tag = employeControl1.Employer;
				ReloadEmployeList();
			}
		}

		private void lvEmploye_SelectedIndexChanged(object sender, EventArgs e) {
			if (lvEmploye.SelectedItems.Count > 0) {
				//Reasignation
				employeControl1.Employer = (Employe)lvEmploye.SelectedItems[0].Tag;
				employeControl1.Enabled = true;
			} else
				employeControl1.Enabled = false;
		}

		private void lvEmploye_KeyDown(object sender, KeyEventArgs e) {			
			if (e.KeyCode == Keys.Delete)
				DeleteSelectedEmploye();
		}

		private void TimerEnableDisable_Tick(object sender, EventArgs e) {
			if (lvEmploye.SelectedItems.Count > 0) {
				employeControl1.Enabled = true;
				//toolBarButton1.Enabled = true;
				toolBarButton2.Enabled = true;
			} else {
				employeControl1.Enabled = false;
				toolBarButton2.Enabled = false;
				//toolBarButton1.Enabled = false;
				employeControl1.CloseEmploye();
			}
		}
	}
}