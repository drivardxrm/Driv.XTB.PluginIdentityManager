namespace Driv.XTB.PluginIdentityManager.Forms
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
            this.lblPluginName = new System.Windows.Forms.Label();
            this.Show = new System.Windows.Forms.Label();
            this.chkUnmanaged = new System.Windows.Forms.CheckBox();
            this.chkManaged = new System.Windows.Forms.CheckBox();
            this.imageManagedIdentity = new Driv.XTB.PluginIdentityManager.ImageGroupBox();
            this.cdsTxtIdentitySubjectScope = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.cdsTxtIdentityCredentialSource = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.cdsTxtIdentityTenantId = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.cdsTxtIdentityApplicationId = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cdsTxtIdentityName = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.cdsGridManagedIdentity = new xrmtb.XrmToolBox.Controls.CRMGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.imageManagedIdentity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdsGridManagedIdentity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblPluginName);
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
            // lblPluginName
            // 
            this.lblPluginName.AutoSize = true;
            this.lblPluginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPluginName.Location = new System.Drawing.Point(679, 306);
            this.lblPluginName.Name = "lblPluginName";
            this.lblPluginName.Size = new System.Drawing.Size(120, 13);
            this.lblPluginName.TabIndex = 120;
            this.lblPluginName.Text = "Assembly : Plugin Name";
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
            // imageManagedIdentity
            // 
            this.imageManagedIdentity.Controls.Add(this.cdsTxtIdentitySubjectScope);
            this.imageManagedIdentity.Controls.Add(this.cdsTxtIdentityCredentialSource);
            this.imageManagedIdentity.Controls.Add(this.cdsTxtIdentityTenantId);
            this.imageManagedIdentity.Controls.Add(this.cdsTxtIdentityApplicationId);
            this.imageManagedIdentity.Controls.Add(this.label3);
            this.imageManagedIdentity.Controls.Add(this.label5);
            this.imageManagedIdentity.Controls.Add(this.label10);
            this.imageManagedIdentity.Controls.Add(this.label9);
            this.imageManagedIdentity.Controls.Add(this.label2);
            this.imageManagedIdentity.Controls.Add(this.cdsTxtIdentityName);
            this.imageManagedIdentity.Icon = ((System.Drawing.Icon)(resources.GetObject("imageManagedIdentity.Icon")));
            this.imageManagedIdentity.Location = new System.Drawing.Point(563, 59);
            this.imageManagedIdentity.Name = "imageManagedIdentity";
            this.imageManagedIdentity.Size = new System.Drawing.Size(344, 187);
            this.imageManagedIdentity.TabIndex = 116;
            this.imageManagedIdentity.TabStop = false;
            this.imageManagedIdentity.Text = "Managed Identity";
            // 
            // cdsTxtIdentitySubjectScope
            // 
            this.cdsTxtIdentitySubjectScope.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTxtIdentitySubjectScope.DisplayFormat = "subjectscope";
            this.cdsTxtIdentitySubjectScope.Entity = null;
            this.cdsTxtIdentitySubjectScope.EntityReference = null;
            this.cdsTxtIdentitySubjectScope.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTxtIdentitySubjectScope.Location = new System.Drawing.Point(119, 149);
            this.cdsTxtIdentitySubjectScope.LogicalName = "managedidentity";
            this.cdsTxtIdentitySubjectScope.Name = "cdsTxtIdentitySubjectScope";
            this.cdsTxtIdentitySubjectScope.OrganizationService = null;
            this.cdsTxtIdentitySubjectScope.Size = new System.Drawing.Size(213, 20);
            this.cdsTxtIdentitySubjectScope.TabIndex = 126;
            // 
            // cdsTxtIdentityCredentialSource
            // 
            this.cdsTxtIdentityCredentialSource.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTxtIdentityCredentialSource.DisplayFormat = "credentialsource";
            this.cdsTxtIdentityCredentialSource.Entity = null;
            this.cdsTxtIdentityCredentialSource.EntityReference = null;
            this.cdsTxtIdentityCredentialSource.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTxtIdentityCredentialSource.Location = new System.Drawing.Point(119, 122);
            this.cdsTxtIdentityCredentialSource.LogicalName = "managedidentity";
            this.cdsTxtIdentityCredentialSource.Name = "cdsTxtIdentityCredentialSource";
            this.cdsTxtIdentityCredentialSource.OrganizationService = null;
            this.cdsTxtIdentityCredentialSource.Size = new System.Drawing.Size(213, 20);
            this.cdsTxtIdentityCredentialSource.TabIndex = 125;
            // 
            // cdsTxtIdentityTenantId
            // 
            this.cdsTxtIdentityTenantId.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTxtIdentityTenantId.DisplayFormat = "tenantid";
            this.cdsTxtIdentityTenantId.Entity = null;
            this.cdsTxtIdentityTenantId.EntityReference = null;
            this.cdsTxtIdentityTenantId.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTxtIdentityTenantId.Location = new System.Drawing.Point(95, 94);
            this.cdsTxtIdentityTenantId.LogicalName = "managedidentity";
            this.cdsTxtIdentityTenantId.Name = "cdsTxtIdentityTenantId";
            this.cdsTxtIdentityTenantId.OrganizationService = null;
            this.cdsTxtIdentityTenantId.Size = new System.Drawing.Size(237, 20);
            this.cdsTxtIdentityTenantId.TabIndex = 124;
            // 
            // cdsTxtIdentityApplicationId
            // 
            this.cdsTxtIdentityApplicationId.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTxtIdentityApplicationId.DisplayFormat = "applicationid";
            this.cdsTxtIdentityApplicationId.Entity = null;
            this.cdsTxtIdentityApplicationId.EntityReference = null;
            this.cdsTxtIdentityApplicationId.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTxtIdentityApplicationId.Location = new System.Drawing.Point(95, 68);
            this.cdsTxtIdentityApplicationId.LogicalName = "managedidentity";
            this.cdsTxtIdentityApplicationId.Name = "cdsTxtIdentityApplicationId";
            this.cdsTxtIdentityApplicationId.OrganizationService = null;
            this.cdsTxtIdentityApplicationId.Size = new System.Drawing.Size(237, 20);
            this.cdsTxtIdentityApplicationId.TabIndex = 123;
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
            // cdsTxtIdentityName
            // 
            this.cdsTxtIdentityName.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTxtIdentityName.DisplayFormat = "name";
            this.cdsTxtIdentityName.Entity = null;
            this.cdsTxtIdentityName.EntityReference = null;
            this.cdsTxtIdentityName.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTxtIdentityName.Location = new System.Drawing.Point(72, 38);
            this.cdsTxtIdentityName.LogicalName = "managedidentity";
            this.cdsTxtIdentityName.Name = "cdsTxtIdentityName";
            this.cdsTxtIdentityName.OrganizationService = null;
            this.cdsTxtIdentityName.Size = new System.Drawing.Size(260, 20);
            this.cdsTxtIdentityName.TabIndex = 12;
            // 
            // cdsGridManagedIdentity
            // 
            this.cdsGridManagedIdentity.AllowUserToOrderColumns = true;
            this.cdsGridManagedIdentity.AllowUserToResizeRows = false;
            this.cdsGridManagedIdentity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 121;
            this.label1.Text = "Note : Filter on CredentialSource = 2 (IsManaged)";
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
            this.Text = "Plugin Identity Manager ";
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
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtIdentitySubjectScope;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtIdentityCredentialSource;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtIdentityTenantId;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtIdentityApplicationId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtIdentityName;
        private System.Windows.Forms.Label Show;
        private System.Windows.Forms.CheckBox chkUnmanaged;
        private System.Windows.Forms.CheckBox chkManaged;
        private System.Windows.Forms.Label lblPluginName;
        private System.Windows.Forms.Label label1;
    }
}