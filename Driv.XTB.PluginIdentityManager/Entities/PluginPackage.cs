// *********************************************************************
// Created by : Latebound Constants Generator 1.2024.11.4 for XrmToolBox
// Tool Author: Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://drivdev.crm3.dynamics.com/
// Filename   : C:\Users\david\Downloads\latebound\PluginPackage.cs
// Created    : 2024-12-03 21:20:34
// *********************************************************************
namespace Driv.XTB.PluginIdentityManager.Entities
{
    /// <summary>DisplayName: Plugin Package, OwnershipType: OrganizationOwned, IntroducedVersion: 9.1.0.0</summary>
    public static class PluginPackage
    {
        public const string EntityName = "pluginpackage";
        public const string EntityCollectionName = "pluginpackages";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        /// <remarks>Unique identifier for entity instances</remarks>
        public const string PrimaryKey = "pluginpackageid";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 100, Format: Text</summary>
        /// <remarks>The name of the plugin package entity.</remarks>
        public const string PrimaryName = "name";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Component State, OptionSetType: Picklist</summary>
        /// <remarks>For internal use only.</remarks>
        public const string ComponentState = "componentstate";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 1073741823</summary>
        public const string Content = "content";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        /// <remarks>Export Key Version</remarks>
        public const string ExportKeyVersion = "exportkeyversion";
        /// <summary>Type: Virtual, RequiredLevel: None</summary>
        /// <remarks>Lookup to FileAttachment</remarks>
        public const string FileId = "fileid";
        /// <summary>Type: ManagedProperty, RequiredLevel: SystemRequired</summary>
        /// <remarks>For internal use only.</remarks>
        public const string IsCustomizable = "iscustomizable";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: False</summary>
        /// <remarks>Indicates whether the solution component is part of a managed solution.</remarks>
        public const string IsManaged = "ismanaged";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: managedidentity</summary>
        /// <remarks>Managed Identity Id to look up to ManagedIdentity Entity</remarks>
        public const string ManagedIdentityId = "managedidentityid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: organization</summary>
        /// <remarks>Unique identifier for the organization</remarks>
        public const string OrganizationId = "organizationid";
        /// <summary>Type: Virtual, RequiredLevel: None</summary>
        /// <remarks>Lookup to FileAttachment</remarks>
        public const string Package = "package";
        /// <summary>Type: DateTime, RequiredLevel: SystemRequired, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        /// <remarks>For internal use only.</remarks>
        public const string RecordOverwriteTime = "overwritetime";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        /// <remarks>For internal use only.</remarks>
        public const string Rowidunique = "componentidunique";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        /// <remarks>Unique identifier of the associated solution.</remarks>
        public const string Solution = "solutionid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        /// <remarks>For internal use only.</remarks>
        public const string Solution1 = "supportingsolutionid";
        /// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, OptionSetType: State</summary>
        /// <remarks>Status of the Plugin Package</remarks>
        public const string Status = "statecode";
        /// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, OptionSetType: Status</summary>
        /// <remarks>Reason for the status of the Plugin Package</remarks>
        public const string StatusReason = "statuscode";
        /// <summary>Type: String, RequiredLevel: SystemRequired, MaxLength: 128, Format: Text</summary>
        /// <remarks>Unique name for the package</remarks>
        public const string UniqueName = "uniquename";
        /// <summary>Type: String, RequiredLevel: SystemRequired, MaxLength: 100, Format: Text</summary>
        /// <remarks>Version of the package</remarks>
        public const string Version = "version";

        #endregion Attributes

        #region OptionSets

        public enum ComponentState_OptionSet
        {
            Published = 0,
            Unpublished = 1,
            Deleted = 2,
            DeletedUnpublished = 3
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

        #endregion OptionSets
    }
}
