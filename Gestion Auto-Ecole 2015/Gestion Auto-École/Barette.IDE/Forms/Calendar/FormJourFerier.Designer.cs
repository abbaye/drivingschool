namespace Barette.IDE.Forms.Calendar {
	partial class FormJourFerier {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJourFerier));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbFunction = new System.Windows.Forms.ToolBar();
            this.tbbAddDate = new System.Windows.Forms.ToolBarButton();
            this.tbbDeleteDate = new System.Windows.Forms.ToolBarButton();
            this.cmdApply = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new Voroshkov.Calendar.VerticalCalendar();
            this.lvDate = new Barette.Library.Listview.ListViewEx();
            this.colHeadDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-icon.png");
            this.imageList1.Images.SetKeyName(1, "delete-icon.png");
            // 
            // tbFunction
            // 
            this.tbFunction.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbFunction.AutoSize = false;
            this.tbFunction.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbAddDate,
            this.tbbDeleteDate});
            this.tbFunction.Divider = false;
            this.tbFunction.Dock = System.Windows.Forms.DockStyle.None;
            this.tbFunction.DropDownArrows = true;
            this.tbFunction.ImageList = this.imageList1;
            this.tbFunction.Location = new System.Drawing.Point(305, 12);
            this.tbFunction.Name = "tbFunction";
            this.tbFunction.ShowToolTips = true;
            this.tbFunction.Size = new System.Drawing.Size(185, 42);
            this.tbFunction.TabIndex = 17;
            this.tbFunction.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.tbFunction.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbFunction_ButtonClick);
            // 
            // tbbAddDate
            // 
            this.tbbAddDate.Enabled = false;
            this.tbbAddDate.ImageKey = "add-icon.png";
            this.tbbAddDate.Name = "tbbAddDate";
            this.tbbAddDate.Tag = "ADD";
            this.tbbAddDate.Text = "Ajouter";
            this.tbbAddDate.ToolTipText = "Ajouter une date fériée";
            // 
            // tbbDeleteDate
            // 
            this.tbbDeleteDate.Enabled = false;
            this.tbbDeleteDate.ImageKey = "delete-icon.png";
            this.tbbDeleteDate.Name = "tbbDeleteDate";
            this.tbbDeleteDate.Tag = "DELETE";
            this.tbbDeleteDate.Text = "Supprimer";
            this.tbbDeleteDate.ToolTipText = "Supprimer la date fériée sélectionnée";
            // 
            // cmdApply
            // 
            this.cmdApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdApply.Image = global::Barette.IDE.Properties.Resources.accept_icon;
            this.cmdApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdApply.Location = new System.Drawing.Point(383, 433);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(94, 42);
            this.cmdApply.TabIndex = 18;
            this.cmdApply.Text = "Appliquer";
            this.cmdApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Image = global::Barette.IDE.Properties.Resources.Cancel_2_icon;
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(483, 433);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(84, 42);
            this.cmdCancel.TabIndex = 19;
            this.cmdCancel.Text = "Annuler";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(364, 352);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(166, 20);
            this.txtDescription.TabIndex = 21;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Description :";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.AnnualDates = new Voroshkov.Calendar.DateWithComment[0];
            this.monthCalendar1.AnnualDatesColor = System.Drawing.Color.Red;
            this.monthCalendar1.AutoSize = true;
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.monthCalendar1.Date = new System.DateTime(2005, 5, 19, 0, 0, 0, 0);
            this.monthCalendar1.DimensionHeight = 1;
            this.monthCalendar1.DimensionWidth = 1;
            this.monthCalendar1.ExactDates = new Voroshkov.Calendar.DateWithComment[0];
            this.monthCalendar1.ExactDatesColor = System.Drawing.Color.DeepPink;
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Default;
            this.monthCalendar1.Location = new System.Drawing.Point(364, 96);
            this.monthCalendar1.MaxDate = new System.DateTime(9997, 11, 1, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(1, 2, 1, 0, 0, 0, 0);
            this.monthCalendar1.MonthlyDates = new Voroshkov.Calendar.DateWithComment[0];
            this.monthCalendar1.MonthlyDatesColor = System.Drawing.Color.DeepPink;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.NavButtonsFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.monthCalendar1.ScrollChange = 1;
            this.monthCalendar1.SelectionBackColor = System.Drawing.Color.BlueViolet;
            this.monthCalendar1.SelectionEnd = new System.DateTime(2005, 5, 19, 0, 0, 0, 0);
            this.monthCalendar1.SelectionForeColor = System.Drawing.Color.White;
            this.monthCalendar1.SelectionRange = new Voroshkov.Calendar.DateSelectionRange(new System.DateTime(2005, 5, 19, 0, 0, 0, 0), new System.DateTime(2005, 5, 19, 0, 0, 0, 0));
            this.monthCalendar1.SelectionShape = Voroshkov.Calendar.CalendarSelectionShape.shapeCircular;
            this.monthCalendar1.SelectionStart = new System.DateTime(2005, 5, 19, 0, 0, 0, 0);
            this.monthCalendar1.ShowAllWeekdayLabels = true;
            this.monthCalendar1.ShowAnnualDates = true;
            this.monthCalendar1.ShowExactDates = true;
            this.monthCalendar1.ShowMonthlyDates = true;
            this.monthCalendar1.ShowNavButtons = true;
            this.monthCalendar1.ShowSelection = true;
            this.monthCalendar1.ShowSpecialDates = true;
            this.monthCalendar1.ShowSpecialDatesBold = true;
            this.monthCalendar1.ShowSpecialDatesToolTip = true;
            this.monthCalendar1.ShowToday = true;
            this.monthCalendar1.ShowTodayCircle = true;
            this.monthCalendar1.ShowTrailingDays = true;
            this.monthCalendar1.Size = new System.Drawing.Size(166, 190);
            this.monthCalendar1.TabIndex = 24;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.Control;
            this.monthCalendar1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.TitleForeColor = System.Drawing.SystemColors.ControlText;
            this.monthCalendar1.TodayCircleColor = System.Drawing.Color.Red;
            this.monthCalendar1.TodayDate = new System.DateTime(2005, 5, 19, 0, 0, 0, 0);
            this.monthCalendar1.TodayLocalizedString = "Aujourd\'hui";
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.DarkGray;
            this.monthCalendar1.WeekendColor = System.Drawing.Color.Blue;
            // 
            // lvDate
            // 
            this.lvDate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadDate,
            this.colHeadDescription});
            this.lvDate.FullRowSelect = true;
            this.lvDate.Location = new System.Drawing.Point(12, 12);
            this.lvDate.MultiSelect = false;
            this.lvDate.Name = "lvDate";
            this.lvDate.Size = new System.Drawing.Size(287, 403);
            this.lvDate.TabIndex = 20;
            this.lvDate.UseCompatibleStateImageBehavior = false;
            this.lvDate.View = System.Windows.Forms.View.Details;
            this.lvDate.SelectedIndexChanged += new System.EventHandler(this.lvDate_SelectedIndexChanged);
            this.lvDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvDate_KeyDown);
            // 
            // colHeadDate
            // 
            this.colHeadDate.Text = "Date";
            this.colHeadDate.Width = 87;
            // 
            // colHeadDescription
            // 
            this.colHeadDescription.Text = "Description";
            this.colHeadDescription.Width = 169;
            // 
            // FormJourFerier
            // 
            this.AcceptButton = this.cmdApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(579, 487);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lvDate);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdApply);
            this.Controls.Add(this.tbFunction);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormJourFerier";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jour Fériés";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBar tbFunction;
		private System.Windows.Forms.ToolBarButton tbbAddDate;
		private System.Windows.Forms.ToolBarButton tbbDeleteDate;
		private System.Windows.Forms.Button cmdApply;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label1;
		private Voroshkov.Calendar.VerticalCalendar monthCalendar1;
		private Barette.Library.Listview.ListViewEx lvDate;
		private System.Windows.Forms.ColumnHeader colHeadDate;
		private System.Windows.Forms.ColumnHeader colHeadDescription;
	}
}