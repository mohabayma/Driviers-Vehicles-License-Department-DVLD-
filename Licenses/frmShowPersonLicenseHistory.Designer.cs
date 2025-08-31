namespace DVLD
{
    partial class frmShowPersonLicenseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPersonLicenseHistory));
            this.ctrlPersonInfoWithFiltering1 = new DVLD.ctrlPersonInfoWithFiltering();
            this.ctrlDriverLicense1 = new DVLD.ctrlDriverLicense();
            this.lblAddUpdarePerson = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlPersonInfoWithFiltering1
            // 
            this.ctrlPersonInfoWithFiltering1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctrlPersonInfoWithFiltering1.FilterEnabled = true;
            this.ctrlPersonInfoWithFiltering1.Location = new System.Drawing.Point(299, 3);
            this.ctrlPersonInfoWithFiltering1.Name = "ctrlPersonInfoWithFiltering1";
            this.ctrlPersonInfoWithFiltering1.ShowAddPerson = true;
            this.ctrlPersonInfoWithFiltering1.Size = new System.Drawing.Size(1023, 474);
            this.ctrlPersonInfoWithFiltering1.TabIndex = 1;
            this.ctrlPersonInfoWithFiltering1.OnPersonSelected += new System.Action<int>(this.ctrlPersonInfoWithFiltering1_OnPersonSelected);
            this.ctrlPersonInfoWithFiltering1.Load += new System.EventHandler(this.ctrlPersonInfoWithFiltering1_Load);
            // 
            // ctrlDriverLicense1
            // 
            this.ctrlDriverLicense1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ctrlDriverLicense1.Location = new System.Drawing.Point(12, 483);
            this.ctrlDriverLicense1.Name = "ctrlDriverLicense1";
            this.ctrlDriverLicense1.Size = new System.Drawing.Size(1310, 310);
            this.ctrlDriverLicense1.TabIndex = 2;
            // 
            // lblAddUpdarePerson
            // 
            this.lblAddUpdarePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUpdarePerson.ForeColor = System.Drawing.Color.Red;
            this.lblAddUpdarePerson.Location = new System.Drawing.Point(5, 380);
            this.lblAddUpdarePerson.Name = "lblAddUpdarePerson";
            this.lblAddUpdarePerson.Size = new System.Drawing.Size(303, 42);
            this.lblAddUpdarePerson.TabIndex = 13;
            this.lblAddUpdarePerson.Text = "License History";
            this.lblAddUpdarePerson.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Location = new System.Drawing.Point(31, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32_1_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(1178, 791);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 53);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowPersonLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1330, 851);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAddUpdarePerson);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrlDriverLicense1);
            this.Controls.Add(this.ctrlPersonInfoWithFiltering1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShowPersonLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowPersonLicenseHistory";
            this.Load += new System.EventHandler(this.frmShowPersonLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlPersonInfoWithFiltering ctrlPersonInfoWithFiltering1;
        private ctrlDriverLicense ctrlDriverLicense1;
        private System.Windows.Forms.Label lblAddUpdarePerson;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
    }
}