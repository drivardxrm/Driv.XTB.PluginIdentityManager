using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace Driv.XTB.PluginIdentityManager
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Plugin Identity Manager"),
        ExportMetadata("Description", "Create, update and assign managed identity records to Dataverse plugin assemblies"),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAAsTAAALEwEAmpwYAAACgklEQVR4nGNgGAWjAApaz/0Xbbjya03DlZ9fGq/8+k8LDDb78q/V9Tf+izCgg4Yrv9bQymIMfPnXKiwO+PmFfg74+RnDAY30shyKh44Dso68/285/zoYZx/5QF8HZB15/5+tav9/pvK9YAxiozsifOszuDw+rDPtIukOsJx/HcMgy/k3UNQUn/oCdgQhnHLgDXUcYLXgBv2iIPvIB5QoYMcSBan734KDlxD2WHWPvESYfeQDONhBGFsipLkDGgcqG5ad+fLffvHt/+Jtx8FBD8Igtv2S22A5QomQIgck7X39n7v2IM4sBZIDqcGXDSlygM60iyTna2y45uK7/0XHz/3PO3L4f+mpq/8brvwgzgEpB96QnK+RccXZh//DNzb9d13o/d95gTsceywJ/Z+8a9H/+ktfaJcIC4+d/u++OAjFYnQcsDr3v/NCZ2EUB1CjOgb5nJDlMOy0wG0Pw38GRkQIXP61mlIHgIIdr8+XBf3vPNz032WBB8QR8z1C4Q4ANZPAjrj88zM5ltdefIcR58g4cHnw/0MPNv2/8/bE/84jMIe6bWWgFnBa4OaIbGHv0db/kasiweyg5SH/jzzcArb84P1N//2XB0JDwP0l1RzguMDdD2Z5w/5qsGVnnu7+n7E57f/RR1sxLIemgx9Uc4DLQhcTmMGei33/b7+1AmwpDB95uPl/0PJg1IQ43/0e1Rxgv9+exWm++xtsjsBmOSQE3GcxUBM4zXerQ7bAe4nf/4Xnp6EEO8L3bn8cF7hrU9UB9vPtOZznu58krhxwr6Kq5TAAKuFAhQxOy+e7/wZbjlwIUR38Z2AEFTKgfO68wP2F03y3n6AEB4pzp7keWshqAeFDmFrBEjA/AAAAAElFTkSuQmCC"),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "DarkSlateGray"),
        ExportMetadata("PrimaryFontColor", "WhiteSmoke"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class PluginIdentityManagerPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new PluginIdentityManagerControl();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public PluginIdentityManagerPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}
