namespace Driv.XTB.PluginIdentityManager.Forms
{
    partial class NewManagedIdentityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewManagedIdentityForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPluginName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenantId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSubjectScope = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cdsCboSolutions = new xrmtb.XrmToolBox.Controls.Controls.CDSDataComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApplicationId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCredentialSource = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtVersion);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblPluginName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTenantId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cboSubjectScope);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cdsCboSolutions);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtApplicationId);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cboCredentialSource);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 313);
            this.panel2.TabIndex = 5;
            // 
            // lblPluginName
            // 
            this.lblPluginName.AutoSize = true;
            this.lblPluginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPluginName.Location = new System.Drawing.Point(12, 249);
            this.lblPluginName.Name = "lblPluginName";
            this.lblPluginName.Size = new System.Drawing.Size(142, 13);
            this.lblPluginName.TabIndex = 115;
            this.lblPluginName.Text = "Assembly : Plugin Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 114;
            this.label2.Text = "TenantId";
            this.ttInfo.SetToolTip(this.label2, "Tenant Id ");
            // 
            // txtTenantId
            // 
            this.txtTenantId.Location = new System.Drawing.Point(104, 90);
            this.txtTenantId.Name = "txtTenantId";
            this.txtTenantId.Size = new System.Drawing.Size(319, 20);
            this.txtTenantId.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 112;
            this.label1.Text = "Subject Scope";
            this.ttInfo.SetToolTip(this.label1, "The Subject Scope of the Managed Identity.\r\nValue: 0 Label: GlobalScope\r\nValue: 1" +
        " Label: EnvironmentScope\r\nValue: 2 Label: DevOnlyScope\r\n");
            // 
            // cboSubjectScope
            // 
            this.cboSubjectScope.FormattingEnabled = true;
            this.cboSubjectScope.ItemHeight = 13;
            this.cboSubjectScope.Location = new System.Drawing.Point(123, 145);
            this.cboSubjectScope.Name = "cboSubjectScope";
            this.cboSubjectScope.Size = new System.Drawing.Size(211, 21);
            this.cboSubjectScope.TabIndex = 111;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 13);
            this.label12.TabIndex = 108;
            this.label12.Text = "Add to unmanaged solution (optional)";
            this.ttInfo.SetToolTip(this.label12, "Controls whether the Custom API can be customized or deleted when deployed as man" +
        "aged.");
            // 
            // cdsCboSolutions
            // 
            this.cdsCboSolutions.DisplayFormat = "{{friendlyname}} ({{P.customizationprefix}})";
            this.cdsCboSolutions.FormattingEnabled = true;
            this.cdsCboSolutions.Location = new System.Drawing.Point(28, 212);
            this.cdsCboSolutions.Name = "cdsCboSolutions";
            this.cdsCboSolutions.OrganizationService = null;
            this.cdsCboSolutions.Size = new System.Drawing.Size(252, 21);
            this.cdsCboSolutions.TabIndex = 10;
            this.cdsCboSolutions.SelectedIndexChanged += new System.EventHandler(this.cdsCboSolutions_SelectedIndexChanged);
            this.cdsCboSolutions.TextUpdate += new System.EventHandler(this.cdsCboSolutions_TextUpdate);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(19, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 20);
            this.lblTitle.TabIndex = 73;
            this.lblTitle.Text = "Create New Managed Identity";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(173, 269);
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
            this.btnOk.Location = new System.Drawing.Point(30, 269);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(137, 32);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "Create and Link";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "ApplicationId";
            this.ttInfo.SetToolTip(this.label10, "Client Id (ApplicationId) of the Managed Identity in Azure");
            // 
            // txtApplicationId
            // 
            this.txtApplicationId.Location = new System.Drawing.Point(104, 64);
            this.txtApplicationId.Name = "txtApplicationId";
            this.txtApplicationId.Size = new System.Drawing.Size(319, 20);
            this.txtApplicationId.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Credential Source";
            this.ttInfo.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // cboCredentialSource
            // 
            this.cboCredentialSource.Enabled = false;
            this.cboCredentialSource.FormattingEnabled = true;
            this.cboCredentialSource.ItemHeight = 13;
            this.cboCredentialSource.Location = new System.Drawing.Point(123, 118);
            this.cboCredentialSource.Name = "cboCredentialSource";
            this.cboCredentialSource.Size = new System.Drawing.Size(211, 21);
            this.cboCredentialSource.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Name";
            this.ttInfo.SetToolTip(this.label4, "The name of the managed identity record (optional)");
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(319, 20);
            this.txtName.TabIndex = 3;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 117;
            this.label3.Text = "Version";
            this.ttInfo.SetToolTip(this.label3, "Version indicating the format of the FIC subject.");
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(123, 172);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(128, 20);
            this.txtVersion.TabIndex = 118;
            this.txtVersion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVersion_KeyPress);
            // 
            // NewManagedIdentityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(456, 325);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewManagedIdentityForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plugin Identity Manager";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtApplicationId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCredentialSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.Label label12;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataComboBox cdsCboSolutions;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenantId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSubjectScope;
        private System.Windows.Forms.Label lblPluginName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVersion;
    }
}