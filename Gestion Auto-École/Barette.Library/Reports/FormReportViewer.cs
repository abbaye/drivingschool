using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Barette.Library.Client;

namespace Barette.Library.Reports {
    public partial class FormReportViewer : Form {
        public FormReportViewer(Customer client, SchoolInfo info) {
            InitializeComponent();

            SchoolInfoBindingSource.DataSource = info ;
            CustomerBindingSource.Add(client);
            
        }

        private void FormReportViewer_Load(object sender, EventArgs e) {

            this.reportViewer1.RefreshReport();
        }

        private void FormReportViewer_FormClosed(object sender, FormClosedEventArgs e) {
            this.Dispose();
        }
    }
}
