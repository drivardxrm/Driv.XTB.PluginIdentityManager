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
    public static  class PlugInAssemblyHelper
    {
        public static EntityCollection GetAllPluginAssemblies(this IOrganizationService service)
        {
            var fetchXml = $@"
            <fetch>
              <entity name='pluginassembly'>
                <attribute name='authtype' />
                <attribute name='createdby' />
                <attribute name='createdon' />
                <attribute name='culture' />
                <attribute name='customizationlevel' />
                <attribute name='description' />
                <attribute name='iscustomizable' />
                <attribute name='ishidden' />
                <attribute name='ismanaged' />
                <attribute name='isolationmode' />
                <attribute name='major' />
                <attribute name='managedidentityid' />
                <attribute name='minor' />
                <attribute name='modifiedby' />
                <attribute name='modifiedon' />
                <attribute name='name' />
                <attribute name='organizationid' />
                <attribute name='packageid' />
                <attribute name='path' />
                <attribute name='pluginassemblyid' />
                <attribute name='pluginassemblyidunique' />
                <attribute name='publickeytoken' />
                <attribute name='solutionid' />
                <attribute name='sourcetype' />
                <attribute name='version' />
                <attribute name='url' />
                <order attribute='name' />
              </entity>
            </fetch>";


            var fetch = new FetchExpression(fetchXml);
            return service.RetrieveMultiple(fetch);
        }

        public static EntityCollection GetPluginAssembliesFor(this IOrganizationService service, Guid solutionid)
        {
            var fetchXml = $@"
            <fetch>
              <entity name='pluginassembly'>
                <attribute name='authtype' />
                <attribute name='createdby' />
                <attribute name='createdon' />
                <attribute name='culture' />
                <attribute name='customizationlevel' />
                <attribute name='description' />
                <attribute name='iscustomizable' />
                <attribute name='ishidden' />
                <attribute name='ismanaged' />
                <attribute name='isolationmode' />
                <attribute name='major' />
                <attribute name='managedidentityid' />
                <attribute name='minor' />
                <attribute name='modifiedby' />
                <attribute name='modifiedon' />
                <attribute name='name' />
                <attribute name='organizationid' />
                <attribute name='packageid' />
                <attribute name='path' />
                <attribute name='pluginassemblyid' />
                <attribute name='pluginassemblyidunique' />
                <attribute name='publickeytoken' />
                <attribute name='solutionid' />
                <attribute name='sourcetype' />
                <attribute name='version' />
                <attribute name='url' />
                <link-entity name='solutioncomponent' from='objectid' to='pluginassemblyid' link-type='inner' alias='SC'>
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
