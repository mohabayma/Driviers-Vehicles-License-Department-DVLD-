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
    public partial class frmShowPersonLicenseHistory : Form
    {
        private int _PersonID = -1;

        public frmShowPersonLicenseHistory()
        {
            InitializeComponent();
        }
        public frmShowPersonLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void ctrlPersonInfoWithFiltering1_Load(object sender, EventArgs e)
        {

        }

        private void frmShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            if (_PersonID != -1)
            {
                ctrlPersonInfoWithFiltering1.LoadPersonInfo(_PersonID);
                ctrlPersonInfoWithFiltering1.FilterEnabled = false;
                ctrlDriverLicense1.LoadInfoByPersonID(_PersonID);
            }
            else
            {
                ctrlPersonInfoWithFiltering1.Enabled = true;
                ctrlPersonInfoWithFiltering1.FilterFocus();
            }

        }

        private void ctrlPersonInfoWithFiltering1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
            if (_PersonID == -1)
            {
                ctrlDriverLicense1.Clear();
            }
            else
                ctrlDriverLicense1.LoadInfoByPersonID(_PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
