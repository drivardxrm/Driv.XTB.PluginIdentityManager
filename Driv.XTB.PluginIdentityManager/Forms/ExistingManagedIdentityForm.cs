using Driv.XTB.PluginIdentityManager.Entities;
using Driv.XTB.PluginIdentityManager.Helpers;
using Driv.XTB.PluginIdentityManager.Proxy;
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


namespace Driv.XTB.PluginIdentityManager.Forms
{
    public partial class ExistingManagedIdentityForm : Form
    {
        #region Private Fields

        //private Control focus;
        private ConnectionDetail _connection;
        private IOrganizationService _service;
        private PluginAssemblyProxy _plugin;
        private PluginPackageProxy _package;
        private SolutionProxy _selectedSolution;
        private Settings _settings;

        #endregion Private Fields

        #region Public Constructors

        public ExistingManagedIdentityForm(IOrganizationService service,PluginAssemblyProxy plugin,PluginPackageProxy package, SolutionProxy solution, Settings settings, ConnectionDetail connection)
        {
            InitializeComponent();
            _service = service;
            _settings = settings;
            _plugin = plugin;
            _connection = connection;
            _package = package;

            cdsGridManagedIdentity.OrganizationService = service;
            cdsTxtIdentityApplicationId.OrganizationService = service;
            cdsTxtIdentityTenantId.OrganizationService = service;
            cdsTxtIdentityName.OrganizationService = service;
            cdsTxtIdentitySubjectScope.OrganizationService = service;
            cdsTxtIdentityCredentialSource.OrganizationService = service;
            cdsTxtIdentityVersion.OrganizationService = service;


            lblPluginName.Text = _package == null ? $"Assembly : {plugin.Name}" : $"Package : {_package.Name}";

            btnOk.Text = _package == null ? "Link to Plugin" : "Link to Package";

            LoadManagedIdentities();

        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// GUID of the Managed Identity Parameter Created
        /// </summary>
        public Guid SelectedManagedIdentity { get; private set; }

        #endregion Public Properties



        #region Private Event Handlers


        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedManagedIdentity == null) 
                {
                    throw new ArgumentException("Please select a Managed Identity");
                }

                if (_plugin.Package != null)
                {
                    // Link to PLugin Package
                    var updatedPackage = new Entity(PluginPackage.EntityName)
                    {
                        Id = _plugin.Package.Id
                    };
                    updatedPackage[PluginPackage.ManagedIdentityId] = new EntityReference(ManagedIdentity.EntityName, SelectedManagedIdentity);

                    _service.Update(updatedPackage);
                }
                else 
                {
                    // Link to PLugin Assembly
                    var updatedPlugin = new Entity(Plug_inAssembly.EntityName)
                    {
                        Id = _plugin.PluginAssemblyRow.Id
                    };
                    updatedPlugin[Plug_inAssembly.ManagedIdentityId] = new EntityReference(ManagedIdentity.EntityName, SelectedManagedIdentity);

                    _service.Update(updatedPlugin);
                }

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


       


      

        private void cdsGridManagedIdentity_RecordEnter(object sender, CRMRecordEventArgs e)
        {
            //SetSelectedRequestParameter(Service.GetRequestParameter(e.Entity.Id));
            SelectedManagedIdentity = e.Entity.Id;
            cdsTxtIdentityApplicationId.Entity = e.Entity;
            cdsTxtIdentityTenantId.Entity = e.Entity;
            cdsTxtIdentityName.Entity = e.Entity;
            cdsTxtIdentitySubjectScope.Entity = e.Entity;
            cdsTxtIdentityCredentialSource.Entity = e.Entity;
            cdsTxtIdentityVersion.Entity = e.Entity;

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

            // Unsubscribe from the RecordEnter event
            cdsGridManagedIdentity.RecordEnter -= cdsGridManagedIdentity_RecordEnter;

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

            // Re-subscribe to the RecordEnter event
            cdsGridManagedIdentity.RecordEnter += cdsGridManagedIdentity_RecordEnter;

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
