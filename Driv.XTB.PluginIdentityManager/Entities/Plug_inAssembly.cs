// *********************************************************************
// Created by : Latebound Constants Generator 1.2023.12.1 for XrmToolBox
// Author     : Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://drivdev.crm3.dynamics.com/
// Filename   : C:\Source_Github\Driv.XTB.ManagedIdentityHelper\Driv.XTB.PluginIdentityManager\Entities\Plug_inAssembly.cs
// Created    : 2024-10-02 21:50:41
// *********************************************************************

namespace Driv.XTB.PluginIdentityManager.Entities
{
    /// <summary>DisplayName: Plug-in Assembly, OwnershipType: OrganizationOwned, IntroducedVersion: 5.0.0.0</summary>
    public static class Plug_inAssembly
    {
        public const string EntityName = "pluginassembly";
        public const string EntityCollectionName = "pluginassemblies";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "pluginassemblyid";
        /// <summary>Type: String, RequiredLevel: SystemRequired, MaxLength: 256, Format: Text</summary>
        public const string PrimaryName = "name";

        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Component State, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string ComponentState = "componentstate";

        /// <summary>Type: String, RequiredLevel: SystemRequired, MaxLength: 32, Format: Text</summary>
        public const string Culture = "culture";
        /// <summary>Type: ManagedProperty, RequiredLevel: SystemRequired</summary>
        public const string Customizable = "iscustomizable";

        /// <summary>Type: String, RequiredLevel: None, MaxLength: 256, Format: Text</summary>
        public const string Description = "description";
        /// <summary>Type: ManagedProperty, RequiredLevel: SystemRequired</summary>
        public const string Hidden = "ishidden";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 48, Format: VersionNumber</summary>
        public const string IntroducedVersion = "introducedversion";

        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Isolation Mode, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string IsolationMode = "isolationmode";


        /// <summary>Type: Lookup, RequiredLevel: None, Targets: managedidentity</summary>
        public const string ManagedIdentityId = "managedidentityid";

        /// <summary>Type: Lookup, RequiredLevel: None, Targets: pluginpackage</summary>
        public const string Package = "packageid";

        /// <summary>Type: String, RequiredLevel: None, MaxLength: 256, Format: Text</summary>
        public const string Path = "path";

        /// <summary>Type: String, RequiredLevel: SystemRequired, MaxLength: 32, Format: Text</summary>
        public const string PublicKeyToken = "publickeytoken";
        /// <summary>Type: DateTime, RequiredLevel: SystemRequired, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string RecordOverwriteTime = "overwritetime";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string Solution = "solutionid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string Solution1 = "supportingsolutionid";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Source Type, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string SourceType = "sourcetype";

        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Auth Type, OptionSetType: Picklist</summary>
        public const string Specifiesmodeofauthenticationwithwebsources = "authtype";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string State = "ismanaged";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 256, Format: Text</summary>
        public const string UserName = "username";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 256, Format: Text</summary>
        public const string UserPassword = "password";
        /// <summary>Type: String, RequiredLevel: SystemRequired, MaxLength: 48, Format: VersionNumber</summary>
        public const string Version = "version";

        /// <summary>Type: String, RequiredLevel: None, MaxLength: 2000, Format: Text</summary>
        public const string WebUrl = "url";

        #endregion Attributes

        #region Relationships

        /// <summary>Parent: "Organization" Child: "Plug_inAssembly" Lookup: ""</summary>
        public const string RelM1_Plug_inAssembly = "organization_pluginassembly";
        /// <summary>Parent: "ManagedIdentity" Child: "Plug_inAssembly" Lookup: "ManagedIdentityId"</summary>
        public const string RelM1_Plug_inAssemblyManagedIdentityId = "managedidentity_PluginAssembly";
        /// <summary>Parent: "PluginPackage" Child: "Plug_inAssembly" Lookup: "Package"</summary>
        public const string RelM1_Plug_inAssemblyPackage = "pluginpackage_pluginassembly";
        /// <summary>Parent: "Plug_inAssembly" Child: "Plug_inType" Lookup: ""</summary>
        public const string Rel1M_pluginassembly_plugintype = "pluginassembly_plugintype";

        #endregion Relationships

        #region OptionSets

        public enum ComponentState_OptionSet
        {
            Published = 0,
            Unpublished = 1,
            Deleted = 2,
            DeletedUnpublished = 3
        }
        public enum IsolationMode_OptionSet
        {
            None = 1,
            Sandbox = 2,
            External = 3
        }
        public enum SourceType_OptionSet
        {
            Database = 0,
            Disk = 1,
            Normal = 2,
            AzureWebApp = 3,
            FileStore = 4
        }
        public enum Specifiesmodeofauthenticationwithwebsources_OptionSet
        {
            BasicAuth = 0
        }

        #endregion OptionSets
    }
}
