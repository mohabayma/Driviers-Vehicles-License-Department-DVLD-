namespace DVLD
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicenseServiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.InternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.RenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplacmentForLostOrDamagedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.ReleaseDetainedDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.RetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalDrivingLicenseApp = new System.Windows.Forms.ToolStripMenuItem();
            this.InternationalLicenseApp = new System.Windows.Forms.ToolStripMenuItem();
            this.detainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.DetainedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.ReleaseDetained = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageTestType = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.SignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1828, 72);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicenseServiseToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.detainedLicenseToolStripMenuItem,
            this.ManageApplicationTypes,
            this.ManageTestType});
            this.applicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationsToolStripMenuItem.Image = global::DVLD.Properties.Resources.Applications_64_1_;
            this.applicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(208, 68);
            this.applicationsToolStripMenuItem.Text = "Applications";
            this.applicationsToolStripMenuItem.Click += new System.EventHandler(this.applicationsToolStripMenuItem_Click);
            // 
            // drivingLicenseServiseToolStripMenuItem
            // 
            this.drivingLicenseServiseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewDrivingLicense,
            this.RenewDrivingLicense,
            this.ReplacmentForLostOrDamagedLicense,
            this.ReleaseDetainedDrivingLicense,
            this.RetakeTest});
            this.drivingLicenseServiseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Driver_License_48_1_;
            this.drivingLicenseServiseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.drivingLicenseServiseToolStripMenuItem.Name = "drivingLicenseServiseToolStripMenuItem";
            this.drivingLicenseServiseToolStripMenuItem.Size = new System.Drawing.Size(394, 70);
            this.drivingLicenseServiseToolStripMenuItem.Text = "Driving License Servise";
            this.drivingLicenseServiseToolStripMenuItem.Click += new System.EventHandler(this.drivingLicenseServiseToolStripMenuItem_Click);
            // 
            // NewDrivingLicense
            // 
            this.NewDrivingLicense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocalLicense,
            this.InternationalLicense});
            this.NewDrivingLicense.Image = global::DVLD.Properties.Resources.New_Driving_License_32_1_;
            this.NewDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewDrivingLicense.Name = "NewDrivingLicense";
            this.NewDrivingLicense.Size = new System.Drawing.Size(503, 38);
            this.NewDrivingLicense.Text = "New Driving License";
            // 
            // LocalLicense
            // 
            this.LocalLicense.Image = global::DVLD.Properties.Resources.Local_32_1_;
            this.LocalLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LocalLicense.Name = "LocalLicense";
            this.LocalLicense.Size = new System.Drawing.Size(308, 38);
            this.LocalLicense.Text = "Local License";
            this.LocalLicense.Click += new System.EventHandler(this.LocalLicense_Click);
            // 
            // InternationalLicense
            // 
            this.InternationalLicense.Image = global::DVLD.Properties.Resources.International_32_1_;
            this.InternationalLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InternationalLicense.Name = "InternationalLicense";
            this.InternationalLicense.Size = new System.Drawing.Size(308, 38);
            this.InternationalLicense.Text = "International License";
            this.InternationalLicense.Click += new System.EventHandler(this.InternationalLicense_Click);
            // 
            // RenewDrivingLicense
            // 
            this.RenewDrivingLicense.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32_1_;
            this.RenewDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RenewDrivingLicense.Name = "RenewDrivingLicense";
            this.RenewDrivingLicense.Size = new System.Drawing.Size(503, 38);
            this.RenewDrivingLicense.Text = "Renew Driving License";
            this.RenewDrivingLicense.Click += new System.EventHandler(this.RenewDrivingLicense_Click);
            // 
            // ReplacmentForLostOrDamagedLicense
            // 
            this.ReplacmentForLostOrDamagedLicense.Image = global::DVLD.Properties.Resources.Damaged_Driving_License_32_1_;
            this.ReplacmentForLostOrDamagedLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReplacmentForLostOrDamagedLicense.Name = "ReplacmentForLostOrDamagedLicense";
            this.ReplacmentForLostOrDamagedLicense.Size = new System.Drawing.Size(503, 38);
            this.ReplacmentForLostOrDamagedLicense.Text = "Replacment For Lost Or Damaged License";
            this.ReplacmentForLostOrDamagedLicense.Click += new System.EventHandler(this.ReplacmentForLostOrDamagedLicense_Click);
            // 
            // ReleaseDetainedDrivingLicense
            // 
            this.ReleaseDetainedDrivingLicense.Image = global::DVLD.Properties.Resources.Detained_Driving_License_32_1_;
            this.ReleaseDetainedDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReleaseDetainedDrivingLicense.Name = "ReleaseDetainedDrivingLicense";
            this.ReleaseDetainedDrivingLicense.Size = new System.Drawing.Size(503, 38);
            this.ReleaseDetainedDrivingLicense.Text = "Release Detained Driving License";
            this.ReleaseDetainedDrivingLicense.Click += new System.EventHandler(this.ReleaseDetainedDrivingLicense_Click);
            // 
            // RetakeTest
            // 
            this.RetakeTest.Image = global::DVLD.Properties.Resources.Retake_Test_32_1_;
            this.RetakeTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RetakeTest.Name = "RetakeTest";
            this.RetakeTest.Size = new System.Drawing.Size(503, 38);
            this.RetakeTest.Text = "Retake Test";
            this.RetakeTest.Click += new System.EventHandler(this.RetakeTest_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocalDrivingLicenseApp,
            this.InternationalLicenseApp});
            this.manageApplicationsToolStripMenuItem.Image = global::DVLD.Properties.Resources.Manage_Applications_64_1_;
            this.manageApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(394, 70);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // LocalDrivingLicenseApp
            // 
            this.LocalDrivingLicenseApp.Image = global::DVLD.Properties.Resources.LocalDriving_License_1_;
            this.LocalDrivingLicenseApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LocalDrivingLicenseApp.Name = "LocalDrivingLicenseApp";
            this.LocalDrivingLicenseApp.Size = new System.Drawing.Size(425, 38);
            this.LocalDrivingLicenseApp.Text = "Local Driving License Application";
            this.LocalDrivingLicenseApp.Click += new System.EventHandler(this.LocalDrivingLicenseApp_Click);
            // 
            // InternationalLicenseApp
            // 
            this.InternationalLicenseApp.Image = global::DVLD.Properties.Resources.International_32_1_;
            this.InternationalLicenseApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InternationalLicenseApp.Name = "InternationalLicenseApp";
            this.InternationalLicenseApp.Size = new System.Drawing.Size(425, 38);
            this.InternationalLicenseApp.Text = "International License Application";
            this.InternationalLicenseApp.Click += new System.EventHandler(this.InternationalLicenseApp_Click);
            // 
            // detainedLicenseToolStripMenuItem
            // 
            this.detainedLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageDetainedLicense,
            this.DetainedLicenses,
            this.ReleaseDetained});
            this.detainedLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Detain_64_1_;
            this.detainedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detainedLicenseToolStripMenuItem.Name = "detainedLicenseToolStripMenuItem";
            this.detainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(394, 70);
            this.detainedLicenseToolStripMenuItem.Text = "Detained Licenses";
            // 
            // ManageDetainedLicense
            // 
            this.ManageDetainedLicense.Image = global::DVLD.Properties.Resources.Detain_32_1_;
            this.ManageDetainedLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManageDetainedLicense.Name = "ManageDetainedLicense";
            this.ManageDetainedLicense.Size = new System.Drawing.Size(354, 38);
            this.ManageDetainedLicense.Text = "Manage Detained License";
            this.ManageDetainedLicense.Click += new System.EventHandler(this.ManageDetainedLicense_Click);
            // 
            // DetainedLicenses
            // 
            this.DetainedLicenses.Image = global::DVLD.Properties.Resources.Detain_32_1_;
            this.DetainedLicenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DetainedLicenses.Name = "DetainedLicenses";
            this.DetainedLicenses.Size = new System.Drawing.Size(354, 38);
            this.DetainedLicenses.Text = "Detain Licenses";
            this.DetainedLicenses.Click += new System.EventHandler(this.DetainedLicenses_Click);
            // 
            // ReleaseDetained
            // 
            this.ReleaseDetained.Image = global::DVLD.Properties.Resources.Release_Detained_License_32_1_;
            this.ReleaseDetained.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReleaseDetained.Name = "ReleaseDetained";
            this.ReleaseDetained.Size = new System.Drawing.Size(354, 38);
            this.ReleaseDetained.Text = "Release Detained License";
            this.ReleaseDetained.Click += new System.EventHandler(this.ReleaseDetained_Click);
            // 
            // ManageApplicationTypes
            // 
            this.ManageApplicationTypes.Image = global::DVLD.Properties.Resources.Application_Types_64_1_;
            this.ManageApplicationTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManageApplicationTypes.Name = "ManageApplicationTypes";
            this.ManageApplicationTypes.Size = new System.Drawing.Size(394, 70);
            this.ManageApplicationTypes.Text = "Manage Application Types";
            this.ManageApplicationTypes.Click += new System.EventHandler(this.ManageApplicationTypes_Click);
            // 
            // ManageTestType
            // 
            this.ManageTestType.Image = global::DVLD.Properties.Resources.Test_Type_64_1_;
            this.ManageTestType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManageTestType.Name = "ManageTestType";
            this.ManageTestType.Size = new System.Drawing.Size(394, 70);
            this.ManageTestType.Text = "Manage Test Types";
            this.ManageTestType.Click += new System.EventHandler(this.ManageTestType_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleToolStripMenuItem.Image = global::DVLD.Properties.Resources.People_64_1_;
            this.peopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(153, 68);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversToolStripMenuItem.Image = global::DVLD.Properties.Resources.Drivers_64_1_;
            this.driversToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(158, 68);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = global::DVLD.Properties.Resources.Users_2_64_1_;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 68);
            this.toolStripMenuItem1.Text = "Users";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentUserInfo,
            this.ChangePassword,
            this.SignOut});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Image = global::DVLD.Properties.Resources.account_settings_64_1_;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(251, 68);
            this.toolStripMenuItem2.Text = "Account Settings";
            // 
            // CurrentUserInfo
            // 
            this.CurrentUserInfo.Image = global::DVLD.Properties.Resources.PersonDetails_32_1_;
            this.CurrentUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CurrentUserInfo.Name = "CurrentUserInfo";
            this.CurrentUserInfo.Size = new System.Drawing.Size(275, 38);
            this.CurrentUserInfo.Text = "Current User Info";
            this.CurrentUserInfo.Click += new System.EventHandler(this.CurrentUserInfo_Click);
            // 
            // ChangePassword
            // 
            this.ChangePassword.Image = global::DVLD.Properties.Resources.Password_32_1_;
            this.ChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(275, 38);
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // SignOut
            // 
            this.SignOut.Image = global::DVLD.Properties.Resources.sign_out_32__2_1_;
            this.SignOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SignOut.Name = "SignOut";
            this.SignOut.Size = new System.Drawing.Size(275, 38);
            this.SignOut.Text = "Sign Out";
            this.SignOut.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.wallpaperflare_com_wallpaper__4_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1828, 722);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1828, 794);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLicenseServiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem ManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem ManageTestType;
        private System.Windows.Forms.ToolStripMenuItem LocalLicense;
        private System.Windows.Forms.ToolStripMenuItem InternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem RenewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem ReplacmentForLostOrDamagedLicense;
        private System.Windows.Forms.ToolStripMenuItem ReleaseDetainedDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem RetakeTest;
        private System.Windows.Forms.ToolStripMenuItem LocalDrivingLicenseApp;
        private System.Windows.Forms.ToolStripMenuItem InternationalLicenseApp;
        private System.Windows.Forms.ToolStripMenuItem ManageDetainedLicense;
        private System.Windows.Forms.ToolStripMenuItem DetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem ReleaseDetained;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem CurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem ChangePassword;
        private System.Windows.Forms.ToolStripMenuItem SignOut;
    }
}

