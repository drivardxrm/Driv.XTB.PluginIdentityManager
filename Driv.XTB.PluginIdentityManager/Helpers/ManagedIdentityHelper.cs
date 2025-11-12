using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk.Organization;

namespace Driv.XTB.PluginIdentityManager.Helpers
{
    public static  class ManagedIdentityHelper
    {
        // Filter on CredentialSource = 2 (IsManaged)
        public static EntityCollection GetAllManagedIdentities(this IOrganizationService service)
        {
            var fetchXml = $@"
            <fetch>
              <entity name='managedidentity'>
                <attribute name='applicationid' />
                <attribute name='componentstate' />
                <attribute name='createdby' />
                <attribute name='createdon' />
                <attribute name='credentialsource' />
                <attribute name='iscustomizable' />
                <attribute name='ismanaged' />
                <attribute name='keyvaultreferenceid' />
                <attribute name='managedidentityid' />
                <attribute name='name' />
                <attribute name='objectid' />
                <attribute name='ownerid' />
                <attribute name='owningbusinessunit' />
                <attribute name='solutionid' />
                <attribute name='statecode' />
                <attribute name='statuscode' />
                <attribute name='subjectscope' />
                <attribute name='tenantid' />
                <attribute name='version' />
                <filter>
                  <condition attribute='credentialsource' operator='eq' value='2' />
                </filter>
                <order attribute='name' />

              </entity>
            </fetch>";


            var fetch = new FetchExpression(fetchXml);
            return service.RetrieveMultiple(fetch);
        }

        
    }
}
