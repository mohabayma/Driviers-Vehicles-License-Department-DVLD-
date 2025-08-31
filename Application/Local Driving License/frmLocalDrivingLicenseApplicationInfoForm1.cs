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
    public partial class frmLocalDrivingLicenseApplicationInfoForm1 : Form
    {
        private int _ApplicationID = -1;

        public frmLocalDrivingLicenseApplicationInfoForm1(int ApplicationID)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;

        }


        private void frmLocalDrivingLicenseApplicationInfoForm1_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicens1.LoadApplicationInfoByLocalDrivingAppID(_ApplicationID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
