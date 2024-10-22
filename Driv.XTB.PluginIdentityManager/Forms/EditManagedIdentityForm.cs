
using Driv.XTB.PluginIdentityManager.Entities;
using Driv.XTB.PluginIdentityManager.Helpers;
using Driv.XTB.PluginIdentityManager.Proxy;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using System;
using System.Linq;
using System.Windows.Forms;
using xrmtb.XrmToolBox.Controls.Controls;
using XrmToolBox.Extensibility;


namespace Driv.XTB.PluginIdentityManager.Forms
{
    public partial class EditManagedIdentityForm : Form
    {
        #region Private Fields

        //private Control focus;
        private ConnectionDetail _connection;
        private IOrganizationService _service;
        private ManagedIdentityProxy _identity;
        
        private SolutionProxy _selectedSolution;
        private Settings _settings;

        #endregion Private Fields

        #region Public Constructors

        public EditManagedIdentityForm(IOrganizationService service,ManagedIdentityProxy identity, SolutionProxy solution, Settings settings, ConnectionDetail connection)
        {
            InitializeComponent();
            _service = service;
            _settings = settings;
            _identity = identity;
            _connection = connection;

            txtName.Text = _identity.Name;
            txtApplicationId.Text = _identity.ManagedIdentityRow[ManagedIdentity.ApplicationId].ToString();
            txtTenantId.Text = _identity.ManagedIdentityRow[ManagedIdentity.TenantId].ToString();


            cboCredentialSource.DataSource = Enum.GetValues(typeof(ManagedIdentity.CredentialSource_OptionSet));
            cboCredentialSource.SelectedIndex = ((OptionSetValue)_identity.ManagedIdentityRow[ManagedIdentity.CredentialSource]).Value;

            cboSubjectScope.DataSource = Enum.GetValues(typeof(ManagedIdentity.SubjectScope_OptionSet));
            cboSubjectScope.SelectedIndex = ((OptionSetValue)_identity.ManagedIdentityRow[ManagedIdentity.SubjectScope]).Value;
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// GUID of the Managed Identity Parameter Created
        /// </summary>
        public Guid UpdatedManagedIdentityId { get; private set; }

        #endregion Public Properties



        #region Private Event Handlers


        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;



                // Link to PLugin Assembly
                var updatedIdentity = ManagedIdentityToUpdate();
               

                _service.Update(updatedIdentity);

                UpdatedManagedIdentityId = updatedIdentity.Id;

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show($"Error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                DialogResult = DialogResult.None;
            }

        }

        #endregion Private Event Handlers


        private Entity ManagedIdentityToUpdate()
        {
            var managedIdentity = new Entity(ManagedIdentity.EntityName) {
                Id = _identity.ManagedIdentityRow.Id
            };
            if (txtName.Text != _identity.Name)
            {
                managedIdentity[ManagedIdentity.PrimaryName] = txtName.Text;
            }
            
            if (cboSubjectScope.SelectedIndex != ((OptionSetValue)_identity.ManagedIdentityRow[ManagedIdentity.SubjectScope]).Value)
            {
                managedIdentity[ManagedIdentity.SubjectScope] = new OptionSetValue(cboSubjectScope.SelectedIndex);
            }
            if(txtApplicationId.Text != _identity.ManagedIdentityRow[ManagedIdentity.ApplicationId].ToString())
            {
                managedIdentity[ManagedIdentity.ApplicationId] = Guid.Parse(txtApplicationId.Text);
            }
            if (txtTenantId.Text != _identity.ManagedIdentityRow[ManagedIdentity.TenantId].ToString())
            {
                managedIdentity[ManagedIdentity.TenantId] = Guid.Parse(txtTenantId.Text);
            }

            return managedIdentity;
        }

    }
}
