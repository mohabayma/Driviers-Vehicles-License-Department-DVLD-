namespace DVLD
{
    partial class frmDetainLicenseApplication
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicenseApplication));
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.ctrlDriverLicenseInfoWithFilter();
            this.lblAddUpdarePerson = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFineFees = new System.Windows.Forms.TextBox();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ljk = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(12, 70);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(1072, 518);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // lblAddUpdarePerson
            // 
            this.lblAddUpdarePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUpdarePerson.ForeColor = System.Drawing.Color.Red;
            this.lblAddUpdarePerson.Location = new System.Drawing.Point(357, 9);
            this.lblAddUpdarePerson.Name = "lblAddUpdarePerson";
            this.lblAddUpdarePerson.Size = new System.Drawing.Size(394, 42);
            this.lblAddUpdarePerson.TabIndex = 14;
            this.lblAddUpdarePerson.Text = "Detain Driver License";
            this.lblAddUpdarePerson.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAddUpdarePerson.Click += new System.EventHandler(this.lblAddUpdarePerson_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.txtFineFees);
            this.groupBox1.Controls.Add(this.lblCreatedByUser);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblLicenseID);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.lblDetainDate);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ljk);
            this.groupBox1.Controls.Add(this.lblDetainID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 594);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 173);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apllication New License Info";
            // 
            // txtFineFees
            // 
            this.txtFineFees.Location = new System.Drawing.Point(237, 126);
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.Size = new System.Drawing.Size(154, 28);
            this.txtFineFees.TabIndex = 96;
            this.txtFineFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFineFees_Validating);
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.Location = new System.Drawing.Point(784, 82);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(66, 22);
            this.lblCreatedByUser.TabIndex = 95;
            this.lblCreatedByUser.Text = "[????]";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(536, 82);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(116, 22);
            this.label29.TabIndex = 94;
            this.label29.Text = "Created By:";
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Image = global::DVLD.Properties.Resources.User_32__2_1_;
            this.label30.Location = new System.Drawing.Point(738, 76);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(29, 37);
            this.label30.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32_1_;
            this.label9.Location = new System.Drawing.Point(733, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 25);
            this.label9.TabIndex = 86;
            this.label9.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(536, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 22);
            this.label11.TabIndex = 84;
            this.label11.Text = "License ID:";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(773, 34);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(55, 22);
            this.lblLicenseID.TabIndex = 85;
            this.lblLicenseID.Text = "[???]";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Image = global::DVLD.Properties.Resources.money_32_1_;
            this.label16.Location = new System.Drawing.Point(196, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 25);
            this.label16.TabIndex = 76;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 22);
            this.label17.TabIndex = 75;
            this.label17.Text = "Fine Fees:";
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Image = global::DVLD.Properties.Resources.Calendar_32_1_;
            this.label24.Location = new System.Drawing.Point(192, 82);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 22);
            this.label24.TabIndex = 71;
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.Location = new System.Drawing.Point(233, 80);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(122, 22);
            this.lblDetainDate.TabIndex = 70;
            this.lblDetainDate.Text = "[??/??/????]";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(22, 80);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(122, 22);
            this.label25.TabIndex = 69;
            this.label25.Text = "Detain Date:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::DVLD.Properties.Resources.Number_32_1_;
            this.label10.Location = new System.Drawing.Point(192, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 25);
            this.label10.TabIndex = 56;
            // 
            // ljk
            // 
            this.ljk.AutoSize = true;
            this.ljk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ljk.Location = new System.Drawing.Point(22, 41);
            this.ljk.Name = "ljk";
            this.ljk.Size = new System.Drawing.Size(99, 22);
            this.ljk.TabIndex = 54;
            this.ljk.Text = "Detain ID:";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.Location = new System.Drawing.Point(233, 41);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(55, 22);
            this.lblDetainID.TabIndex = 55;
            this.lblDetainID.Text = "[???]";
            // 
            // btnDetain
            // 
            this.btnDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.Image = global::DVLD.Properties.Resources.International_32_1_;
            this.btnDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetain.Location = new System.Drawing.Point(924, 774);
            this.btnDetain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(157, 46);
            this.btnDetain.TabIndex = 61;
            this.btnDetain.Text = "  Detain";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32_1_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(756, 774);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 46);
            this.btnClose.TabIndex = 60;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowLicenseInfo.Location = new System.Drawing.Point(260, 787);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(172, 25);
            this.llShowLicenseInfo.TabIndex = 59;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show License Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // llShowLicenseHistory
            // 
            this.llShowLicenseHistory.AutoSize = true;
            this.llShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowLicenseHistory.Location = new System.Drawing.Point(12, 787);
            this.llShowLicenseHistory.Name = "llShowLicenseHistory";
            this.llShowLicenseHistory.Size = new System.Drawing.Size(200, 25);
            this.llShowLicenseHistory.TabIndex = 58;
            this.llShowLicenseHistory.TabStop = true;
            this.llShowLicenseHistory.Text = "Show License History";
            this.llShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDetainLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1094, 837);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.llShowLicenseInfo);
            this.Controls.Add(this.llShowLicenseHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAddUpdarePerson);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetainLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetainLicense";
            this.Activated += new System.EventHandler(this.frmDetainLicenseApplication_Activated);
            this.Load += new System.EventHandler(this.frmDetainLicenseApplication_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.Label lblAddUpdarePerson;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ljk;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.TextBox txtFineFees;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}