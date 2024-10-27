using Driv.XTB.PluginIdentityManager.Entities;
using Driv.XTB.PluginIdentityManager.Forms;
using Driv.XTB.PluginIdentityManager.Helpers;
using Driv.XTB.PluginIdentityManager.Proxy;
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
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace Driv.XTB.PluginIdentityManager
{
    public partial class PluginIdentityManagerControl : PluginControlBase  , IGitHubPlugin
    {

        private Settings _globalsettings;

        private Settings _connectionsettings;

        private SolutionProxy _selectedSolution;

        private PluginAssemblyProxy _selectedPlugin;

        private ManagedIdentityProxy _selectedManagedIdentity;

        public string RepositoryName => "Driv.XTB.PluginIdentityManager";

        public string UserName => "drivardxrm";

        public PluginIdentityManagerControl()
        {
            InitializeComponent();
        }

        private void PluginIdentityManagerControl_Load(object sender, EventArgs e)
        {
            LoadGlobalSettings();
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

        private void LoadGlobalSettings()
        {
            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out _globalsettings))
            {
                _globalsettings = new Settings();

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

            cdsTxtPluginName.OrganizationService = Service;
            cdsTxtPluginIsManaged.OrganizationService = Service;
            cdsTxtPluginVersion.OrganizationService = Service;

            cdsTxtIdentityApplicationId.OrganizationService = Service;
            cdsTxtIdentityCredentialSource.OrganizationService = Service;
            cdsTxtIdentityName.OrganizationService = Service;
            cdsTxtIdentitySubjectScope.OrganizationService = Service;
            cdsTxtIdentityApplicationId.OrganizationService = Service;
            cdsTxtIdentityTenantId.OrganizationService = Service;
            cdsTxtIdentityIsManaged.OrganizationService = Service;

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


                SetCdsCboPluginDataSource(null);
                


                //LoadSolutions();
                ExecuteMethod(InitializeService);


                //select the all radio button
                rbAll.Checked = true;
                _selectedManagedIdentity = null;
                _selectedPlugin = null;
                _selectedSolution = null;
                ExecuteMethod(LoadPluginAssemblies);
                cdsCboPlugin.Select();
            }
        }

        

        private void SetCdsCboPluginDataSource(object datasource)
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

            var pluginAssembly = cdsCboPlugin.SelectedIndex == -1 ? null : cdsCboPlugin.SelectedEntity;
            SetSelectedPluginAssembly(pluginAssembly);
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

            SetCdsCboPluginDataSource(null);



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
                            //Remove managed from list
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

                            //Find the index of the selected plugin in the list
                            var index = plugins.Entities.Select(e => e.Id).ToList().IndexOf(_selectedPlugin?.PluginAssemblyRow.Id ?? Guid.Empty);

                            SetCdsCboPluginDataSource(plugins);

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
                            SetCdsCboPluginDataSource(null);

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
            
            
            // Mangaged Identity
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

                // delete only visible if unmanaged
                btnEditIdentity.Visible = !_selectedManagedIdentity?.IsManaged ?? false;
                btnDelete.Visible = !_selectedManagedIdentity?.IsManaged ?? false;

                

            }
            else 
            {
                _selectedManagedIdentity = null;
                cdsTxtIdentityName.Entity = null;
                cdsTxtIdentityApplicationId.Entity = null;
                cdsTxtIdentityTenantId.Entity = null;
                cdsTxtIdentityCredentialSource.Entity = null;
                cdsTxtIdentitySubjectScope.Entity = null;

                cdsTxtIdentityIsManaged.Entity = null;

                btnEditIdentity.Visible = false;
                btnDelete.Visible = false;

                
            }
            lblCertificate.Visible = _selectedPlugin != null && _selectedManagedIdentity == null;

            cdsTxtPluginName.Entity = _selectedPlugin?.PluginAssemblyRow;
            cdsTxtPluginVersion.Entity = _selectedPlugin?.PluginAssemblyRow;
            cdsTxtPluginIsManaged.Entity = _selectedPlugin?.PluginAssemblyRow;


           


            imageManagedIdentity.Enabled = _selectedPlugin?.ManagedIdentity != null;
            imagePlugin.Enabled = _selectedPlugin != null;

            

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
        private void PluginIdentityManager_OnCloseTool(object sender, EventArgs e)
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
                ExecuteMethod(LoadPluginAssemblies);

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
                ExecuteMethod(LoadPluginAssemblies);

            }
            else if (dlgresult == DialogResult.Ignore)
            {

            }
        }

        private void EditManagedIdentityDialog()
        {
            var inputdlg = new EditManagedIdentityForm(Service, _selectedManagedIdentity, _selectedSolution, _globalsettings, ConnectionDetail);
            var dlgresult = inputdlg.ShowDialog();
            if (dlgresult == DialogResult.Cancel)
            {
                return;
            }
            if (dlgresult == DialogResult.OK && inputdlg.UpdatedManagedIdentityId != null)
            {
                ExecuteMethod(LoadPluginAssemblies);

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
            // open existing identity form
            ExistingManagedIdentityDialog();
        }

        private void btnEditIdentity_Click(object sender, EventArgs e)
        {
            // open edit identity form
            EditManagedIdentityDialog();
        }

        private void tslAbout_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.StartPosition = FormStartPosition.CenterParent;
            about.lblVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            about.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure to delete this managed identity record ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                // delete the selected item
                if (_selectedManagedIdentity != null)
                {
                    Service.Delete(ManagedIdentity.EntityName, _selectedManagedIdentity.ManagedIdentityRow.Id);
                    ExecuteMethod(LoadPluginAssemblies);
                }
            }
        }

        private void rbSolution_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSolution.Checked)
            {

                SetCdsCboPluginDataSource(null);


                cdsCboPlugin.SelectedIndex = -1;

                cdsCboSolutions.Enabled = true;

                ExecuteMethod(LoadSolutions, Guid.Empty);
                cdsCboSolutions.Select();

            }
            else
            {
                cdsCboSolutions.Enabled = false;


                SetCdsCboSolutionsDataSource(null);


                cdsCboSolutions.SelectedIndex = -1;
                _selectedSolution = null;

            }
        }

    }
}