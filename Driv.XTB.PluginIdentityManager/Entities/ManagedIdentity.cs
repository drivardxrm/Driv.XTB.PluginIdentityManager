// *********************************************************************
// Created by : Latebound Constants Generator 1.2023.12.1 for XrmToolBox
// Author     : Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://drivdev.crm3.dynamics.com/
// Filename   : C:\Source_Github\Driv.XTB.ManagedIdentityHelper\Driv.XTB.PluginIdentityManager\Entities\ManagedIdentity.cs
// Created    : 2024-10-02 21:46:22
// *********************************************************************

namespace Driv.XTB.PluginIdentityManager.Entities
{
    /// <summary>DisplayName: Managed Identity, OwnershipType: UserOwned, IntroducedVersion: 9.0.0.0</summary>
    public static class ManagedIdentity
    {
        public const string EntityName = "managedidentity";
        public const string EntityCollectionName = "managedidentities";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "managedidentityid";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 100, Format: Text</summary>
        public const string PrimaryName = "name";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: ApplicationRequired</summary>
        public const string ApplicationId = "applicationid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string ClientSecret = "clientsecret";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Component State, OptionSetType: Picklist</summary>
        public const string ComponentState = "componentstate";

        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Credential Source, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string CredentialSource = "credentialsource";

        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string ImportSequenceNumber = "importsequencenumber";
        /// <summary>Type: ManagedProperty, RequiredLevel: SystemRequired</summary>
        public const string IsCustomizable = "iscustomizable";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string IsManaged = "ismanaged";

        /// <summary>Type: Lookup, RequiredLevel: None, Targets: keyvaultreference</summary>
        public const string KeyVaultReferenceId = "keyvaultreferenceid";

        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string ObjectId = "objectid";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string RecordCreatedOn = "overriddencreatedon";
        /// <summary>Type: DateTime, RequiredLevel: SystemRequired, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string RecordOverwriteTime = "overwritetime";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string Rowidunique = "componentidunique";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string Solution = "solutionid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string Solution1 = "supportingsolutionid";

        /// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, OptionSetType: State</summary>
        public const string Status = "statecode";
        /// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, OptionSetType: Status</summary>
        public const string StatusReason = "statuscode";

        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Subject Scope, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string SubjectScope = "subjectscope";

        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string TenantId = "tenantid";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -1, MaxValue: 2147483647</summary>
        public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -1, MaxValue: 2147483647</summary>
        public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -1, MaxValue: 2147483647</summary>
        public const string Version = "version";
        /// <summary>Type: BigInt, RequiredLevel: None, MinValue: -9223372036854775808, MaxValue: 9223372036854775807</summary>
        public const string VersionNumber = "versionnumber";

        #endregion Attributes

        #region Relationships

        /// <summary>Parent: "KeyVaultReference" Child: "ManagedIdentity" Lookup: "KeyVaultReferenceId"</summary>
        public const string RelM1_ManagedIdentityKeyVaultReferenceId = "keyvaultreference_ManagedIdentity";
        /// <summary>Parent: "ManagedIdentity" Child: "FieldSharing" Lookup: ""</summary>
        public const string Rel1M_managedidentity_PrincipalObjectAttributeAccesses = "managedidentity_PrincipalObjectAttributeAccesses";
        /// <summary>Parent: "ManagedIdentity" Child: "Plug_inAssembly" Lookup: ""</summary>
        public const string Rel1M_managedidentity_PluginAssembly = "managedidentity_PluginAssembly";
        /// <summary>Parent: "ManagedIdentity" Child: "KeyVaultReference" Lookup: ""</summary>
        public const string Rel1M_managedidentity_KeyVaultReference = "managedidentity_KeyVaultReference";
        /// <summary>Parent: "ManagedIdentity" Child: "EmailServerProfile" Lookup: ""</summary>
        public const string Rel1M_managedidentity_emailserverprofile_managedidentityid = "managedidentity_emailserverprofile_managedidentityid";
        /// <summary>Parent: "ManagedIdentity" Child: "PluginPackage" Lookup: ""</summary>
        public const string Rel1M_managedidentity_pluginpackage = "managedidentity_pluginpackage";
        /// <summary>Parent: "ManagedIdentity" Child: "PowerPagesManagedIdentity" Lookup: ""</summary>
        public const string Rel1M_PowerPagesManagedIdentity_ManagedIdentity_ManagedIdentity = "PowerPagesManagedIdentity_ManagedIdentity_ManagedIdentity";
        /// <summary>Parent: "ManagedIdentity" Child: "CertificateCredential" Lookup: ""</summary>
        public const string Rel1M_ComponentId_CertificateCredential_Managedidentity = "ComponentId_CertificateCredential_Managedidentity";

        #endregion Relationships

        #region OptionSets

        public enum ComponentState_OptionSet
        {
            Published = 0,
            Unpublished = 1,
            Deleted = 2,
            DeletedUnpublished = 3
        }
        public enum CredentialSource_OptionSet
        {
            ClientSecret = 0,
            KeyVault = 1,
            IsManaged = 2,
            MicrosoftFirstPartyCertificate = 3
        }
        public enum Status_OptionSet
        {
            Active = 0,
            Inactive = 1
        }
        public enum StatusReason_OptionSet
        {
            Active = 1,
            Inactive = 2
        }
        public enum SubjectScope_OptionSet
        {
            GlobalScope = 0,
            EnvironmentScope = 1,
            DevOnlyScope = 2
        }

        #endregion OptionSets
    }
}
