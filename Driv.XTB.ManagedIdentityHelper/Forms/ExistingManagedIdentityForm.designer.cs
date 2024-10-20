namespace Driv.XTB.ManagedIdentityHelper.Forms
{
    partial class ExistingManagedIdentityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExistingManagedIdentityForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageManagedIdentity = new Driv.XTB.ManagedIdentityHelper.ImageGroupBox();
            this.cdsIdentityTxtSubjectScope = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.cdsIdentityTxtCredentialSource = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.cdsIdentityTxtTenantId = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.cdsIdentityTxtApplicationId = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cdsIdentityTxtName = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.cdsGridManagedIdentity = new xrmtb.XrmToolBox.Controls.CRMGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.Show = new System.Windows.Forms.Label();
            this.chkUnmanaged = new System.Windows.Forms.CheckBox();
            this.chkManaged = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.imageManagedIdentity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdsGridManagedIdentity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Show);
            this.panel2.Controls.Add(this.chkUnmanaged);
            this.panel2.Controls.Add(this.chkManaged);
            this.panel2.Controls.Add(this.imageManagedIdentity);
            this.panel2.Controls.Add(this.cdsGridManagedIdentity);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 455);
            this.panel2.TabIndex = 5;
            // 
            // imageManagedIdentity
            // 
            this.imageManagedIdentity.Controls.Add(this.cdsIdentityTxtSubjectScope);
            this.imageManagedIdentity.Controls.Add(this.cdsIdentityTxtCredentialSource);
            this.imageManagedIdentity.Controls.Add(this.cdsIdentityTxtTenantId);
            this.imageManagedIdentity.Controls.Add(this.cdsIdentityTxtApplicationId);
            this.imageManagedIdentity.Controls.Add(this.label3);
            this.imageManagedIdentity.Controls.Add(this.label5);
            this.imageManagedIdentity.Controls.Add(this.label10);
            this.imageManagedIdentity.Controls.Add(this.label9);
            this.imageManagedIdentity.Controls.Add(this.label2);
            this.imageManagedIdentity.Controls.Add(this.cdsIdentityTxtName);
            this.imageManagedIdentity.Icon = ((System.Drawing.Icon)(resources.GetObject("imageManagedIdentity.Icon")));
            this.imageManagedIdentity.Location = new System.Drawing.Point(563, 59);
            this.imageManagedIdentity.Name = "imageManagedIdentity";
            this.imageManagedIdentity.Size = new System.Drawing.Size(344, 187);
            this.imageManagedIdentity.TabIndex = 116;
            this.imageManagedIdentity.TabStop = false;
            this.imageManagedIdentity.Text = "Managed Identity";
            // 
            // cdsIdentityTxtSubjectScope
            // 
            this.cdsIdentityTxtSubjectScope.BackColor = System.Drawing.SystemColors.Window;
            this.cdsIdentityTxtSubjectScope.DisplayFormat = "subjectscope";
            this.cdsIdentityTxtSubjectScope.Entity = null;
            this.cdsIdentityTxtSubjectScope.EntityReference = null;
            this.cdsIdentityTxtSubjectScope.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsIdentityTxtSubjectScope.Location = new System.Drawing.Point(119, 149);
            this.cdsIdentityTxtSubjectScope.LogicalName = "managedidentity";
            this.cdsIdentityTxtSubjectScope.Name = "cdsIdentityTxtSubjectScope";
            this.cdsIdentityTxtSubjectScope.OrganizationService = null;
            this.cdsIdentityTxtSubjectScope.Size = new System.Drawing.Size(213, 20);
            this.cdsIdentityTxtSubjectScope.TabIndex = 126;
            // 
            // cdsIdentityTxtCredentialSource
            // 
            this.cdsIdentityTxtCredentialSource.BackColor = System.Drawing.SystemColors.Window;
            this.cdsIdentityTxtCredentialSource.DisplayFormat = "credentialsource";
            this.cdsIdentityTxtCredentialSource.Entity = null;
            this.cdsIdentityTxtCredentialSource.EntityReference = null;
            this.cdsIdentityTxtCredentialSource.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsIdentityTxtCredentialSource.Location = new System.Drawing.Point(119, 122);
            this.cdsIdentityTxtCredentialSource.LogicalName = "managedidentity";
            this.cdsIdentityTxtCredentialSource.Name = "cdsIdentityTxtCredentialSource";
            this.cdsIdentityTxtCredentialSource.OrganizationService = null;
            this.cdsIdentityTxtCredentialSource.Size = new System.Drawing.Size(213, 20);
            this.cdsIdentityTxtCredentialSource.TabIndex = 125;
            // 
            // cdsIdentityTxtTenantId
            // 
            this.cdsIdentityTxtTenantId.BackColor = System.Drawing.SystemColors.Window;
            this.cdsIdentityTxtTenantId.DisplayFormat = "tenantid";
            this.cdsIdentityTxtTenantId.Entity = null;
            this.cdsIdentityTxtTenantId.EntityReference = null;
            this.cdsIdentityTxtTenantId.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsIdentityTxtTenantId.Location = new System.Drawing.Point(95, 94);
            this.cdsIdentityTxtTenantId.LogicalName = "managedidentity";
            this.cdsIdentityTxtTenantId.Name = "cdsIdentityTxtTenantId";
            this.cdsIdentityTxtTenantId.OrganizationService = null;
            this.cdsIdentityTxtTenantId.Size = new System.Drawing.Size(237, 20);
            this.cdsIdentityTxtTenantId.TabIndex = 124;
            // 
            // cdsIdentityTxtApplicationId
            // 
            this.cdsIdentityTxtApplicationId.BackColor = System.Drawing.SystemColors.Window;
            this.cdsIdentityTxtApplicationId.DisplayFormat = "applicationid";
            this.cdsIdentityTxtApplicationId.Entity = null;
            this.cdsIdentityTxtApplicationId.EntityReference = null;
            this.cdsIdentityTxtApplicationId.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsIdentityTxtApplicationId.Location = new System.Drawing.Point(95, 68);
            this.cdsIdentityTxtApplicationId.LogicalName = "managedidentity";
            this.cdsIdentityTxtApplicationId.Name = "cdsIdentityTxtApplicationId";
            this.cdsIdentityTxtApplicationId.OrganizationService = null;
            this.cdsIdentityTxtApplicationId.Size = new System.Drawing.Size(237, 20);
            this.cdsIdentityTxtApplicationId.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 122;
            this.label3.Text = "TenantId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 120;
            this.label5.Text = "Subject Scope";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 118;
            this.label10.Text = "ApplicationId";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 117;
            this.label9.Text = "Credential Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // cdsIdentityTxtName
            // 
            this.cdsIdentityTxtName.BackColor = System.Drawing.SystemColors.Window;
            this.cdsIdentityTxtName.DisplayFormat = "name";
            this.cdsIdentityTxtName.Entity = null;
            this.cdsIdentityTxtName.EntityReference = null;
            this.cdsIdentityTxtName.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsIdentityTxtName.Location = new System.Drawing.Point(72, 38);
            this.cdsIdentityTxtName.LogicalName = "managedidentity";
            this.cdsIdentityTxtName.Name = "cdsIdentityTxtName";
            this.cdsIdentityTxtName.OrganizationService = null;
            this.cdsIdentityTxtName.Size = new System.Drawing.Size(260, 20);
            this.cdsIdentityTxtName.TabIndex = 12;
            // 
            // cdsGridManagedIdentity
            // 
            this.cdsGridManagedIdentity.AllowUserToOrderColumns = true;
            this.cdsGridManagedIdentity.AllowUserToResizeRows = false;
            this.cdsGridManagedIdentity.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.cdsGridManagedIdentity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cdsGridManagedIdentity.ColumnOrder = "name, applicationid, tenantid, credentialsource, subjectscope";
            this.cdsGridManagedIdentity.FilterColumns = "";
            this.cdsGridManagedIdentity.Location = new System.Drawing.Point(23, 97);
            this.cdsGridManagedIdentity.Name = "cdsGridManagedIdentity";
            this.cdsGridManagedIdentity.OrganizationService = null;
            this.cdsGridManagedIdentity.ShowFriendlyNames = true;
            this.cdsGridManagedIdentity.ShowIdColumn = false;
            this.cdsGridManagedIdentity.ShowIndexColumn = false;
            this.cdsGridManagedIdentity.Size = new System.Drawing.Size(510, 340);
            this.cdsGridManagedIdentity.TabIndex = 115;
            this.cdsGridManagedIdentity.RecordEnter += new xrmtb.XrmToolBox.Controls.CRMRecordEventHandler(this.cdsGridManagedIdentity_RecordEnter);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(19, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 20);
            this.lblTitle.TabIndex = 73;
            this.lblTitle.Text = "Link to Existing Managed Identity";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(825, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 32);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(682, 271);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(137, 32);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "Link to Plugin";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ttInfo
            // 
            this.ttInfo.AutoPopDelay = 10000;
            this.ttInfo.InitialDelay = 500;
            this.ttInfo.ReshowDelay = 100;
            this.ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttInfo.ToolTipTitle = "Attribute Info";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(104, 64);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(319, 20);
            this.txtDisplayName.TabIndex = 4;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.ItemHeight = 13;
            this.cboType.Location = new System.Drawing.Point(123, 89);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(211, 21);
            this.cboType.TabIndex = 6;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboCredentialSource_SelectedIndexChanged);
            // 
            // Show
            // 
            this.Show.AutoSize = true;
            this.Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(20, 43);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(38, 13);
            this.Show.TabIndex = 119;
            this.Show.Text = "Show";
            // 
            // chkUnmanaged
            // 
            this.chkUnmanaged.AutoSize = true;
            this.chkUnmanaged.Checked = true;
            this.chkUnmanaged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUnmanaged.Location = new System.Drawing.Point(32, 76);
            this.chkUnmanaged.Name = "chkUnmanaged";
            this.chkUnmanaged.Size = new System.Drawing.Size(84, 17);
            this.chkUnmanaged.TabIndex = 118;
            this.chkUnmanaged.Text = "Unmanaged";
            this.chkUnmanaged.UseVisualStyleBackColor = true;
            this.chkUnmanaged.CheckedChanged += new System.EventHandler(this.chkUnmanaged_CheckedChanged);
            // 
            // chkManaged
            // 
            this.chkManaged.AutoSize = true;
            this.chkManaged.Checked = true;
            this.chkManaged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkManaged.Location = new System.Drawing.Point(32, 59);
            this.chkManaged.Name = "chkManaged";
            this.chkManaged.Size = new System.Drawing.Size(71, 17);
            this.chkManaged.TabIndex = 117;
            this.chkManaged.Text = "Managed";
            this.chkManaged.UseVisualStyleBackColor = true;
            this.chkManaged.CheckedChanged += new System.EventHandler(this.chkManaged_CheckedChanged);
            // 
            // ExistingManagedIdentityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(949, 608);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExistingManagedIdentityForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Managed Identity Helper  ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.imageManagedIdentity.ResumeLayout(false);
            this.imageManagedIdentity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdsGridManagedIdentity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.ComboBox cboType;
        private xrmtb.XrmToolBox.Controls.CRMGridView cdsGridManagedIdentity;
        private ImageGroupBox imageManagedIdentity;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsIdentityTxtSubjectScope;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsIdentityTxtCredentialSource;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsIdentityTxtTenantId;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsIdentityTxtApplicationId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsIdentityTxtName;
        private System.Windows.Forms.Label Show;
        private System.Windows.Forms.CheckBox chkUnmanaged;
        private System.Windows.Forms.CheckBox chkManaged;
    }
}