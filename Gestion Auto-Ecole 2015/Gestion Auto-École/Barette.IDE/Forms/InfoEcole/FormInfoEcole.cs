using System;
using System.Windows.Forms;

using Barette.Library;

namespace Barette.IDE.Forms.InfoEcole
{
    public partial class FormInfoEcole : Form
    {

        private readonly SchoolInfo _InfoSchool;
        private readonly Config _appConfig;

        public FormInfoEcole(SchoolInfo info, bool FirstRun, Config appconfig)
        {
            InitializeComponent();

            _appConfig = appconfig;

            //Assignation de l'information sur l'ecoles de conduites
            _InfoSchool = info;
            LoadSchoolInfo(_InfoSchool);

            //Desactive le boutton cancel
            if (FirstRun == true) cmdCancel.Enabled = false;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdOK_Click(object sender, EventArgs e) {

            if (IsValide() == true) {
                SaveSchoolInfo(_InfoSchool);
                Close();
            }
        }

        private bool IsValide() {
            if (txtSchoolName.Text == "") {
                MessageBox.Show(this, "Entré le nom de votre école de conduite. Entré le dans la case approprié", _appConfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSchoolName.Focus();
                return false;
            }

            if (txtStreetName.Text == "") {
                MessageBox.Show(this, "Votre école doit avoir une rue.", _appConfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStreetName.Focus();
                return false;
            }

            if (txtStreetNumber.Text == "" || txtStreetNumber.Text == "0") {
                MessageBox.Show(this, "Votre école doit avoir un numéro civic pour son adresse.  Entré la dans la case approprié", _appConfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStreetNumber.Focus();
                return false;
            }

            if (cbCity.Text == "") {
                MessageBox.Show(this, "Votre école doit avoir une Ville.", _appConfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbCity.Focus();
                return false;
            }

            return true;
        }

        #region Methodes
        /// <summary>
        /// Chargement des information sur l'ecole de conduite
        /// </summary>        
        private void LoadSchoolInfo(SchoolInfo info) {            
            // Informations de base
            cbCity.Text = info.City;
            txtFax.Text = info.Fax;
            txtPhoneNumber.Text = info.Phone;
            txtCodePostal.Text = info.PostalCode;
            txtSchoolName.Text = info.SchoolName;
            txtStreetName.Text = info.StreetName;
            txtStreetNumber.Text = info.StreetNumber.ToString();
            ctbTauxPratique.Text = info.TauxHorairePratique;
            ctbTauxTheorie.Text = info.TauxHoraireTheorie;
            txtEmail.Text = info.Email;
            txtResponsable.Text = info.Responsable;

            //Info Lieu du cours
            txtCourseBatisseName.Text = info.CourseBatisseName;
            txtCourseStreetNumber.Text =  info.CourseStreetNumber.ToString(); 
            txtCourseStreetName.Text = info.CourseStreetName;
            txtCourseCity.Text = info.CourseCity;
            txtCourseCodePostal.Text = info.CoursePostalCode; 
            
            // Autre informations
            txtRegistreIncriptionAuto.Text = info.RegistrationAuto;
            txtRegistreIncriptionMoto.Text = info.RegistrationMoto;
            mtbTPS.Text = info.TPS;
            mtbTVQ.Text = info.TVQ;
        }

        private void SaveSchoolInfo(SchoolInfo info) {
            // Informations de base
            info.City = cbCity.Text;
            info.Fax = txtFax.Text;
            info.Phone = txtPhoneNumber.Text;
            info.PostalCode = txtCodePostal.Text;
            info.SchoolName = txtSchoolName.Text;
            info.StreetName = txtStreetName.Text;
            info.StreetNumber = txtStreetNumber.Value;
            info.Email = txtEmail.Text;
            info.Responsable = txtResponsable.Text;

            //Info Lieu du cours
            info.CourseBatisseName = txtCourseBatisseName.Text;
            info.CourseStreetNumber = txtCourseStreetNumber.Value;
            info.CourseStreetName = txtCourseStreetName.Text;
            info.CourseCity = txtCourseCity.Text;
            info.CoursePostalCode =txtCourseCodePostal.Text; 

            //Taux horaire par default
            info.TauxHorairePratique = ctbTauxPratique.Text;
            info.TauxHoraireTheorie = ctbTauxTheorie.Text;

            // Autre informations
            info.RegistrationAuto = txtRegistreIncriptionAuto.Text;
            info.RegistrationMoto = txtRegistreIncriptionMoto.Text;
            info.TPS = mtbTPS.Text;
            info.TVQ = mtbTVQ.Text;
        }
        #endregion

        private void txtCourseCodePostal_Leave(object sender, EventArgs e) {
            try {
                ((MaskedTextBox)sender).Text = ((MaskedTextBox)sender).Text.ToUpper();
            }
            catch {

            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
