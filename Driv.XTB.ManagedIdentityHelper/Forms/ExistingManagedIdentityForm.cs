using Driv.XTB.ManagedIdentityHelper;
using Driv.XTB.ManagedIdentityHelper.Entities;
using Driv.XTB.ManagedIdentityHelper.Helpers;
using Driv.XTB.ManagedIdentityHelper.Proxy;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using System;
using System.Linq;
using System.Web.Services.Description;
using System.Windows.Forms;
using xrmtb.XrmToolBox.Controls;
using xrmtb.XrmToolBox.Controls.Controls;
using XrmToolBox.Extensibility;

//using XTB.CustomApiManager.Proxy;
//using static XTB.CustomApiManager.Entities.CustomAPI;

namespace Driv.XTB.ManagedIdentityHelper.Forms
{
    public partial class ExistingManagedIdentityForm : Form
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

        public ExistingManagedIdentityForm(IOrganizationService service,PluginAssemblyProxy plugin, SolutionProxy solution, Settings settings, ConnectionDetail connection)
        {
            InitializeComponent();
            _service = service;
            _settings = settings;
            _plugin = plugin;
            _connection = connection;

            cdsGridManagedIdentity.OrganizationService = service;
            cdsIdentityTxtApplicationId.OrganizationService = service;
            cdsIdentityTxtTenantId.OrganizationService = service;
            cdsIdentityTxtName.OrganizationService = service;
            cdsIdentityTxtSubjectScope.OrganizationService = service;
            


            //txtName.Text = $"{plugin.Name} Identity";

            //txtTenantId.Text = _connection.TenantId.ToString();
            //cboEntities.Service = service;
            //cboEntities.Update();

            //cboCredentialSource.DataSource = Enum.GetValues(typeof(ManagedIdentity.CredentialSource_OptionSet));
            //cboCredentialSource.SelectedIndex = (int)ManagedIdentity.CredentialSource_OptionSet.IsManaged;

            //cboSubjectScope.DataSource = Enum.GetValues(typeof(ManagedIdentity.SubjectScope_OptionSet));
            //cboSubjectScope.SelectedIndex = (int)ManagedIdentity.SubjectScope_OptionSet.EnvironmentScope;

            //cdsCustomApiName.Entity = customapi.CustomApiRow;

            LoadManagedIdentities();

            //cdsCboSolutions.OrganizationService = service;

            //var unmanagedsolutions = _service.GetUnmanagedSolutions();
            //cdsCboSolutions.SelectedIndexChanged -= new EventHandler(cdsCboSolutions_SelectedIndexChanged);
            //cdsCboSolutions.DataSource = unmanagedsolutions;
            //cdsCboSolutions.SelectedIndexChanged += new EventHandler(cdsCboSolutions_SelectedIndexChanged);

            //cdsCboSolutions.SelectedIndex = unmanagedsolutions.Entities.Select(e => e.Id).ToList().IndexOf(solution?.SolutionRow?.Id ?? Guid.Empty);

        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// GUID of the Managed Identity Parameter Created
        /// </summary>
        public Guid SelectedManagedIdentity { get; private set; }

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
                if (SelectedManagedIdentity == null) 
                {
                    throw new ArgumentException("Please select a Managed Identity");
                }


                // Link to PLugin Assembly
                var updatedPlugin = new Entity(Plug_inAssembly.EntityName)
                {
                    Id = _plugin.PluginAssemblyRow.Id
                };
                updatedPlugin[Plug_inAssembly.ManagedIdentityId] = new EntityReference(ManagedIdentity.EntityName, SelectedManagedIdentity);

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


       


        //private void cdsCboSolutions_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    _selectedSolution = cdsCboSolutions.SelectedIndex != -1 ?
        //                                    new SolutionProxy(cdsCboSolutions.SelectedEntity) :
        //                                    null;

        //}

        //private void cdsCboSolutions_TextUpdate(object sender, EventArgs e)
        //{
        //    if (cdsCboSolutions.SelectedText == "")
        //    {
        //        cdsCboSolutions.SelectedIndex = -1;
        //    }
        //}

        private void cdsGridManagedIdentity_RecordEnter(object sender, CRMRecordEventArgs e)
        {
            //SetSelectedRequestParameter(Service.GetRequestParameter(e.Entity.Id));
            SelectedManagedIdentity = e.Entity.Id;
            cdsIdentityTxtApplicationId.Entity = e.Entity;
            cdsIdentityTxtTenantId.Entity = e.Entity;
            cdsIdentityTxtName.Entity = e.Entity;
            cdsIdentityTxtSubjectScope.Entity = e.Entity;
            cdsIdentityTxtCredentialSource.Entity = e.Entity;

        }

        private void SetGridManagedIdentityDataSource(object datasource)
        {
            cdsGridManagedIdentity.RecordEnter -= new CRMRecordEventHandler(cdsGridManagedIdentity_RecordEnter);
            cdsGridManagedIdentity.DataSource = datasource;
            cdsGridManagedIdentity.RecordEnter += new CRMRecordEventHandler(cdsGridManagedIdentity_RecordEnter);
        }

        private void LoadManagedIdentities(Guid? selected = null)
        {

            SetGridManagedIdentityDataSource(null);

            var identities = _service.GetAllManagedIdentities();

            //Remove managed  from list
            if (!chkManaged.Checked)
            {
                var entities = identities.Entities.ToList();
                entities.RemoveAll(e => e.GetAttributeValue<bool>(ManagedIdentity.IsManaged));

                identities = new EntityCollection(entities);
            }
            //Remove unmanaged from list
            if (!chkUnmanaged.Checked)
            {
                var entities = identities.Entities.ToList();
                entities.RemoveAll(e => !e.GetAttributeValue<bool>(ManagedIdentity.IsManaged));

                identities = new EntityCollection(entities);
            }


            SetGridManagedIdentityDataSource(identities);

           
        }

        private void chkManaged_CheckedChanged(object sender, EventArgs e)
        {
            LoadManagedIdentities();
        }

        private void chkUnmanaged_CheckedChanged(object sender, EventArgs e)
        {
            LoadManagedIdentities();
        }
    }
}
