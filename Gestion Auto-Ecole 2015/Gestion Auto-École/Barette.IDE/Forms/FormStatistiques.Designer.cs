namespace Barette.IDE.Forms {
    partial class FormStatistiques {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistiques));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lvStats = new Barette.Library.Listview.ListViewEx();
            this.colHeadType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.tbbRefresh = new System.Windows.Forms.ToolBarButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.customerCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpStartMonth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerCollectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lvStats
            // 
            this.lvStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadType,
            this.colHeadTotal});
            this.lvStats.FullRowSelect = true;
            this.lvStats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStats.HideSelection = false;
            this.lvStats.Location = new System.Drawing.Point(12, 57);
            this.lvStats.MultiSelect = false;
            this.lvStats.Name = "lvStats";
            this.lvStats.ShowGroups = false;
            this.lvStats.ShowItemToolTips = true;
            this.lvStats.Size = new System.Drawing.Size(854, 163);
            this.lvStats.TabIndex = 21;
            this.lvStats.UseCompatibleStateImageBehavior = false;
            this.lvStats.View = System.Windows.Forms.View.Details;
            this.lvStats.SelectedIndexChanged += new System.EventHandler(this.lvStats_SelectedIndexChanged);
            // 
            // colHeadType
            // 
            this.colHeadType.Text = "Type";
            this.colHeadType.Width = 372;
            // 
            // colHeadTotal
            // 
            this.colHeadTotal.Text = "Total";
            this.colHeadTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colHeadTotal.Width = 61;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-icon.png");
            this.imageList1.Images.SetKeyName(1, "delete-icon.png");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            // 
            // toolBar1
            // 
            this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbRefresh});
            this.toolBar1.Divider = false;
            this.toolBar1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(12, 12);
            this.toolBar1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(326, 42);
            this.toolBar1.TabIndex = 23;
            this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // tbbRefresh
            // 
            this.tbbRefresh.ImageIndex = 4;
            this.tbbRefresh.Name = "tbbRefresh";
            this.tbbRefresh.Tag = "REFRESH";
            this.tbbRefresh.ToolTipText = "Rafraîchir la liste de clients";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 252);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.LegendText = "Inscription total";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.Name = "Inscriptions";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Motocyclette";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Cyclomoteur";
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Automobile";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(854, 368);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            this.chart1.Titles.Add(title1);
            // 
            // customerCollectionBindingSource
            // 
            this.customerCollectionBindingSource.DataSource = typeof(Barette.Library.Collections.CustomerCollection);
            // 
            // dtpStartMonth
            // 
            this.dtpStartMonth.CustomFormat = "MMM yyyy";
            this.dtpStartMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartMonth.Location = new System.Drawing.Point(79, 226);
            this.dtpStartMonth.Name = "dtpStartMonth";
            this.dtpStartMonth.Size = new System.Drawing.Size(139, 20);
            this.dtpStartMonth.TabIndex = 25;
            this.dtpStartMonth.ValueChanged += new System.EventHandler(this.dtpStartMonth_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "A partir de :";
            // 
            // FormStatistiques
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(878, 632);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStartMonth);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.lvStats);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStatistiques";
            this.Text = "Statistiques";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerCollectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Library.Listview.ListViewEx lvStats;
        private System.Windows.Forms.ColumnHeader colHeadType;
        private System.Windows.Forms.ColumnHeader colHeadTotal;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ToolBarButton tbbRefresh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource customerCollectionBindingSource;
        private System.Windows.Forms.DateTimePicker dtpStartMonth;
        private System.Windows.Forms.Label label1;
    }
}