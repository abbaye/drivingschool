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
	public class FormEmploye : Form
    {
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

            _FormMain = formMain;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmploye));
            Barette.Library.Employer.Employe employe1 = new Barette.Library.Employer.Employe();
            ImageListTB = new System.Windows.Forms.ImageList(components);
            tbEmploye = new System.Windows.Forms.ToolBar();
            toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            tbbSeparator = new System.Windows.Forms.ToolBarButton();
            tbbRefresh = new System.Windows.Forms.ToolBarButton();
            ImageListLV = new System.Windows.Forms.ImageList(components);
            AutoUpdateTimer = new System.Windows.Forms.Timer(components);
            employeControl1 = new Barette.Library.UserControls.EmployeControl();
            lvEmploye = new Barette.Library.Listview.ListViewEx();
            colHeadName = new System.Windows.Forms.ColumnHeader();
            colHeadNumeroEmploye = new System.Windows.Forms.ColumnHeader();
            TimerEnableDisable = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ImageListTB
            // 
            ImageListTB.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListTB.ImageStream")));
            ImageListTB.TransparentColor = System.Drawing.Color.Transparent;
            ImageListTB.Images.SetKeyName(0, "add-icon.png");
            ImageListTB.Images.SetKeyName(1, "delete-icon.png");
            ImageListTB.Images.SetKeyName(2, "");
            ImageListTB.Images.SetKeyName(3, "");
            ImageListTB.Images.SetKeyName(4, "");
            // 
            // tbEmploye
            // 
            tbEmploye.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            tbEmploye.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            toolBarButton1,
            toolBarButton2,
            tbbSeparator,
            tbbRefresh});
            tbEmploye.Divider = false;
            tbEmploye.Dock = System.Windows.Forms.DockStyle.None;
            tbEmploye.DropDownArrows = true;
            tbEmploye.ImageList = ImageListTB;
            tbEmploye.Location = new System.Drawing.Point(4, 6);
            tbEmploye.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            tbEmploye.Name = "tbEmploye";
            tbEmploye.ShowToolTips = true;
            tbEmploye.Size = new System.Drawing.Size(233, 42);
            tbEmploye.TabIndex = 16;
            tbEmploye.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            tbEmploye.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(tbEmploye_ButtonClick);
            // 
            // toolBarButton1
            // 
            toolBarButton1.ImageIndex = 0;
            toolBarButton1.Name = "toolBarButton1";
            toolBarButton1.Tag = "ADD";
            toolBarButton1.ToolTipText = "Ajouter un client";
            // 
            // toolBarButton2
            // 
            toolBarButton2.ImageIndex = 1;
            toolBarButton2.Name = "toolBarButton2";
            toolBarButton2.Tag = "DELETE";
            toolBarButton2.ToolTipText = "Effacer un client";
            // 
            // tbbSeparator
            // 
            tbbSeparator.Name = "tbbSeparator";
            tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbRefresh
            // 
            tbbRefresh.ImageIndex = 4;
            tbbRefresh.Name = "tbbRefresh";
            tbbRefresh.Tag = "REFRESH";
            tbbRefresh.ToolTipText = "Rafraîchir la liste de clients";
            // 
            // ImageListLV
            // 
            ImageListLV.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListLV.ImageStream")));
            ImageListLV.TransparentColor = System.Drawing.Color.Transparent;
            ImageListLV.Images.SetKeyName(0, "employe");
            // 
            // AutoUpdateTimer
            // 
            AutoUpdateTimer.Enabled = true;
            AutoUpdateTimer.Interval = 250;
            AutoUpdateTimer.Tick += new System.EventHandler(AutoUpdateTimer_Tick);
            // 
            // employeControl1
            // 
            employeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            employeControl1.Location = new System.Drawing.Point(255, 6);
            employeControl1.Name = "employeControl1";
            employeControl1.Size = new System.Drawing.Size(634, 524);
            employeControl1.TabIndex = 17;
            // 
            // lvEmploye
            // 
            lvEmploye.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lvEmploye.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            colHeadName,
            colHeadNumeroEmploye});
            lvEmploye.FullRowSelect = true;
            lvEmploye.Location = new System.Drawing.Point(5, 51);
            lvEmploye.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            lvEmploye.MultiSelect = false;
            lvEmploye.Name = "lvEmploye";
            lvEmploye.Size = new System.Drawing.Size(233, 479);
            lvEmploye.SmallImageList = ImageListLV;
            lvEmploye.Sorting = System.Windows.Forms.SortOrder.Ascending;
            lvEmploye.TabIndex = 0;
            lvEmploye.UseCompatibleStateImageBehavior = false;
            lvEmploye.View = System.Windows.Forms.View.Details;
            lvEmploye.SelectedIndexChanged += new System.EventHandler(lvEmploye_SelectedIndexChanged);
            lvEmploye.KeyDown += new System.Windows.Forms.KeyEventHandler(lvEmploye_KeyDown);
            // 
            // colHeadName
            // 
            colHeadName.Text = "Nom";
            colHeadName.Width = 142;
            // 
            // colHeadNumeroEmploye
            // 
            colHeadNumeroEmploye.Text = "#Emp.";
            colHeadNumeroEmploye.Width = 63;
            // 
            // TimerEnableDisable
            // 
            TimerEnableDisable.Enabled = true;
            TimerEnableDisable.Interval = 250;
            TimerEnableDisable.Tick += new System.EventHandler(TimerEnableDisable_Tick);
            // 
            // FormEmploye
            // 
            ClientSize = new System.Drawing.Size(893, 536);
            Controls.Add(employeControl1);
            Controls.Add(tbEmploye);
            Controls.Add(lvEmploye);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEmploye";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Gestion des employés";
            ResumeLayout(false);
            PerformLayout();

		}
		#endregion

		private void tbEmploye_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
			switch (e.Button.Tag.ToString()) {
				case "ADD":
					new FormAjoutEmploye(_FormMain, this).ShowDialog(this);
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
                    _FormMain.AppConfig.ApplicationName,
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

			for (int i = 0; i < _FormMain.EmployeList.Count; i++) {
                AddEmploye(_FormMain.EmployeList[i]);
			}

			Cursor.Current = Cursors.Default;
		}

		/// <summary>
		/// Transfere la liste d'employé dans la FormMain
		/// </summary>
		private void ReloadEmployeList() {
            //Efface la liste des clients
            _FormMain.EmployeList.Clear();

			//reload la liste des client
			for (int i = 0; i < lvEmploye.Items.Count; i++) {
                _FormMain.EmployeList.Add((Employe)lvEmploye.Items[i].Tag);
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