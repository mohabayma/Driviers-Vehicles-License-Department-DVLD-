namespace DVLD
{
    partial class ctrlDriverLicense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblLocalLicensesRecords = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvLocalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblInternationalLicensesRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvInternationalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLocalLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensesHistory)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1303, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1293, 272);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.lblLocalLicensesRecords);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.dgvLocalLicensesHistory);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1285, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local";
            // 
            // lblLocalLicensesRecords
            // 
            this.lblLocalLicensesRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicensesRecords.Location = new System.Drawing.Point(163, 211);
            this.lblLocalLicensesRecords.Name = "lblLocalLicensesRecords";
            this.lblLocalLicensesRecords.Size = new System.Drawing.Size(440, 25);
            this.lblLocalLicensesRecords.TabIndex = 50;
            this.lblLocalLicensesRecords.Text = "[????]";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(7, 210);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(140, 23);
            this.label22.TabIndex = 49;
            this.label22.Text = " # Records:";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(260, 28);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "Local Licenses History: ";
            // 
            // dgvLocalLicensesHistory
            // 
            this.dgvLocalLicensesHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLocalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicensesHistory.Location = new System.Drawing.Point(6, 42);
            this.dgvLocalLicensesHistory.Name = "dgvLocalLicensesHistory";
            this.dgvLocalLicensesHistory.RowHeadersWidth = 51;
            this.dgvLocalLicensesHistory.RowTemplate.Height = 24;
            this.dgvLocalLicensesHistory.Size = new System.Drawing.Size(1272, 165);
            this.dgvLocalLicensesHistory.TabIndex = 0;
            this.dgvLocalLicensesHistory.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLocalLicensesHistory_CellMouseDown);
            this.dgvLocalLicensesHistory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvLocalLicensesHistory_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.lblInternationalLicensesRecords);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dgvInternationalLicensesHistory);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1285, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International";
            // 
            // lblInternationalLicensesRecords
            // 
            this.lblInternationalLicensesRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalLicensesRecords.Location = new System.Drawing.Point(163, 207);
            this.lblInternationalLicensesRecords.Name = "lblInternationalLicensesRecords";
            this.lblInternationalLicensesRecords.Size = new System.Drawing.Size(440, 25);
            this.lblInternationalLicensesRecords.TabIndex = 54;
            this.lblInternationalLicensesRecords.Text = "[????]";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = " # Records:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 28);
            this.label3.TabIndex = 52;
            this.label3.Text = "International Licenses History: ";
            // 
            // dgvInternationalLicensesHistory
            // 
            this.dgvInternationalLicensesHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInternationalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicensesHistory.Location = new System.Drawing.Point(6, 38);
            this.dgvInternationalLicensesHistory.Name = "dgvInternationalLicensesHistory";
            this.dgvInternationalLicensesHistory.RowHeadersWidth = 51;
            this.dgvInternationalLicensesHistory.RowTemplate.Height = 24;
            this.dgvInternationalLicensesHistory.Size = new System.Drawing.Size(1273, 165);
            this.dgvInternationalLicensesHistory.TabIndex = 51;
            this.dgvInternationalLicensesHistory.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInternationalLicensesHistory_CellMouseDown);
            this.dgvInternationalLicensesHistory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvInternationalLicensesHistory_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLocalLicenseInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(300, 42);
            // 
            // showLocalLicenseInfoToolStripMenuItem
            // 
            this.showLocalLicenseInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLocalLicenseInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32_1_1;
            this.showLocalLicenseInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLocalLicenseInfoToolStripMenuItem.Name = "showLocalLicenseInfoToolStripMenuItem";
            this.showLocalLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(299, 38);
            this.showLocalLicenseInfoToolStripMenuItem.Text = "Show Local License Info";
            this.showLocalLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLocalLicenseInfoToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(367, 42);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = global::DVLD.Properties.Resources.License_View_32_1_1;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(366, 38);
            this.toolStripMenuItem1.Text = "Show International License Info";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ctrlDriverLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlDriverLicense";
            this.Size = new System.Drawing.Size(1310, 310);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensesHistory)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvLocalLicensesHistory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLocalLicensesRecords;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblInternationalLicensesRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvInternationalLicensesHistory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLocalLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
