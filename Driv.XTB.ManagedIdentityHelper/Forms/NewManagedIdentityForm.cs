using Driv.XTB.ManagedIdentityHelper;
using Driv.XTB.ManagedIdentityHelper.Entities;
using Driv.XTB.ManagedIdentityHelper.Helpers;
using Driv.XTB.ManagedIdentityHelper.Proxy;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using System;
using System.Linq;
using System.Windows.Forms;
using xrmtb.XrmToolBox.Controls.Controls;
using XrmToolBox.Extensibility;

//using XTB.CustomApiManager.Proxy;
//using static XTB.CustomApiManager.Entities.CustomAPI;

namespace Driv.XTB.ManagedIdentityHelper.Forms
{
    public partial class NewManagedIdentityForm : Form
    {
        #region Private Fields

        //private Control focus;
        private ConnectionDetail _connection;
        private IOrganizationService _service;
        private PluginAssemblyProxy _plugin;
        private SolutionProxy _selectedSolution;
        private Settings _settings;

        #endregion Private Fields

        #region Public Constructors

        public NewManagedIdentityForm(IOrganizationService service,PluginAssemblyProxy plugin, SolutionProxy solution, Settings settings, ConnectionDetail connection)
        {
            InitializeComponent();
            _service = service;
            _settings = settings;
            _plugin = plugin;
            _connection = connection;

            txtName.Text = $"{plugin.Name} Identity";

            //txtTenantId.Text = _connection.TenantId.ToString();
            //cboEntities.Service = service;
            //cboEntities.Update();

            cboCredentialSource.DataSource = Enum.GetValues(typeof(ManagedIdentity.CredentialSource_OptionSet));
            cboCredentialSource.SelectedIndex = (int)ManagedIdentity.CredentialSource_OptionSet.IsManaged;

            cboSubjectScope.DataSource = Enum.GetValues(typeof(ManagedIdentity.SubjectScope_OptionSet));
            cboSubjectScope.SelectedIndex = (int)ManagedIdentity.SubjectScope_OptionSet.EnvironmentScope;

            //cdsCustomApiName.Entity = customapi.CustomApiRow;

            cdsCboSolutions.OrganizationService = service;

            var unmanagedsolutions = _service.GetUnmanagedSolutions();
            cdsCboSolutions.SelectedIndexChanged -= new EventHandler(cdsCboSolutions_SelectedIndexChanged);
            cdsCboSolutions.DataSource = unmanagedsolutions;
            cdsCboSolutions.SelectedIndexChanged += new EventHandler(cdsCboSolutions_SelectedIndexChanged);

            cdsCboSolutions.SelectedIndex = unmanagedsolutions.Entities.Select(e => e.Id).ToList().IndexOf(solution?.SolutionRow?.Id ?? Guid.Empty);

        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// GUID of the Managed Identity Parameter Created
        /// </summary>
        public Guid NewManagedIdentityId { get; private set; }

        #endregion Public Properties



        #region Private Event Handlers


        // remove this
        private void txtUniqueName_Leave(object sender, EventArgs e)
        {
            //var compositename = _settings.ResponsePropertyDefaultName
            //                .Replace("{customapiname}", cdsCustomApiName.Entity.Attributes[CustomAPI.PrimaryName].ToString())
            //                .Replace("{uniquename}", txtUniqueName.Text);

            //if (txtName.Text == string.Empty)
            //{
            //    txtName.Text = compositename;
            //}

            //if (txtDisplayName.Text == string.Empty)
            //{
            //    txtDisplayName.Text = compositename;
            //}

        }

        private void cboCredentialSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (IsBoundToEntity())
            //{
            //    cboEntities.LoadData();
            //    cboEntities.Enabled = true;
            //    chkExpando.Enabled = true;
            //    chkExpando.Checked = false;
            //}
            //else
            //{
            //    cboEntities.ClearData();
            //    cboEntities.Enabled = false;
            //    chkExpando.Enabled = false;
            //    chkExpando.Checked = false;
            //}

        }

        

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var createRequest = new CreateRequest
                {
                    Target = ManagedIdentityToCreate()
                };
                if (_selectedSolution != null)
                {
                    createRequest["SolutionUniqueName"] = _selectedSolution.UniqueName;
                }

                var createResponse = (CreateResponse)_service.Execute(createRequest);

                NewManagedIdentityId = createResponse.id;

                // Link to PLugin Assembly
                var updatedPlugin = new Entity(Plug_inAssembly.EntityName)
                {
                    Id = _plugin.PluginAssemblyRow.Id
                };
                updatedPlugin[Plug_inAssembly.ManagedIdentityId] = new EntityReference(ManagedIdentity.EntityName, NewManagedIdentityId);

                _service.Update(updatedPlugin);


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


        private Entity ManagedIdentityToCreate()
        {
            var managedIdentity = new Entity(ManagedIdentity.EntityName);
            managedIdentity[ManagedIdentity.PrimaryName] = txtName.Text;
            managedIdentity[ManagedIdentity.CredentialSource] = new OptionSetValue(cboCredentialSource.SelectedIndex);
            managedIdentity[ManagedIdentity.SubjectScope] = new OptionSetValue(cboSubjectScope.SelectedIndex);
            managedIdentity[ManagedIdentity.TenantId] = Guid.Parse(txtTenantId.Text);
            managedIdentity[ManagedIdentity.ApplicationId] = Guid.Parse(txtApplicationId.Text);


            return managedIdentity;
        }


        private void cdsCboSolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedSolution = cdsCboSolutions.SelectedIndex != -1 ?
                                            new SolutionProxy(cdsCboSolutions.SelectedEntity) :
                                            null;

        }

        private void cdsCboSolutions_TextUpdate(object sender, EventArgs e)
        {
            if (cdsCboSolutions.SelectedText == "")
            {
                cdsCboSolutions.SelectedIndex = -1;
            }
        }

       
    }
}
