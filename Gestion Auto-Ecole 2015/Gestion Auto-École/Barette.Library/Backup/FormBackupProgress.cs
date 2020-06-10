using System.Windows.Forms;

namespace Barette.Library.Backup
{
    public partial class FormBackupProgress : Form {
        public FormBackupProgress(int Minimum, int Maximum) {
            InitializeComponent();

            progressBar1.Minimum = Minimum;
            progressBar1.Maximum = Maximum;
        }

        public int SetActualValue {
            set {
                progressBar1.Value = value;
            }
        }
    }
}
