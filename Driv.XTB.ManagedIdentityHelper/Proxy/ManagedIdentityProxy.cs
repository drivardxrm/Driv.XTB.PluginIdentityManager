using Driv.XTB.ManagedIdentityHelper.Entities;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using static XTB.CustomApiManager.Entities.CustomAPI;

namespace Driv.XTB.ManagedIdentityHelper.Proxy
{
    public class ManagedIdentityProxy
    {


        public Entity ManagedIdentityRow;



        public ManagedIdentityProxy(Entity managedIdentity)
        {
            ManagedIdentityRow = managedIdentity;
        }



        public string Name => ManagedIdentityRow.Attributes.Contains(ManagedIdentity.PrimaryName) ?
                                                    ManagedIdentityRow[ManagedIdentity.PrimaryName].ToString() :
                                                    string.Empty;

        // Put the id in the display name if the name is empty
        public string DisplayName => string.IsNullOrEmpty(Name) ?
                                                    ManagedIdentityRow.Id.ToString() :
                                                    Name;




        public ManagedIdentity.CredentialSource_OptionSet CredentialSource => (ManagedIdentity.CredentialSource_OptionSet)(ManagedIdentityRow[ManagedIdentity.CredentialSource] as OptionSetValue).Value;



        public bool IsManaged => ManagedIdentityRow.Attributes.Contains(ManagedIdentity.IsManaged) &&
                                    (bool)ManagedIdentityRow[ManagedIdentity.IsManaged];

        public bool IsCustomizable => ManagedIdentityRow.Attributes.Contains(ManagedIdentity.IsCustomizable) &&
                                   ((BooleanManagedProperty)ManagedIdentityRow[ManagedIdentity.IsCustomizable]).Value;


        public bool CanCustomize => !IsManaged || IsManaged && IsCustomizable; // maybe lock if Managed


    }
}
