using Driv.XTB.PluginIdentityManager.Entities;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Driv.XTB.PluginIdentityManager.Proxy
{
    public class PluginAssemblyProxy
    {


        public Entity PluginAssemblyRow;



        public PluginAssemblyProxy(Entity pluginAssembly)
        {
            PluginAssemblyRow = pluginAssembly;
        }



        public string Name => PluginAssemblyRow.Attributes.Contains(Plug_inAssembly.PrimaryName) ?
                                                    PluginAssemblyRow[Plug_inAssembly.PrimaryName].ToString() :
                                                    string.Empty;


        public bool IsManaged => PluginAssemblyRow.Attributes.Contains(Plug_inAssembly.State) &&
                            (bool)PluginAssemblyRow[Plug_inAssembly.State];

        public EntityReference Package => PluginAssemblyRow.Attributes.Contains(Plug_inAssembly.Package) ?
                                            (EntityReference)PluginAssemblyRow[Plug_inAssembly.Package] : 
                                            null;




        public bool IsCustomizable => PluginAssemblyRow.Attributes.Contains(Plug_inAssembly.Customizable) &&
                                   ((BooleanManagedProperty)PluginAssemblyRow[Plug_inAssembly.Customizable]).Value;


        

        public bool CanCustomize => !IsManaged || IsManaged && IsCustomizable; // maybe lock if Managed

        public EntityReference ManagedIdentity => PluginAssemblyRow.Attributes.Contains(Plug_inAssembly.ManagedIdentityId) ?
                                                    (EntityReference)PluginAssemblyRow[Plug_inAssembly.ManagedIdentityId] :
                                                    null;
    }
}
