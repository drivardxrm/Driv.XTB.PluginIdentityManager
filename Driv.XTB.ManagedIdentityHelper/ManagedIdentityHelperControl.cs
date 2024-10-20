using Driv.XTB.ManagedIdentityHelper.Entities;
using Driv.XTB.ManagedIdentityHelper.Forms;
using Driv.XTB.ManagedIdentityHelper.Helpers;
using Driv.XTB.ManagedIdentityHelper.Proxy;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace Driv.XTB.ManagedIdentityHelper
{
    public partial class ManagedIdentityHelperControl : PluginControlBase  //, IGitHubPlugin
    {

        private Settings _globalsettings;

        private Settings _connectionsettings;

        private SolutionProxy _selectedSolution;

        private PluginAssemblyProxy _selectedPlugin;

        private ManagedIdentityProxy _selectedManagedIdentity;


        public ManagedIdentityHelperControl()
        {
            InitializeComponent();
        }

        private void ManagedIdentityHelperControl_Load(object sender, EventArgs e)
        {
            LoadConnectionSettings();

            ExecuteMethod(InitializeService);
            rbAll.Checked = true;
            cdsCboPlugin.Select();
        }

        private void LoadConnectionSettings()
        {
            if (!SettingsManager.Instance.TryLoad(GetType(), out _connectionsettings, ConnectionDetail.ConnectionId.ToString()))
            {
                _connectionsettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void InitializeService()
        {

            
            cdsCboPlugin.OrganizationService = Service;
            cdsCboSolutions.OrganizationService = Service;
            cdsTxtIdentityApplicationId.OrganizationService = Service;
            cdsTxtIdentityCredentialSource.OrganizationService = Service;
            cdsTxtIdentityName.OrganizationService = Service;
            cdsTxtIdentitySubjectScope.OrganizationService = Service;
            cdsTxtIdentityApplicationId.OrganizationService = Service;
            cdsTxtIdentityTenantId.OrganizationService = Service;
            cdsTxtPluginIsManaged.OrganizationService = Service;
            cdsTxtIdentityIsManaged.OrganizationService = Service;
            cdsTxtPluginVersion.OrganizationService = Service;






        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);


            if (_globalsettings != null && detail != null)
            {
                LoadConnectionSettings();

                _globalsettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);

                SetCdsCbpPluginDataSource(null);


                //LoadSolutions();
                ExecuteMethod(InitializeService);


                //select the all radio button
                rbAll.Checked = true;
                ExecuteMethod(LoadPluginAssemblies);
                cdsCboPlugin.Select();
            }
        }

        

        private void SetCdsCbpPluginDataSource(object datasource)
        {
            cdsCboPlugin.SelectedIndexChanged -= new EventHandler(cdsCboPlugin_SelectedIndexChanged);
            cdsCboPlugin.DataSource = datasource;
            cdsCboPlugin.SelectedIndexChanged += new EventHandler(cdsCboPlugin_SelectedIndexChanged);
        }

        /// Will set the DataSource of the control. Disabling the event handlers will prevent unessesary triggers.
        private void SetCdsCboSolutionsDataSource(object datasource)
        {
            cdsCboSolutions.SelectedIndexChanged -= new EventHandler(cdsCboSolutions_SelectedIndexChanged);
            cdsCboSolutions.DataSource = datasource;
            cdsCboSolutions.SelectedIndexChanged += new EventHandler(cdsCboSolutions_SelectedIndexChanged);
        }

        private void cdsCboPlugin_SelectedIndexChanged(object sender, EventArgs e)
        {


            //Clear SElected Input / Output if needed
            //SetSelectedRequestParameter(null);
            //SetSelectedResponseProperty(null);


            var pluginAssembly = cdsCboPlugin.SelectedIndex == -1 ? null : cdsCboPlugin.SelectedEntity;
            SetSelectedPluginAssembly(pluginAssembly);


            //Refresh Inputs / Outputs
            //LoadRequestParameters();
            //LoadResponseProperties();

            //menuTestApi.Enabled = cdsCboCustomApi.SelectedIndex != -1;

        }

        

        private void cdsCboSolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedSolution = cdsCboSolutions.SelectedIndex != -1 ?
                                            new SolutionProxy(cdsCboSolutions.SelectedEntity) :
                                            null;

            ExecuteMethod(LoadPluginAssemblies);

        }

        private void LoadPluginAssemblies()
        {

            SetCdsCbpPluginDataSource(null);



            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading plugin assemblies...",
                Work = (worker, args) =>
                {
                    if (rbAll.Checked)
                    {
                        args.Result = Service.GetAllPluginAssemblies();
                    }
                    else if (rbSolution.Checked && _selectedSolution != null)
                    {
                        args.Result = Service.GetPluginAssembliesFor(_selectedSolution.SolutionRow.Id);
                    }
                    else
                    {
                        args.Result = null;
                    }
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.Message);
                    }
                    else
                    {
                        if (args.Result is EntityCollection)
                        {

                            var plugins = (EntityCollection)args.Result;
                            //Remove managed  from list
                            if (!chkManaged.Checked)
                            {
                                var entities = plugins.Entities.ToList();
                                entities.RemoveAll(e => e.GetAttributeValue<bool>(Plug_inAssembly.State));

                                plugins = new EntityCollection(entities);
                            }
                            //Remove unmanaged from list
                            if (!chkUnmanaged.Checked)
                            {
                                var entities = plugins.Entities.ToList();
                                entities.RemoveAll(e => !e.GetAttributeValue<bool>(Plug_inAssembly.State));

                                plugins = new EntityCollection(entities);
                            }

                            //Find the index of the selected API in the list
                            var index = plugins.Entities.Select(e => e.Id).ToList().IndexOf(_selectedManagedIdentity?.ManagedIdentityRow.Id ?? Guid.Empty);

                            SetCdsCbpPluginDataSource(plugins);

                            //hack to force a refresh... must be a better way
                            if (cdsCboPlugin.SelectedIndex == index)
                            {
                                cdsCboPlugin.SelectedIndex = -1;
                            }
                            cdsCboPlugin.SelectedIndex = index;
                            cdsCboPlugin.Enabled = true;

                        }
                        else
                        {
                            SetCdsCbpPluginDataSource(null);

                            cdsCboPlugin.SelectedIndex = -1;
                            cdsCboPlugin.Enabled = false;
                        }
                    }
                }
            });

        }



        

        private void SetSelectedPluginAssembly(Entity pluginAssembly)
        {
            _selectedPlugin = pluginAssembly != null ? new PluginAssemblyProxy(pluginAssembly) : null;
            if (_selectedPlugin?.ManagedIdentity != null)
            {
                var managedIdentity = Service.Retrieve(ManagedIdentity.EntityName, _selectedPlugin.ManagedIdentity.Id, new ColumnSet(true));
                _selectedManagedIdentity = new ManagedIdentityProxy(managedIdentity);

                cdsTxtIdentityName.Entity = _selectedManagedIdentity?.ManagedIdentityRow;
                cdsTxtIdentityApplicationId.Entity = _selectedManagedIdentity?.ManagedIdentityRow;
                cdsTxtIdentityTenantId.Entity = _selectedManagedIdentity?.ManagedIdentityRow;
                cdsTxtIdentityCredentialSource.Entity = _selectedManagedIdentity?.ManagedIdentityRow;
                cdsTxtIdentitySubjectScope.Entity = _selectedManagedIdentity?.ManagedIdentityRow;

                cdsTxtIdentityIsManaged.Entity = _selectedManagedIdentity?.ManagedIdentityRow;


            }
            



            //cdsTxtUniqueName.Entity = _selectedCustomApi?.CustomApiRow;
            cdsTxtPluginName.Entity = _selectedPlugin?.PluginAssemblyRow;
            cdsTxtPluginVersion.Entity = _selectedPlugin?.PluginAssemblyRow;


            //cdsTxtDisplayName.Entity = _selectedCustomApi?.CustomApiRow;
            //cdsTxtDescription.Entity = _selectedCustomApi?.CustomApiRow;
            //cdsTxtAllowedCustomProcessingStep.Entity = _selectedCustomApi?.CustomApiRow;
            //cdsTxtBindingType.Entity = _selectedCustomApi?.CustomApiRow;
            //cdsTxtBoundEntity.Entity = _selectedCustomApi?.CustomApiRow;

            //cdsTxtPluginType.EntityReference = _selectedCustomApi?.PluginType; //todo try to move out from proxy
            //cdsTxtIsFunction.Entity = _selectedCustomApi?.CustomApiRow;
            //cdsTxtIsWFEnabled.Entity = _selectedCustomApi?.CustomApiRow;
            //cdsTxtExecutePrivilegeName.Entity = _selectedCustomApi?.CustomApiRow;
            //cdsTxtIsPrivate.Entity = _selectedCustomApi?.CustomApiRow;

            cdsTxtPluginIsManaged.Entity = _selectedPlugin?.PluginAssemblyRow;


            //if (_selectedCustomApi != null)
            //{
            //    txtCustomizableWarning.Visible = !_selectedCustomApi.CanCustomize;
            //    btnEditCustomApi.Enabled = _selectedCustomApi.CanCustomize;
            //    btnDeleteApi.Enabled = _selectedCustomApi.CanCustomize;
            //    btnAddInput.Enabled = _selectedCustomApi.CanCustomize;
            //    btnAddOutput.Enabled = _selectedCustomApi.CanCustomize;

            //}


            //imgGrpCustomApi.Enabled = _selectedCustomApi != null;
            //imgGrpInputs.Enabled = _selectedCustomApi != null;
            //imgGrpOutputs.Enabled = _selectedCustomApi != null;



        }


        private void SetSelectedManagedIdentity(Entity managedIdentity)
        {
            _selectedManagedIdentity = managedIdentity != null ? new ManagedIdentityProxy(managedIdentity) : null;



            //cdsTxtUniqueName.Entity = _selectedCustomApi?.CustomApiRow;
            cdsTxtIdentityName.Entity = _selectedManagedIdentity?.ManagedIdentityRow;
            //cdsTxtDisplayName.Entity = _selectedCustomApi?.CustomApiRow;
            //cdsTxtDescription.Entity = _selectedCustomApi?.CustomApiRow;
            //cdsTxtAllowedCustomProcessingStep.Entity = _selectedCustomApi?.CustomApiRow;
            //cdsTxtBindingType.Entity = _selectedCustomApi?.CustomApiRow;
            //cdsTxtBoundEntity.Entity = _selectedCustomApi?.CustomApiRow;

            //cdsTxtPluginType.EntityReference = _selectedCustomApi?.PluginType; //todo try to move out from proxy
            //cdsTxtIsFunction.Entity = _selectedCustomApi?.CustomApiRow;
            //cdsTxtIsWFEnabled.Entity = _selectedCustomApi?.CustomApiRow;
            //cdsTxtExecutePrivilegeName.Entity = _selectedCustomApi?.CustomApiRow;
            //cdsTxtIsPrivate.Entity = _selectedCustomApi?.CustomApiRow;

            //cdsTxtIsManaged.Entity = _selectedCustomApi?.CustomApiRow;
            //cdsTxtIsCustomizable.Entity = _selectedCustomApi?.CustomApiRow;

            //if (_selectedCustomApi != null)
            //{
            //    txtCustomizableWarning.Visible = !_selectedCustomApi.CanCustomize;
            //    btnEditCustomApi.Enabled = _selectedCustomApi.CanCustomize;
            //    btnDeleteApi.Enabled = _selectedCustomApi.CanCustomize;
            //    btnAddInput.Enabled = _selectedCustomApi.CanCustomize;
            //    btnAddOutput.Enabled = _selectedCustomApi.CanCustomize;

            //}


            //imgGrpCustomApi.Enabled = _selectedCustomApi != null;
            //imgGrpInputs.Enabled = _selectedCustomApi != null;
            //imgGrpOutputs.Enabled = _selectedCustomApi != null;



        }

        private void LoadSolutions(Guid selected)
        {

            SetCdsCboSolutionsDataSource(null);

            //TODO Apply filters



            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading solutions...",
                Work = (worker, args) =>
                {
                    args.Result = Service.GetSolutions();

                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.Message);
                    }
                    else
                    {
                        if (args.Result is EntityCollection)
                        {


                            var solutions = (EntityCollection)args.Result;
                            //Find the index of the selected solution
                            var index = solutions.Entities.Select(e => e.Id).ToList().IndexOf(selected);

                            SetCdsCboSolutionsDataSource(solutions);


                            cdsCboSolutions.SelectedIndex = index;
                            cdsCboSolutions.Enabled = true;

                        }
                    }
                }
            });

        }


        

        

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManagedIdentityHelperControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), _globalsettings);
        }

        private void menuRefresh_Click(object sender, EventArgs e)
        {
            ExecuteMethod(LoadPluginAssemblies);
        }

        private void btnNewIdentity_Click(object sender, EventArgs e)
        {
            // open new identity form
            CreateManagedIdentityDialog();
        }

        private void CreateManagedIdentityDialog()
        {
            var inputdlg = new NewManagedIdentityForm(Service, _selectedPlugin, _selectedSolution, _globalsettings, ConnectionDetail);
            var dlgresult = inputdlg.ShowDialog();
            if (dlgresult == DialogResult.Cancel)
            {
                return;
            }
            if (dlgresult == DialogResult.OK && inputdlg.NewManagedIdentityId != null)
            {
                /// TODO REFRESH PLUGIN ASSEMBLY
                //LoadRequestParameters(inputdlg.NewCustomApiRequestParameterId);

            }
            else if (dlgresult == DialogResult.Ignore)
            {

            }
        }

        private void ExistingManagedIdentityDialog()
        {
            var inputdlg = new ExistingManagedIdentityForm(Service, _selectedPlugin, _selectedSolution, _globalsettings, ConnectionDetail);
            var dlgresult = inputdlg.ShowDialog();
            if (dlgresult == DialogResult.Cancel)
            {
                return;
            }
            if (dlgresult == DialogResult.OK && inputdlg.SelectedManagedIdentity != null)
            {
                /// TODO REFRESH PLUGIN ASSEMBLY
                //LoadRequestParameters(inputdlg.NewCustomApiRequestParameterId);

            }
            else if (dlgresult == DialogResult.Ignore)
            {

            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked)
            {
                ExecuteMethod(LoadPluginAssemblies);
            }
        }

        private void chkManaged_CheckedChanged(object sender, EventArgs e)
        {
            LoadPluginAssemblies();
        }

        private void chkUnmanaged_CheckedChanged(object sender, EventArgs e)
        {
            LoadPluginAssemblies();
        }

        private void btnExistingIdentity_Click(object sender, EventArgs e)
        {
            // open new identity form
            ExistingManagedIdentityDialog();
        }

        
    }
}