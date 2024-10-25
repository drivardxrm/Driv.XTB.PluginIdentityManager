namespace Driv.XTB.PluginIdentityManager
{
    partial class PluginIdentityManagerControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginIdentityManagerControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.menuRefresh = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSample = new System.Windows.Forms.ToolStripButton();
            this.tslAbout = new System.Windows.Forms.ToolStripLabel();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cdsCboPlugin = new xrmtb.XrmToolBox.Controls.Controls.CDSDataComboBox();
            this.Show = new System.Windows.Forms.Label();
            this.chkUnmanaged = new System.Windows.Forms.CheckBox();
            this.chkManaged = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cdsCboSolutions = new xrmtb.XrmToolBox.Controls.Controls.CDSDataComboBox();
            this.rbSolution = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.imagePlugin = new Driv.XTB.PluginIdentityManager.ImageGroupBox();
            this.lblCertificate = new System.Windows.Forms.TextBox();
            this.Version = new System.Windows.Forms.Label();
            this.cdsTxtPluginVersion = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.btnExistingIdentity = new System.Windows.Forms.Button();
            this.imageManagedIdentity = new Driv.XTB.PluginIdentityManager.ImageGroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditIdentity = new System.Windows.Forms.Button();
            this.cdsTxtIdentityIsManaged = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.cdsTxtPluginIsManaged = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewIdentity = new System.Windows.Forms.Button();
            this.cdsTxtPluginName = new xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox();
            this.toolStripMenu.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.imagePlugin.SuspendLayout();
            this.imageManagedIdentity.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRefresh,
            this.tssSeparator1,
            this.tsbSample,
            this.tslAbout});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1073, 31);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // menuRefresh
            // 
            this.menuRefresh.Image = ((System.Drawing.Image)(resources.GetObject("menuRefresh.Image")));
            this.menuRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.Size = new System.Drawing.Size(132, 28);
            this.menuRefresh.Text = "Refresh Plugin List";
            this.menuRefresh.Click += new System.EventHandler(this.menuRefresh_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbSample
            // 
            this.tsbSample.Name = "tsbSample";
            this.tsbSample.Size = new System.Drawing.Size(23, 28);
            // 
            // tslAbout
            // 
            this.tslAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslAbout.Image = global::Driv.XTB.PluginIdentityManager.Properties.Resources.icons8_identity_32;
            this.tslAbout.IsLink = true;
            this.tslAbout.Name = "tslAbout";
            this.tslAbout.Size = new System.Drawing.Size(113, 28);
            this.tslAbout.Text = "by David Rivard";
            this.tslAbout.Click += new System.EventHandler(this.tslAbout_Click);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Controls.Add(this.cdsCboPlugin);
            this.grpFilter.Controls.Add(this.Show);
            this.grpFilter.Controls.Add(this.chkUnmanaged);
            this.grpFilter.Controls.Add(this.chkManaged);
            this.grpFilter.Controls.Add(this.label22);
            this.grpFilter.Controls.Add(this.cdsCboSolutions);
            this.grpFilter.Controls.Add(this.rbSolution);
            this.grpFilter.Controls.Add(this.rbAll);
            this.grpFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilter.Location = new System.Drawing.Point(13, 39);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(756, 80);
            this.grpFilter.TabIndex = 22;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Select Plugin Assembly";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Plugin Assemblies";
            // 
            // cdsCboPlugin
            // 
            this.cdsCboPlugin.DisplayFormat = "{{name}}";
            this.cdsCboPlugin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdsCboPlugin.FormattingEnabled = true;
            this.cdsCboPlugin.Location = new System.Drawing.Point(128, 43);
            this.cdsCboPlugin.Name = "cdsCboPlugin";
            this.cdsCboPlugin.OrganizationService = null;
            this.cdsCboPlugin.Size = new System.Drawing.Size(414, 21);
            this.cdsCboPlugin.TabIndex = 97;
            this.cdsCboPlugin.SelectedIndexChanged += new System.EventHandler(this.cdsCboPlugin_SelectedIndexChanged);
            // 
            // Show
            // 
            this.Show.AutoSize = true;
            this.Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(555, 18);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(38, 13);
            this.Show.TabIndex = 96;
            this.Show.Text = "Show";
            // 
            // chkUnmanaged
            // 
            this.chkUnmanaged.AutoSize = true;
            this.chkUnmanaged.Checked = true;
            this.chkUnmanaged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUnmanaged.Location = new System.Drawing.Point(558, 51);
            this.chkUnmanaged.Name = "chkUnmanaged";
            this.chkUnmanaged.Size = new System.Drawing.Size(84, 17);
            this.chkUnmanaged.TabIndex = 86;
            this.chkUnmanaged.Text = "Unmanaged";
            this.chkUnmanaged.UseVisualStyleBackColor = true;
            this.chkUnmanaged.CheckedChanged += new System.EventHandler(this.chkUnmanaged_CheckedChanged);
            // 
            // chkManaged
            // 
            this.chkManaged.AutoSize = true;
            this.chkManaged.Checked = true;
            this.chkManaged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkManaged.Location = new System.Drawing.Point(558, 34);
            this.chkManaged.Name = "chkManaged";
            this.chkManaged.Size = new System.Drawing.Size(71, 17);
            this.chkManaged.TabIndex = 85;
            this.chkManaged.Text = "Managed";
            this.chkManaged.UseVisualStyleBackColor = true;
            this.chkManaged.CheckedChanged += new System.EventHandler(this.chkManaged_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(11, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 84;
            this.label22.Text = "Filter";
            // 
            // cdsCboSolutions
            // 
            this.cdsCboSolutions.DisplayFormat = "{{friendlyname}} ({{P.customizationprefix}})";
            this.cdsCboSolutions.Enabled = false;
            this.cdsCboSolutions.FormattingEnabled = true;
            this.cdsCboSolutions.Location = new System.Drawing.Point(176, 18);
            this.cdsCboSolutions.Name = "cdsCboSolutions";
            this.cdsCboSolutions.OrganizationService = null;
            this.cdsCboSolutions.Size = new System.Drawing.Size(366, 21);
            this.cdsCboSolutions.TabIndex = 3;
            // 
            // rbSolution
            // 
            this.rbSolution.AutoSize = true;
            this.rbSolution.Location = new System.Drawing.Point(89, 20);
            this.rbSolution.Name = "rbSolution";
            this.rbSolution.Size = new System.Drawing.Size(78, 17);
            this.rbSolution.TabIndex = 2;
            this.rbSolution.TabStop = true;
            this.rbSolution.Text = "By Solution";
            this.rbSolution.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(50, 20);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(36, 17);
            this.rbAll.TabIndex = 1;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // imagePlugin
            // 
            this.imagePlugin.Controls.Add(this.lblCertificate);
            this.imagePlugin.Controls.Add(this.Version);
            this.imagePlugin.Controls.Add(this.cdsTxtPluginVersion);
            this.imagePlugin.Controls.Add(this.btnExistingIdentity);
            this.imagePlugin.Controls.Add(this.imageManagedIdentity);
            this.imagePlugin.Controls.Add(this.cdsTxtPluginIsManaged);
            this.imagePlugin.Controls.Add(this.label23);
            this.imagePlugin.Controls.Add(this.label4);
            this.imagePlugin.Controls.Add(this.btnNewIdentity);
            this.imagePlugin.Controls.Add(this.cdsTxtPluginName);
            this.imagePlugin.Enabled = false;
            this.imagePlugin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePlugin.Icon = ((System.Drawing.Icon)(resources.GetObject("imagePlugin.Icon")));
            this.imagePlugin.Location = new System.Drawing.Point(13, 125);
            this.imagePlugin.Name = "imagePlugin";
            this.imagePlugin.Size = new System.Drawing.Size(789, 309);
            this.imagePlugin.TabIndex = 23;
            this.imagePlugin.TabStop = false;
            this.imagePlugin.Text = "Plugin Assembly";
            // 
            // lblCertificate
            // 
            this.lblCertificate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertificate.Location = new System.Drawing.Point(21, 129);
            this.lblCertificate.Multiline = true;
            this.lblCertificate.Name = "lblCertificate";
            this.lblCertificate.ReadOnly = true;
            this.lblCertificate.Size = new System.Drawing.Size(199, 52);
            this.lblCertificate.TabIndex = 96;
            this.lblCertificate.Text = "Plugin Assembly must be signed with a valid certificate to associate to a managed" +
    " identity";
            this.lblCertificate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblCertificate.Visible = false;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(18, 66);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(42, 13);
            this.Version.TabIndex = 95;
            this.Version.Text = "Version";
            // 
            // cdsTxtPluginVersion
            // 
            this.cdsTxtPluginVersion.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTxtPluginVersion.DisplayFormat = "version";
            this.cdsTxtPluginVersion.Entity = null;
            this.cdsTxtPluginVersion.EntityReference = null;
            this.cdsTxtPluginVersion.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTxtPluginVersion.Location = new System.Drawing.Point(82, 62);
            this.cdsTxtPluginVersion.LogicalName = "pluginassembly";
            this.cdsTxtPluginVersion.Name = "cdsTxtPluginVersion";
            this.cdsTxtPluginVersion.OrganizationService = null;
            this.cdsTxtPluginVersion.Size = new System.Drawing.Size(68, 20);
            this.cdsTxtPluginVersion.TabIndex = 93;
            // 
            // btnExistingIdentity
            // 
            this.btnExistingIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistingIdentity.Image = global::Driv.XTB.PluginIdentityManager.Properties.Resources.icons8_link_25;
            this.btnExistingIdentity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExistingIdentity.Location = new System.Drawing.Point(528, 23);
            this.btnExistingIdentity.Name = "btnExistingIdentity";
            this.btnExistingIdentity.Size = new System.Drawing.Size(181, 33);
            this.btnExistingIdentity.TabIndex = 92;
            this.btnExistingIdentity.Text = "Link to existing Identity";
            this.btnExistingIdentity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExistingIdentity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExistingIdentity.UseVisualStyleBackColor = true;
            this.btnExistingIdentity.Click += new System.EventHandler(this.btnExistingIdentity_Click);
            // 
            // imageManagedIdentity
            // 
            this.imageManagedIdentity.Controls.Add(this.btnDelete);
            this.imageManagedIdentity.Controls.Add(this.btnEditIdentity);
            this.imageManagedIdentity.Controls.Add(this.cdsTxtIdentityIsManaged);
            this.imageManagedIdentity.Controls.Add(this.label6);
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
            this.imageManagedIdentity.Enabled = false;
            this.imageManagedIdentity.Icon = ((System.Drawing.Icon)(resources.GetObject("imageManagedIdentity.Icon")));
            this.imageManagedIdentity.Location = new System.Drawing.Point(355, 58);
            this.imageManagedIdentity.Name = "imageManagedIdentity";
            this.imageManagedIdentity.Size = new System.Drawing.Size(428, 245);
            this.imageManagedIdentity.TabIndex = 91;
            this.imageManagedIdentity.TabStop = false;
            this.imageManagedIdentity.Text = "Managed Identity";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(348, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 29);
            this.btnDelete.TabIndex = 127;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditIdentity
            // 
            this.btnEditIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditIdentity.Image = global::Driv.XTB.PluginIdentityManager.Properties.Resources.icons8_edit_20;
            this.btnEditIdentity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditIdentity.Location = new System.Drawing.Point(348, 21);
            this.btnEditIdentity.Name = "btnEditIdentity";
            this.btnEditIdentity.Size = new System.Drawing.Size(74, 33);
            this.btnEditIdentity.TabIndex = 96;
            this.btnEditIdentity.Text = "Edit";
            this.btnEditIdentity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditIdentity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditIdentity.UseVisualStyleBackColor = true;
            this.btnEditIdentity.Click += new System.EventHandler(this.btnEditIdentity_Click);
            // 
            // cdsTxtIdentityIsManaged
            // 
            this.cdsTxtIdentityIsManaged.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTxtIdentityIsManaged.DisplayFormat = "ismanaged";
            this.cdsTxtIdentityIsManaged.Entity = null;
            this.cdsTxtIdentityIsManaged.EntityReference = null;
            this.cdsTxtIdentityIsManaged.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTxtIdentityIsManaged.Location = new System.Drawing.Point(108, 175);
            this.cdsTxtIdentityIsManaged.LogicalName = "managedidentity";
            this.cdsTxtIdentityIsManaged.Name = "cdsTxtIdentityIsManaged";
            this.cdsTxtIdentityIsManaged.OrganizationService = null;
            this.cdsTxtIdentityIsManaged.Size = new System.Drawing.Size(68, 20);
            this.cdsTxtIdentityIsManaged.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "IsManaged";
            // 
            // cdsTxtIdentitySubjectScope
            // 
            this.cdsTxtIdentitySubjectScope.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTxtIdentitySubjectScope.DisplayFormat = "subjectscope";
            this.cdsTxtIdentitySubjectScope.Entity = null;
            this.cdsTxtIdentitySubjectScope.EntityReference = null;
            this.cdsTxtIdentitySubjectScope.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTxtIdentitySubjectScope.Location = new System.Drawing.Point(108, 149);
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
            this.cdsTxtIdentityCredentialSource.Location = new System.Drawing.Point(108, 122);
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
            this.cdsTxtIdentityTenantId.Location = new System.Drawing.Point(84, 94);
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
            this.cdsTxtIdentityApplicationId.Location = new System.Drawing.Point(84, 68);
            this.cdsTxtIdentityApplicationId.LogicalName = "managedidentity";
            this.cdsTxtIdentityApplicationId.Name = "cdsTxtIdentityApplicationId";
            this.cdsTxtIdentityApplicationId.OrganizationService = null;
            this.cdsTxtIdentityApplicationId.Size = new System.Drawing.Size(237, 20);
            this.cdsTxtIdentityApplicationId.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 122;
            this.label3.Text = "TenantId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 120;
            this.label5.Text = "Subject Scope";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 118;
            this.label10.Text = "ApplicationId";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 117;
            this.label9.Text = "Credential Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
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
            this.cdsTxtIdentityName.Location = new System.Drawing.Point(61, 38);
            this.cdsTxtIdentityName.LogicalName = "managedidentity";
            this.cdsTxtIdentityName.Name = "cdsTxtIdentityName";
            this.cdsTxtIdentityName.OrganizationService = null;
            this.cdsTxtIdentityName.Size = new System.Drawing.Size(260, 20);
            this.cdsTxtIdentityName.TabIndex = 12;
            // 
            // cdsTxtPluginIsManaged
            // 
            this.cdsTxtPluginIsManaged.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTxtPluginIsManaged.DisplayFormat = "ismanaged";
            this.cdsTxtPluginIsManaged.Entity = null;
            this.cdsTxtPluginIsManaged.EntityReference = null;
            this.cdsTxtPluginIsManaged.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTxtPluginIsManaged.Location = new System.Drawing.Point(84, 93);
            this.cdsTxtPluginIsManaged.LogicalName = "pluginassembly";
            this.cdsTxtPluginIsManaged.Name = "cdsTxtPluginIsManaged";
            this.cdsTxtPluginIsManaged.OrganizationService = null;
            this.cdsTxtPluginIsManaged.Size = new System.Drawing.Size(68, 20);
            this.cdsTxtPluginIsManaged.TabIndex = 88;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 96);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 89;
            this.label23.Text = "IsManaged";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            // 
            // btnNewIdentity
            // 
            this.btnNewIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewIdentity.Image = ((System.Drawing.Image)(resources.GetObject("btnNewIdentity.Image")));
            this.btnNewIdentity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewIdentity.Location = new System.Drawing.Point(365, 23);
            this.btnNewIdentity.Name = "btnNewIdentity";
            this.btnNewIdentity.Size = new System.Drawing.Size(157, 33);
            this.btnNewIdentity.TabIndex = 5;
            this.btnNewIdentity.Text = "Link to New Identity";
            this.btnNewIdentity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewIdentity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewIdentity.UseVisualStyleBackColor = true;
            this.btnNewIdentity.Click += new System.EventHandler(this.btnNewIdentity_Click);
            // 
            // cdsTxtPluginName
            // 
            this.cdsTxtPluginName.BackColor = System.Drawing.SystemColors.Window;
            this.cdsTxtPluginName.DisplayFormat = "name";
            this.cdsTxtPluginName.Entity = null;
            this.cdsTxtPluginName.EntityReference = null;
            this.cdsTxtPluginName.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.cdsTxtPluginName.Location = new System.Drawing.Point(60, 36);
            this.cdsTxtPluginName.LogicalName = "pluginassembly";
            this.cdsTxtPluginName.Name = "cdsTxtPluginName";
            this.cdsTxtPluginName.OrganizationService = null;
            this.cdsTxtPluginName.Size = new System.Drawing.Size(274, 20);
            this.cdsTxtPluginName.TabIndex = 11;
            // 
            // PluginIdentityManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imagePlugin);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "PluginIdentityManagerControl";
            this.Size = new System.Drawing.Size(1073, 437);
            this.Load += new System.EventHandler(this.PluginIdentityManagerControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.imagePlugin.ResumeLayout(false);
            this.imagePlugin.PerformLayout();
            this.imageManagedIdentity.ResumeLayout(false);
            this.imageManagedIdentity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbSample;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.ToolStripButton menuRefresh;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label Show;
        private System.Windows.Forms.CheckBox chkUnmanaged;
        private System.Windows.Forms.CheckBox chkManaged;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnNewIdentity;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataComboBox cdsCboSolutions;
        private System.Windows.Forms.RadioButton rbSolution;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label label1;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataComboBox cdsCboPlugin;
        private ImageGroupBox imagePlugin;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtPluginIsManaged;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label4;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtPluginName;
        private ImageGroupBox imageManagedIdentity;
        private System.Windows.Forms.Label label2;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtIdentityName;
        private System.Windows.Forms.Button btnExistingIdentity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtIdentitySubjectScope;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtIdentityCredentialSource;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtIdentityTenantId;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtIdentityApplicationId;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtIdentityIsManaged;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Version;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataTextBox cdsTxtPluginVersion;
        private System.Windows.Forms.ToolStripLabel tslAbout;
        private System.Windows.Forms.Button btnEditIdentity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox lblCertificate;
    }
}
