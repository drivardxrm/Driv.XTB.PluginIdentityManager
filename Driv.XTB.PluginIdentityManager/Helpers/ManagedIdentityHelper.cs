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
               
                <order attribute='name' />

              </entity>
            </fetch>";


            var fetch = new FetchExpression(fetchXml);
            return service.RetrieveMultiple(fetch);
        }

        public static EntityCollection GetManagedIdentitiesFor(this IOrganizationService service, Guid solutionid)
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
                
                <link-entity name='solutioncomponent' from='objectid' to='managedidentityid' link-type='inner' alias='SC'>
                    <attribute name='componenttype' />
                    <attribute name='solutionid' />
                    <filter>
                        <condition attribute='solutionid' operator='eq' value='{solutionid}'/>
                    </filter>
                    
                </link-entity>
                <order attribute='name' />
              </entity>
            </fetch>";


            var fetch = new FetchExpression(fetchXml);
            return service.RetrieveMultiple(fetch);
        }
    }
}
