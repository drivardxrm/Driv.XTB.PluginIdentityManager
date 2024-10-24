﻿using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Driv.XTB.PluginIdentityManager.Helpers
{
    public static class SolutionHelper
    {




        public static EntityCollection GetSolutions(this IOrganizationService service)
        {
            var fetchxml = $@"
                            <fetch>
                              <entity name='solution'>
                                <attribute name='isvisible' />
                                <attribute name='uniquename' />
                                <attribute name='friendlyname' />
                                <attribute name='publisherid' />
                                <attribute name='publisheridprefix' />
                                <attribute name='publisheridname' />
                                <attribute name='ismanaged' />
                                <filter>
                                  <condition attribute='isvisible' operator='eq' value='1'/>
                                </filter>
                                <link-entity name='publisher' from='publisherid' to='publisherid' link-type='outer' alias='P'>
                                  <attribute name='uniquename' />
                                  <attribute name='customizationoptionvalueprefix' />
                                  <attribute name='customizationprefix' />
                                </link-entity>
                                <order attribute='friendlyname' />
                              </entity>
                            </fetch>";

            var fetch = new FetchExpression(fetchxml);
            return service.RetrieveMultiple(fetch);
        }

        public static EntityCollection GetUnmanagedSolutions(this IOrganizationService service)
        {
            var fetchxml = $@"
                            <fetch>
                              <entity name='solution'>
                                <attribute name='isvisible' />
                                <attribute name='uniquename' />
                                <attribute name='friendlyname' />
                                <attribute name='publisherid' />
                                <attribute name='publisheridprefix' />
                                <attribute name='publisheridname' />
                                <attribute name='ismanaged' />
                                <filter>
                                  <condition attribute='isvisible' operator='eq' value='1'/>
                                  <condition attribute='ismanaged' operator='eq' value='0'/>
                                </filter>
                                <link-entity name='publisher' from='publisherid' to='publisherid' link-type='outer' alias='P'>
                                  <attribute name='uniquename' />
                                  <attribute name='customizationoptionvalueprefix' />
                                  <attribute name='customizationprefix' />
                                </link-entity>
                                <order attribute='friendlyname' />
                              </entity>
                            </fetch>";

            var fetch = new FetchExpression(fetchxml);
            return service.RetrieveMultiple(fetch);
        }



    }
}
