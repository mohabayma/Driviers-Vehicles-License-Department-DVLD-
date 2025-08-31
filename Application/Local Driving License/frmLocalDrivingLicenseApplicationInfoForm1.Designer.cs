namespace DVLD
{
    partial class frmLocalDrivingLicenseApplicationInfoForm1
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
            this.ctrlDrivingLicens1 = new DVLD.ctrlDrivingLicens();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlDrivingLicens1
            // 
            this.ctrlDrivingLicens1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctrlDrivingLicens1.Location = new System.Drawing.Point(12, 12);
            this.ctrlDrivingLicens1.Name = "ctrlDrivingLicens1";
            this.ctrlDrivingLicens1.Size = new System.Drawing.Size(969, 440);
            this.ctrlDrivingLicens1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32_1_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(863, 459);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 39);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLocalDrivingLicenseApplicationInfoForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(993, 511);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlDrivingLicens1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLocalDrivingLicenseApplicationInfoForm1";
            this.Text = "frmLocalDrivingLicenseApplicationInfoForm1";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplicationInfoForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDrivingLicens ctrlDrivingLicens1;
        private System.Windows.Forms.Button btnClose;
    }
}