namespace DVLD
{
    partial class frmFindPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindPerson));
            this.lblAddUpdarePerson = new System.Windows.Forms.Label();
            this.ctrlPersonInfoWithFiltering1 = new DVLD.ctrlPersonInfoWithFiltering();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddUpdarePerson
            // 
            this.lblAddUpdarePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUpdarePerson.ForeColor = System.Drawing.Color.Red;
            this.lblAddUpdarePerson.Location = new System.Drawing.Point(296, 33);
            this.lblAddUpdarePerson.Name = "lblAddUpdarePerson";
            this.lblAddUpdarePerson.Size = new System.Drawing.Size(368, 56);
            this.lblAddUpdarePerson.TabIndex = 11;
            this.lblAddUpdarePerson.Text = "Find Person";
            this.lblAddUpdarePerson.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ctrlPersonInfoWithFiltering1
            // 
            this.ctrlPersonInfoWithFiltering1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctrlPersonInfoWithFiltering1.FilterEnabled = true;
            this.ctrlPersonInfoWithFiltering1.Location = new System.Drawing.Point(12, 92);
            this.ctrlPersonInfoWithFiltering1.Name = "ctrlPersonInfoWithFiltering1";
            this.ctrlPersonInfoWithFiltering1.ShowAddPerson = true;
            this.ctrlPersonInfoWithFiltering1.Size = new System.Drawing.Size(956, 483);
            this.ctrlPersonInfoWithFiltering1.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32_1_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(829, 582);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 42);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(977, 649);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlPersonInfoWithFiltering1);
            this.Controls.Add(this.lblAddUpdarePerson);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFindPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FindPerson";
            this.Load += new System.EventHandler(this.FindPerson_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAddUpdarePerson;
        private ctrlPersonInfoWithFiltering ctrlPersonInfoWithFiltering1;
        private System.Windows.Forms.Button btnClose;
    }
}