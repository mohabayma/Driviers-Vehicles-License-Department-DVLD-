﻿using DVLD___Buseniss_Layer;
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
    public partial class ctrlDriverLicense : UserControl
    {
        private int _DriverID;
        private clsDriver _Driver;
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory;

        public ctrlDriverLicense()
        {
            InitializeComponent();
        }
        private void _LoadLocalLicenseInfo()
        {

            _dtDriverLocalLicensesHistory = clsDriver.GetLicenses(_DriverID);


            dgvLocalLicensesHistory.DataSource = _dtDriverLocalLicensesHistory;
            lblLocalLicensesRecords.Text = dgvLocalLicensesHistory.Rows.Count.ToString();

            if (dgvLocalLicensesHistory.Rows.Count > 0)
            {
                dgvLocalLicensesHistory.Columns[0].HeaderText = "Lic.ID";
                dgvLocalLicensesHistory.Columns[0].Width = 110;

                dgvLocalLicensesHistory.Columns[1].HeaderText = "App.ID";
                dgvLocalLicensesHistory.Columns[1].Width = 110;

                dgvLocalLicensesHistory.Columns[2].HeaderText = "Class Name";
                dgvLocalLicensesHistory.Columns[2].Width = 270;

                dgvLocalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicensesHistory.Columns[3].Width = 170;

                dgvLocalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicensesHistory.Columns[4].Width = 170;

                dgvLocalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvLocalLicensesHistory.Columns[5].Width = 110;

            }
        }
        private void _LoadInternationalLicenseInfo()
        {

            _dtDriverInternationalLicensesHistory = clsDriver.GetInternationalLicenses(_DriverID);


            dgvInternationalLicensesHistory.DataSource = _dtDriverInternationalLicensesHistory;
            lblInternationalLicensesRecords.Text = dgvInternationalLicensesHistory.Rows.Count.ToString();

            if (dgvInternationalLicensesHistory.Rows.Count > 0)
            {
                dgvInternationalLicensesHistory.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicensesHistory.Columns[0].Width = 160;

                dgvInternationalLicensesHistory.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicensesHistory.Columns[1].Width = 130;

                dgvInternationalLicensesHistory.Columns[2].HeaderText = "L.License ID";
                dgvInternationalLicensesHistory.Columns[2].Width = 130;

                dgvInternationalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicensesHistory.Columns[3].Width = 180;

                dgvInternationalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicensesHistory.Columns[4].Width = 180;

                dgvInternationalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicensesHistory.Columns[5].Width = 120;

            }
        }
        public void LoadInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Driver = clsDriver.FindByDriverID(_DriverID);
            if(_Driver == null )
            {
                MessageBox.Show("There No Driver With ID = " + _DriverID);
            }
            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();

        }
        public void LoadInfoByPersonID(int PersonID)
        {

            _Driver = clsDriver.FindByPersonID(PersonID);

            if (_Driver == null)
            {
                MessageBox.Show("There No Driver Linked With Person With ID = " + PersonID);
            }

            _DriverID = _Driver.DriverID;

            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            _dtDriverLocalLicensesHistory.Clear();

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = (int)dgvInternationalLicensesHistory.CurrentRow.Cells[0].Value;
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(InternationalLicenseID);
            frm.ShowDialog();
        }

        private void showLocalLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLocalLicensesHistory.CurrentRow.Cells[0].Value;
            //DriverLicense.
                frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
            frm.ShowDialog();
        }

        private void dgvLocalLicensesHistory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgvLocalLicensesHistory.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    // تحديد الصف
                    dgvLocalLicensesHistory.ClearSelection();
                    dgvLocalLicensesHistory.Rows[hit.RowIndex].Selected = true;

                    // إظهار الكونتكست مينيو في المكان المطلوب
                    contextMenuStrip1.Show(dgvLocalLicensesHistory, e.Location);
                }
            }
        }

        private void dgvLocalLicensesHistory_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvLocalLicensesHistory.ClearSelection(); // إلغاء التحديد السابق
                dgvLocalLicensesHistory.Rows[e.RowIndex].Selected = true; // تحديد الصف اللي ضغطت عليه
                dgvLocalLicensesHistory.CurrentCell = dgvLocalLicensesHistory.Rows[e.RowIndex].Cells[e.ColumnIndex]; // تعيين الخلية الحالية
            }
        }

        private void dgvInternationalLicensesHistory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgvInternationalLicensesHistory.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    // تحديد الصف
                    dgvInternationalLicensesHistory.ClearSelection();
                    dgvInternationalLicensesHistory.Rows[hit.RowIndex].Selected = true;

                    // إظهار الكونتكست مينيو في المكان المطلوب
                    contextMenuStrip2.Show(dgvInternationalLicensesHistory, e.Location);
                }
            }
        }

        private void dgvInternationalLicensesHistory_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvInternationalLicensesHistory.ClearSelection(); // إلغاء التحديد السابق
                dgvInternationalLicensesHistory.Rows[e.RowIndex].Selected = true; // تحديد الصف اللي ضغطت عليه
                dgvInternationalLicensesHistory.CurrentCell = dgvInternationalLicensesHistory.Rows[e.RowIndex].Cells[e.ColumnIndex]; // تعيين الخلية الحالية
            }
        }
    }
}
