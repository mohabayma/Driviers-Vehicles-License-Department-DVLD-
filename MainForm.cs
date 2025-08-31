using DVLD___Buseniss_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class mainForm : Form
    {
        frmLogin _frmLogin;
        public mainForm(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmListPeople = new frmManage_People();
            frmListPeople.ShowDialog();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmListPeople = new frmManageUsers();
            frmListPeople.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
       
        private void SignOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void CurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void ManageApplicationTypes_Click(object sender, EventArgs e)
        {
            Form frmAppType =new frmManageApplicationTypes();
            frmAppType.ShowDialog();
        }

        private void ManageTestType_Click(object sender, EventArgs e)
        {
            Form form =new frmManageTestType();
            form.ShowDialog();
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void drivingLicenseServiseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LocalLicense_Click(object sender, EventArgs e)
        {
            Form frmAddLocalLicenseApp = new frmAddUpdateLocalDrivingLicenseApplication();
            frmAddLocalLicenseApp.ShowDialog();
        }

        private void LocalDrivingLicenseApp_Click(object sender, EventArgs e)
        {
            Form form = new frmListLocalDrivingLicesnseApplications();
            form.ShowDialog();
        }

        private void RetakeTest_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicesnseApplications frm = new frmListLocalDrivingLicesnseApplications();
            frm.ShowDialog();
        }

        private void RenewDrivingLicense_Click(object sender, EventArgs e)
        {
            Form frmRenewLocalLicense = new frmRenewDriverLicense();
            frmRenewLocalLicense.ShowDialog();
        }

        private void ReplacmentForLostOrDamagedLicense_Click(object sender, EventArgs e)
        {
            Form frmReplaceForDamagedOrLostLicenses = new frmReplaseLostOrDamagedLicense();
            frmReplaceForDamagedOrLostLicenses.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmListDrivers1 = new frmListDrivers();
            frmListDrivers1.ShowDialog();
        }

        private void DetainedLicenses_Click(object sender, EventArgs e)
        {
            frmDetainLicenseApplication frmDetainLicenseApplication = new frmDetainLicenseApplication();
            frmDetainLicenseApplication.ShowDialog();
        }

        private void ReleaseDetained_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenses frmReleaseDetainedLicense=new frmReleaseDetainedLicenses();
            frmReleaseDetainedLicense.ShowDialog();
        }

        private void ReleaseDetainedDrivingLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenses frmReleaseDetainedLicense = new frmReleaseDetainedLicenses();
            frmReleaseDetainedLicense.ShowDialog();
        }

        private void ManageDetainedLicense_Click(object sender, EventArgs e)
        {
            frmManageDetaineLicenses frmManageDetaine=new frmManageDetaineLicenses();
            frmManageDetaine.ShowDialog();
        }

        private void InternationalLicense_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication frmNewInternationalLicenseApplication = new frmNewInternationalLicenseApplication();
            frmNewInternationalLicenseApplication.ShowDialog();
        }

        private void InternationalLicenseApp_Click(object sender, EventArgs e)
        {
            frmListInternationalLicenses frmListInternationalLicenses = new frmListInternationalLicenses();
            frmListInternationalLicenses.ShowDialog();
        }
    }
}
