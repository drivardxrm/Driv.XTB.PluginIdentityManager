using Driv.XTB.PluginIdentityManager.Entities;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Driv.XTB.PluginIdentityManager.Proxy
{
    public class PluginPackageProxy
    {


        public Entity PluginPackageRow;



        public PluginPackageProxy(Entity pluginPackage)
        {
            PluginPackageRow = pluginPackage;
        }



        public string Name => PluginPackageRow.Attributes.Contains(PluginPackage.PrimaryName) ?
                                                    PluginPackageRow[PluginPackage.PrimaryName].ToString() :
                                                    string.Empty;


        public bool IsManaged => PluginPackageRow.Attributes.Contains(PluginPackage.IsManaged) &&
                            (bool)PluginPackageRow[PluginPackage.IsManaged];




        public bool IsCustomizable => PluginPackageRow.Attributes.Contains(PluginPackage.IsCustomizable) &&
                                   ((BooleanManagedProperty)PluginPackageRow[PluginPackage.IsCustomizable]).Value;


        

        public bool CanCustomize => !IsManaged || IsManaged && IsCustomizable; // maybe lock if Managed

        public EntityReference ManagedIdentity => PluginPackageRow.Attributes.Contains(PluginPackage.ManagedIdentityId) ?
                                                    (EntityReference)PluginPackageRow[PluginPackage.ManagedIdentityId] :
                                                    null;
    }
}
