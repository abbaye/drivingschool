namespace Barette.IDE.Forms.Calendar {
	partial class FormHoraire {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoraire));
            Barette.Library.Client.Customer customer1 = new Barette.Library.Client.Customer();
            this.cbEmploye = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbFunction = new System.Windows.Forms.ToolBar();
            this.tbbRefresh = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbPrint = new System.Windows.Forms.ToolBarButton();
            this.cmPrintChoice = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
            this.tbbJourFerier = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbShowClient = new System.Windows.Forms.ToolBarButton();
            this.tbbShowSeances = new System.Windows.Forms.ToolBarButton();
            this.tbbseparator4 = new System.Windows.Forms.ToolBarButton();
            this.tbbDeleteAllNotes = new System.Windows.Forms.ToolBarButton();
            this.vCalendar = new Voroshkov.Calendar.VerticalCalendar();
            this.timerButton = new System.Windows.Forms.Timer(this.components);
            this.ImageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDay = new System.Windows.Forms.TabPage();
            this.listViewEx1 = new Barette.Library.Listview.ListViewEx();
            this.colHeadHours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadContratNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadSeanceNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadPaimentDu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadSeanceCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadTelephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadManuelAutomatique = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpWeek = new System.Windows.Forms.TabPage();
            this.scheduleControl7 = new Barette.Library.UserControls.Schedule.ScheduleControl();
            this.scheduleControl6 = new Barette.Library.UserControls.Schedule.ScheduleControl();
            this.scheduleControl5 = new Barette.Library.UserControls.Schedule.ScheduleControl();
            this.scheduleControl4 = new Barette.Library.UserControls.Schedule.ScheduleControl();
            this.scheduleControl3 = new Barette.Library.UserControls.Schedule.ScheduleControl();
            this.scheduleControl2 = new Barette.Library.UserControls.Schedule.ScheduleControl();
            this.scheduleControl1 = new Barette.Library.UserControls.Schedule.ScheduleControl();
            this.printDocWeek = new System.Drawing.Printing.PrintDocument();
            this.clientControl1 = new Barette.Library.UserControls.Client.ClientControl();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.tabControl1.SuspendLayout();
            this.tpDay.SuspendLayout();
            this.tpWeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbEmploye
            // 
            this.cbEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmploye.FormattingEnabled = true;
            this.cbEmploye.ItemHeight = 13;
            this.cbEmploye.Location = new System.Drawing.Point(262, 63);
            this.cbEmploye.Name = "cbEmploye";
            this.cbEmploye.Size = new System.Drawing.Size(287, 21);
            this.cbEmploye.TabIndex = 15;
            this.cbEmploye.SelectedIndexChanged += new System.EventHandler(this.cbEmploye_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "user-group-icon.png");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "delete Notes.ico");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(199, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Employés :";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(219, 3);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(383, 23);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "-";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFunction
            // 
            this.tbFunction.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbFunction.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbRefresh,
            this.tbbSeparator,
            this.tbbPrint,
            this.tbbSeparator3,
            this.tbbJourFerier,
            this.tbbSeparator2,
            this.tbbShowClient,
            this.tbbShowSeances,
            this.tbbseparator4,
            this.tbbDeleteAllNotes});
            this.tbFunction.Divider = false;
            this.tbFunction.Dock = System.Windows.Forms.DockStyle.None;
            this.tbFunction.DropDownArrows = true;
            this.tbFunction.ImageList = this.imageList1;
            this.tbFunction.Location = new System.Drawing.Point(12, 12);
            this.tbFunction.Name = "tbFunction";
            this.tbFunction.ShowToolTips = true;
            this.tbFunction.Size = new System.Drawing.Size(299, 50);
            this.tbFunction.TabIndex = 16;
            this.tbFunction.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.tbFunction.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbFunction_ButtonClick);
            // 
            // tbbRefresh
            // 
            this.tbbRefresh.ImageIndex = 2;
            this.tbbRefresh.Name = "tbbRefresh";
            this.tbbRefresh.Tag = "REFRESH";
            this.tbbRefresh.ToolTipText = "Rafraîchir";
            // 
            // tbbSeparator
            // 
            this.tbbSeparator.Name = "tbbSeparator";
            this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbPrint
            // 
            this.tbbPrint.DropDownMenu = this.cmPrintChoice;
            this.tbbPrint.ImageIndex = 0;
            this.tbbPrint.Name = "tbbPrint";
            this.tbbPrint.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            this.tbbPrint.Tag = "PRINT";
            this.tbbPrint.ToolTipText = "Imprimer l\'horaire du jour";
            // 
            // cmPrintChoice
            // 
            this.cmPrintChoice.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem4,
            this.menuItem6,
            this.menuItem2,
            this.menuItem3,
            this.menuItem5});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Impression normal";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.Text = "Impression Avant-Midi";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 4;
            this.menuItem3.Text = "Impression Après-Midi";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 5;
            this.menuItem5.Text = "Impression Soirée";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // tbbSeparator3
            // 
            this.tbbSeparator3.Name = "tbbSeparator3";
            this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbJourFerier
            // 
            this.tbbJourFerier.ImageIndex = 4;
            this.tbbJourFerier.Name = "tbbJourFerier";
            this.tbbJourFerier.Tag = "JOURFERIER";
            this.tbbJourFerier.ToolTipText = "Gestion des jours fériés";
            // 
            // tbbSeparator2
            // 
            this.tbbSeparator2.Name = "tbbSeparator2";
            this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbShowClient
            // 
            this.tbbShowClient.Enabled = false;
            this.tbbShowClient.ImageIndex = 3;
            this.tbbShowClient.Name = "tbbShowClient";
            this.tbbShowClient.Tag = "SHOWCLIENT";
            this.tbbShowClient.ToolTipText = "Affiche le client sélectionné";
            // 
            // tbbShowSeances
            // 
            this.tbbShowSeances.Enabled = false;
            this.tbbShowSeances.ImageIndex = 5;
            this.tbbShowSeances.Name = "tbbShowSeances";
            this.tbbShowSeances.Tag = "SHOWSEANCE";
            this.tbbShowSeances.ToolTipText = "Afficher l\'horaire du client en cours";
            // 
            // tbbseparator4
            // 
            this.tbbseparator4.Name = "tbbseparator4";
            this.tbbseparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbDeleteAllNotes
            // 
            this.tbbDeleteAllNotes.ImageIndex = 6;
            this.tbbDeleteAllNotes.Name = "tbbDeleteAllNotes";
            this.tbbDeleteAllNotes.Tag = "DELETENOTES";
            this.tbbDeleteAllNotes.ToolTipText = "Supprime tous les notes de bas de pages";
            // 
            // vCalendar
            // 
            this.vCalendar.AnnualDates = new Voroshkov.Calendar.DateWithComment[0];
            this.vCalendar.AnnualDatesColor = System.Drawing.Color.Red;
            this.vCalendar.AutoSize = true;
            this.vCalendar.BackColor = System.Drawing.SystemColors.Window;
            this.vCalendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vCalendar.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.vCalendar.Date = new System.DateTime(2010, 9, 27, 0, 0, 0, 0);
            this.vCalendar.DimensionHeight = 3;
            this.vCalendar.DimensionWidth = 1;
            this.vCalendar.ExactDates = new Voroshkov.Calendar.DateWithComment[0];
            this.vCalendar.ExactDatesColor = System.Drawing.Color.DarkOrange;
            this.vCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Default;
            this.vCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vCalendar.Location = new System.Drawing.Point(12, 60);
            this.vCalendar.MaxDate = new System.DateTime(9997, 11, 1, 0, 0, 0, 0);
            this.vCalendar.MaxSelectionCount = 1;
            this.vCalendar.MinDate = new System.DateTime(1, 2, 1, 0, 0, 0, 0);
            this.vCalendar.MonthlyDates = new Voroshkov.Calendar.DateWithComment[0];
            this.vCalendar.MonthlyDatesColor = System.Drawing.Color.DeepPink;
            this.vCalendar.Name = "vCalendar";
            this.vCalendar.NavButtonsFlatStyle = System.Windows.Forms.FlatStyle.System;
            this.vCalendar.ScrollChange = 1;
            this.vCalendar.SelectionBackColor = System.Drawing.Color.BlueViolet;
            this.vCalendar.SelectionEnd = new System.DateTime(2005, 5, 19, 0, 0, 0, 0);
            this.vCalendar.SelectionForeColor = System.Drawing.Color.White;
            this.vCalendar.SelectionRange = new Voroshkov.Calendar.DateSelectionRange(new System.DateTime(2005, 5, 19, 0, 0, 0, 0), new System.DateTime(2005, 5, 19, 0, 0, 0, 0));
            this.vCalendar.SelectionShape = Voroshkov.Calendar.CalendarSelectionShape.shapeCircular;
            this.vCalendar.SelectionStart = new System.DateTime(2005, 5, 19, 0, 0, 0, 0);
            this.vCalendar.ShowAllWeekdayLabels = true;
            this.vCalendar.ShowAnnualDates = true;
            this.vCalendar.ShowExactDates = true;
            this.vCalendar.ShowMonthlyDates = true;
            this.vCalendar.ShowNavButtons = true;
            this.vCalendar.ShowSelection = true;
            this.vCalendar.ShowSpecialDates = true;
            this.vCalendar.ShowSpecialDatesBold = true;
            this.vCalendar.ShowSpecialDatesToolTip = true;
            this.vCalendar.ShowToday = true;
            this.vCalendar.ShowTodayCircle = true;
            this.vCalendar.ShowTrailingDays = true;
            this.vCalendar.Size = new System.Drawing.Size(166, 520);
            this.vCalendar.TabIndex = 0;
            this.vCalendar.TitleBackColor = System.Drawing.SystemColors.Control;
            this.vCalendar.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vCalendar.TitleForeColor = System.Drawing.SystemColors.ControlText;
            this.vCalendar.TodayCircleColor = System.Drawing.Color.Red;
            this.vCalendar.TodayDate = new System.DateTime(2005, 5, 29, 0, 0, 0, 0);
            this.vCalendar.TodayLocalizedString = "Aujourd\'hui";
            this.vCalendar.TrailingForeColor = System.Drawing.Color.DarkGray;
            this.vCalendar.WeekendColor = System.Drawing.Color.Blue;
            this.vCalendar.SelectionChanged += new System.EventHandler(this.vCalendar_SelectionChanged);
            this.vCalendar.DateChanged += new System.EventHandler(this.vCalendar_DateChanged);
            // 
            // timerButton
            // 
            this.timerButton.Enabled = true;
            this.timerButton.Interval = 250;
            this.timerButton.Tick += new System.EventHandler(this.timerButton_Tick);
            // 
            // ImageListSmall
            // 
            this.ImageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListSmall.ImageStream")));
            this.ImageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListSmall.Images.SetKeyName(0, "Moto");
            this.ImageListSmall.Images.SetKeyName(1, "Auto");
            this.ImageListSmall.Images.SetKeyName(2, "Camion");
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(6, 247);
            this.txtNotes.MaxLength = 250;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(596, 136);
            this.txtNotes.TabIndex = 20;
            this.txtNotes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNotes_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Notes (imprimable)";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpDay);
            this.tabControl1.Controls.Add(this.tpWeek);
            this.tabControl1.Location = new System.Drawing.Point(200, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(616, 415);
            this.tabControl1.TabIndex = 22;
            // 
            // tpDay
            // 
            this.tpDay.Controls.Add(this.listViewEx1);
            this.tpDay.Controls.Add(this.txtNotes);
            this.tpDay.Controls.Add(this.lblDate);
            this.tpDay.Controls.Add(this.label2);
            this.tpDay.Location = new System.Drawing.Point(4, 22);
            this.tpDay.Name = "tpDay";
            this.tpDay.Padding = new System.Windows.Forms.Padding(3);
            this.tpDay.Size = new System.Drawing.Size(608, 389);
            this.tpDay.TabIndex = 0;
            this.tpDay.Tag = "DAY";
            this.tpDay.Text = "Journalière";
            this.tpDay.UseVisualStyleBackColor = true;
            // 
            // listViewEx1
            // 
            this.listViewEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEx1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadHours,
            this.colHeadContratNumber,
            this.colHeadClientName,
            this.colHeadSeanceNumber,
            this.colHeadPaimentDu,
            this.colHeadSeanceCode,
            this.colHeadTelephone,
            this.colHeadManuelAutomatique});
            this.listViewEx1.FullRowSelect = true;
            this.listViewEx1.Location = new System.Drawing.Point(6, 30);
            this.listViewEx1.MultiSelect = false;
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.Size = new System.Drawing.Size(596, 190);
            this.listViewEx1.SmallImageList = this.ImageListSmall;
            this.listViewEx1.TabIndex = 0;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.Details;
            this.listViewEx1.SelectedIndexChanged += new System.EventHandler(this.listViewEx1_SelectedIndexChanged);
            this.listViewEx1.DoubleClick += new System.EventHandler(this.listViewEx1_DoubleClick);
            // 
            // colHeadHours
            // 
            this.colHeadHours.Text = "Heures";
            this.colHeadHours.Width = 73;
            // 
            // colHeadContratNumber
            // 
            this.colHeadContratNumber.Text = "# Contrat";
            this.colHeadContratNumber.Width = 86;
            // 
            // colHeadClientName
            // 
            this.colHeadClientName.Text = "Nom du Client";
            this.colHeadClientName.Width = 195;
            // 
            // colHeadSeanceNumber
            // 
            this.colHeadSeanceNumber.Text = "#Seance";
            // 
            // colHeadPaimentDu
            // 
            this.colHeadPaimentDu.Text = "Paiment dû";
            this.colHeadPaimentDu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colHeadPaimentDu.Width = 73;
            // 
            // colHeadSeanceCode
            // 
            this.colHeadSeanceCode.Text = "Code seance";
            this.colHeadSeanceCode.Width = 77;
            // 
            // colHeadTelephone
            // 
            this.colHeadTelephone.Text = "Téléphone";
            this.colHeadTelephone.Width = 97;
            // 
            // colHeadManuelAutomatique
            // 
            this.colHeadManuelAutomatique.Text = "Type";
            this.colHeadManuelAutomatique.Width = 80;
            // 
            // tpWeek
            // 
            this.tpWeek.AutoScroll = true;
            this.tpWeek.Controls.Add(this.scheduleControl7);
            this.tpWeek.Controls.Add(this.scheduleControl6);
            this.tpWeek.Controls.Add(this.scheduleControl5);
            this.tpWeek.Controls.Add(this.scheduleControl4);
            this.tpWeek.Controls.Add(this.scheduleControl3);
            this.tpWeek.Controls.Add(this.scheduleControl2);
            this.tpWeek.Controls.Add(this.scheduleControl1);
            this.tpWeek.Location = new System.Drawing.Point(4, 22);
            this.tpWeek.Name = "tpWeek";
            this.tpWeek.Padding = new System.Windows.Forms.Padding(3);
            this.tpWeek.Size = new System.Drawing.Size(608, 389);
            this.tpWeek.TabIndex = 1;
            this.tpWeek.Tag = "WEEK";
            this.tpWeek.Text = "Hebdomadaire";
            this.tpWeek.UseVisualStyleBackColor = true;
            // 
            // scheduleControl7
            // 
            this.scheduleControl7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.scheduleControl7.Date = new System.DateTime(2005, 6, 21, 20, 46, 48, 63);
            this.scheduleControl7.Location = new System.Drawing.Point(1693, 0);
            this.scheduleControl7.Name = "scheduleControl7";
            this.scheduleControl7.Notes = "";
            this.scheduleControl7.Size = new System.Drawing.Size(279, 264);
            this.scheduleControl7.TabIndex = 6;
            this.scheduleControl7.NotesChanged += new System.EventHandler(this.scheduleControl7_NotesChanged);
            this.scheduleControl7.ItemSelected += new System.EventHandler(this.scheduleControl7_ItemSelected);
            this.scheduleControl7.MouseItemDoubleClick += new System.Windows.Forms.MouseEventHandler(this.scheduleControl_MouseItemDoubleClick);
            // 
            // scheduleControl6
            // 
            this.scheduleControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.scheduleControl6.Date = new System.DateTime(2005, 6, 21, 20, 46, 48, 83);
            this.scheduleControl6.Location = new System.Drawing.Point(1411, 0);
            this.scheduleControl6.Name = "scheduleControl6";
            this.scheduleControl6.Notes = "";
            this.scheduleControl6.Size = new System.Drawing.Size(279, 264);
            this.scheduleControl6.TabIndex = 5;
            this.scheduleControl6.NotesChanged += new System.EventHandler(this.scheduleControl6_NotesChanged);
            this.scheduleControl6.ItemSelected += new System.EventHandler(this.scheduleControl6_ItemSelected);
            this.scheduleControl6.MouseItemDoubleClick += new System.Windows.Forms.MouseEventHandler(this.scheduleControl_MouseItemDoubleClick);
            // 
            // scheduleControl5
            // 
            this.scheduleControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.scheduleControl5.Date = new System.DateTime(2005, 6, 21, 20, 46, 48, 83);
            this.scheduleControl5.Location = new System.Drawing.Point(1130, 0);
            this.scheduleControl5.Name = "scheduleControl5";
            this.scheduleControl5.Notes = "";
            this.scheduleControl5.Size = new System.Drawing.Size(279, 264);
            this.scheduleControl5.TabIndex = 4;
            this.scheduleControl5.NotesChanged += new System.EventHandler(this.scheduleControl5_NotesChanged);
            this.scheduleControl5.ItemSelected += new System.EventHandler(this.scheduleControl5_ItemSelected);
            this.scheduleControl5.MouseItemDoubleClick += new System.Windows.Forms.MouseEventHandler(this.scheduleControl_MouseItemDoubleClick);
            // 
            // scheduleControl4
            // 
            this.scheduleControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.scheduleControl4.Date = new System.DateTime(2005, 6, 21, 20, 46, 48, 93);
            this.scheduleControl4.Location = new System.Drawing.Point(849, 0);
            this.scheduleControl4.Name = "scheduleControl4";
            this.scheduleControl4.Notes = "";
            this.scheduleControl4.Size = new System.Drawing.Size(279, 264);
            this.scheduleControl4.TabIndex = 3;
            this.scheduleControl4.NotesChanged += new System.EventHandler(this.scheduleControl4_NotesChanged);
            this.scheduleControl4.ItemSelected += new System.EventHandler(this.scheduleControl4_ItemSelected);
            this.scheduleControl4.MouseItemDoubleClick += new System.Windows.Forms.MouseEventHandler(this.scheduleControl_MouseItemDoubleClick);
            // 
            // scheduleControl3
            // 
            this.scheduleControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.scheduleControl3.Date = new System.DateTime(2005, 6, 21, 20, 46, 48, 103);
            this.scheduleControl3.Location = new System.Drawing.Point(568, 0);
            this.scheduleControl3.Name = "scheduleControl3";
            this.scheduleControl3.Notes = "";
            this.scheduleControl3.Size = new System.Drawing.Size(279, 264);
            this.scheduleControl3.TabIndex = 2;
            this.scheduleControl3.NotesChanged += new System.EventHandler(this.scheduleControl3_NotesChanged);
            this.scheduleControl3.ItemSelected += new System.EventHandler(this.scheduleControl3_ItemSelected);
            this.scheduleControl3.MouseItemDoubleClick += new System.Windows.Forms.MouseEventHandler(this.scheduleControl_MouseItemDoubleClick);
            // 
            // scheduleControl2
            // 
            this.scheduleControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.scheduleControl2.Date = new System.DateTime(2005, 6, 21, 20, 46, 48, 113);
            this.scheduleControl2.Location = new System.Drawing.Point(286, 0);
            this.scheduleControl2.Name = "scheduleControl2";
            this.scheduleControl2.Notes = "";
            this.scheduleControl2.Size = new System.Drawing.Size(279, 264);
            this.scheduleControl2.TabIndex = 1;
            this.scheduleControl2.NotesChanged += new System.EventHandler(this.scheduleControl2_NotesChanged);
            this.scheduleControl2.ItemSelected += new System.EventHandler(this.scheduleControl2_ItemSelected);
            this.scheduleControl2.MouseItemDoubleClick += new System.Windows.Forms.MouseEventHandler(this.scheduleControl_MouseItemDoubleClick);
            // 
            // scheduleControl1
            // 
            this.scheduleControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.scheduleControl1.Date = new System.DateTime(2005, 6, 21, 20, 46, 48, 123);
            this.scheduleControl1.Location = new System.Drawing.Point(6, 0);
            this.scheduleControl1.Name = "scheduleControl1";
            this.scheduleControl1.Notes = "";
            this.scheduleControl1.Size = new System.Drawing.Size(279, 264);
            this.scheduleControl1.TabIndex = 0;
            this.scheduleControl1.NotesChanged += new System.EventHandler(this.scheduleControl1_NotesChanged);
            this.scheduleControl1.ItemSelected += new System.EventHandler(this.scheduleControl1_ItemSelected);
            this.scheduleControl1.MouseItemDoubleClick += new System.Windows.Forms.MouseEventHandler(this.scheduleControl_MouseItemDoubleClick);
            // 
            // printDocWeek
            // 
            this.printDocWeek.DocumentName = "Semaine entière";
            this.printDocWeek.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocWeek_PrintPage);
            // 
            // clientControl1
            // 
            this.clientControl1.AutoUpdate = true;
            this.clientControl1.BackColor = System.Drawing.SystemColors.Control;
            customer1.AttestationNumber1 = "0";
            customer1.AttestationNumber2 = "";
            customer1.BVA = false;
            customer1.BVADate = new System.DateTime(2005, 5, 29, 20, 41, 11, 124);
            customer1.City = "";
            customer1.ClientNull = false;
            customer1.CodePostal = "   -";
            customer1.ContratNumber = "0";
            customer1.DateAttestation1 = new System.DateTime(2010, 7, 2, 9, 25, 16, 698);
            customer1.DateAttestation2 = new System.DateTime(2010, 7, 2, 9, 25, 16, 698);
            customer1.DateDebutCours = new System.DateTime(2010, 3, 11, 12, 27, 34, 946);
            customer1.DateExpiration = new System.DateTime(2010, 3, 11, 12, 27, 34, 946);
            customer1.DateInscription = new System.DateTime(2003, 8, 26, 0, 0, 0, 0);
            customer1.DateNaissance = new System.DateTime(2010, 3, 11, 12, 27, 34, 946);
            customer1.DateTemporaire = new System.DateTime(2005, 5, 29, 20, 41, 11, 124);
            customer1.DisponibilityAlway = false;
            customer1.DisponibilityAM = false;
            customer1.DisponibilityDimanche = false;
            customer1.DisponibilityPM = false;
            customer1.DisponibilitySamedi = false;
            customer1.DisponibilitySoirer = false;
            customer1.Email = "";
            customer1.FirstName = "";
            customer1.HaveTemporaire = false;
            customer1.LastRecuNumber = "";
            customer1.LocationAutomobile = false;
            customer1.LocationMoto = false;
            customer1.MontantCours = "";
            customer1.MontantLocation = "0 $";
            customer1.Name = "";
            customer1.No6R = "";
            customer1.Notes = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3084{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            customer1.NumeroGroupe = 0;
            customer1.NumeroPermis = "";
            customer1.Phone = "(418)418-418";
            customer1.PhoneBureau = "(418)418-418";
            customer1.ProgramMoto = Barette.Library.Client.ProgramMoto.Nothing;
            customer1.Solde = "0 $";
            customer1.StreetApp = "";
            customer1.StreetName = "";
            customer1.StreetNumber = "";
            customer1.TauxHorairePratique = "";
            customer1.TauxHoraireTheorique = "";
            customer1.TypeClient = Barette.Library.Client.ProfileType.Actif;
            customer1.TypeVehicule = Barette.Library.Client.VehiculeType.Automatique;
            this.clientControl1.Client = customer1;
            this.clientControl1.Location = new System.Drawing.Point(587, 12);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.School = null;
            this.clientControl1.Size = new System.Drawing.Size(242, 51);
            this.clientControl1.TabIndex = 19;
            this.clientControl1.Visible = false;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.Text = "Impression Journée entière";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // FormHoraire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 605);
            this.Controls.Add(this.clientControl1);
            this.Controls.Add(this.vCalendar);
            this.Controls.Add(this.tbFunction);
            this.Controls.Add(this.cbEmploye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormHoraire";
            this.Text = "FormHoraire";
            this.tabControl1.ResumeLayout(false);
            this.tpDay.ResumeLayout(false);
            this.tpDay.PerformLayout();
            this.tpWeek.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbEmploye;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.ToolBar tbFunction;
		private System.Windows.Forms.ToolBarButton tbbPrint;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbShowClient;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbRefresh;
		private System.Windows.Forms.ToolBarButton tbbSeparator3;
		private System.Windows.Forms.ToolBarButton tbbJourFerier;
		private Voroshkov.Calendar.VerticalCalendar vCalendar;
		private System.Windows.Forms.Timer timerButton;
		private System.Windows.Forms.ToolBarButton tbbShowSeances;
		private System.Windows.Forms.ImageList ImageListSmall;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Label label2;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.ToolBarButton tbbseparator4;
		private System.Windows.Forms.ToolBarButton tbbDeleteAllNotes;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpDay;
		private System.Windows.Forms.TabPage tpWeek;
		private System.Drawing.Printing.PrintDocument printDocWeek;
		private Barette.Library.Listview.ListViewEx listViewEx1;
		private System.Windows.Forms.ColumnHeader colHeadHours;
		private System.Windows.Forms.ColumnHeader colHeadContratNumber;
		private System.Windows.Forms.ColumnHeader colHeadClientName;
		private System.Windows.Forms.ColumnHeader colHeadSeanceNumber;
		private System.Windows.Forms.ColumnHeader colHeadPaimentDu;
		private System.Windows.Forms.ColumnHeader colHeadSeanceCode;
		private System.Windows.Forms.ColumnHeader colHeadTelephone;
		private System.Windows.Forms.ColumnHeader colHeadManuelAutomatique;
		private Barette.Library.UserControls.Schedule.ScheduleControl scheduleControl7;
		private Barette.Library.UserControls.Schedule.ScheduleControl scheduleControl6;
		private Barette.Library.UserControls.Schedule.ScheduleControl scheduleControl5;
		private Barette.Library.UserControls.Schedule.ScheduleControl scheduleControl4;
		private Barette.Library.UserControls.Schedule.ScheduleControl scheduleControl3;
		private Barette.Library.UserControls.Schedule.ScheduleControl scheduleControl2;
		private Barette.Library.UserControls.Schedule.ScheduleControl scheduleControl1;
        private Barette.Library.UserControls.Client.ClientControl clientControl1;
        private System.Windows.Forms.ContextMenu cmPrintChoice;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.MenuItem menuItem6;
    }
}